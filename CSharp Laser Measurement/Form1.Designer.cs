namespace AAMotion_V7_Example
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox72 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Pos_textBox = new System.Windows.Forms.TextBox();
            this.textBox66 = new System.Windows.Forms.TextBox();
            this.MotorCurr_textBox = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox64 = new System.Windows.Forms.TextBox();
            this.PosErr_textBox = new System.Windows.Forms.TextBox();
            this.textBox44 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.PosRef_textBox = new System.Windows.Forms.TextBox();
            this.Vel_textBox = new System.Windows.Forms.TextBox();
            this.Axis_comboBox = new System.Windows.Forms.ComboBox();
            this.Conn_groupBox = new System.Windows.Forms.GroupBox();
            this.textBox40 = new System.Windows.Forms.TextBox();
            this.ControllerType_comboBox = new System.Windows.Forms.ComboBox();
            this.Conn_button = new System.Windows.Forms.Button();
            this.Addr_textBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timerRefreshUI = new System.Windows.Forms.Timer(this.components);
            this.status_groupBox = new System.Windows.Forms.GroupBox();
            this.text_MotionReason = new System.Windows.Forms.TextBox();
            this.text_ConFlt = new System.Windows.Forms.TextBox();
            this.text_MotionStat = new System.Windows.Forms.TextBox();
            this.label126 = new System.Windows.Forms.Label();
            this.label125 = new System.Windows.Forms.Label();
            this.label124 = new System.Windows.Forms.Label();
            this.laserMeasurement_groupBox = new System.Windows.Forms.GroupBox();
            this.buttonStartLaser = new System.Windows.Forms.Button();
            this.numericDwellTime = new System.Windows.Forms.NumericUpDown();
            this.labelDwellTime = new System.Windows.Forms.Label();
            this.numericRuns = new System.Windows.Forms.NumericUpDown();
            this.labelRuns = new System.Windows.Forms.Label();
            this.numericInterval = new System.Windows.Forms.NumericUpDown();
            this.labelInterval = new System.Windows.Forms.Label();
            this.numericOverrun = new System.Windows.Forms.NumericUpDown();
            this.labelOverrun = new System.Windows.Forms.Label();
            this.numericStroke = new System.Windows.Forms.NumericUpDown();
            this.labelStroke = new System.Windows.Forms.Label();
            this.numericStartPosition = new System.Windows.Forms.NumericUpDown();
            this.labelStartPosition = new System.Windows.Forms.Label();
            this.comboBoxBidirectional = new System.Windows.Forms.ComboBox();
            this.labelBidirectional = new System.Windows.Forms.Label();
            this.motionSpec_groupBox = new System.Windows.Forms.GroupBox();
            this.numericEmrgDecel = new System.Windows.Forms.NumericUpDown();
            this.labelEmrgDecel = new System.Windows.Forms.Label();
            this.numericDecel = new System.Windows.Forms.NumericUpDown();
            this.labelDecel = new System.Windows.Forms.Label();
            this.numericAccel = new System.Windows.Forms.NumericUpDown();
            this.labelAccel = new System.Windows.Forms.Label();
            this.numericSpeed = new System.Windows.Forms.NumericUpDown();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.Conn_groupBox.SuspendLayout();
            this.status_groupBox.SuspendLayout();
            this.laserMeasurement_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDwellTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRuns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericOverrun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStroke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStartPosition)).BeginInit();
            this.motionSpec_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericEmrgDecel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDecel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAccel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox72
            // 
            this.textBox72.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox72.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox72.Location = new System.Drawing.Point(37, 14);
            this.textBox72.Name = "textBox72";
            this.textBox72.Size = new System.Drawing.Size(71, 15);
            this.textBox72.TabIndex = 31;
            this.textBox72.Text = "Axis:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Pos_textBox);
            this.groupBox1.Controls.Add(this.textBox66);
            this.groupBox1.Controls.Add(this.MotorCurr_textBox);
            this.groupBox1.Controls.Add(this.textBox16);
            this.groupBox1.Controls.Add(this.textBox64);
            this.groupBox1.Controls.Add(this.PosErr_textBox);
            this.groupBox1.Controls.Add(this.textBox44);
            this.groupBox1.Controls.Add(this.textBox12);
            this.groupBox1.Controls.Add(this.PosRef_textBox);
            this.groupBox1.Controls.Add(this.Vel_textBox);
            this.groupBox1.Location = new System.Drawing.Point(23, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 95);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // Pos_textBox
            // 
            this.Pos_textBox.BackColor = System.Drawing.SystemColors.Window;
            this.Pos_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Pos_textBox.Location = new System.Drawing.Point(92, 43);
            this.Pos_textBox.Name = "Pos_textBox";
            this.Pos_textBox.ReadOnly = true;
            this.Pos_textBox.Size = new System.Drawing.Size(71, 15);
            this.Pos_textBox.TabIndex = 20;
            // 
            // textBox66
            // 
            this.textBox66.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox66.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox66.Location = new System.Drawing.Point(227, 43);
            this.textBox66.Name = "textBox66";
            this.textBox66.Size = new System.Drawing.Size(71, 15);
            this.textBox66.TabIndex = 25;
            this.textBox66.Text = "MotorCurr:";
            // 
            // MotorCurr_textBox
            // 
            this.MotorCurr_textBox.BackColor = System.Drawing.SystemColors.Window;
            this.MotorCurr_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MotorCurr_textBox.Location = new System.Drawing.Point(303, 43);
            this.MotorCurr_textBox.Name = "MotorCurr_textBox";
            this.MotorCurr_textBox.ReadOnly = true;
            this.MotorCurr_textBox.Size = new System.Drawing.Size(71, 15);
            this.MotorCurr_textBox.TabIndex = 24;
            // 
            // textBox16
            // 
            this.textBox16.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox16.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox16.Location = new System.Drawing.Point(227, 22);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(71, 15);
            this.textBox16.TabIndex = 23;
            this.textBox16.Text = "Vel:";
            // 
            // textBox64
            // 
            this.textBox64.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox64.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox64.Location = new System.Drawing.Point(15, 64);
            this.textBox64.Name = "textBox64";
            this.textBox64.Size = new System.Drawing.Size(71, 15);
            this.textBox64.TabIndex = 21;
            this.textBox64.Text = "PosErr:";
            // 
            // PosErr_textBox
            // 
            this.PosErr_textBox.BackColor = System.Drawing.SystemColors.Window;
            this.PosErr_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PosErr_textBox.Location = new System.Drawing.Point(92, 64);
            this.PosErr_textBox.Name = "PosErr_textBox";
            this.PosErr_textBox.ReadOnly = true;
            this.PosErr_textBox.Size = new System.Drawing.Size(71, 15);
            this.PosErr_textBox.TabIndex = 22;
            // 
            // textBox44
            // 
            this.textBox44.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox44.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox44.Location = new System.Drawing.Point(15, 43);
            this.textBox44.Name = "textBox44";
            this.textBox44.Size = new System.Drawing.Size(71, 15);
            this.textBox44.TabIndex = 19;
            this.textBox44.Text = "Pos:";
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox12.Location = new System.Drawing.Point(15, 22);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(71, 15);
            this.textBox12.TabIndex = 15;
            this.textBox12.Text = "PosRef:";
            // 
            // PosRef_textBox
            // 
            this.PosRef_textBox.BackColor = System.Drawing.SystemColors.Window;
            this.PosRef_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PosRef_textBox.Location = new System.Drawing.Point(92, 22);
            this.PosRef_textBox.Name = "PosRef_textBox";
            this.PosRef_textBox.ReadOnly = true;
            this.PosRef_textBox.Size = new System.Drawing.Size(71, 15);
            this.PosRef_textBox.TabIndex = 16;
            // 
            // Vel_textBox
            // 
            this.Vel_textBox.BackColor = System.Drawing.SystemColors.Window;
            this.Vel_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Vel_textBox.Location = new System.Drawing.Point(303, 22);
            this.Vel_textBox.Name = "Vel_textBox";
            this.Vel_textBox.ReadOnly = true;
            this.Vel_textBox.Size = new System.Drawing.Size(71, 15);
            this.Vel_textBox.TabIndex = 17;
            // 
            // Axis_comboBox
            // 
            this.Axis_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Axis_comboBox.FormattingEnabled = true;
            this.Axis_comboBox.Items.AddRange(new object[] {
            "A", "B", "C", "D", "E", "F", "G", "H"});
            this.Axis_comboBox.Location = new System.Drawing.Point(115, 10);
            this.Axis_comboBox.Name = "Axis_comboBox";
            this.Axis_comboBox.Size = new System.Drawing.Size(69, 24);
            this.Axis_comboBox.TabIndex = 28;
            // 
            // Conn_groupBox
            // 
            this.Conn_groupBox.Controls.Add(this.textBox40);
            this.Conn_groupBox.Controls.Add(this.ControllerType_comboBox);
            this.Conn_groupBox.Controls.Add(this.Conn_button);
            this.Conn_groupBox.Controls.Add(this.Addr_textBox);
            this.Conn_groupBox.Controls.Add(this.textBox1);
            this.Conn_groupBox.Location = new System.Drawing.Point(417, 42);
            this.Conn_groupBox.Name = "Conn_groupBox";
            this.Conn_groupBox.Size = new System.Drawing.Size(293, 94);
            this.Conn_groupBox.TabIndex = 27;
            this.Conn_groupBox.TabStop = false;
            this.Conn_groupBox.Text = "Connection";
            // 
            // textBox40
            // 
            this.textBox40.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox40.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox40.Location = new System.Drawing.Point(5, 28);
            this.textBox40.Name = "textBox40";
            this.textBox40.Size = new System.Drawing.Size(71, 15);
            this.textBox40.TabIndex = 26;
            this.textBox40.Text = "Controller";
            // 
            // ControllerType_comboBox
            // 
            this.ControllerType_comboBox.FormattingEnabled = true;
            this.ControllerType_comboBox.Items.AddRange(new object[] {
            "AGM800", "AGD301", "AGD200", "AGD155", "AGD101"});
            this.ControllerType_comboBox.Location = new System.Drawing.Point(80, 25);
            this.ControllerType_comboBox.Name = "ControllerType_comboBox";
            this.ControllerType_comboBox.Size = new System.Drawing.Size(100, 24);
            this.ControllerType_comboBox.TabIndex = 25;
            this.ControllerType_comboBox.Text = "AGM800";
            this.ControllerType_comboBox.SelectedValueChanged += new System.EventHandler(this.ControllerType_comboBox_SelectedValueChanged);
            // 
            // Conn_button
            // 
            this.Conn_button.Location = new System.Drawing.Point(187, 22);
            this.Conn_button.Name = "Conn_button";
            this.Conn_button.Size = new System.Drawing.Size(96, 59);
            this.Conn_button.TabIndex = 2;
            this.Conn_button.Text = "Connect";
            this.Conn_button.UseVisualStyleBackColor = true;
            this.Conn_button.Click += new System.EventHandler(this.Conn_button_Click);
            // 
            // Addr_textBox
            // 
            this.Addr_textBox.Location = new System.Drawing.Point(80, 55);
            this.Addr_textBox.Name = "Addr_textBox";
            this.Addr_textBox.Size = new System.Drawing.Size(100, 22);
            this.Addr_textBox.TabIndex = 1;
            this.Addr_textBox.Text = "172.1.1.101";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(5, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(71, 15);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Address";
            // 
            // timerRefreshUI
            // 
            this.timerRefreshUI.Tick += new System.EventHandler(this.timerRefreshUI_Tick);
            // 
            // status_groupBox
            // 
            this.status_groupBox.Controls.Add(this.text_MotionReason);
            this.status_groupBox.Controls.Add(this.text_ConFlt);
            this.status_groupBox.Controls.Add(this.text_MotionStat);
            this.status_groupBox.Controls.Add(this.label126);
            this.status_groupBox.Controls.Add(this.label125);
            this.status_groupBox.Controls.Add(this.label124);
            this.status_groupBox.Location = new System.Drawing.Point(23, 144);
            this.status_groupBox.Name = "status_groupBox";
            this.status_groupBox.Size = new System.Drawing.Size(687, 100);
            this.status_groupBox.TabIndex = 56;
            this.status_groupBox.TabStop = false;
            this.status_groupBox.Text = "Status";
            // 
            // text_MotionReason
            // 
            this.text_MotionReason.Location = new System.Drawing.Point(119, 71);
            this.text_MotionReason.Name = "text_MotionReason";
            this.text_MotionReason.ReadOnly = true;
            this.text_MotionReason.Size = new System.Drawing.Size(558, 22);
            this.text_MotionReason.TabIndex = 61;
            // 
            // text_ConFlt
            // 
            this.text_ConFlt.Location = new System.Drawing.Point(119, 44);
            this.text_ConFlt.Name = "text_ConFlt";
            this.text_ConFlt.ReadOnly = true;
            this.text_ConFlt.Size = new System.Drawing.Size(558, 22);
            this.text_ConFlt.TabIndex = 60;
            // 
            // text_MotionStat
            // 
            this.text_MotionStat.Location = new System.Drawing.Point(119, 19);
            this.text_MotionStat.Name = "text_MotionStat";
            this.text_MotionStat.ReadOnly = true;
            this.text_MotionStat.Size = new System.Drawing.Size(558, 22);
            this.text_MotionStat.TabIndex = 4;
            // 
            // label126
            // 
            this.label126.AutoSize = true;
            this.label126.Location = new System.Drawing.Point(12, 77);
            this.label126.Name = "label126";
            this.label126.Size = new System.Drawing.Size(101, 16);
            this.label126.TabIndex = 59;
            this.label126.Text = "Motion Reason:";
            // 
            // label125
            // 
            this.label125.AutoSize = true;
            this.label125.Location = new System.Drawing.Point(12, 50);
            this.label125.Name = "label125";
            this.label125.Size = new System.Drawing.Size(48, 16);
            this.label125.TabIndex = 58;
            this.label125.Text = "ConFlt:";
            // 
            // label124
            // 
            this.label124.AutoSize = true;
            this.label124.Location = new System.Drawing.Point(12, 26);
            this.label124.Name = "label124";
            this.label124.Size = new System.Drawing.Size(90, 16);
            this.label124.TabIndex = 57;
            this.label124.Text = "Motion Status:";
            // 
            // laserMeasurement_groupBox
            // 
            this.laserMeasurement_groupBox.Controls.Add(this.buttonStartLaser);
            this.laserMeasurement_groupBox.Controls.Add(this.numericDwellTime);
            this.laserMeasurement_groupBox.Controls.Add(this.labelDwellTime);
            this.laserMeasurement_groupBox.Controls.Add(this.numericRuns);
            this.laserMeasurement_groupBox.Controls.Add(this.labelRuns);
            this.laserMeasurement_groupBox.Controls.Add(this.numericInterval);
            this.laserMeasurement_groupBox.Controls.Add(this.labelInterval);
            this.laserMeasurement_groupBox.Controls.Add(this.numericOverrun);
            this.laserMeasurement_groupBox.Controls.Add(this.labelOverrun);
            this.laserMeasurement_groupBox.Controls.Add(this.numericStroke);
            this.laserMeasurement_groupBox.Controls.Add(this.labelStroke);
            this.laserMeasurement_groupBox.Controls.Add(this.numericStartPosition);
            this.laserMeasurement_groupBox.Controls.Add(this.labelStartPosition);
            this.laserMeasurement_groupBox.Controls.Add(this.comboBoxBidirectional);
            this.laserMeasurement_groupBox.Controls.Add(this.labelBidirectional);
            this.laserMeasurement_groupBox.Location = new System.Drawing.Point(23, 250);
            this.laserMeasurement_groupBox.Name = "laserMeasurement_groupBox";
            this.laserMeasurement_groupBox.Size = new System.Drawing.Size(350, 340);
            this.laserMeasurement_groupBox.TabIndex = 29;
            this.laserMeasurement_groupBox.TabStop = false;
            this.laserMeasurement_groupBox.Text = "Laser Measurement";
            // 
            // buttonStartLaser
            // 
            this.buttonStartLaser.Location = new System.Drawing.Point(150, 285);
            this.buttonStartLaser.Name = "buttonStartLaser";
            this.buttonStartLaser.Size = new System.Drawing.Size(120, 35);
            this.buttonStartLaser.TabIndex = 44;
            this.buttonStartLaser.Text = "Start";
            this.buttonStartLaser.UseVisualStyleBackColor = true;
            this.buttonStartLaser.Click += new System.EventHandler(this.buttonStartLaser_Click);
            // 
            // labelBidirectional
            // 
            this.labelBidirectional.AutoSize = true;
            this.labelBidirectional.Location = new System.Drawing.Point(20, 40);
            this.labelBidirectional.Name = "labelBidirectional";
            this.labelBidirectional.Size = new System.Drawing.Size(85, 16);
            this.labelBidirectional.TabIndex = 30;
            this.labelBidirectional.Text = "Bidirectional:";
            // 
            // comboBoxBidirectional
            // 
            this.comboBoxBidirectional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBidirectional.FormattingEnabled = true;
            this.comboBoxBidirectional.Location = new System.Drawing.Point(150, 37);
            this.comboBoxBidirectional.Name = "comboBoxBidirectional";
            this.comboBoxBidirectional.Size = new System.Drawing.Size(120, 24);
            this.comboBoxBidirectional.TabIndex = 31;
            this.comboBoxBidirectional.Items.Add("Yes");
            this.comboBoxBidirectional.Items.Add("No");
            // 
            // labelStartPosition
            // 
            this.labelStartPosition.AutoSize = true;
            this.labelStartPosition.Location = new System.Drawing.Point(20, 75);
            this.labelStartPosition.Name = "labelStartPosition";
            this.labelStartPosition.Size = new System.Drawing.Size(89, 16);
            this.labelStartPosition.TabIndex = 32;
            this.labelStartPosition.Text = "Start Position:";
            // 
            // numericStartPosition
            // 
            this.numericStartPosition.Location = new System.Drawing.Point(150, 73);
            this.numericStartPosition.Name = "numericStartPosition";
            this.numericStartPosition.Size = new System.Drawing.Size(120, 22);
            this.numericStartPosition.TabIndex = 33;
            // 
            // labelStroke
            // 
            this.labelStroke.AutoSize = true;
            this.labelStroke.Location = new System.Drawing.Point(20, 110);
            this.labelStroke.Name = "labelStroke";
            this.labelStroke.Size = new System.Drawing.Size(49, 16);
            this.labelStroke.TabIndex = 34;
            this.labelStroke.Text = "Stroke:";
            // 
            // numericStroke
            // 
            this.numericStroke.Location = new System.Drawing.Point(150, 108);
            this.numericStroke.Name = "numericStroke";
            this.numericStroke.Size = new System.Drawing.Size(120, 22);
            this.numericStroke.TabIndex = 35;
            // 
            // labelOverrun
            // 
            this.labelOverrun.AutoSize = true;
            this.labelOverrun.Location = new System.Drawing.Point(20, 145);
            this.labelOverrun.Name = "labelOverrun";
            this.labelOverrun.Size = new System.Drawing.Size(58, 16);
            this.labelOverrun.TabIndex = 36;
            this.labelOverrun.Text = "Overrun:";
            // 
            // numericOverrun
            // 
            this.numericOverrun.Location = new System.Drawing.Point(150, 143);
            this.numericOverrun.Name = "numericOverrun";
            this.numericOverrun.Size = new System.Drawing.Size(120, 22);
            this.numericOverrun.TabIndex = 37;
            // 
            // labelInterval
            // 
            this.labelInterval.AutoSize = true;
            this.labelInterval.Location = new System.Drawing.Point(20, 180);
            this.labelInterval.Name = "labelInterval";
            this.labelInterval.Size = new System.Drawing.Size(53, 16);
            this.labelInterval.TabIndex = 38;
            this.labelInterval.Text = "Interval:";
            // 
            // numericInterval
            // 
            this.numericInterval.Location = new System.Drawing.Point(150, 178);
            this.numericInterval.Name = "numericInterval";
            this.numericInterval.Size = new System.Drawing.Size(120, 22);
            this.numericInterval.TabIndex = 39;
            // 
            // labelRuns
            // 
            this.labelRuns.AutoSize = true;
            this.labelRuns.Location = new System.Drawing.Point(20, 215);
            this.labelRuns.Name = "labelRuns";
            this.labelRuns.Size = new System.Drawing.Size(41, 16);
            this.labelRuns.TabIndex = 40;
            this.labelRuns.Text = "Runs:";
            // 
            // numericRuns
            // 
            this.numericRuns.Location = new System.Drawing.Point(150, 213);
            this.numericRuns.Name = "numericRuns";
            this.numericRuns.Size = new System.Drawing.Size(120, 22);
            this.numericRuns.TabIndex = 41;
            // 
            // labelDwellTime
            // 
            this.labelDwellTime.AutoSize = true;
            this.labelDwellTime.Location = new System.Drawing.Point(20, 250);
            this.labelDwellTime.Name = "labelDwellTime";
            this.labelDwellTime.Size = new System.Drawing.Size(101, 16);
            this.labelDwellTime.TabIndex = 42;
            this.labelDwellTime.Text = "Dwell time (ms):";
            // 
            // numericDwellTime
            // 
            this.numericDwellTime.Location = new System.Drawing.Point(150, 248);
            this.numericDwellTime.Name = "numericDwellTime";
            this.numericDwellTime.Size = new System.Drawing.Size(120, 22);
            this.numericDwellTime.TabIndex = 43;
            // 
            // motionSpec_groupBox
            // 
            this.motionSpec_groupBox.Controls.Add(this.numericEmrgDecel);
            this.motionSpec_groupBox.Controls.Add(this.labelEmrgDecel);
            this.motionSpec_groupBox.Controls.Add(this.numericDecel);
            this.motionSpec_groupBox.Controls.Add(this.labelDecel);
            this.motionSpec_groupBox.Controls.Add(this.numericAccel);
            this.motionSpec_groupBox.Controls.Add(this.labelAccel);
            this.motionSpec_groupBox.Controls.Add(this.numericSpeed);
            this.motionSpec_groupBox.Controls.Add(this.labelSpeed);
            this.motionSpec_groupBox.Location = new System.Drawing.Point(417, 250);
            this.motionSpec_groupBox.Name = "motionSpec_groupBox";
            this.motionSpec_groupBox.Size = new System.Drawing.Size(293, 200);
            this.motionSpec_groupBox.TabIndex = 60;
            this.motionSpec_groupBox.TabStop = false;
            this.motionSpec_groupBox.Text = "Motion Specification";
            // 
            // numericEmrgDecel
            // 
            this.numericEmrgDecel.Location = new System.Drawing.Point(150, 138);
            this.numericEmrgDecel.Name = "numericEmrgDecel";
            this.numericEmrgDecel.Size = new System.Drawing.Size(120, 22);
            this.numericEmrgDecel.TabIndex = 7;
            // 
            // labelEmrgDecel
            // 
            this.labelEmrgDecel.AutoSize = true;
            this.labelEmrgDecel.Location = new System.Drawing.Point(15, 140);
            this.labelEmrgDecel.Name = "labelEmrgDecel";
            this.labelEmrgDecel.Size = new System.Drawing.Size(91, 16);
            this.labelEmrgDecel.TabIndex = 6;
            this.labelEmrgDecel.Text = "Emerg. Decel:";
            // 
            // numericDecel
            // 
            this.numericDecel.Location = new System.Drawing.Point(150, 103);
            this.numericDecel.Name = "numericDecel";
            this.numericDecel.Size = new System.Drawing.Size(120, 22);
            this.numericDecel.TabIndex = 5;
            // 
            // labelDecel
            // 
            this.labelDecel.AutoSize = true;
            this.labelDecel.Location = new System.Drawing.Point(15, 105);
            this.labelDecel.Name = "labelDecel";
            this.labelDecel.Size = new System.Drawing.Size(89, 16);
            this.labelDecel.TabIndex = 4;
            this.labelDecel.Text = "Deceleration:";
            // 
            // numericAccel
            // 
            this.numericAccel.Location = new System.Drawing.Point(150, 68);
            this.numericAccel.Name = "numericAccel";
            this.numericAccel.Size = new System.Drawing.Size(120, 22);
            this.numericAccel.TabIndex = 3;
            // 
            // labelAccel
            // 
            this.labelAccel.AutoSize = true;
            this.labelAccel.Location = new System.Drawing.Point(15, 70);
            this.labelAccel.Name = "labelAccel";
            this.labelAccel.Size = new System.Drawing.Size(85, 16);
            this.labelAccel.TabIndex = 2;
            this.labelAccel.Text = "Acceleration:";
            // 
            // numericSpeed
            // 
            this.numericSpeed.Location = new System.Drawing.Point(150, 33);
            this.numericSpeed.Name = "numericSpeed";
            this.numericSpeed.Size = new System.Drawing.Size(120, 22);
            this.numericSpeed.TabIndex = 1;
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(15, 35);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(51, 16);
            this.labelSpeed.TabIndex = 0;
            this.labelSpeed.Text = "Speed:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 620);
            this.Controls.Add(this.motionSpec_groupBox);
            this.Controls.Add(this.laserMeasurement_groupBox);
            this.Controls.Add(this.status_groupBox);
            this.Controls.Add(this.textBox72);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Axis_comboBox);
            this.Controls.Add(this.Conn_groupBox);
            this.Name = "Form1";
            this.Text = "Agito Laser Measurement XM60";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Conn_groupBox.ResumeLayout(false);
            this.Conn_groupBox.PerformLayout();
            this.status_groupBox.ResumeLayout(false);
            this.status_groupBox.PerformLayout();
            this.laserMeasurement_groupBox.ResumeLayout(false);
            this.laserMeasurement_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDwellTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRuns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericOverrun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStroke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStartPosition)).EndInit();
            this.motionSpec_groupBox.ResumeLayout(false);
            this.motionSpec_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericEmrgDecel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDecel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAccel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox72;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox66;
        private System.Windows.Forms.TextBox MotorCurr_textBox;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox64;
        private System.Windows.Forms.TextBox PosErr_textBox;
        private System.Windows.Forms.TextBox textBox44;
        private System.Windows.Forms.TextBox Pos_textBox;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox PosRef_textBox;
        private System.Windows.Forms.TextBox Vel_textBox;
        private System.Windows.Forms.ComboBox Axis_comboBox;
        private System.Windows.Forms.GroupBox Conn_groupBox;
        private System.Windows.Forms.TextBox textBox40;
        private System.Windows.Forms.ComboBox ControllerType_comboBox;
        private System.Windows.Forms.Button Conn_button;
        private System.Windows.Forms.TextBox Addr_textBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timerRefreshUI;
        private System.Windows.Forms.GroupBox status_groupBox;
        private System.Windows.Forms.Label label126;
        private System.Windows.Forms.Label label125;
        private System.Windows.Forms.Label label124;
        private System.Windows.Forms.TextBox text_MotionReason;
        private System.Windows.Forms.TextBox text_ConFlt;
        private System.Windows.Forms.TextBox text_MotionStat;
        private System.Windows.Forms.GroupBox laserMeasurement_groupBox;
        private System.Windows.Forms.Button buttonStartLaser;
        private System.Windows.Forms.Label labelBidirectional;
        private System.Windows.Forms.ComboBox comboBoxBidirectional;
        private System.Windows.Forms.Label labelStartPosition;
        private System.Windows.Forms.NumericUpDown numericStartPosition;
        private System.Windows.Forms.Label labelStroke;
        private System.Windows.Forms.NumericUpDown numericStroke;
        private System.Windows.Forms.Label labelOverrun;
        private System.Windows.Forms.NumericUpDown numericOverrun;
        private System.Windows.Forms.Label labelInterval;
        private System.Windows.Forms.NumericUpDown numericInterval;
        private System.Windows.Forms.Label labelRuns;
        private System.Windows.Forms.NumericUpDown numericRuns;
        private System.Windows.Forms.Label labelDwellTime;
        private System.Windows.Forms.NumericUpDown numericDwellTime;
        private System.Windows.Forms.GroupBox motionSpec_groupBox;
        private System.Windows.Forms.NumericUpDown numericEmrgDecel;
        private System.Windows.Forms.Label labelEmrgDecel;
        private System.Windows.Forms.NumericUpDown numericDecel;
        private System.Windows.Forms.Label labelDecel;
        private System.Windows.Forms.NumericUpDown numericAccel;
        private System.Windows.Forms.Label labelAccel;
        private System.Windows.Forms.NumericUpDown numericSpeed;
        private System.Windows.Forms.Label labelSpeed;
    }
}