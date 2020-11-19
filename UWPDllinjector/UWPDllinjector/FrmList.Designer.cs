namespace UWPDllinjector
{
    partial class FrmList
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
            this.lblListTitle = new System.Windows.Forms.Label();
            this.pnlListTitle = new System.Windows.Forms.Panel();
            this.listProcess = new System.Windows.Forms.ListBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.TimerOpacityFrmList = new System.Windows.Forms.Timer(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlListTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblListTitle
            // 
            this.lblListTitle.AutoSize = true;
            this.lblListTitle.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListTitle.ForeColor = System.Drawing.Color.Silver;
            this.lblListTitle.Location = new System.Drawing.Point(22, 8);
            this.lblListTitle.Name = "lblListTitle";
            this.lblListTitle.Size = new System.Drawing.Size(182, 15);
            this.lblListTitle.TabIndex = 0;
            this.lblListTitle.Text = "List Of Running Processes";
            this.lblListTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlListTitle_MouseDown);
            this.lblListTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlListTitle_MouseMove);
            this.lblListTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlListTitle_MouseUp);
            // 
            // pnlListTitle
            // 
            this.pnlListTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlListTitle.Controls.Add(this.lblListTitle);
            this.pnlListTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlListTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlListTitle.Name = "pnlListTitle";
            this.pnlListTitle.Size = new System.Drawing.Size(227, 31);
            this.pnlListTitle.TabIndex = 1;
            this.pnlListTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlListTitle_MouseDown);
            this.pnlListTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlListTitle_MouseMove);
            this.pnlListTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlListTitle_MouseUp);
            // 
            // listProcess
            // 
            this.listProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.listProcess.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listProcess.ForeColor = System.Drawing.Color.Silver;
            this.listProcess.FormattingEnabled = true;
            this.listProcess.Location = new System.Drawing.Point(6, 34);
            this.listProcess.Name = "listProcess";
            this.listProcess.Size = new System.Drawing.Size(215, 195);
            this.listProcess.TabIndex = 2;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnOK.FlatAppearance.BorderSize = 2;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.Silver;
            this.btnOK.Location = new System.Drawing.Point(32, 232);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(78, 27);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // TimerOpacityFrmList
            // 
            this.TimerOpacityFrmList.Enabled = true;
            this.TimerOpacityFrmList.Interval = 20;
            this.TimerOpacityFrmList.Tick += new System.EventHandler(this.TimerOpacityFrmList_Tick);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCancel.FlatAppearance.BorderSize = 2;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Silver;
            this.btnCancel.Location = new System.Drawing.Point(116, 232);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 27);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(227, 262);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.listProcess);
            this.Controls.Add(this.pnlListTitle);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmList";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmList_Load);
            this.pnlListTitle.ResumeLayout(false);
            this.pnlListTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblListTitle;
        private System.Windows.Forms.Panel pnlListTitle;
        private System.Windows.Forms.ListBox listProcess;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Timer TimerOpacityFrmList;
        private System.Windows.Forms.Button btnCancel;
    }
}