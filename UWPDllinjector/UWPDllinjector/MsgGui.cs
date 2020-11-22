using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace UWPDllinjector
{
    public partial class MsgGui : Form
    {

        #region WinAPi Imports
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        #endregion

        private string msg;
        public MsgGui(string _msg)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 12, 12));
            msg = _msg;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MsgGui_Load(object sender, EventArgs e)
        {
            lblmsg.Text = msg;
            lblmsg.Left = (this.Width - lblmsg.Width) / 2;
        }

        private void TimerOpacity_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1.0f)
            {
                this.Opacity += 0.1f;
                if (this.Opacity >= 1.0f)
                {
                    TimerOpacity.Enabled = false;
                }
            }
        }

        private bool mouseDown;
        private Point lastLocation;

        private void MsgGui_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void MsgGui_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void MsgGui_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
