using AAComm.Shared;
using AAMotion;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAMotion_V7_Example
{
    public partial class Form1 : Form
    {
        private MotionController _controller;
        private bool _connected;

        private readonly Dictionary<string, AxisRef> axisRefs = new Dictionary<string, AxisRef>
            {
                { "A", AxisRef.A },
                { "B", AxisRef.B },
                { "C", AxisRef.C },
                { "D", AxisRef.D },
                { "E", AxisRef.E },
                { "F", AxisRef.F },
                { "G", AxisRef.G },
                { "H", AxisRef.H },
                { "I", AxisRef.I },
                { "J", AxisRef.J },
                { "K", AxisRef.K },
                { "L", AxisRef.L }
            };

        private void errorMessagePopUp(int err, string msg, string ex)
        {
            MessageBox.Show($"Exception  : {ex}");
        }
        public Form1()
        {
            InitializeComponent();
            _controller = new AGM800();
            Action<int, string, string> errorHandler = (errorCode, message, exception) =>
            {
                errorMessagePopUp(errorCode, message, exception);
            };

            _controller.ErrorOccurred += errorHandler;
            _connected = false;

            //Initialize a default value of laser measurement 
            comboBoxBidirectional.SelectedIndex = 0;
            Axis_comboBox.SelectedIndex = 0;


            // Using int.MaxValue allows up to 2,147,483,647
            numericStartPosition.Maximum = int.MaxValue;
            numericStartPosition.Minimum = int.MinValue; // Allow negative starting positions
            numericStroke.Maximum = int.MaxValue;
            numericOverrun.Maximum = int.MaxValue;
            numericInterval.Maximum = int.MaxValue;
            numericRuns.Maximum = int.MaxValue;
            numericDwellTime.Maximum = int.MaxValue;

            numericSpeed.Maximum = int.MaxValue;
            numericAccel.Maximum = int.MaxValue;
            numericDecel.Maximum = int.MaxValue;
            numericEmrgDecel.Maximum = int.MaxValue;

            // Set laser measurement specs and motion profile
            numericStartPosition.Value = 0;
            numericStroke.Value = 1000000;
            numericOverrun.Value = 10000;
            numericInterval.Value = 100000;
            numericRuns.Value = 1;
            numericDwellTime.Value = 2000;

            numericSpeed.Value = 200000;
            numericAccel.Value = 2000000;
            numericDecel.Value = 2000000;
            numericEmrgDecel.Value = 4000000;

            this.AutoScroll = true;
        }

        private void ControllerType_comboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (ControllerType_comboBox.Text)
            {
                case "AGM800":
                    _controller = new AGM800();
                    break;
                case "AGD301":
                    _controller = new AGD301();
                    break;
                case "AGD200":
                    _controller = new AGD200();
                    break;
                case "AGD155":
                    _controller = new AGD155();
                    break;
                case "AGD101":
                    _controller = new AGD101EC();
                    break;
                default:
                    _controller = new AGM800();
                    break;
            }
        }

        public static bool checkIP(string ip)
        {
            //If it is empty, it is considered invalid.
            if (string.IsNullOrEmpty(ip))
            {
                return false;
            }

            //Remove spaces from the string to be validated
            ip = ip.Trim();

            //pattern string, regular expression
            string patten = @"^((2[0-4]\d|25[0-5]|[01]?\d\d?)\.){3}(2[0-4]\d|25[0-5]|[01]?\d\d?)$";

            //Verify
            return Regex.IsMatch(ip, patten);
        }


        private void Conn_button_Click(object sender, EventArgs e)
        {
            string StrAddIp = "";
            bool IpCheckResult = false;
            StrAddIp = Addr_textBox.Text;
            IpCheckResult = checkIP(StrAddIp); ///Check IP Format


            if (IpCheckResult == true)
            {
                try
                {
                    if (!_controller.IsConnected)
                    {
                        if (_controller.Connect(StrAddIp))
                        {
                            timerRefreshUI.Start();
                            MessageBox.Show("Connected successfully");
                        }
                    }
                    else
                    {
                        _controller.Disconnect();
                        MessageBox.Show("Disconnected");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Controller communication error: {ex.Message}");
                }
            }


        }
        public void getMotionStatus(string Axis, out Int32 MotionCode, out Int32 ConfltCode, out Int32 MotionReason, out Int32 HomeStat, out string MotionStatDesc, out string ConFltDesc, out string MotionReasonDesc, out string HomingStatDesc)
        {
            string iMotionStatDesc = "";
            string iConFltDesc = "";
            string iMotionReasonDesc = "";
            string iHomingStatDesc = "";
            Int32 iMotionCode = 0;
            Int32 iConfltCode = 0;
            Int32 iMotionReason = 0;
            Int32 iHomingStat = 0;

            if (_controller.IsConnected)
            {
                if (axisRefs.TryGetValue(Axis, out AxisRef axisRef))
                {
                    iMotionCode = _controller.GetAxis(axisRef).MotionStat;
                    iConfltCode = _controller.GetAxis(axisRef).ConFlt;
                    iMotionReason = _controller.GetAxis(axisRef).MotionReason;
                    iHomingStat = _controller.GetAxis(axisRef).HomingStat;

                    iMotionStatDesc = EnumPropertyHelper.GetMotionStatDes(iMotionCode);
                    iConFltDesc = EnumPropertyHelper.GetConFltDes(iConfltCode);
                    iMotionReasonDesc = EnumPropertyHelper.GetMotionReasonDes(iMotionReason);
                    iHomingStatDesc = EnumPropertyHelper.GetHomingStatDes(iHomingStat);

                }
            }
            MotionStatDesc = iMotionStatDesc;
            ConFltDesc = iConFltDesc;
            MotionReasonDesc = iMotionReasonDesc;
            HomingStatDesc = iHomingStatDesc;
            MotionCode = iMotionCode;
            ConfltCode = iConfltCode;
            MotionReason = iMotionReason;
            HomeStat = iHomingStat;

        }

        public void StatusReflesh()
        {
            string sAxisName = Axis_comboBox.Text;
            string MotionStatDesc;
            string ConFltDesc;
            string MotionReasonDesc;
            string HomingStatDesc;
            Int32 MotionCode;
            Int32 ConfltCode;
            Int32 MotionReason;
            Int32 HomeStat;

            getMotionStatus(sAxisName, out MotionCode, out ConfltCode, out MotionReason, out HomeStat, out MotionStatDesc, out ConFltDesc, out MotionReasonDesc, out HomingStatDesc);
            text_MotionStat.Text = Convert.ToString(MotionCode) + " : " + MotionStatDesc;
            text_ConFlt.Text = Convert.ToString(ConfltCode) + " : " + ConFltDesc;
            text_MotionReason.Text = Convert.ToString(MotionReason) + " : " + MotionReasonDesc;

        }
        private void timerRefreshUI_Tick(object sender, EventArgs e)
        {
            try
            {
                if (_controller.IsConnected)
                {
                    if (!_connected)
                    {
                        Text = "AAMotion V7 Example (FW: " + _controller.FirmwareVersion + ")";
                        Conn_button.Text = "Disconnect";
                        Addr_textBox.Enabled = false;
                        _connected = true;
                    }



                    string axis = Axis_comboBox.Text;
                    if (!axisRefs.TryGetValue(axis, out AxisRef axisRef)) return;
                    Int32 iposref = 0;
                    Int32 ipos = 0;
                    Int32 iposerr = 0;
                    Int32 ivel = 0;
                    Int32 imotorcurr = 0;

                    ReadPosition(axis, out iposref, out ipos, out iposerr, out ivel, out imotorcurr);
                    StatusReflesh();

                    // show them in UI
                    PosRef_textBox.Text = Convert.ToString(iposref);
                    Pos_textBox.Text = Convert.ToString(ipos);
                    PosErr_textBox.Text = Convert.ToString(iposerr);
                    Vel_textBox.Text = Convert.ToString(ivel);
                    MotorCurr_textBox.Text = Convert.ToString(imotorcurr);
                }
                else
                {
                    if (_connected)
                    {
                        Text = "AAMotion V7 Example";
                        Conn_button.Text = "Connect";
                        Addr_textBox.Enabled = true;
                        _connected = false;
                    }
                }
            }
            catch
            {

            }
        }

        private void ReadPosition(string axis, out Int32 posref, out Int32 pos, out Int32 poserr, out Int32 vel, out Int32 Motorcurr)
        {
            Int32 iposref = 0;
            Int32 ipos = 0;
            Int32 iposerr = 0;
            Int32 ivel = 0;
            Int32 iMotorcurr = 0;

            if (_controller.IsConnected)
            {
                if (axisRefs.TryGetValue(axis, out AxisRef axisRef))
                {
                    iposref = _controller.GetAxis(axisRef).PosRef;
                    ipos = _controller.GetAxis(axisRef).Pos;
                    iposerr = _controller.GetAxis(axisRef).PosErr;
                    ivel = _controller.GetAxis(axisRef).Vel[1];
                    iMotorcurr = _controller.GetAxis(axisRef).MotorCurr;

                }
            }
            posref = iposref;
            pos = ipos;
            poserr = iposerr;
            vel = ivel;
            Motorcurr = iMotorcurr;
        }

        private async Task MoveToAndDwellAsync(dynamic axis, int targetPosition, int dwellTimeMs)
        {
            // Set target and begin motion
            axis.AbsTrgt = targetPosition;
            axis.Begin = 1;

            // Poll until the axis reaches the target (InTargetStat == 4)
            // A delay is added to prevent UI thread blocking
            while (axis.InTargetStat != 4)
            {
                await Task.Delay(20);
            }

            // Wait for the specified dwell time
            if (dwellTimeMs > 0)
            {
                await Task.Delay(dwellTimeMs);
            }
        }

        private async Task RunLaserMeasurementAsync()
        {
            if (!_controller.IsConnected)
            {
                MessageBox.Show("Controller is not connected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string axisName = Axis_comboBox.Text;
            if (!axisRefs.TryGetValue(axisName, out AxisRef axisRef))
            {
                MessageBox.Show($"Invalid axis selected: {axisName}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var axis = _controller.GetAxis(axisRef);

            // Retrieve parameters from the UI
            int startPos = (int)numericStartPosition.Value;
            int stroke = (int)numericStroke.Value;
            int overrun = (int)numericOverrun.Value;
            int interval = (int)numericInterval.Value;
            int runs = (int)numericRuns.Value;
            int dwellTime = (int)numericDwellTime.Value;
            bool isBidirectional = (comboBoxBidirectional.Text == "Yes");

            if (interval == 0)
            {
                MessageBox.Show("Interval cannot be 0.", "Configuration Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int triggers = Math.Abs(stroke / interval);

            try
            {
                // Setup axis specifications
                axis.MotorOn = 1;
                // Optional: Ensure axis is in the correct motion mode (1 = PTP)
                axis.MotionMode = 1;

                int curRun = 0;

                // Running motion profile
                axis.Speed = (int)numericSpeed.Value;
                axis.Accel = (int)numericAccel.Value;
                axis.Decel = (int)numericDecel.Value;
                axis.EmrgDecel = (int)numericEmrgDecel.Value;

                // Begin the overrun first before positive run
                await MoveToAndDwellAsync(axis, startPos - overrun, dwellTime);

                while (curRun < runs)
                {
                    curRun++;
                    int buffer = 0;

                    // Begin positive run by going to 0 position
                    while (buffer != triggers)
                    {
                        await MoveToAndDwellAsync(axis, (buffer * interval) + startPos, dwellTime);
                        buffer++;
                    }

                    // Last positive position
                    await MoveToAndDwellAsync(axis, (buffer * interval) + startPos, dwellTime);

                    // Overrun after positive run
                    await MoveToAndDwellAsync(axis, (buffer * interval) + startPos + overrun, dwellTime);

                    if (isBidirectional)
                    {
                        // Begin negative run by moving back to max Stroke
                        while (buffer != 0)
                        {
                            await MoveToAndDwellAsync(axis, (buffer * interval) + startPos, dwellTime);
                            buffer--;
                        }

                        // Last negative Position
                        await MoveToAndDwellAsync(axis, (buffer * interval) + startPos, dwellTime);

                        // Overrun after negative run
                        await MoveToAndDwellAsync(axis, (buffer * interval) + startPos - overrun, dwellTime);
                    }
                }

                // Move back to Start_pos and issue a stop
                await MoveToAndDwellAsync(axis, startPos, dwellTime);
                axis.Stop(); // Brings the axis to a controlled stop// Brings the axis to a controlled stop

                MessageBox.Show($"Laser measurement completed successfully on Axis {axisName}.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Motion error during laser measurement: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void buttonStartLaser_Click(object sender, EventArgs e)
        {
            // Disable the button while running to prevent double-triggering
            buttonStartLaser.Enabled = false;
            await RunLaserMeasurementAsync();
            buttonStartLaser.Enabled = true;
        }
    }
}