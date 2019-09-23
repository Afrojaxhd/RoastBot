using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Gma.System.MouseKeyHook;
using RoastBot.Helpers;
using RoastBot.Modules;
using RoastBot.Objects;

namespace RoastBot
{
    public partial class FrmMain : Form
    {
        private Aimbot aimbot;
        private Anabot anabot;
        private Triggerbot triggerbot;
        private Widowbot widowbot;

        private Point resolution;

        private FrmDrawing drawingForm;

        private IKeyboardMouseEvents m_Events;

        public FrmMain()
        {
            InitializeComponent();

            SettingsManager.LoadSettingsFromDefaultPath();

            aimbot = new Aimbot();
            anabot = new Anabot();
            triggerbot = new Triggerbot();
            widowbot = new Widowbot();

            GrabScreenResolution();

            UpdateUserInterface();
            RandomiseWindowTitle();

            m_Events = Hook.GlobalEvents();

            m_Events.KeyDown += OnKeyDown;
            m_Events.KeyUp += OnKeyUp;

            m_Events.MouseDown += OnMouseDown;
            m_Events.MouseUp += OnMouseUp;
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            var key = (int)e.KeyCode;
            CheckInput(key, true);
        }

        private void OnKeyUp(object sender, KeyEventArgs e)
        {
            var key = (int) e.KeyCode;
            CheckInput(key, false);
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            var key = MouseButtonToKeyCode(e.Button);
            CheckInput(key, true);
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            var key = MouseButtonToKeyCode(e.Button);
            CheckInput(key, false);
        }

        private int MouseButtonToKeyCode(MouseButtons button)
        {
            switch (button)
            {
                case MouseButtons.Left:
                    return 1;
                case MouseButtons.Right:
                    return 2;
                case MouseButtons.Middle:
                    return 3;
                case MouseButtons.XButton1:
                    return 5;
                case MouseButtons.XButton2:
                    return 6;
            }
            return -1;
        }

        private void CheckInput(int key, bool down)
        {
            if (key == SettingsManager.Aimbot.AimKey)
            {
                aimbot.HandleKeyPress(down);
                UpdateDrawingFrame();
            }
            if (key == SettingsManager.Anabot.AimKey)
            {
                anabot.HandleKeyPress(down);
                UpdateDrawingFrame();
            }
            if (key == SettingsManager.Triggerbot.AimKey)
            {
                triggerbot.HandleKeyPress(down);
                UpdateDrawingFrame();
            }
            if (key == SettingsManager.Widowbot.AimKey)
            {
                widowbot.HandleKeyPress(down);
                UpdateDrawingFrame();
            }
        }

        private void RandomiseWindowTitle()
        {
            var stringBuilder = new StringBuilder();
            var random = new Random();
            for (var i = 0; i < 20; i++)
            {
                stringBuilder.Append((char) random.Next(0, 1000));
            }
            Text = stringBuilder.ToString();
            drawingForm?.SetTitle(stringBuilder.ToString());
        }

        private void UpdateUserInterface()
        {
            PopulateMonitorComboBox();
            UpdateModuleControls();
            UpdateFovControls();
        }

        private void GrabScreenResolution()
        {
            var screen = Screen.AllScreens[SettingsManager.General.GameMonitor];
            resolution = new Point(screen.Bounds.Width, screen.Bounds.Height);

            lblResolution.Text = $@"Resolution: {resolution.X} x {resolution.Y}";

            aimbot.resolution = resolution;
            anabot.resolution = resolution;
            triggerbot.resolution = resolution;
            widowbot.resolution = resolution;
        }

        private void PopulateMonitorComboBox()
        {
            cbMonitor.Items.Clear();
            for (var i = 0; i < Screen.AllScreens.Length; i++)
            {
                cbMonitor.Items.Add(i+1);
            }
            cbMonitor.SelectedIndex = SettingsManager.General.GameMonitor;
        }

        private void UpdateModuleControls()
        {
            cbAimEnable.Checked = SettingsManager.Aimbot.IsEnabled;
            cbAnaEnable.Checked = SettingsManager.Anabot.IsEnabled;
            cbTriggerEnable.Checked = SettingsManager.Triggerbot.IsEnabled;
            cbWidowEnable.Checked = SettingsManager.Widowbot.IsEnabled;

            cbAntiShake.Checked = SettingsManager.General.AntiShake;

            nudAimSpeedX.Value = SettingsManager.General.AimSpeedX;
            nudAimSpeedY.Value = SettingsManager.General.AimSpeedY;

            nudAimKey.Value = SettingsManager.Aimbot.AimKey;
            cbAimMode.SelectedIndex = (int)SettingsManager.Aimbot.AimMode;

            nudAnaKey.Value = SettingsManager.Anabot.AimKey;
            cbAnaMode.SelectedIndex = (int)SettingsManager.Anabot.AimMode;

            nudTriggerKey.Value = SettingsManager.Triggerbot.AimKey;
            cbTriggerMode.SelectedIndex = (int)SettingsManager.Triggerbot.AimMode;

            nudWidowKey.Value = SettingsManager.Widowbot.AimKey;
            cbWidowMode.SelectedIndex = (int)SettingsManager.Widowbot.AimMode;

            cbDrawOver.Checked = SettingsManager.General.DrawOverlay;

            cbAimStatus.Checked = SettingsManager.Aimbot.DrawStatus;
            cbAimFov.Checked = SettingsManager.Aimbot.DrawFov;

            cbAnabotStatus.Checked = SettingsManager.Anabot.DrawStatus;
            cbAnaFov.Checked = SettingsManager.Anabot.DrawFov;

            cbTriggerStatus.Checked = SettingsManager.Triggerbot.DrawOverlay;
            cbTriggerFov.Checked = SettingsManager.Triggerbot.DrawFov;

            cbWidowStatus.Checked = SettingsManager.Widowbot.DrawOverlay;
            cbWidowFov.Checked = SettingsManager.Widowbot.DrawFov;
        }

        private void UpdateFovControls()
        {
            var aimSettings = SettingsManager.Aimbot.FieldOfView;

            nudAimFovWidth.Maximum = resolution.X;
            nudAimFovWidth.Value = aimSettings.FieldOfView.Width;

            nudAimFovHeight.Maximum = resolution.Y;
            nudAimFovHeight.Value = aimSettings.FieldOfView.Height;

            nudAimXOffset.Value = aimSettings.Offset.X;
            nudAimYOffset.Value = aimSettings.Offset.Y;
            nudAimXTolerance.Value = aimSettings.Tolerance.X;
            nudAimYTolerance.Value = aimSettings.Tolerance.Y;

            var anaSettings = SettingsManager.Anabot.FieldOfView;

            nudAnaFovWidth.Maximum = resolution.X;
            nudAnaFovWidth.Value = anaSettings.FieldOfView.Width;

            nudAnaFovHeight.Maximum = resolution.Y;
            nudAnaFovHeight.Value = anaSettings.FieldOfView.Height;

            nudAnaXOffset.Value = aimSettings.Offset.X;
            nudAnaYOffset.Value = anaSettings.Offset.Y;
            nudAnaXTolerance.Value = anaSettings.Tolerance.X;
            nudAnaYTolerance.Value = anaSettings.Tolerance.Y;

            var triggerSettings = SettingsManager.Triggerbot.FieldOfView;

            nudTriggerFovWidth.Maximum = resolution.X;
            nudTriggerFovWidth.Value = triggerSettings.FieldOfView.Width;

            nudTriggerFovHeight.Maximum = resolution.Y;
            nudTriggerFovHeight.Value = triggerSettings.FieldOfView.Height;

            var widowSettings = SettingsManager.Widowbot.FieldOfView;

            nudWidowFovWidth.Maximum = resolution.X;
            nudWidowFovWidth.Value = widowSettings.FieldOfView.Width;

            nudWidowFovHeight.Maximum = resolution.Y;
            nudWidowFovHeight.Value = widowSettings.FieldOfView.Height;

            nudWidowXOffset.Value = aimSettings.Offset.X;
            nudWidowYOffset.Value = widowSettings.Offset.Y;
            nudWidowXTolerance.Value = widowSettings.Tolerance.X;
            nudWidowYTolerance.Value = widowSettings.Tolerance.Y;
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            SettingsManager.SaveSettingsToFile();
        }

        private void btnLoadSettings_Click(object sender, EventArgs e)
        {
            SettingsManager.LoadSettingsFromDefaultPath();
            UpdateModuleControls();
            UpdateFovControls();
        }

        private void cbAimEnable_CheckedChanged(object sender, EventArgs e)
        {
            ToggleThread(aimbot, cbAimEnable.Checked);

            SettingsManager.Aimbot.IsEnabled = cbAimEnable.Checked;

            UpdateDrawingFrame();
        }

        private void cbAnaEnable_CheckedChanged(object sender, EventArgs e)
        {
            ToggleThread(anabot, cbAnaEnable.Checked);

            SettingsManager.Anabot.IsEnabled = cbAnaEnable.Checked;

            UpdateDrawingFrame();
        }

        private void cbTriggerEnable_CheckedChanged(object sender, EventArgs e)
        {
            ToggleThread(triggerbot, cbTriggerEnable.Checked);

            SettingsManager.Triggerbot.IsEnabled = cbTriggerEnable.Checked;

            UpdateDrawingFrame();
        }

        private void cbWidowEnable_CheckedChanged(object sender, EventArgs e)
        {
            ToggleThread(widowbot, cbWidowEnable.Checked);

            SettingsManager.Widowbot.IsEnabled = cbWidowEnable.Checked;

            UpdateDrawingFrame();
        }

        private static void ToggleThread(IModule module, bool enabled)
        {
            if (!enabled)
                module.StopThread();
            else
                module.StartThread();
        }

        private void nudAimKey_ValueChanged(object sender, EventArgs e)
        {
            SettingsManager.Aimbot.AimKey = (byte)nudAimKey.Value;
        }

        private void cbAimMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            SettingsManager.Aimbot.AimMode = (AimMode) cbAimMode.SelectedIndex;
            UpdateDrawingFrame();
        }

        private void nudAnaKey_ValueChanged(object sender, EventArgs e)
        {
            SettingsManager.Anabot.AimKey = (byte) nudAnaKey.Value;
        }

        private void cbAnaMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            SettingsManager.Anabot.AimMode = (AimMode) cbAnaMode.SelectedIndex;
            UpdateDrawingFrame();
        }

        private void nudTriggerKey_ValueChanged(object sender, EventArgs e)
        {
            SettingsManager.Triggerbot.AimKey = (byte) nudTriggerKey.Value;
        }

        private void cbTriggerMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            SettingsManager.Triggerbot.AimMode = (AimMode) cbTriggerMode.SelectedIndex;
            UpdateDrawingFrame();
        }

        private void nudWidowKey_ValueChanged(object sender, EventArgs e)
        {
            SettingsManager.Widowbot.AimKey = (byte) nudWidowKey.Value;
        }

        private void cbWidowMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            SettingsManager.Widowbot.AimMode = (AimMode) cbWidowMode.SelectedIndex;
            UpdateDrawingFrame();
        }

        private void cbMonitor_SelectedIndexChanged(object sender, EventArgs e)
        {
            SettingsManager.General.GameMonitor = cbMonitor.SelectedIndex;
            aimbot = new Aimbot();
            anabot = new Anabot();
            triggerbot = new Triggerbot();
            widowbot = new Widowbot();
            GrabScreenResolution();
        }

        private void frmMain_FormClosing(object sender, EventArgs e)
        {
            aimbot.StopThread();
            anabot.StopThread();
            triggerbot.StopThread();
            widowbot.StopThread();
            drawingForm?.Close();
        }

        private void cbDrawOver_CheckedChanged(object sender, EventArgs e)
        {
            SettingsManager.General.DrawOverlay = cbDrawOver.Checked;
            var isDrawingOverlay = SettingsManager.General.DrawOverlay;
            if (!isDrawingOverlay)
            {
                drawingForm?.Dispose();
                drawingForm?.Close();
            }
            else
            {
                drawingForm = new FrmDrawing { Text = Text };
            }
            cbAimStatus.Enabled = isDrawingOverlay;
            cbAimFov.Enabled = isDrawingOverlay;
            cbAnabotStatus.Enabled = isDrawingOverlay;
            cbAnaFov.Enabled = isDrawingOverlay;
            cbTriggerStatus.Enabled = isDrawingOverlay;
            cbTriggerFov.Enabled = isDrawingOverlay;
            cbWidowStatus.Enabled = isDrawingOverlay;
            cbWidowFov.Enabled = isDrawingOverlay;

            drawingForm.aimRect = aimbot.MyFov.FieldOfView;
            drawingForm.anaRect = anabot.MyFov.FieldOfView;
            drawingForm.triggerRect = triggerbot.MyFov.FieldOfView;
            drawingForm.widowRect = widowbot.MyFov.FieldOfView;
        }

        private void cbDrawAim_CheckedChanged(object sender, EventArgs e)
        {
            SettingsManager.Aimbot.DrawStatus = cbAimStatus.Checked;
            UpdateDrawingFrame();
        }

        private void cbDrawAna_CheckedChanged(object sender, EventArgs e)
        {
            SettingsManager.Anabot.DrawStatus = cbAnabotStatus.Checked;
            UpdateDrawingFrame();
        }

        private void cbDrawTrigger_CheckedChanged(object sender, EventArgs e)
        {
            SettingsManager.Triggerbot.DrawOverlay = cbTriggerStatus.Checked;
            UpdateDrawingFrame();
        }

        private void cbDrawWidow_CheckedChanged(object sender, EventArgs e)
        {
            SettingsManager.Widowbot.DrawOverlay = cbWidowStatus.Checked;
            UpdateDrawingFrame();
        }

        private void cbAimFov_CheckedChanged(object sender, EventArgs e)
        {
            SettingsManager.Aimbot.DrawFov = cbAimFov.Checked;
            UpdateDrawingFrame();
        }

        private void cbAnaFov_CheckedChanged(object sender, EventArgs e)
        {
            SettingsManager.Anabot.DrawFov = cbAnaFov.Checked;
            UpdateDrawingFrame();
        }

        private void cbTriggerFov_CheckedChanged(object sender, EventArgs e)
        {
            SettingsManager.Triggerbot.DrawFov = cbTriggerFov.Checked;
            UpdateDrawingFrame();
        }

        private void cbWidowFov_CheckedChanged(object sender, EventArgs e)
        {
            SettingsManager.Widowbot.DrawFov = cbWidowFov.Checked;
            UpdateDrawingFrame();
        }

        private void nudAimFovWidth_ValueChanged(object sender, EventArgs e)
        {
            RecreateAimbotFov(true);
        }

        private void nudAimFovHeight_ValueChanged(object sender, EventArgs e)
        {
            RecreateAimbotFov(true);
        }

        private void UpdateAimbotFovNoDrawing(object sender, EventArgs e)
        {
            RecreateAimbotFov(false);
        }

        private void UpdateAnabotFovNoDrawing(object sender, EventArgs e)
        {
            RecreateAnabotFov(false);
        }

        private void nudAnaFovWidth_ValueChanged(object sender, EventArgs e)
        {
            RecreateAnabotFov(true);
        }

        private void nudAnaFovHeight_ValueChanged(object sender, EventArgs e)
        {
            RecreateAnabotFov(true);
        }

        private void nudTriggerFovHeight_ValueChanged(object sender, EventArgs e)
        {
            RecreateTriggerbotFov(true);
        }

        private void nudTriggerFovWidth_ValueChanged(object sender, EventArgs e)
        {
            RecreateTriggerbotFov(true);
        }
        private void UpdateWidowbotFovNoDrawing(object sender, EventArgs e)
        {
            RecreateWidowbotFov(true);
        }

        public void UpdateDrawingFrame()
        {
            drawingForm?.Invalidate();
        }

        private void RecreateAimbotFov(bool updateDrawing)
        {
            var width = (int)nudAimFovWidth.Value;
            var height = (int)nudAimFovHeight.Value;

            var view = new Rectangle(resolution.X / 2 - width / 2,
                resolution.Y / 2 - height / 2,
                width,
                height);

            var offset = new Point((int)nudAimXOffset.Value, (int)nudAimYOffset.Value);

            var tolerance = new Point((int)nudAimXTolerance.Value, (int)nudAimYTolerance.Value);

            var fov = new Fov {FieldOfView = view, Offset = offset, Tolerance = tolerance};

            aimbot.AssignFov(fov);

            SettingsManager.Aimbot.FieldOfView = fov;

            if (updateDrawing && drawingForm != null)
            {
                drawingForm.aimRect = view;
                UpdateDrawingFrame();
            }
        }

        private void RecreateAnabotFov(bool updateDrawing)
        {
            var width = (int)nudAnaFovWidth.Value;
            var height = (int)nudAnaFovHeight.Value;

            var view = new Rectangle(resolution.X / 2 - width / 2,
                resolution.Y / 2 - height / 2,
                width,
                height);

            var offset = new Point((int)nudAnaXOffset.Value, (int)nudAnaYOffset.Value);

            var tolerance = new Point((int)nudAnaXTolerance.Value, (int)nudAnaYTolerance.Value);

            var fov = new Fov { FieldOfView = view, Offset = offset, Tolerance = tolerance };

            anabot.AssignFov(fov);

            SettingsManager.Anabot.FieldOfView = fov;

            if (updateDrawing && drawingForm != null)
            {
                drawingForm.anaRect = view;
                UpdateDrawingFrame();
            }
        }

        private void RecreateTriggerbotFov(bool updateDrawing)
        {
            var width = (int)nudTriggerFovWidth.Value;
            var height = (int)nudTriggerFovHeight.Value;

            var view = new Rectangle(resolution.X / 2 - width / 2,
                resolution.Y / 2 - height / 2,
                width,
                height);

            var fov = new Fov { FieldOfView = view };

            triggerbot.AssignFov(fov);

            SettingsManager.Triggerbot.FieldOfView = fov;

            if (updateDrawing && drawingForm != null)
            {
                drawingForm.triggerRect = view;
                UpdateDrawingFrame();
            }
        }

        private void RecreateWidowbotFov(bool updateDrawing)
        {
            var width = (int)nudWidowFovWidth.Value;
            var height = (int)nudWidowFovHeight.Value;

            var view = new Rectangle(resolution.X / 2 - width / 2,
                resolution.Y / 2 - height / 2,
                width,
                height);

            var offset = new Point((int)nudWidowXOffset.Value, (int)nudWidowYOffset.Value);

            var tolerance = new Point((int)nudWidowXTolerance.Value, (int)nudWidowYTolerance.Value);

            var fov = new Fov { FieldOfView = view, Offset = offset, Tolerance = tolerance };

            widowbot.AssignFov(fov);

            SettingsManager.Widowbot.FieldOfView = fov;

            if (updateDrawing && drawingForm != null)
            {
                drawingForm.widowRect = view;
                UpdateDrawingFrame();
            }
        }

        private void cbAntiShake_CheckedChanged(object sender, EventArgs e)
        {
            SettingsManager.General.AntiShake = cbAntiShake.Checked;
        }

        private void nudAimSpeedX_ValueChanged(object sender, EventArgs e)
        {
            SettingsManager.General.AimSpeedX = (int)nudAimSpeedX.Value;
        }

        private void nudAimSpeedY_ValueChanged(object sender, EventArgs e)
        {
            SettingsManager.General.AimSpeedY = (int)nudAimSpeedY.Value;
        }

        private void nudWidowFovWidth_ValueChanged(object sender, EventArgs e)
        {
            RecreateWidowbotFov(true);
        }

        private void nudWidowFovHeight_ValueChanged(object sender, EventArgs e)
        {
            RecreateWidowbotFov(true);
        }
    }
}
