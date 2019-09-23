using System.Windows.Forms;

namespace RoastBot
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.cbAimMode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudAimKey = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResolution = new System.Windows.Forms.Label();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.btnLoadSettings = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.nudAnaKey = new System.Windows.Forms.NumericUpDown();
            this.cbAnaMode = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMain = new System.Windows.Forms.TabControl();
            this.tgGeneral = new System.Windows.Forms.TabPage();
            this.gbDrawing = new System.Windows.Forms.GroupBox();
            this.cbWidowFov = new System.Windows.Forms.CheckBox();
            this.cbTriggerFov = new System.Windows.Forms.CheckBox();
            this.cbAnaFov = new System.Windows.Forms.CheckBox();
            this.cbAimFov = new System.Windows.Forms.CheckBox();
            this.cbWidowStatus = new System.Windows.Forms.CheckBox();
            this.cbTriggerStatus = new System.Windows.Forms.CheckBox();
            this.cbAnabotStatus = new System.Windows.Forms.CheckBox();
            this.cbAimStatus = new System.Windows.Forms.CheckBox();
            this.cbDrawOver = new System.Windows.Forms.CheckBox();
            this.cbMonitor = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbWidowEnable = new System.Windows.Forms.CheckBox();
            this.cbTriggerEnable = new System.Windows.Forms.CheckBox();
            this.cbAnaEnable = new System.Windows.Forms.CheckBox();
            this.cbAimEnable = new System.Windows.Forms.CheckBox();
            this.tpAim = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nudAimYTolerance = new System.Windows.Forms.NumericUpDown();
            this.nudAimXTolerance = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.nudAimYOffset = new System.Windows.Forms.NumericUpDown();
            this.nudAimXOffset = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nudAimFovHeight = new System.Windows.Forms.NumericUpDown();
            this.nudAimFovWidth = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAimFovWith = new System.Windows.Forms.Label();
            this.tpAna = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudAnaYTolerance = new System.Windows.Forms.NumericUpDown();
            this.nudAnaXTolerance = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.nudAnaYOffset = new System.Windows.Forms.NumericUpDown();
            this.nudAnaXOffset = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.nudAnaFovHeight = new System.Windows.Forms.NumericUpDown();
            this.nudAnaFovWidth = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tpTrigger = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.nudTriggerFovHeight = new System.Windows.Forms.NumericUpDown();
            this.nudTriggerFovWidth = new System.Windows.Forms.NumericUpDown();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.cbTriggerMode = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.nudTriggerKey = new System.Windows.Forms.NumericUpDown();
            this.tpWidow = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudWidowYTolerance = new System.Windows.Forms.NumericUpDown();
            this.nudWidowXTolerance = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.nudWidowYOffset = new System.Windows.Forms.NumericUpDown();
            this.nudWidowXOffset = new System.Windows.Forms.NumericUpDown();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.nudWidowFovHeight = new System.Windows.Forms.NumericUpDown();
            this.nudWidowFovWidth = new System.Windows.Forms.NumericUpDown();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.cbWidowMode = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nudWidowKey = new System.Windows.Forms.NumericUpDown();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tpGlobal = new System.Windows.Forms.TabPage();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.nudAimSpeedY = new System.Windows.Forms.NumericUpDown();
            this.nudAimSpeedX = new System.Windows.Forms.NumericUpDown();
            this.cbAntiShake = new System.Windows.Forms.CheckBox();
            this.label31 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudAimKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnaKey)).BeginInit();
            this.tbMain.SuspendLayout();
            this.tgGeneral.SuspendLayout();
            this.gbDrawing.SuspendLayout();
            this.tpAim.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAimYTolerance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAimXTolerance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAimYOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAimXOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAimFovHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAimFovWidth)).BeginInit();
            this.tpAna.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnaYTolerance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnaXTolerance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnaYOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnaXOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnaFovHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnaFovWidth)).BeginInit();
            this.tpTrigger.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTriggerFovHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTriggerFovWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTriggerKey)).BeginInit();
            this.tpWidow.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidowYTolerance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidowXTolerance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidowYOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidowXOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidowFovHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidowFovWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidowKey)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.tpGlobal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAimSpeedY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAimSpeedX)).BeginInit();
            this.SuspendLayout();
            // 
            // cbAimMode
            // 
            this.cbAimMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAimMode.FormattingEnabled = true;
            this.cbAimMode.Items.AddRange(new object[] {
            "Always on",
            "Toggle",
            "HoldDown"});
            this.cbAimMode.Location = new System.Drawing.Point(66, 34);
            this.cbAimMode.Name = "cbAimMode";
            this.cbAimMode.Size = new System.Drawing.Size(75, 21);
            this.cbAimMode.TabIndex = 2;
            this.cbAimMode.SelectedIndexChanged += new System.EventHandler(this.cbAimMode_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Aim Key";
            // 
            // nudAimKey
            // 
            this.nudAimKey.Location = new System.Drawing.Point(66, 6);
            this.nudAimKey.Maximum = new decimal(new int[] {
            254,
            0,
            0,
            0});
            this.nudAimKey.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAimKey.Name = "nudAimKey";
            this.nudAimKey.Size = new System.Drawing.Size(75, 20);
            this.nudAimKey.TabIndex = 4;
            this.nudAimKey.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAimKey.ValueChanged += new System.EventHandler(this.nudAimKey_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Aim Mode";
            // 
            // lblResolution
            // 
            this.lblResolution.AutoSize = true;
            this.lblResolution.Location = new System.Drawing.Point(13, 9);
            this.lblResolution.Name = "lblResolution";
            this.lblResolution.Size = new System.Drawing.Size(114, 13);
            this.lblResolution.TabIndex = 1;
            this.lblResolution.Text = "Screen resolution label";
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Location = new System.Drawing.Point(16, 29);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(90, 25);
            this.btnSaveSettings.TabIndex = 8;
            this.btnSaveSettings.Text = "Save Settings";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // btnLoadSettings
            // 
            this.btnLoadSettings.Location = new System.Drawing.Point(112, 29);
            this.btnLoadSettings.Name = "btnLoadSettings";
            this.btnLoadSettings.Size = new System.Drawing.Size(90, 25);
            this.btnLoadSettings.TabIndex = 9;
            this.btnLoadSettings.Text = "Load Settings";
            this.btnLoadSettings.UseVisualStyleBackColor = true;
            this.btnLoadSettings.Click += new System.EventHandler(this.btnLoadSettings_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Aim Key";
            // 
            // nudAnaKey
            // 
            this.nudAnaKey.Location = new System.Drawing.Point(66, 6);
            this.nudAnaKey.Maximum = new decimal(new int[] {
            254,
            0,
            0,
            0});
            this.nudAnaKey.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAnaKey.Name = "nudAnaKey";
            this.nudAnaKey.Size = new System.Drawing.Size(75, 20);
            this.nudAnaKey.TabIndex = 4;
            this.nudAnaKey.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAnaKey.ValueChanged += new System.EventHandler(this.nudAnaKey_ValueChanged);
            // 
            // cbAnaMode
            // 
            this.cbAnaMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAnaMode.FormattingEnabled = true;
            this.cbAnaMode.Items.AddRange(new object[] {
            "Always on",
            "Toggle",
            "HoldDown"});
            this.cbAnaMode.Location = new System.Drawing.Point(66, 34);
            this.cbAnaMode.Name = "cbAnaMode";
            this.cbAnaMode.Size = new System.Drawing.Size(75, 21);
            this.cbAnaMode.TabIndex = 2;
            this.cbAnaMode.SelectedIndexChanged += new System.EventHandler(this.cbAnaMode_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Aim Mode";
            // 
            // tbMain
            // 
            this.tbMain.Controls.Add(this.tgGeneral);
            this.tbMain.Controls.Add(this.tpGlobal);
            this.tbMain.Controls.Add(this.tpAim);
            this.tbMain.Controls.Add(this.tpAna);
            this.tbMain.Controls.Add(this.tpTrigger);
            this.tbMain.Controls.Add(this.tpWidow);
            this.tbMain.Location = new System.Drawing.Point(12, 60);
            this.tbMain.Name = "tbMain";
            this.tbMain.SelectedIndex = 0;
            this.tbMain.Size = new System.Drawing.Size(307, 276);
            this.tbMain.TabIndex = 11;
            // 
            // tgGeneral
            // 
            this.tgGeneral.Controls.Add(this.comboBox1);
            this.tgGeneral.Controls.Add(this.label31);
            this.tgGeneral.Controls.Add(this.gbDrawing);
            this.tgGeneral.Controls.Add(this.cbMonitor);
            this.tgGeneral.Controls.Add(this.label13);
            this.tgGeneral.Controls.Add(this.cbWidowEnable);
            this.tgGeneral.Controls.Add(this.cbTriggerEnable);
            this.tgGeneral.Controls.Add(this.cbAnaEnable);
            this.tgGeneral.Controls.Add(this.cbAimEnable);
            this.tgGeneral.Location = new System.Drawing.Point(4, 22);
            this.tgGeneral.Name = "tgGeneral";
            this.tgGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tgGeneral.Size = new System.Drawing.Size(299, 250);
            this.tgGeneral.TabIndex = 0;
            this.tgGeneral.Text = "General";
            this.tgGeneral.UseVisualStyleBackColor = true;
            // 
            // gbDrawing
            // 
            this.gbDrawing.Controls.Add(this.cbWidowFov);
            this.gbDrawing.Controls.Add(this.cbTriggerFov);
            this.gbDrawing.Controls.Add(this.cbAnaFov);
            this.gbDrawing.Controls.Add(this.cbAimFov);
            this.gbDrawing.Controls.Add(this.cbWidowStatus);
            this.gbDrawing.Controls.Add(this.cbTriggerStatus);
            this.gbDrawing.Controls.Add(this.cbAnabotStatus);
            this.gbDrawing.Controls.Add(this.cbAimStatus);
            this.gbDrawing.Controls.Add(this.cbDrawOver);
            this.gbDrawing.Location = new System.Drawing.Point(6, 56);
            this.gbDrawing.Name = "gbDrawing";
            this.gbDrawing.Size = new System.Drawing.Size(284, 133);
            this.gbDrawing.TabIndex = 14;
            this.gbDrawing.TabStop = false;
            this.gbDrawing.Text = "Overlay WIP";
            // 
            // cbWidowFov
            // 
            this.cbWidowFov.AutoSize = true;
            this.cbWidowFov.Enabled = false;
            this.cbWidowFov.Location = new System.Drawing.Point(140, 111);
            this.cbWidowFov.Name = "cbWidowFov";
            this.cbWidowFov.Size = new System.Drawing.Size(98, 17);
            this.cbWidowFov.TabIndex = 8;
            this.cbWidowFov.Text = "Widowbot FOV";
            this.cbWidowFov.UseVisualStyleBackColor = true;
            this.cbWidowFov.CheckedChanged += new System.EventHandler(this.cbWidowFov_CheckedChanged);
            // 
            // cbTriggerFov
            // 
            this.cbTriggerFov.AutoSize = true;
            this.cbTriggerFov.Enabled = false;
            this.cbTriggerFov.Location = new System.Drawing.Point(140, 88);
            this.cbTriggerFov.Name = "cbTriggerFov";
            this.cbTriggerFov.Size = new System.Drawing.Size(98, 17);
            this.cbTriggerFov.TabIndex = 7;
            this.cbTriggerFov.Text = "Triggerbot FOV";
            this.cbTriggerFov.UseVisualStyleBackColor = true;
            this.cbTriggerFov.CheckedChanged += new System.EventHandler(this.cbTriggerFov_CheckedChanged);
            // 
            // cbAnaFov
            // 
            this.cbAnaFov.AutoSize = true;
            this.cbAnaFov.Enabled = false;
            this.cbAnaFov.Location = new System.Drawing.Point(140, 65);
            this.cbAnaFov.Name = "cbAnaFov";
            this.cbAnaFov.Size = new System.Drawing.Size(84, 17);
            this.cbAnaFov.TabIndex = 6;
            this.cbAnaFov.Text = "Anabot FOV";
            this.cbAnaFov.UseVisualStyleBackColor = true;
            this.cbAnaFov.CheckedChanged += new System.EventHandler(this.cbAnaFov_CheckedChanged);
            // 
            // cbAimFov
            // 
            this.cbAimFov.AutoSize = true;
            this.cbAimFov.Enabled = false;
            this.cbAimFov.Location = new System.Drawing.Point(140, 42);
            this.cbAimFov.Name = "cbAimFov";
            this.cbAimFov.Size = new System.Drawing.Size(82, 17);
            this.cbAimFov.TabIndex = 5;
            this.cbAimFov.Text = "Aimbot FOV";
            this.cbAimFov.UseVisualStyleBackColor = true;
            this.cbAimFov.CheckedChanged += new System.EventHandler(this.cbAimFov_CheckedChanged);
            // 
            // cbWidowStatus
            // 
            this.cbWidowStatus.AutoSize = true;
            this.cbWidowStatus.Location = new System.Drawing.Point(19, 111);
            this.cbWidowStatus.Name = "cbWidowStatus";
            this.cbWidowStatus.Size = new System.Drawing.Size(107, 17);
            this.cbWidowStatus.TabIndex = 4;
            this.cbWidowStatus.Text = "Widowbot Status";
            this.cbWidowStatus.UseVisualStyleBackColor = true;
            this.cbWidowStatus.CheckedChanged += new System.EventHandler(this.cbDrawWidow_CheckedChanged);
            // 
            // cbTriggerStatus
            // 
            this.cbTriggerStatus.AutoSize = true;
            this.cbTriggerStatus.Location = new System.Drawing.Point(19, 88);
            this.cbTriggerStatus.Name = "cbTriggerStatus";
            this.cbTriggerStatus.Size = new System.Drawing.Size(107, 17);
            this.cbTriggerStatus.TabIndex = 3;
            this.cbTriggerStatus.Text = "Triggerbot Status";
            this.cbTriggerStatus.UseVisualStyleBackColor = true;
            this.cbTriggerStatus.CheckedChanged += new System.EventHandler(this.cbDrawTrigger_CheckedChanged);
            // 
            // cbAnabotStatus
            // 
            this.cbAnabotStatus.AutoSize = true;
            this.cbAnabotStatus.Location = new System.Drawing.Point(19, 65);
            this.cbAnabotStatus.Name = "cbAnabotStatus";
            this.cbAnabotStatus.Size = new System.Drawing.Size(93, 17);
            this.cbAnabotStatus.TabIndex = 2;
            this.cbAnabotStatus.Text = "Anabot Status";
            this.cbAnabotStatus.UseVisualStyleBackColor = true;
            this.cbAnabotStatus.CheckedChanged += new System.EventHandler(this.cbDrawAna_CheckedChanged);
            // 
            // cbAimStatus
            // 
            this.cbAimStatus.AutoSize = true;
            this.cbAimStatus.Location = new System.Drawing.Point(19, 42);
            this.cbAimStatus.Name = "cbAimStatus";
            this.cbAimStatus.Size = new System.Drawing.Size(91, 17);
            this.cbAimStatus.TabIndex = 1;
            this.cbAimStatus.Text = "Aimbot Status";
            this.cbAimStatus.UseVisualStyleBackColor = true;
            this.cbAimStatus.CheckedChanged += new System.EventHandler(this.cbDrawAim_CheckedChanged);
            // 
            // cbDrawOver
            // 
            this.cbDrawOver.AutoSize = true;
            this.cbDrawOver.Location = new System.Drawing.Point(6, 19);
            this.cbDrawOver.Name = "cbDrawOver";
            this.cbDrawOver.Size = new System.Drawing.Size(90, 17);
            this.cbDrawOver.TabIndex = 0;
            this.cbDrawOver.Text = "Draw Overlay";
            this.cbDrawOver.UseVisualStyleBackColor = true;
            this.cbDrawOver.CheckedChanged += new System.EventHandler(this.cbDrawOver_CheckedChanged);
            // 
            // cbMonitor
            // 
            this.cbMonitor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonitor.FormattingEnabled = true;
            this.cbMonitor.Location = new System.Drawing.Point(47, 29);
            this.cbMonitor.Name = "cbMonitor";
            this.cbMonitor.Size = new System.Drawing.Size(38, 21);
            this.cbMonitor.TabIndex = 13;
            this.cbMonitor.SelectedIndexChanged += new System.EventHandler(this.cbMonitor_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Monitor";
            // 
            // cbWidowEnable
            // 
            this.cbWidowEnable.AutoSize = true;
            this.cbWidowEnable.Location = new System.Drawing.Point(216, 6);
            this.cbWidowEnable.Name = "cbWidowEnable";
            this.cbWidowEnable.Size = new System.Drawing.Size(74, 17);
            this.cbWidowEnable.TabIndex = 11;
            this.cbWidowEnable.Text = "Widowbot";
            this.cbWidowEnable.UseVisualStyleBackColor = true;
            this.cbWidowEnable.CheckedChanged += new System.EventHandler(this.cbWidowEnable_CheckedChanged);
            // 
            // cbTriggerEnable
            // 
            this.cbTriggerEnable.AutoSize = true;
            this.cbTriggerEnable.Location = new System.Drawing.Point(136, 6);
            this.cbTriggerEnable.Name = "cbTriggerEnable";
            this.cbTriggerEnable.Size = new System.Drawing.Size(74, 17);
            this.cbTriggerEnable.TabIndex = 10;
            this.cbTriggerEnable.Text = "Triggerbot";
            this.cbTriggerEnable.UseVisualStyleBackColor = true;
            this.cbTriggerEnable.CheckedChanged += new System.EventHandler(this.cbTriggerEnable_CheckedChanged);
            // 
            // cbAnaEnable
            // 
            this.cbAnaEnable.AutoSize = true;
            this.cbAnaEnable.Location = new System.Drawing.Point(70, 6);
            this.cbAnaEnable.Name = "cbAnaEnable";
            this.cbAnaEnable.Size = new System.Drawing.Size(60, 17);
            this.cbAnaEnable.TabIndex = 9;
            this.cbAnaEnable.Text = "Anabot";
            this.cbAnaEnable.UseVisualStyleBackColor = true;
            this.cbAnaEnable.CheckedChanged += new System.EventHandler(this.cbAnaEnable_CheckedChanged);
            // 
            // cbAimEnable
            // 
            this.cbAimEnable.AutoSize = true;
            this.cbAimEnable.Location = new System.Drawing.Point(6, 6);
            this.cbAimEnable.Name = "cbAimEnable";
            this.cbAimEnable.Size = new System.Drawing.Size(58, 17);
            this.cbAimEnable.TabIndex = 8;
            this.cbAimEnable.Text = "Aimbot";
            this.cbAimEnable.UseVisualStyleBackColor = true;
            this.cbAimEnable.CheckedChanged += new System.EventHandler(this.cbAimEnable_CheckedChanged);
            // 
            // tpAim
            // 
            this.tpAim.Controls.Add(this.groupBox3);
            this.tpAim.Controls.Add(this.cbAimMode);
            this.tpAim.Controls.Add(this.label1);
            this.tpAim.Controls.Add(this.label2);
            this.tpAim.Controls.Add(this.nudAimKey);
            this.tpAim.Location = new System.Drawing.Point(4, 22);
            this.tpAim.Name = "tpAim";
            this.tpAim.Padding = new System.Windows.Forms.Padding(3);
            this.tpAim.Size = new System.Drawing.Size(299, 250);
            this.tpAim.TabIndex = 1;
            this.tpAim.Text = "Aimbot";
            this.tpAim.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nudAimYTolerance);
            this.groupBox3.Controls.Add(this.nudAimXTolerance);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.nudAimYOffset);
            this.groupBox3.Controls.Add(this.nudAimXOffset);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.nudAimFovHeight);
            this.groupBox3.Controls.Add(this.nudAimFovWidth);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.lblAimFovWith);
            this.groupBox3.Location = new System.Drawing.Point(6, 60);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(278, 160);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Field of View";
            // 
            // nudAimYTolerance
            // 
            this.nudAimYTolerance.Location = new System.Drawing.Point(90, 116);
            this.nudAimYTolerance.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudAimYTolerance.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAimYTolerance.Name = "nudAimYTolerance";
            this.nudAimYTolerance.Size = new System.Drawing.Size(61, 20);
            this.nudAimYTolerance.TabIndex = 11;
            this.nudAimYTolerance.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAimYTolerance.ValueChanged += new System.EventHandler(this.UpdateAimbotFovNoDrawing);
            // 
            // nudAimXTolerance
            // 
            this.nudAimXTolerance.Location = new System.Drawing.Point(9, 116);
            this.nudAimXTolerance.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudAimXTolerance.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAimXTolerance.Name = "nudAimXTolerance";
            this.nudAimXTolerance.Size = new System.Drawing.Size(61, 20);
            this.nudAimXTolerance.TabIndex = 10;
            this.nudAimXTolerance.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAimXTolerance.ValueChanged += new System.EventHandler(this.UpdateAimbotFovNoDrawing);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(87, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Y Tolerance";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "X Tolerance";
            // 
            // nudAimYOffset
            // 
            this.nudAimYOffset.Location = new System.Drawing.Point(90, 74);
            this.nudAimYOffset.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudAimYOffset.Name = "nudAimYOffset";
            this.nudAimYOffset.Size = new System.Drawing.Size(61, 20);
            this.nudAimYOffset.TabIndex = 7;
            this.nudAimYOffset.ValueChanged += new System.EventHandler(this.UpdateAimbotFovNoDrawing);
            // 
            // nudAimXOffset
            // 
            this.nudAimXOffset.Location = new System.Drawing.Point(9, 74);
            this.nudAimXOffset.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudAimXOffset.Name = "nudAimXOffset";
            this.nudAimXOffset.Size = new System.Drawing.Size(61, 20);
            this.nudAimXOffset.TabIndex = 6;
            this.nudAimXOffset.ValueChanged += new System.EventHandler(this.UpdateAimbotFovNoDrawing);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Y Offset";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "X Offset";
            // 
            // nudAimFovHeight
            // 
            this.nudAimFovHeight.Location = new System.Drawing.Point(90, 32);
            this.nudAimFovHeight.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudAimFovHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAimFovHeight.Name = "nudAimFovHeight";
            this.nudAimFovHeight.Size = new System.Drawing.Size(61, 20);
            this.nudAimFovHeight.TabIndex = 3;
            this.nudAimFovHeight.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudAimFovHeight.ValueChanged += new System.EventHandler(this.nudAimFovHeight_ValueChanged);
            // 
            // nudAimFovWidth
            // 
            this.nudAimFovWidth.Location = new System.Drawing.Point(9, 32);
            this.nudAimFovWidth.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudAimFovWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAimFovWidth.Name = "nudAimFovWidth";
            this.nudAimFovWidth.Size = new System.Drawing.Size(61, 20);
            this.nudAimFovWidth.TabIndex = 2;
            this.nudAimFovWidth.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudAimFovWidth.ValueChanged += new System.EventHandler(this.nudAimFovWidth_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "FOV Height";
            // 
            // lblAimFovWith
            // 
            this.lblAimFovWith.AutoSize = true;
            this.lblAimFovWith.Location = new System.Drawing.Point(6, 16);
            this.lblAimFovWith.Name = "lblAimFovWith";
            this.lblAimFovWith.Size = new System.Drawing.Size(59, 13);
            this.lblAimFovWith.TabIndex = 0;
            this.lblAimFovWith.Text = "FOV Width";
            // 
            // tpAna
            // 
            this.tpAna.Controls.Add(this.groupBox2);
            this.tpAna.Controls.Add(this.cbAnaMode);
            this.tpAna.Controls.Add(this.label5);
            this.tpAna.Controls.Add(this.label6);
            this.tpAna.Controls.Add(this.nudAnaKey);
            this.tpAna.Location = new System.Drawing.Point(4, 22);
            this.tpAna.Name = "tpAna";
            this.tpAna.Size = new System.Drawing.Size(299, 250);
            this.tpAna.TabIndex = 2;
            this.tpAna.Text = "Anabot";
            this.tpAna.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudAnaYTolerance);
            this.groupBox2.Controls.Add(this.nudAnaXTolerance);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.nudAnaYOffset);
            this.groupBox2.Controls.Add(this.nudAnaXOffset);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.nudAnaFovHeight);
            this.groupBox2.Controls.Add(this.nudAnaFovWidth);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Location = new System.Drawing.Point(6, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 160);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Field of View";
            // 
            // nudAnaYTolerance
            // 
            this.nudAnaYTolerance.Location = new System.Drawing.Point(90, 116);
            this.nudAnaYTolerance.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudAnaYTolerance.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAnaYTolerance.Name = "nudAnaYTolerance";
            this.nudAnaYTolerance.Size = new System.Drawing.Size(61, 20);
            this.nudAnaYTolerance.TabIndex = 11;
            this.nudAnaYTolerance.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAnaYTolerance.ValueChanged += new System.EventHandler(this.UpdateAnabotFovNoDrawing);
            // 
            // nudAnaXTolerance
            // 
            this.nudAnaXTolerance.Location = new System.Drawing.Point(9, 116);
            this.nudAnaXTolerance.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudAnaXTolerance.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAnaXTolerance.Name = "nudAnaXTolerance";
            this.nudAnaXTolerance.Size = new System.Drawing.Size(61, 20);
            this.nudAnaXTolerance.TabIndex = 10;
            this.nudAnaXTolerance.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAnaXTolerance.ValueChanged += new System.EventHandler(this.UpdateAnabotFovNoDrawing);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(87, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Y Tolerance";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 100);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "X Tolerance";
            // 
            // nudAnaYOffset
            // 
            this.nudAnaYOffset.Location = new System.Drawing.Point(90, 74);
            this.nudAnaYOffset.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudAnaYOffset.Name = "nudAnaYOffset";
            this.nudAnaYOffset.Size = new System.Drawing.Size(61, 20);
            this.nudAnaYOffset.TabIndex = 7;
            this.nudAnaYOffset.ValueChanged += new System.EventHandler(this.UpdateAnabotFovNoDrawing);
            // 
            // nudAnaXOffset
            // 
            this.nudAnaXOffset.Location = new System.Drawing.Point(9, 74);
            this.nudAnaXOffset.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudAnaXOffset.Name = "nudAnaXOffset";
            this.nudAnaXOffset.Size = new System.Drawing.Size(61, 20);
            this.nudAnaXOffset.TabIndex = 6;
            this.nudAnaXOffset.ValueChanged += new System.EventHandler(this.UpdateAnabotFovNoDrawing);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(87, 58);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 13);
            this.label17.TabIndex = 5;
            this.label17.Text = "Y Offset";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 58);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(45, 13);
            this.label18.TabIndex = 4;
            this.label18.Text = "X Offset";
            // 
            // nudAnaFovHeight
            // 
            this.nudAnaFovHeight.Location = new System.Drawing.Point(90, 32);
            this.nudAnaFovHeight.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudAnaFovHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAnaFovHeight.Name = "nudAnaFovHeight";
            this.nudAnaFovHeight.Size = new System.Drawing.Size(61, 20);
            this.nudAnaFovHeight.TabIndex = 3;
            this.nudAnaFovHeight.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudAnaFovHeight.ValueChanged += new System.EventHandler(this.nudAnaFovHeight_ValueChanged);
            // 
            // nudAnaFovWidth
            // 
            this.nudAnaFovWidth.Location = new System.Drawing.Point(9, 32);
            this.nudAnaFovWidth.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudAnaFovWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAnaFovWidth.Name = "nudAnaFovWidth";
            this.nudAnaFovWidth.Size = new System.Drawing.Size(61, 20);
            this.nudAnaFovWidth.TabIndex = 2;
            this.nudAnaFovWidth.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudAnaFovWidth.ValueChanged += new System.EventHandler(this.nudAnaFovWidth_ValueChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(87, 16);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(62, 13);
            this.label19.TabIndex = 1;
            this.label19.Text = "FOV Height";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 16);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(59, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "FOV Width";
            // 
            // tpTrigger
            // 
            this.tpTrigger.Controls.Add(this.groupBox5);
            this.tpTrigger.Controls.Add(this.groupBox4);
            this.tpTrigger.Controls.Add(this.cbTriggerMode);
            this.tpTrigger.Controls.Add(this.label15);
            this.tpTrigger.Controls.Add(this.label16);
            this.tpTrigger.Controls.Add(this.nudTriggerKey);
            this.tpTrigger.Location = new System.Drawing.Point(4, 22);
            this.tpTrigger.Name = "tpTrigger";
            this.tpTrigger.Size = new System.Drawing.Size(299, 250);
            this.tpTrigger.TabIndex = 3;
            this.tpTrigger.Text = "Triggerbot";
            this.tpTrigger.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(6, 126);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(278, 94);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Flick settings coming soon";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.nudTriggerFovHeight);
            this.groupBox4.Controls.Add(this.nudTriggerFovWidth);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.label26);
            this.groupBox4.Location = new System.Drawing.Point(6, 60);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(278, 63);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Field of View";
            // 
            // nudTriggerFovHeight
            // 
            this.nudTriggerFovHeight.Location = new System.Drawing.Point(90, 32);
            this.nudTriggerFovHeight.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudTriggerFovHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTriggerFovHeight.Name = "nudTriggerFovHeight";
            this.nudTriggerFovHeight.Size = new System.Drawing.Size(61, 20);
            this.nudTriggerFovHeight.TabIndex = 3;
            this.nudTriggerFovHeight.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudTriggerFovHeight.ValueChanged += new System.EventHandler(this.nudTriggerFovHeight_ValueChanged);
            // 
            // nudTriggerFovWidth
            // 
            this.nudTriggerFovWidth.Location = new System.Drawing.Point(9, 32);
            this.nudTriggerFovWidth.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudTriggerFovWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTriggerFovWidth.Name = "nudTriggerFovWidth";
            this.nudTriggerFovWidth.Size = new System.Drawing.Size(61, 20);
            this.nudTriggerFovWidth.TabIndex = 2;
            this.nudTriggerFovWidth.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudTriggerFovWidth.ValueChanged += new System.EventHandler(this.nudTriggerFovWidth_ValueChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(87, 16);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(62, 13);
            this.label25.TabIndex = 1;
            this.label25.Text = "FOV Height";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 16);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(59, 13);
            this.label26.TabIndex = 0;
            this.label26.Text = "FOV Width";
            // 
            // cbTriggerMode
            // 
            this.cbTriggerMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTriggerMode.FormattingEnabled = true;
            this.cbTriggerMode.Items.AddRange(new object[] {
            "Always on",
            "Toggle",
            "HoldDown"});
            this.cbTriggerMode.Location = new System.Drawing.Point(66, 34);
            this.cbTriggerMode.Name = "cbTriggerMode";
            this.cbTriggerMode.Size = new System.Drawing.Size(75, 21);
            this.cbTriggerMode.TabIndex = 17;
            this.cbTriggerMode.SelectedIndexChanged += new System.EventHandler(this.cbTriggerMode_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 8);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 13);
            this.label15.TabIndex = 18;
            this.label15.Text = "Aim Key";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 37);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 13);
            this.label16.TabIndex = 20;
            this.label16.Text = "Aim Mode";
            // 
            // nudTriggerKey
            // 
            this.nudTriggerKey.Location = new System.Drawing.Point(66, 6);
            this.nudTriggerKey.Maximum = new decimal(new int[] {
            254,
            0,
            0,
            0});
            this.nudTriggerKey.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTriggerKey.Name = "nudTriggerKey";
            this.nudTriggerKey.Size = new System.Drawing.Size(75, 20);
            this.nudTriggerKey.TabIndex = 19;
            this.nudTriggerKey.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTriggerKey.ValueChanged += new System.EventHandler(this.nudTriggerKey_ValueChanged);
            // 
            // tpWidow
            // 
            this.tpWidow.Controls.Add(this.groupBox1);
            this.tpWidow.Controls.Add(this.cbWidowMode);
            this.tpWidow.Controls.Add(this.label8);
            this.tpWidow.Controls.Add(this.label9);
            this.tpWidow.Controls.Add(this.nudWidowKey);
            this.tpWidow.Location = new System.Drawing.Point(4, 22);
            this.tpWidow.Name = "tpWidow";
            this.tpWidow.Size = new System.Drawing.Size(299, 250);
            this.tpWidow.TabIndex = 4;
            this.tpWidow.Text = "Widowbot";
            this.tpWidow.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudWidowYTolerance);
            this.groupBox1.Controls.Add(this.nudWidowXTolerance);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.nudWidowYOffset);
            this.groupBox1.Controls.Add(this.nudWidowXOffset);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.nudWidowFovHeight);
            this.groupBox1.Controls.Add(this.nudWidowFovWidth);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Location = new System.Drawing.Point(6, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 160);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Field of View";
            // 
            // nudWidowYTolerance
            // 
            this.nudWidowYTolerance.Location = new System.Drawing.Point(90, 116);
            this.nudWidowYTolerance.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudWidowYTolerance.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWidowYTolerance.Name = "nudWidowYTolerance";
            this.nudWidowYTolerance.Size = new System.Drawing.Size(61, 20);
            this.nudWidowYTolerance.TabIndex = 11;
            this.nudWidowYTolerance.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWidowYTolerance.ValueChanged += new System.EventHandler(this.UpdateWidowbotFovNoDrawing);
            // 
            // nudWidowXTolerance
            // 
            this.nudWidowXTolerance.Location = new System.Drawing.Point(9, 116);
            this.nudWidowXTolerance.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudWidowXTolerance.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWidowXTolerance.Name = "nudWidowXTolerance";
            this.nudWidowXTolerance.Size = new System.Drawing.Size(61, 20);
            this.nudWidowXTolerance.TabIndex = 10;
            this.nudWidowXTolerance.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWidowXTolerance.ValueChanged += new System.EventHandler(this.UpdateWidowbotFovNoDrawing);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(87, 100);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(65, 13);
            this.label21.TabIndex = 9;
            this.label21.Text = "Y Tolerance";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 100);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(65, 13);
            this.label22.TabIndex = 8;
            this.label22.Text = "X Tolerance";
            // 
            // nudWidowYOffset
            // 
            this.nudWidowYOffset.Location = new System.Drawing.Point(90, 74);
            this.nudWidowYOffset.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudWidowYOffset.Name = "nudWidowYOffset";
            this.nudWidowYOffset.Size = new System.Drawing.Size(61, 20);
            this.nudWidowYOffset.TabIndex = 7;
            this.nudWidowYOffset.ValueChanged += new System.EventHandler(this.UpdateWidowbotFovNoDrawing);
            // 
            // nudWidowXOffset
            // 
            this.nudWidowXOffset.Location = new System.Drawing.Point(9, 74);
            this.nudWidowXOffset.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudWidowXOffset.Name = "nudWidowXOffset";
            this.nudWidowXOffset.Size = new System.Drawing.Size(61, 20);
            this.nudWidowXOffset.TabIndex = 6;
            this.nudWidowXOffset.ValueChanged += new System.EventHandler(this.UpdateWidowbotFovNoDrawing);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(87, 58);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(45, 13);
            this.label23.TabIndex = 5;
            this.label23.Text = "Y Offset";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 58);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(45, 13);
            this.label24.TabIndex = 4;
            this.label24.Text = "X Offset";
            // 
            // nudWidowFovHeight
            // 
            this.nudWidowFovHeight.Location = new System.Drawing.Point(90, 32);
            this.nudWidowFovHeight.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudWidowFovHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWidowFovHeight.Name = "nudWidowFovHeight";
            this.nudWidowFovHeight.Size = new System.Drawing.Size(61, 20);
            this.nudWidowFovHeight.TabIndex = 3;
            this.nudWidowFovHeight.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudWidowFovHeight.ValueChanged += new System.EventHandler(this.nudWidowFovHeight_ValueChanged);
            // 
            // nudWidowFovWidth
            // 
            this.nudWidowFovWidth.Location = new System.Drawing.Point(9, 32);
            this.nudWidowFovWidth.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudWidowFovWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWidowFovWidth.Name = "nudWidowFovWidth";
            this.nudWidowFovWidth.Size = new System.Drawing.Size(61, 20);
            this.nudWidowFovWidth.TabIndex = 2;
            this.nudWidowFovWidth.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudWidowFovWidth.ValueChanged += new System.EventHandler(this.nudWidowFovWidth_ValueChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(87, 16);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(62, 13);
            this.label27.TabIndex = 1;
            this.label27.Text = "FOV Height";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(6, 16);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(59, 13);
            this.label28.TabIndex = 0;
            this.label28.Text = "FOV Width";
            // 
            // cbWidowMode
            // 
            this.cbWidowMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWidowMode.FormattingEnabled = true;
            this.cbWidowMode.Items.AddRange(new object[] {
            "Always on",
            "Toggle",
            "HoldDown"});
            this.cbWidowMode.Location = new System.Drawing.Point(66, 34);
            this.cbWidowMode.Name = "cbWidowMode";
            this.cbWidowMode.Size = new System.Drawing.Size(75, 21);
            this.cbWidowMode.TabIndex = 23;
            this.cbWidowMode.SelectedIndexChanged += new System.EventHandler(this.cbWidowMode_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Aim Key";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Aim Mode";
            // 
            // nudWidowKey
            // 
            this.nudWidowKey.Location = new System.Drawing.Point(66, 6);
            this.nudWidowKey.Maximum = new decimal(new int[] {
            254,
            0,
            0,
            0});
            this.nudWidowKey.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWidowKey.Name = "nudWidowKey";
            this.nudWidowKey.Size = new System.Drawing.Size(75, 20);
            this.nudWidowKey.TabIndex = 25;
            this.nudWidowKey.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWidowKey.ValueChanged += new System.EventHandler(this.nudWidowKey_ValueChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 346);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(331, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(70, 17);
            this.toolStripStatusLabel1.Text = "Version 0.4c";
            // 
            // tpGlobal
            // 
            this.tpGlobal.Controls.Add(this.label30);
            this.tpGlobal.Controls.Add(this.label29);
            this.tpGlobal.Controls.Add(this.nudAimSpeedY);
            this.tpGlobal.Controls.Add(this.nudAimSpeedX);
            this.tpGlobal.Controls.Add(this.cbAntiShake);
            this.tpGlobal.Location = new System.Drawing.Point(4, 22);
            this.tpGlobal.Name = "tpGlobal";
            this.tpGlobal.Padding = new System.Windows.Forms.Padding(3);
            this.tpGlobal.Size = new System.Drawing.Size(299, 250);
            this.tpGlobal.TabIndex = 5;
            this.tpGlobal.Text = "Global";
            this.tpGlobal.UseVisualStyleBackColor = true;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(6, 52);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(68, 13);
            this.label30.TabIndex = 24;
            this.label30.Text = "Aim Speed Y";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(6, 26);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(68, 13);
            this.label29.TabIndex = 23;
            this.label29.Text = "Aim Speed X";
            // 
            // nudAimSpeedY
            // 
            this.nudAimSpeedY.Location = new System.Drawing.Point(89, 50);
            this.nudAimSpeedY.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudAimSpeedY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAimSpeedY.Name = "nudAimSpeedY";
            this.nudAimSpeedY.Size = new System.Drawing.Size(64, 20);
            this.nudAimSpeedY.TabIndex = 22;
            this.nudAimSpeedY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudAimSpeedX
            // 
            this.nudAimSpeedX.Location = new System.Drawing.Point(89, 24);
            this.nudAimSpeedX.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudAimSpeedX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAimSpeedX.Name = "nudAimSpeedX";
            this.nudAimSpeedX.Size = new System.Drawing.Size(64, 20);
            this.nudAimSpeedX.TabIndex = 21;
            this.nudAimSpeedX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbAntiShake
            // 
            this.cbAntiShake.AutoSize = true;
            this.cbAntiShake.Location = new System.Drawing.Point(6, 6);
            this.cbAntiShake.Name = "cbAntiShake";
            this.cbAntiShake.Size = new System.Drawing.Size(73, 17);
            this.cbAntiShake.TabIndex = 20;
            this.cbAntiShake.Text = "Antishake";
            this.cbAntiShake.UseVisualStyleBackColor = true;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(93, 32);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(99, 13);
            this.label31.TabIndex = 15;
            this.label31.Text = "Screenshot method";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Default",
            "Windowed 1",
            "Windowed 2",
            "Fullscreen 1",
            "Fullscreen 2"});
            this.comboBox1.Location = new System.Drawing.Point(198, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 368);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tbMain);
            this.Controls.Add(this.btnLoadSettings);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.lblResolution);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.nudAimKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnaKey)).EndInit();
            this.tbMain.ResumeLayout(false);
            this.tgGeneral.ResumeLayout(false);
            this.tgGeneral.PerformLayout();
            this.gbDrawing.ResumeLayout(false);
            this.gbDrawing.PerformLayout();
            this.tpAim.ResumeLayout(false);
            this.tpAim.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAimYTolerance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAimXTolerance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAimYOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAimXOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAimFovHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAimFovWidth)).EndInit();
            this.tpAna.ResumeLayout(false);
            this.tpAna.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnaYTolerance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnaXTolerance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnaYOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnaXOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnaFovHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnaFovWidth)).EndInit();
            this.tpTrigger.ResumeLayout(false);
            this.tpTrigger.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTriggerFovHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTriggerFovWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTriggerKey)).EndInit();
            this.tpWidow.ResumeLayout(false);
            this.tpWidow.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidowYTolerance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidowXTolerance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidowYOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidowXOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidowFovHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidowFovWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidowKey)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tpGlobal.ResumeLayout(false);
            this.tpGlobal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAimSpeedY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAimSpeedX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudAimKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAimMode;
        private System.Windows.Forms.Label lblResolution;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Button btnLoadSettings;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudAnaKey;
        private System.Windows.Forms.ComboBox cbAnaMode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tbMain;
        private System.Windows.Forms.TabPage tgGeneral;
        private System.Windows.Forms.TabPage tpAim;
        private System.Windows.Forms.CheckBox cbTriggerEnable;
        private System.Windows.Forms.CheckBox cbAnaEnable;
        private System.Windows.Forms.CheckBox cbAimEnable;
        private System.Windows.Forms.TabPage tpAna;
        private System.Windows.Forms.TabPage tpTrigger;
        private System.Windows.Forms.CheckBox cbWidowEnable;
        private System.Windows.Forms.ComboBox cbMonitor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox gbDrawing;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbTriggerMode;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown nudTriggerKey;
        private System.Windows.Forms.TabPage tpWidow;
        private System.Windows.Forms.ComboBox cbWidowMode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudWidowKey;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private CheckBox cbDrawOver;
        private CheckBox cbWidowStatus;
        private CheckBox cbTriggerStatus;
        private CheckBox cbAnabotStatus;
        private CheckBox cbAimStatus;
        private CheckBox cbAimFov;
        private CheckBox cbWidowFov;
        private CheckBox cbTriggerFov;
        private CheckBox cbAnaFov;
        private Label label3;
        private Label lblAimFovWith;
        private NumericUpDown nudAimYOffset;
        private NumericUpDown nudAimXOffset;
        private Label label4;
        private Label label7;
        private NumericUpDown nudAimFovHeight;
        private NumericUpDown nudAimFovWidth;
        private NumericUpDown nudAimYTolerance;
        private NumericUpDown nudAimXTolerance;
        private Label label10;
        private Label label11;
        private GroupBox groupBox2;
        private NumericUpDown nudAnaYTolerance;
        private NumericUpDown nudAnaXTolerance;
        private Label label12;
        private Label label14;
        private NumericUpDown nudAnaYOffset;
        private NumericUpDown nudAnaXOffset;
        private Label label17;
        private Label label18;
        private NumericUpDown nudAnaFovHeight;
        private NumericUpDown nudAnaFovWidth;
        private Label label19;
        private Label label20;
        private GroupBox groupBox4;
        private NumericUpDown nudTriggerFovHeight;
        private NumericUpDown nudTriggerFovWidth;
        private Label label25;
        private Label label26;
        private GroupBox groupBox5;
        private GroupBox groupBox1;
        private NumericUpDown nudWidowYTolerance;
        private NumericUpDown nudWidowXTolerance;
        private Label label21;
        private Label label22;
        private NumericUpDown nudWidowYOffset;
        private NumericUpDown nudWidowXOffset;
        private Label label23;
        private Label label24;
        private NumericUpDown nudWidowFovHeight;
        private NumericUpDown nudWidowFovWidth;
        private Label label27;
        private Label label28;
        private TabPage tpGlobal;
        private Label label30;
        private Label label29;
        private NumericUpDown nudAimSpeedY;
        private NumericUpDown nudAimSpeedX;
        private CheckBox cbAntiShake;
        private ComboBox comboBox1;
        private Label label31;
    }
}

