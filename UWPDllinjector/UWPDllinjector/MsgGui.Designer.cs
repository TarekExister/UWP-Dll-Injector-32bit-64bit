namespace UWPDllinjector
{
    partial class MsgGui
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
            this.components = new System.ComponentModel.Container();
            this.lblmsg = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.TimerOpacity = new System.Windows.Forms.Timer(this.components);
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.ForeColor = System.Drawing.Color.Silver;
            this.lblmsg.Location = new System.Drawing.Point(38, 17);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(0, 15);
            this.lblmsg.TabIndex = 5;
            this.lblmsg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MsgGui_MouseDown);
            this.lblmsg.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MsgGui_MouseMove);
            this.lblmsg.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MsgGui_MouseUp);
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlBottom.Controls.Add(this.btnOK);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 44);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(202, 41);
            this.pnlBottom.TabIndex = 4;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnOK.FlatAppearance.BorderSize = 2;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.Silver;
            this.btnOK.Location = new System.Drawing.Point(62, 7);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(78, 27);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // TimerOpacity
            // 
            this.TimerOpacity.Enabled = true;
            this.TimerOpacity.Interval = 20;
            this.TimerOpacity.Tick += new System.EventHandler(this.TimerOpacity_Tick);
            // 
            // MsgGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(202, 85);
            this.ControlBox = false;
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.pnlBottom);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MsgGui";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MsgGui_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MsgGui_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MsgGui_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MsgGui_MouseUp);
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Timer TimerOpacity;
    }
}