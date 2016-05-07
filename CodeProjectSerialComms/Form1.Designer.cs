namespace CodeProjectSerialComms
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
            this.btnGetSerialPorts = new System.Windows.Forms.Button();
            this.rtbIncoming = new System.Windows.Forms.RichTextBox();
            this.cboPorts = new System.Windows.Forms.ComboBox();
            this.cboBaudRate = new System.Windows.Forms.ComboBox();
            this.cboStopBits = new System.Windows.Forms.ComboBox();
            this.cboParity = new System.Windows.Forms.ComboBox();
            this.cboHandShaking = new System.Windows.Forms.ComboBox();
            this.lblBreakStatus = new System.Windows.Forms.Label();
            this.lblCTSStatus = new System.Windows.Forms.Label();
            this.lblDSRStatus = new System.Windows.Forms.Label();
            this.lblRIStatus = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnPortState = new System.Windows.Forms.Button();
            this.btnHello = new System.Windows.Forms.Button();
            this.rtbOutgoing = new System.Windows.Forms.RichTextBox();
            this.btnHyperTerm = new System.Windows.Forms.Button();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.ClearLog = new System.Windows.Forms.Button();
            this.SendBtn = new System.Windows.Forms.Button();
            this.CreateTimerBtn = new System.Windows.Forms.Button();
            this.TimeValue = new System.Windows.Forms.TextBox();
            this.cboDataBits = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TestMode = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PowerOff2On = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PowerOn2Off = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGetSerialPorts
            // 
            this.btnGetSerialPorts.Enabled = false;
            this.btnGetSerialPorts.Location = new System.Drawing.Point(616, 133);
            this.btnGetSerialPorts.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnGetSerialPorts.Name = "btnGetSerialPorts";
            this.btnGetSerialPorts.Size = new System.Drawing.Size(125, 32);
            this.btnGetSerialPorts.TabIndex = 0;
            this.btnGetSerialPorts.Text = "Ports";
            this.btnGetSerialPorts.UseVisualStyleBackColor = true;
            this.btnGetSerialPorts.Visible = false;
            this.btnGetSerialPorts.Click += new System.EventHandler(this.btnGetSerialPorts_Click);
            // 
            // rtbIncoming
            // 
            this.rtbIncoming.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbIncoming.Location = new System.Drawing.Point(14, 356);
            this.rtbIncoming.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rtbIncoming.Name = "rtbIncoming";
            this.rtbIncoming.Size = new System.Drawing.Size(780, 374);
            this.rtbIncoming.TabIndex = 1;
            this.rtbIncoming.Text = "";
            // 
            // cboPorts
            // 
            this.cboPorts.FormattingEnabled = true;
            this.cboPorts.Location = new System.Drawing.Point(166, 34);
            this.cboPorts.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cboPorts.Name = "cboPorts";
            this.cboPorts.Size = new System.Drawing.Size(199, 26);
            this.cboPorts.TabIndex = 2;
            // 
            // cboBaudRate
            // 
            this.cboBaudRate.FormattingEnabled = true;
            this.cboBaudRate.Location = new System.Drawing.Point(166, 78);
            this.cboBaudRate.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cboBaudRate.Name = "cboBaudRate";
            this.cboBaudRate.Size = new System.Drawing.Size(199, 26);
            this.cboBaudRate.TabIndex = 3;
            // 
            // cboStopBits
            // 
            this.cboStopBits.FormattingEnabled = true;
            this.cboStopBits.Location = new System.Drawing.Point(407, 88);
            this.cboStopBits.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cboStopBits.Name = "cboStopBits";
            this.cboStopBits.Size = new System.Drawing.Size(199, 26);
            this.cboStopBits.TabIndex = 5;
            this.cboStopBits.Visible = false;
            // 
            // cboParity
            // 
            this.cboParity.FormattingEnabled = true;
            this.cboParity.Location = new System.Drawing.Point(407, 126);
            this.cboParity.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cboParity.Name = "cboParity";
            this.cboParity.Size = new System.Drawing.Size(199, 26);
            this.cboParity.TabIndex = 6;
            this.cboParity.Visible = false;
            // 
            // cboHandShaking
            // 
            this.cboHandShaking.FormattingEnabled = true;
            this.cboHandShaking.Location = new System.Drawing.Point(407, 163);
            this.cboHandShaking.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cboHandShaking.Name = "cboHandShaking";
            this.cboHandShaking.Size = new System.Drawing.Size(199, 26);
            this.cboHandShaking.TabIndex = 7;
            this.cboHandShaking.Visible = false;
            // 
            // lblBreakStatus
            // 
            this.lblBreakStatus.AutoSize = true;
            this.lblBreakStatus.Location = new System.Drawing.Point(424, 232);
            this.lblBreakStatus.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblBreakStatus.Name = "lblBreakStatus";
            this.lblBreakStatus.Size = new System.Drawing.Size(54, 18);
            this.lblBreakStatus.TabIndex = 8;
            this.lblBreakStatus.Text = "Break";
            this.lblBreakStatus.Visible = false;
            // 
            // lblCTSStatus
            // 
            this.lblCTSStatus.AutoSize = true;
            this.lblCTSStatus.Location = new System.Drawing.Point(516, 232);
            this.lblCTSStatus.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCTSStatus.Name = "lblCTSStatus";
            this.lblCTSStatus.Size = new System.Drawing.Size(41, 18);
            this.lblCTSStatus.TabIndex = 9;
            this.lblCTSStatus.Text = "CTS";
            this.lblCTSStatus.Visible = false;
            // 
            // lblDSRStatus
            // 
            this.lblDSRStatus.AutoSize = true;
            this.lblDSRStatus.Location = new System.Drawing.Point(601, 232);
            this.lblDSRStatus.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDSRStatus.Name = "lblDSRStatus";
            this.lblDSRStatus.Size = new System.Drawing.Size(41, 18);
            this.lblDSRStatus.TabIndex = 10;
            this.lblDSRStatus.Text = "DSR";
            this.lblDSRStatus.Visible = false;
            // 
            // lblRIStatus
            // 
            this.lblRIStatus.AutoSize = true;
            this.lblRIStatus.Location = new System.Drawing.Point(697, 232);
            this.lblRIStatus.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblRIStatus.Name = "lblRIStatus";
            this.lblRIStatus.Size = new System.Drawing.Size(22, 18);
            this.lblRIStatus.TabIndex = 11;
            this.lblRIStatus.Text = "RI";
            this.lblRIStatus.Visible = false;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(404, 196);
            this.btnTest.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(125, 32);
            this.btnTest.TabIndex = 12;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Visible = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnPortState
            // 
            this.btnPortState.Location = new System.Drawing.Point(20, 74);
            this.btnPortState.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnPortState.Name = "btnPortState";
            this.btnPortState.Size = new System.Drawing.Size(125, 32);
            this.btnPortState.TabIndex = 13;
            this.btnPortState.Text = "Closed";
            this.btnPortState.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPortState.UseVisualStyleBackColor = true;
            this.btnPortState.Click += new System.EventHandler(this.btnPortState_Click);
            // 
            // btnHello
            // 
            this.btnHello.Location = new System.Drawing.Point(407, 14);
            this.btnHello.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(125, 32);
            this.btnHello.TabIndex = 14;
            this.btnHello.Text = "Send Hello";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Visible = false;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // rtbOutgoing
            // 
            this.rtbOutgoing.Enabled = false;
            this.rtbOutgoing.Location = new System.Drawing.Point(14, 307);
            this.rtbOutgoing.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rtbOutgoing.Name = "rtbOutgoing";
            this.rtbOutgoing.Size = new System.Drawing.Size(463, 41);
            this.rtbOutgoing.TabIndex = 15;
            this.rtbOutgoing.Text = "";
            this.rtbOutgoing.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbOutgoing_KeyPress);
            // 
            // btnHyperTerm
            // 
            this.btnHyperTerm.Location = new System.Drawing.Point(616, 54);
            this.btnHyperTerm.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnHyperTerm.Name = "btnHyperTerm";
            this.btnHyperTerm.Size = new System.Drawing.Size(125, 32);
            this.btnHyperTerm.TabIndex = 16;
            this.btnHyperTerm.Text = "HyperTerm";
            this.btnHyperTerm.UseVisualStyleBackColor = true;
            this.btnHyperTerm.Visible = false;
            this.btnHyperTerm.Click += new System.EventHandler(this.btnHyperTerm_Click);
            // 
            // txtCommand
            // 
            this.txtCommand.Location = new System.Drawing.Point(616, 97);
            this.txtCommand.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(164, 28);
            this.txtCommand.TabIndex = 17;
            this.txtCommand.Visible = false;
            // 
            // ClearLog
            // 
            this.ClearLog.Location = new System.Drawing.Point(628, 307);
            this.ClearLog.Name = "ClearLog";
            this.ClearLog.Size = new System.Drawing.Size(121, 41);
            this.ClearLog.TabIndex = 18;
            this.ClearLog.Text = "Clear Log";
            this.ClearLog.UseVisualStyleBackColor = true;
            this.ClearLog.Click += new System.EventHandler(this.ClearLog_Click);
            // 
            // SendBtn
            // 
            this.SendBtn.Location = new System.Drawing.Point(485, 307);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(121, 41);
            this.SendBtn.TabIndex = 19;
            this.SendBtn.Text = "Data Send";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Visible = false;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // CreateTimerBtn
            // 
            this.CreateTimerBtn.Location = new System.Drawing.Point(20, 239);
            this.CreateTimerBtn.Name = "CreateTimerBtn";
            this.CreateTimerBtn.Size = new System.Drawing.Size(125, 32);
            this.CreateTimerBtn.TabIndex = 20;
            this.CreateTimerBtn.Text = "Timer Stop";
            this.CreateTimerBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CreateTimerBtn.UseVisualStyleBackColor = true;
            this.CreateTimerBtn.Click += new System.EventHandler(this.CreateTimerBtn_Click);
            // 
            // TimeValue
            // 
            this.TimeValue.Location = new System.Drawing.Point(166, 244);
            this.TimeValue.MaxLength = 3;
            this.TimeValue.Name = "TimeValue";
            this.TimeValue.Size = new System.Drawing.Size(72, 28);
            this.TimeValue.TabIndex = 21;
            this.TimeValue.Text = "2";
            this.TimeValue.Visible = false;
            this.TimeValue.TextChanged += new System.EventHandler(this.TimeValue_TextChanged);
            // 
            // cboDataBits
            // 
            this.cboDataBits.FormattingEnabled = true;
            this.cboDataBits.Location = new System.Drawing.Point(407, 51);
            this.cboDataBits.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cboDataBits.Name = "cboDataBits";
            this.cboDataBits.Size = new System.Drawing.Size(199, 26);
            this.cboDataBits.TabIndex = 4;
            this.cboDataBits.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "Com Port";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TestMode
            // 
            this.TestMode.FormattingEnabled = true;
            this.TestMode.Items.AddRange(new object[] {
            "Auto power off/on"});
            this.TestMode.Location = new System.Drawing.Point(166, 121);
            this.TestMode.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TestMode.Name = "TestMode";
            this.TestMode.Size = new System.Drawing.Size(199, 26);
            this.TestMode.TabIndex = 24;
            this.TestMode.Text = "Auto power off/on";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "Test Mode";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 18);
            this.label4.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 18);
            this.label5.TabIndex = 27;
            this.label5.Text = "Temp command";
            // 
            // PowerOff2On
            // 
            this.PowerOff2On.Location = new System.Drawing.Point(166, 163);
            this.PowerOff2On.MaxLength = 3;
            this.PowerOff2On.Name = "PowerOff2On";
            this.PowerOff2On.Size = new System.Drawing.Size(72, 28);
            this.PowerOff2On.TabIndex = 28;
            this.PowerOff2On.Text = "5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 18);
            this.label6.TabIndex = 29;
            this.label6.Text = "Power off->on";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 18);
            this.label7.TabIndex = 31;
            this.label7.Text = "Power on->off";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PowerOn2Off
            // 
            this.PowerOn2Off.Location = new System.Drawing.Point(166, 200);
            this.PowerOn2Off.MaxLength = 3;
            this.PowerOn2Off.Name = "PowerOn2Off";
            this.PowerOn2Off.Size = new System.Drawing.Size(72, 28);
            this.PowerOn2Off.TabIndex = 30;
            this.PowerOn2Off.Text = "15";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(244, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 18);
            this.label8.TabIndex = 32;
            this.label8.Text = "Second";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(244, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 18);
            this.label9.TabIndex = 33;
            this.label9.Text = "Second";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 743);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PowerOn2Off);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PowerOff2On);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TestMode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TimeValue);
            this.Controls.Add(this.CreateTimerBtn);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.ClearLog);
            this.Controls.Add(this.txtCommand);
            this.Controls.Add(this.btnHyperTerm);
            this.Controls.Add(this.rtbOutgoing);
            this.Controls.Add(this.btnHello);
            this.Controls.Add(this.btnPortState);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.lblRIStatus);
            this.Controls.Add(this.lblDSRStatus);
            this.Controls.Add(this.lblCTSStatus);
            this.Controls.Add(this.lblBreakStatus);
            this.Controls.Add(this.cboHandShaking);
            this.Controls.Add(this.cboParity);
            this.Controls.Add(this.cboStopBits);
            this.Controls.Add(this.cboDataBits);
            this.Controls.Add(this.cboBaudRate);
            this.Controls.Add(this.cboPorts);
            this.Controls.Add(this.rtbIncoming);
            this.Controls.Add(this.btnGetSerialPorts);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "PW-1x00 Command Tester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetSerialPorts;
        private System.Windows.Forms.RichTextBox rtbIncoming;
        private System.Windows.Forms.ComboBox cboPorts;
        private System.Windows.Forms.ComboBox cboBaudRate;
        private System.Windows.Forms.ComboBox cboStopBits;
        private System.Windows.Forms.ComboBox cboParity;
        private System.Windows.Forms.ComboBox cboHandShaking;
        private System.Windows.Forms.Label lblBreakStatus;
        private System.Windows.Forms.Label lblCTSStatus;
        private System.Windows.Forms.Label lblDSRStatus;
        private System.Windows.Forms.Label lblRIStatus;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnPortState;
        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.RichTextBox rtbOutgoing;
        private System.Windows.Forms.Button btnHyperTerm;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.Button ClearLog;
        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.Button CreateTimerBtn;
        private System.Windows.Forms.TextBox TimeValue;
        private System.Windows.Forms.ComboBox cboDataBits;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TestMode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PowerOff2On;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PowerOn2Off;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

