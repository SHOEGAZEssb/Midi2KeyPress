using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Midi;
using WindowsInput;
using System.Runtime.InteropServices;
using WindowsInput.Native;

namespace MidiGUI
{
  public partial class Form1 : Form
  {
    [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
    public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

    InputDevice inDevice;
    OutputDevice outDevice;

    InputSimulator simulator = new InputSimulator();

    List<ComboBox> comboBoxNoteList = new List<ComboBox>();
    List<ComboBox> comboBoxKeyList = new List<ComboBox>();
    List<CheckBox> checkBoxActiveList = new List<CheckBox>();

    int comboBoxCount = 0;

    public Form1()
    {
      this.Icon = Midi2KeyPress.Properties.Resources.logo;

      InitializeComponent();
      foreach (InputDevice device in InputDevice.InstalledDevices)
      {
        listBox1.Items.Add(device);
      }

      foreach (OutputDevice device in OutputDevice.InstalledDevices)
      {
        listBox2.Items.Add(device);
      }

      fillNoteComboBox(comboBox1);

      label3.Text = "Velocity: " + trackBar1.Value.ToString();
    }

    private void btnRecieve_Click(object sender, EventArgs e)
    {
      if (listBox1.SelectedItem == null)
      {
        MessageBox.Show("No device selected!");
        return;
      }

      inDevice = (InputDevice)listBox1.SelectedItem;

      try
      {
        inDevice.Open();
        inDevice.NoteOn += new InputDevice.NoteOnHandler(NoteOn);
        inDevice.StartReceiving(null);  // Note events will be received in another thread
        btnRecieve.Enabled = false;
        btnClose.Enabled = true;
      }

      catch (Midi.DeviceException)
      {
        MessageBox.Show("Device is already openend in another program", "Error");
      }
    }

    //Is fired when a MIDI note is catched 
    public void NoteOn(NoteOnMessage msg) 
    {
      AppendTextBox(msg.Pitch.ToString());

      for (int i = 0; i < comboBoxCount; i++)
      {
        if (checkBoxActiveList[i].Checked)
        {

          Pitch selectedNote = (Pitch)Invoke(new Func<Pitch>(() => (Pitch)comboBoxNoteList[i].SelectedItem));

          VirtualKeyCode selectedKey = (VirtualKeyCode)Invoke(new Func<VirtualKeyCode>(() => (VirtualKeyCode)comboBoxKeyList[i].SelectedItem));

          if (msg.Pitch == selectedNote)
          {
            if (selectedKey == VirtualKeyCode.LBUTTON)
            {
              simulator.Mouse.LeftButtonClick();
            }

            else if (selectedKey == VirtualKeyCode.RBUTTON)
            {
              simulator.Mouse.RightButtonClick();
            }

            else if (selectedKey == VirtualKeyCode.MBUTTON)
            {
              simulator.Mouse.XButtonClick(0);
            }

            simulator.Keyboard.KeyPress(selectedKey);
          }
        }
      }
    }

    //Write the value of the played note into the textbox
    public void AppendTextBox(string value)
    {
      if (InvokeRequired)
        this.Invoke(new Action<string>(AppendTextBox), new object[] { value });
      else
        textBox1.Text += value + "\r\n";
    }

    private void btnReceiveOut_Click(object sender, EventArgs e)
    {
      if (listBox2.SelectedItem == null)
        MessageBox.Show("No device selected!");
      else
      {
        outDevice = (OutputDevice)listBox2.SelectedItem;
        outDevice.Open();
        if (comboBox1.SelectedItem != null)
          outDevice.SendNoteOn(Channel.Channel1, (Pitch)comboBox1.SelectedItem, trackBar1.Value);

        outDevice.Close();
      }
    }

    private void trackBar1_ValueChanged(object sender, EventArgs e)
    {
      label3.Text = "Velocity: " + trackBar1.Value.ToString();
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      inDevice.StopReceiving();
      inDevice.Close();
      btnRecieve.Enabled = true;
      btnClose.Enabled = false;
    }

    private void populatePageTwo()
    {
      Label noteLabel = new Label();
      noteLabel.Text = "Note:";
      noteLabel.Location = new Point(15, 15 * (comboBoxCount + 1) + (20 * comboBoxCount) + 2 /*+2 for being placed into the middle of the combobox */);

      ComboBox noteBox = new ComboBox();
      noteBox.Location = new Point(50, 15 * (comboBoxCount + 1) + (20 * comboBoxCount));
      noteBox.Size = new Size(100, 20);
      noteBox.DropDownStyle = ComboBoxStyle.DropDownList;
      fillNoteComboBox(noteBox);
      noteBox.SelectedItem = noteBox.Items[0];
      comboBoxNoteList.Add(noteBox);

      Label keyLabel = new Label();
      keyLabel.Text = "Key:";
      keyLabel.Location = new Point(152, 15 * (comboBoxCount + 1) + (20 * comboBoxCount) + 2);

      ComboBox keyBox = new ComboBox();
      keyBox.Location = new Point(180, 15 * (comboBoxCount + 1) + (20 * comboBoxCount));
      keyBox.Size = new Size(100, 20);
      keyBox.DropDownStyle = ComboBoxStyle.DropDownList;
      fillKeyComboBox(keyBox);
      keyBox.SelectedItem = keyBox.Items[0];
      comboBoxKeyList.Add(keyBox);

      CheckBox activeCheck = new CheckBox();
      activeCheck.Text = "Active";
      activeCheck.Location = new Point(285, 15 * (comboBoxCount + 1) + (20 * comboBoxCount));
      checkBoxActiveList.Add(activeCheck);

      this.tabPage2.Controls.Add(noteBox);
      this.tabPage2.Controls.Add(keyBox);
      this.tabPage2.Controls.Add(noteLabel);
      this.tabPage2.Controls.Add(keyLabel);
      this.tabPage2.Controls.Add(activeCheck);

      comboBoxCount++;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      populatePageTwo();
    }

    private void fillNoteComboBox(ComboBox box)
    {
      foreach (Pitch note in Enum.GetValues(typeof(Pitch)))
      {
        box.Items.Add(note);
      }
    }

    private void fillKeyComboBox(ComboBox box)
    {
      foreach (VirtualKeyCode key in Enum.GetValues(typeof(VirtualKeyCode)))
      {
        box.Items.Add(key);
      }
    }

    private void btnClearInputListBox_Click(object sender, EventArgs e)
    {
      textBox1.Clear();
    }
  }
}