using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace UWPDllinjector
{
    public partial class MainForm : Form
    {

        #region WinAPi Imports
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        #endregion

        public MainForm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 12, 12));
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

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void pnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void pnlTop_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void btnDllPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Dll Files(.dll)| *.dll";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtDllPath.Text = ofd.FileName;
            }
        }

        private void TimerState_Tick(object sender, EventArgs e)
        {
            int pid = ProcessInfo.GetProcessID(txtProcessName.Text);
            if (pid == 0) lblPid.Text = "Process ID: " + " 0x0";
            else lblPid.Text = "Process ID: " + " 0x" + pid.ToString("X");
            if (pid != 0) lblState.Text = "Process State: Found";
            else lblState.Text = "Process State: Not Found";
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnInject_Click(object sender, EventArgs e)
        {
            int pid = ProcessInfo.GetProcessID(txtProcessName.Text);
            string dllPath = txtDllPath.Text;
            if (pid != 0)
            {
                if (dllPath != string.Empty)
                {
                    DllPermission.SetDllPermission(dllPath);
                    InjectDll.Injectlibrary(pid, dllPath);
                    MessageBox.Show("Dll Injected successfully");
                }
                else MessageBox.Show("Incorrect DllPath");
            }
            else MessageBox.Show("Process Not Found");
        }

        private void btnSelect_MouseEnter(object sender, EventArgs e)
        {
            (sender as Button).ForeColor = Color.FromArgb(30, 30, 30);
            (sender as Button).BackColor = Color.FromArgb(70, 70, 70);
        }

        private void btnSelect_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).ForeColor = Color.Silver;
            (sender as Button).BackColor = Color.FromArgb(40, 40, 40);
        }

        private void btnInject_MouseEnter(object sender, EventArgs e)
        {
            btnInject.BackColor = Color.FromArgb(40, 40, 40);
        }

        private void btnInject_MouseLeave(object sender, EventArgs e)
        {
            btnInject.BackColor = Color.FromArgb(70, 70, 70);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            FrmList frmList = new FrmList(this);
            frmList.ShowDialog();
        }
    }

}
