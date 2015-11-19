namespace MidiGUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.label3 = new System.Windows.Forms.Label();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.btnClose = new System.Windows.Forms.Button();
      this.btnReceiveOut = new System.Windows.Forms.Button();
      this.listBox2 = new System.Windows.Forms.ListBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.btnRecieve = new System.Windows.Forms.Button();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.button1 = new System.Windows.Forms.Button();
      this.btnClearInputListBox = new System.Windows.Forms.Button();
      this.trackBar1 = new System.Windows.Forms.TrackBar();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
      this.SuspendLayout();
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl1.Location = new System.Drawing.Point(0, 0);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(436, 357);
      this.tabControl1.TabIndex = 0;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.trackBar1);
      this.tabPage1.Controls.Add(this.btnClearInputListBox);
      this.tabPage1.Controls.Add(this.label3);
      this.tabPage1.Controls.Add(this.comboBox1);
      this.tabPage1.Controls.Add(this.btnClose);
      this.tabPage1.Controls.Add(this.btnReceiveOut);
      this.tabPage1.Controls.Add(this.listBox2);
      this.tabPage1.Controls.Add(this.label2);
      this.tabPage1.Controls.Add(this.label1);
      this.tabPage1.Controls.Add(this.btnRecieve);
      this.tabPage1.Controls.Add(this.textBox1);
      this.tabPage1.Controls.Add(this.listBox1);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(428, 331);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Midi In/Out Controller";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(210, 271);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(47, 13);
      this.label3.TabIndex = 24;
      this.label3.Text = "Velocity:";
      // 
      // comboBox1
      // 
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Location = new System.Drawing.Point(213, 227);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(91, 21);
      this.comboBox1.TabIndex = 22;
      // 
      // btnClose
      // 
      this.btnClose.Enabled = false;
      this.btnClose.Location = new System.Drawing.Point(113, 140);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(91, 23);
      this.btnClose.TabIndex = 21;
      this.btnClose.Text = "Close";
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // btnReceiveOut
      // 
      this.btnReceiveOut.Location = new System.Drawing.Point(310, 227);
      this.btnReceiveOut.Name = "btnReceiveOut";
      this.btnReceiveOut.Size = new System.Drawing.Size(99, 23);
      this.btnReceiveOut.TabIndex = 20;
      this.btnReceiveOut.Text = "Send Note";
      this.btnReceiveOut.UseVisualStyleBackColor = true;
      this.btnReceiveOut.Click += new System.EventHandler(this.btnReceiveOut_Click);
      // 
      // listBox2
      // 
      this.listBox2.DisplayMember = "Name";
      this.listBox2.FormattingEnabled = true;
      this.listBox2.Location = new System.Drawing.Point(8, 227);
      this.listBox2.Name = "listBox2";
      this.listBox2.Size = new System.Drawing.Size(196, 95);
      this.listBox2.TabIndex = 18;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(8, 211);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(81, 13);
      this.label2.TabIndex = 17;
      this.label2.Text = "Output Devices";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(8, 5);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(73, 13);
      this.label1.TabIndex = 16;
      this.label1.Text = "Input Devices";
      // 
      // btnRecieve
      // 
      this.btnRecieve.Location = new System.Drawing.Point(8, 140);
      this.btnRecieve.Name = "btnRecieve";
      this.btnRecieve.Size = new System.Drawing.Size(99, 23);
      this.btnRecieve.TabIndex = 15;
      this.btnRecieve.Text = "Start Receiving";
      this.btnRecieve.UseVisualStyleBackColor = true;
      this.btnRecieve.Click += new System.EventHandler(this.btnRecieve_Click);
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(213, 5);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.textBox1.Size = new System.Drawing.Size(199, 158);
      this.textBox1.TabIndex = 14;
      // 
      // listBox1
      // 
      this.listBox1.DisplayMember = "Name";
      this.listBox1.FormattingEnabled = true;
      this.listBox1.Location = new System.Drawing.Point(8, 28);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(199, 95);
      this.listBox1.TabIndex = 13;
      // 
      // tabPage2
      // 
      this.tabPage2.AutoScroll = true;
      this.tabPage2.Controls.Add(this.button1);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(428, 439);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Key/Mouse Simulation";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(326, 6);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 6;
      this.button1.Text = "Add Rule";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // btnClearInputListBox
      // 
      this.btnClearInputListBox.Location = new System.Drawing.Point(337, 169);
      this.btnClearInputListBox.Name = "btnClearInputListBox";
      this.btnClearInputListBox.Size = new System.Drawing.Size(75, 23);
      this.btnClearInputListBox.TabIndex = 25;
      this.btnClearInputListBox.Text = "Clear";
      this.btnClearInputListBox.UseVisualStyleBackColor = true;
      this.btnClearInputListBox.Click += new System.EventHandler(this.btnClearInputListBox_Click);
      // 
      // trackBar1
      // 
      this.trackBar1.Location = new System.Drawing.Point(281, 256);
      this.trackBar1.Maximum = 127;
      this.trackBar1.Name = "trackBar1";
      this.trackBar1.Size = new System.Drawing.Size(128, 45);
      this.trackBar1.TabIndex = 26;
      this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(436, 357);
      this.Controls.Add(this.tabControl1);
      this.Name = "Form1";
      this.Text = "MIDI2KeyPress";
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      this.tabPage2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnReceiveOut;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRecieve;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClearInputListBox;
        private System.Windows.Forms.TrackBar trackBar1;

    }
}

