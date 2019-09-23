using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using RoastBot.Helpers;
using RoastBot.Modules;

namespace RoastBot
{
    internal partial class FrmDrawing : Form
    {
        private Pen pen;
        private SolidBrush enabledBrush;
        private SolidBrush disabledBrush;
        private Font uiFont;

        public Rectangle aimRect;
        public Rectangle anaRect;
        public Rectangle triggerRect;
        public Rectangle widowRect;

        public FrmDrawing()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.None; // no borders

            var screen = Screen.AllScreens[SettingsManager.General.GameMonitor];
            Size = new Size(screen.Bounds.Width, screen.Bounds.Height);

            Location = new Point(0, 0);

            TransparencyKey = BackColor = Color.Teal;

            pen = new Pen(Color.Aqua);
            enabledBrush = new SolidBrush(Color.LimeGreen);
            disabledBrush = new SolidBrush(Color.Red);
            uiFont = new Font("Arial", 16);

            TopMost = true;
            Visible = true;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x80000 /* WS_EX_LAYERED */ | 0x20 /* WS_EX_TRANSPARENT */ | 0x80 /* WS_EX_TOOLWINDOW */;
                return cp;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.Clear(Color.Teal);
            var x = 10;
            var y = 50;

            if (!SettingsManager.General.DrawOverlay) return;

            if(SettingsManager.Aimbot.DrawStatus)
                y = DrawAimbotGui(x, y, e);

            if(SettingsManager.Anabot.DrawStatus)
                y = DrawAnabotGui(x, y, e);

            if(SettingsManager.Triggerbot.DrawOverlay)
                y = DrawTriggerBotGui(x, y, e);

            if(SettingsManager.Widowbot.DrawOverlay)
                y = DrawWidowBotGui(x, y, e);

            DrawFieldsOfView(e);
        }

        private int DrawAimbotGui(int x, int y, PaintEventArgs e)
        {
            var aimSettings = SettingsManager.Aimbot;
            var postDrawY = y;
            e.Graphics.DrawString($"Aimbot Enabled: {aimSettings.IsEnabled}", uiFont, GetBrush(aimSettings.IsEnabled), x, postDrawY);
            postDrawY += 20;
            e.Graphics.DrawString($"Aim Mode: {aimSettings.AimMode}", uiFont, GetBrush(aimSettings.IsEnabled), x, postDrawY);
            postDrawY += 20;
            e.Graphics.DrawString($"Is Toggled: {aimSettings.IsToggled}", uiFont, GetBrush(new []{aimSettings.IsEnabled, aimSettings.IsToggled}), x, postDrawY);
            postDrawY += 40;
            return postDrawY;
        }

        private int DrawAnabotGui(int x, int y, PaintEventArgs e)
        {
            var anaSettings = SettingsManager.Anabot;
            var postDrawY = y;
            e.Graphics.DrawString($"Anabot Enabled: {anaSettings.IsEnabled}", uiFont, GetBrush(anaSettings.IsEnabled), x, postDrawY);
            postDrawY += 20;
            e.Graphics.DrawString($"Aim Mode: {anaSettings.AimMode}", uiFont, GetBrush(anaSettings.IsEnabled), x, postDrawY);
            postDrawY += 20;
            e.Graphics.DrawString($"Is Toggled: {anaSettings.IsToggled}", uiFont, GetBrush(new[] { anaSettings.IsEnabled, anaSettings.IsToggled }), x, postDrawY);
            postDrawY += 40;
            return postDrawY;
        }

        private int DrawTriggerBotGui(int x, int y, PaintEventArgs e)
        {
            var triggerSettings = SettingsManager.Triggerbot;
            var postDrawY = y;
            e.Graphics.DrawString($"Triggerbot Enabled: {triggerSettings.IsEnabled}", uiFont, GetBrush(triggerSettings.IsEnabled), x, postDrawY);
            postDrawY += 20;
            e.Graphics.DrawString($"Aim Mode: {triggerSettings.AimMode}", uiFont, GetBrush(triggerSettings.IsEnabled), x, postDrawY);
            postDrawY += 20;
            e.Graphics.DrawString($"Is Toggled: {triggerSettings.IsToggled}", uiFont, GetBrush(new[] { triggerSettings.IsEnabled, triggerSettings.IsToggled }), x, postDrawY);
            postDrawY += 40;
            return postDrawY;
        }

        private int DrawWidowBotGui(int x, int y, PaintEventArgs e)
        {
            var widowSettings = SettingsManager.Widowbot;
            var postDrawY = y;
            e.Graphics.DrawString($"Widowbot Enabled: {widowSettings.IsEnabled}", uiFont, GetBrush(widowSettings.IsEnabled), x, postDrawY);
            postDrawY += 20;
            e.Graphics.DrawString($"Aim Mode: {widowSettings.AimMode}", uiFont, GetBrush(widowSettings.IsEnabled), x, postDrawY);
            postDrawY += 20;
            e.Graphics.DrawString($"Is Toggled: {widowSettings.IsToggled}", uiFont, GetBrush(new[] { widowSettings.IsEnabled, widowSettings.IsToggled }), x, postDrawY);
            postDrawY += 40;
            return postDrawY;
        }

        private void DrawFieldsOfView(PaintEventArgs e)
        {
            if (SettingsManager.Aimbot.DrawFov)
            {
                e.Graphics.DrawRectangle(pen, aimRect);
                //e.Graphics.DrawString($"{aimRect.Width}W, {aimRect.Height}H", uiFont, enabledBrush, aimRect.X, aimRect.Height + aimRect.Y);
                //e.Graphics.DrawString($"X: {aimRect.X}, Y: {aimRect.Y}", uiFont, enabledBrush, aimRect.X, aimRect.Height + aimRect.Y + 20);
            }

            if (SettingsManager.Anabot.DrawFov)
            {
                e.Graphics.DrawRectangle(pen, anaRect);
                //e.Graphics.DrawString($"{anaRect.Width}W, {anaRect.Height}H", uiFont, enabledBrush, anaRect.X, anaRect.Height + anaRect.Y);
                //e.Graphics.DrawString($"X: {anaRect.X}, Y: {anaRect.Y}", uiFont, enabledBrush, anaRect.X, anaRect.Height + anaRect.Y + 20);
            }

            if (SettingsManager.Triggerbot.DrawFov)
            {
                e.Graphics.DrawRectangle(pen, triggerRect);
                //e.Graphics.DrawString($"{triggerRect.Width}W, {triggerRect.Height}H", uiFont, enabledBrush, triggerRect.X, triggerRect.Height + triggerRect.Y);
                //e.Graphics.DrawString($"X: {triggerRect.X}, Y: {triggerRect.Y}", uiFont, enabledBrush, triggerRect.X, triggerRect.Height + triggerRect.Y + 20);
            }

            if (SettingsManager.Widowbot.DrawFov)
            {
                e.Graphics.DrawRectangle(pen, widowRect);
                //e.Graphics.DrawString($"{widowRect.Width}W, {widowRect.Height}H", uiFont, enabledBrush, widowRect.X, widowRect.Height + widowRect.Y);
                //e.Graphics.DrawString($"X: {widowRect.X}, Y: {widowRect.Y}", uiFont, enabledBrush, widowRect.X, widowRect.Height + widowRect.Y + 20);
            }
        }

        public void SetTitle(string title)
        {
            Text = title;
        }

        private SolidBrush GetBrush(bool condition)
        {
            return condition ? enabledBrush : disabledBrush;
        }

        private SolidBrush GetBrush(IEnumerable<bool> conditions)
        {
            // ReSharper disable once RedundantBoolCompare
            return conditions.All(x => x == true) ? enabledBrush : disabledBrush;
        }
    }
}