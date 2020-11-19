using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace UWPDllinjector
{
    public partial class FrmList : Form
    {

        #region WinAPi Imports
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        #endregion
        MainForm _MainForm;
        public FrmList(MainForm frm)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 12, 12));
            _MainForm = frm;
        }

        private void FrmList_Load(object sender, EventArgs e)
        {
            Process[] ProcessList = Process.GetProcesses();
            foreach (Process _this_process in ProcessList)
            {
                listProcess.Items.Add(_this_process.ProcessName);
            }
        }

        private void TimerOpacityFrmList_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1.0f)
            {
                this.Opacity += 0.1f;
                if (this.Opacity >= 1.0f)
                {
                    TimerOpacityFrmList.Enabled = false;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool mouseDown;
        private Point lastLocation;

        private void pnlListTitle_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void pnlListTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void pnlListTitle_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (listProcess.GetItemText(listProcess.SelectedItem) != string.Empty) 
            {
                _MainForm.txtProcessName.Text = listProcess.GetItemText(listProcess.SelectedItem);
                this.Close();
            }
        }
    }
}
