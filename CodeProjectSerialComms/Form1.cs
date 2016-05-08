using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Windows.Forms;
using System.Timers;

//CodeProjectSerialComms program 
//23/04/2013   16:29

namespace CodeProjectSerialComms
{
    public partial class Form1 : Form
    {
        SerialPort ComPort = new SerialPort();
        System.Timers.Timer timer = new System.Timers.Timer();

        internal delegate void SerialDataReceivedEventHandlerDelegate(object sender, SerialDataReceivedEventArgs e);
        internal delegate void SerialPinChangedEventHandlerDelegate(object sender, SerialPinChangedEventArgs e);
        private SerialPinChangedEventHandler SerialPinChangedEventHandler1;
        delegate void SetTextCallback(string text);
        string InputData = String.Empty;

        public Form1()
        {
            InitializeComponent();
            SerialPinChangedEventHandler1 = new SerialPinChangedEventHandler(PinChanged);
            ComPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(port_DataReceived_1);
            ProcessorInit();
        }

        private void ProcessorInit()
        {
            /** Port Create & Init */
            Portinit();

            /** Create Timer Task */
            TimerThreadInit();
            TestMode.Text = TestMode.Items[0].ToString();
            TestMode.SelectedValue = 0;
            CreateTimerBtn.Enabled = false;
        }

        private void TimerThreadInit()
        {
            // 타이머 생성 및 시작
            timer = new System.Timers.Timer();
            timer.Interval = Convert.ToDouble(PowerOff2On.Text) * 1000; 
            timer.Elapsed += new ElapsedEventHandler(timer_Elapsed);
            //timer.Start();
            //timer.Enabled = false;
        }

        static bool bPowerFlag = false;
        void timer_Elapsed(object sender, ElapsedEventArgs e)
        {                       
            if (bPowerFlag)
            {
                bPowerFlag = false;                
                ComPort.Write("power off");
                SetTimerInterval(PowerOff2On.Text);
            }
            else
            {
                bPowerFlag = true;
                ComPort.Write("power on");
                SetTimerInterval(PowerOn2Off.Text);
            }
            ComPort.Write("\r\n");
        }


        private void Portinit()
        {
#if false
            btnGetSerialPorts.PerformClick();
# endif

#if true
            string[] ArrayComPortsNames = null;
            int index = -1;
            string ComPortName = null;

            //Com Ports
            ArrayComPortsNames = SerialPort.GetPortNames();
            do
            {
                index += 1;
                cboPorts.Items.Add(ArrayComPortsNames[index]);


            } while (!((ArrayComPortsNames[index] == ComPortName) || (index == ArrayComPortsNames.GetUpperBound(0))));
            Array.Sort(ArrayComPortsNames);

            if (index == ArrayComPortsNames.GetUpperBound(0))
            {
                ComPortName = ArrayComPortsNames[0];
            }
            //get first item print in text
            cboPorts.Text = ArrayComPortsNames[0];
            //Baud Rate
#if false
            cboBaudRate.Items.Add(300);
            cboBaudRate.Items.Add(600);
            cboBaudRate.Items.Add(1200);
            cboBaudRate.Items.Add(2400);
            cboBaudRate.Items.Add(9600);
            cboBaudRate.Items.Add(14400);
            cboBaudRate.Items.Add(19200);
            cboBaudRate.Items.Add(38400);
            cboBaudRate.Items.Add(57600); 
#endif
            cboBaudRate.Items.Add(115200);
            cboBaudRate.Items.ToString();
            //get first item print in text
            cboBaudRate.Text = cboBaudRate.Items[0].ToString();
            //Data Bits
            //cboDataBits.Items.Add(7);     // Do not used this program
            cboDataBits.Items.Add(8);
            //get the first item print it in the text 
            cboDataBits.Text = cboDataBits.Items[0].ToString();

            //Stop Bits
            cboStopBits.Items.Add("One");
            cboStopBits.Items.Add("OnePointFive");
            cboStopBits.Items.Add("Two");
            //get the first item print in the text
            cboStopBits.Text = cboStopBits.Items[0].ToString();
            //Parity 
            cboParity.Items.Add("None");
            cboParity.Items.Add("Even");
            cboParity.Items.Add("Mark");
            cboParity.Items.Add("Odd");
            cboParity.Items.Add("Space");
            //get the first item print in the text
            cboParity.Text = cboParity.Items[0].ToString();
            //Handshake
            cboHandShaking.Items.Add("None");
            cboHandShaking.Items.Add("XOnXOff");
            cboHandShaking.Items.Add("RequestToSend");
            cboHandShaking.Items.Add("RequestToSendXOnXOff");
            //get the first item print it in the text 
            cboHandShaking.Text = cboHandShaking.Items[0].ToString(); 
#endif
        }

        private void btnGetSerialPorts_Click(object sender, EventArgs e)
        {
            string[] ArrayComPortsNames = null;
            int index = -1;
            string ComPortName = null;
           
//Com Ports
            ArrayComPortsNames = SerialPort.GetPortNames();
            do
            {
                index += 1;
                cboPorts.Items.Add(ArrayComPortsNames[index]);
               
              
            } while (!((ArrayComPortsNames[index] == ComPortName) || (index == ArrayComPortsNames.GetUpperBound(0))));
            Array.Sort(ArrayComPortsNames);
           
            if (index == ArrayComPortsNames.GetUpperBound(0))
            {
                ComPortName = ArrayComPortsNames[0];
            }
            //get first item print in text
            cboPorts.Text = ArrayComPortsNames[0];
            //Baud Rate
#if false
            cboBaudRate.Items.Add(300);
            cboBaudRate.Items.Add(600);
            cboBaudRate.Items.Add(1200);
            cboBaudRate.Items.Add(2400);
            cboBaudRate.Items.Add(9600);
            cboBaudRate.Items.Add(14400);
            cboBaudRate.Items.Add(19200);
            cboBaudRate.Items.Add(38400);
            cboBaudRate.Items.Add(57600); 
#endif
            cboBaudRate.Items.Add(115200);
            cboBaudRate.Items.ToString();
            //get first item print in text
            cboBaudRate.Text = cboBaudRate.Items[0].ToString();
            
            //Data Bits
            //cboDataBits.Items.Add(7);
            //cboDataBits.Items.Add(8);
            //get the first item print it in the text 
            //cboDataBits.Text = cboDataBits.Items[0].ToString();

            //Stop Bits
            //cboStopBits.Items.Add("One");
            //cboStopBits.Items.Add("OnePointFive");
            //cboStopBits.Items.Add("Two");
            //get the first item print in the text
            //cboStopBits.Text = cboStopBits.Items[0].ToString();
            
            //Parity             
            //cboParity.Items.Add("None");
            //cboParity.Items.Add("Even");
            //cboParity.Items.Add("Mark");
            //cboParity.Items.Add("Odd");
            //cboParity.Items.Add("Space");
            //get the first item print in the text
            //cboParity.Text = cboParity.Items[0].ToString();
            
            //Handshake            
            //cboHandShaking.Items.Add("None");
            //cboHandShaking.Items.Add("XOnXOff");
            //cboHandShaking.Items.Add("RequestToSend");
            //cboHandShaking.Items.Add("RequestToSendXOnXOff");
            //get the first item print it in the text 
            //cboHandShaking.Text = cboHandShaking.Items[0].ToString();
        }


        private void port_DataReceived_1(object sender, SerialDataReceivedEventArgs e)
        {
            InputData = ComPort.ReadExisting();
            if (InputData != String.Empty)
            {
                this.BeginInvoke(new SetTextCallback(SetText), new object[] { InputData });
            }
        }
        private void SetText(string text)
        {
            this.rtbIncoming.Text += text;                        
        }
        internal void PinChanged(object sender, SerialPinChangedEventArgs e)
        {
            SerialPinChange SerialPinChange1 = 0;
            bool signalState = false;

            SerialPinChange1 = e.EventType;
            lblCTSStatus.BackColor = Color.Green;
            lblDSRStatus.BackColor = Color.Green;
            lblRIStatus.BackColor = Color.Green;
            lblBreakStatus.BackColor = Color.Green;
            switch (SerialPinChange1)
            {
                case SerialPinChange.Break:
                    lblBreakStatus.BackColor = Color.Red;
                    //MessageBox.Show("Break is Set");
                    break;
                case SerialPinChange.CDChanged:
                    signalState = ComPort.CtsHolding;
                  //  MessageBox.Show("CD = " + signalState.ToString());
                    break;
                case SerialPinChange.CtsChanged:
                    signalState = ComPort.CDHolding;
                    lblCTSStatus.BackColor = Color.Red;
                    //MessageBox.Show("CTS = " + signalState.ToString());
                    break;
                case SerialPinChange.DsrChanged:
                    signalState = ComPort.DsrHolding;
                    lblDSRStatus.BackColor = Color.Red;
                    // MessageBox.Show("DSR = " + signalState.ToString());
                    break;
                case SerialPinChange.Ring:
                    lblRIStatus.BackColor = Color.Red;
                    //MessageBox.Show("Ring Detected");
                    break;
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            //SerialPinChangedEventHandler1 = new SerialPinChangedEventHandler(PinChanged);
            //ComPort.PinChanged += SerialPinChangedEventHandler1;
            //ComPort.Open();

            //ComPort.RtsEnable = true;
            //ComPort.DtrEnable = true;
            //btnTest.Enabled = false;

        }

        private void btnPortState_Click(object sender, EventArgs e)
        {
          
            if (btnPortState.Text == "Closed")
            {
                btnPortState.Text = "Open";
                ComPort.PortName = Convert.ToString(cboPorts.Text);
                ComPort.BaudRate = Convert.ToInt32(cboBaudRate.Text);

                ComPort.DataBits = Convert.ToInt16("8");
                ComPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), "One");
                ComPort.Handshake = (Handshake)Enum.Parse(typeof(Handshake), "None");
                ComPort.Parity = (Parity)Enum.Parse(typeof(Parity), "None");
#if false
                ComPort.DataBits = Convert.ToInt16(cboDataBits.Text);
                ComPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cboStopBits.Text);
                ComPort.Handshake = (Handshake)Enum.Parse(typeof(Handshake), cboHandShaking.Text);
                ComPort.Parity = (Parity)Enum.Parse(typeof(Parity), cboParity.Text); 
#endif
                ComPort.Open();

                rtbOutgoing.Enabled = true;
                CreateTimerBtn.Enabled = true;
            }
            else if (btnPortState.Text == "Open")
            {
                if (timer.Enabled)
                {
                    CreateTimerBtn.PerformClick();
                }
                CreateTimerBtn.Enabled = false;

                btnPortState.Text = "Closed";
                ComPort.Close();
                rtbOutgoing.Enabled = false;                
            }
        }
        private void rtbOutgoing_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) // enter key  
            {
                ComPort.Write("\r\n");
                rtbOutgoing.Text = "";
            }
            else if (e.KeyChar < 32 || e.KeyChar > 126)
            {
                e.Handled = true; // ignores anything else outside printable ASCII range  
            }
            else
            {
                ComPort.Write(e.KeyChar.ToString());
            }
        }
        private void btnHello_Click(object sender, EventArgs e)
        {
            ComPort.Write("Hello World!");
        }

        private void btnHyperTerm_Click(object sender, EventArgs e)
        {
            string Command1 = txtCommand.Text;
            string CommandSent;
            int Length, j = 0;

            Length = Command1.Length;

            for (int i = 0; i < Length; i++)
            {
                CommandSent = Command1.Substring(j, 1);
                ComPort.Write(CommandSent);
                j++;
            }
        }

        private void ClearLog_Click(object sender, EventArgs e)
        {
            rtbIncoming.Text = "";
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            var dataArray = new byte[] { 0x0D };
            ComPort.Write(txtCommand.Text);
            ComPort.Write(dataArray, 0,1);
        }

        private void CreateTimerBtn_Click(object sender, EventArgs e)
        {
            if (btnPortState.Text == "Closed")
            {
                rtbIncoming.AppendText("Uart Port is closed. please Open port firstly\n\r");
                return;
            }

            if (timer == null)
            {
                TimerThreadInit();
            }
            
            if (timer.Enabled)
            {
                CreateTimerBtn.Text = "Timer Stop";
                timer.Stop();
            }
            else
            {
                CreateTimerBtn.Text = "Timer Start";
                timer.Start();

                if (bPowerFlag)
                {
                    SetTimerInterval(PowerOff2On.Text);
                }
                else
                {                    
                    SetTimerInterval(PowerOn2Off.Text);
                }
            }

            /** Power On/Off Timer coefficient enable set */
            PowerOff2On.Enabled = !timer.Enabled;
            PowerOn2Off.Enabled = !timer.Enabled;
        }

        private void SetTimerInterval(string timeText)
        {
            if (timeText != "")
            {
                timer.Interval = Convert.ToDouble(timeText) * 1000;
            }            
        }

        private void TimeValue_TextChanged(object sender, EventArgs e)
        {
            if (TimeValue.Text == "")
            {
                return;
            }

            Double u32Temp = Convert.ToDouble(TimeValue.Text);

            if (u32Temp > 0)
            {
                if (timer != null)
                {
                    timer.Interval = Convert.ToDouble(TimeValue.Text) * 1000;
                }                
            }
        }
    }
}
