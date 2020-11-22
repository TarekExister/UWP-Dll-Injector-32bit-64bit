namespace UWPDllinjector
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblPid = new System.Windows.Forms.Label();
            this.btnInject = new System.Windows.Forms.Button();
            this.TimerOpacity = new System.Windows.Forms.Timer(this.components);
            this.btnDllPath = new System.Windows.Forms.Button();
            this.txtDllPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProcessName = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.TimerState = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlTop.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlTop.Controls.Add(this.pictureBox1);
            this.pnlTop.Controls.Add(this.lblMinimize);
            this.pnlTop.Controls.Add(this.lblClose);
            this.pnlTop.Controls.Add(this.label2);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(412, 78);
            this.pnlTop.TabIndex = 0;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            this.pnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseMove);
            this.pnlTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseUp);
            // 
            // lblMinimize
            // 
            this.lblMinimize.AutoSize = true;
            this.lblMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinimize.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimize.ForeColor = System.Drawing.Color.Silver;
            this.lblMinimize.Location = new System.Drawing.Point(363, 30);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(18, 19);
            this.lblMinimize.TabIndex = 12;
            this.lblMinimize.Text = "-";
            this.lblMinimize.Click += new System.EventHandler(this.lblMinimize_Click);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.Silver;
            this.lblClose.Location = new System.Drawing.Point(384, 30);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(18, 19);
            this.lblClose.TabIndex = 11;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(78, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "version:18.11.20";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseMove);
            this.label2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(76, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "UWP Dll Injector";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseUp);
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlBottom.Controls.Add(this.label8);
            this.pnlBottom.Controls.Add(this.label7);
            this.pnlBottom.Controls.Add(this.lblState);
            this.pnlBottom.Controls.Add(this.lblPid);
            this.pnlBottom.Controls.Add(this.btnInject);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 153);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(412, 41);
            this.pnlBottom.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Silver;
            this.label8.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(315, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(2, 25);
            this.label8.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Silver;
            this.label7.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(132, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(2, 25);
            this.label7.TabIndex = 12;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.ForeColor = System.Drawing.Color.Silver;
            this.lblState.Location = new System.Drawing.Point(137, 14);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(151, 13);
            this.lblState.TabIndex = 11;
            this.lblState.Text = "Process State: Not Found";
            // 
            // lblPid
            // 
            this.lblPid.AutoSize = true;
            this.lblPid.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPid.ForeColor = System.Drawing.Color.Silver;
            this.lblPid.Location = new System.Drawing.Point(5, 14);
            this.lblPid.Name = "lblPid";
            this.lblPid.Size = new System.Drawing.Size(97, 13);
            this.lblPid.TabIndex = 10;
            this.lblPid.Text = "Process ID: 0x0";
            // 
            // btnInject
            // 
            this.btnInject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnInject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInject.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnInject.FlatAppearance.BorderSize = 2;
            this.btnInject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInject.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInject.ForeColor = System.Drawing.Color.Silver;
            this.btnInject.Location = new System.Drawing.Point(324, 7);
            this.btnInject.Name = "btnInject";
            this.btnInject.Size = new System.Drawing.Size(78, 27);
            this.btnInject.TabIndex = 9;
            this.btnInject.Text = "Inject";
            this.btnInject.UseVisualStyleBackColor = false;
            this.btnInject.Click += new System.EventHandler(this.btnInject_Click);
            this.btnInject.MouseEnter += new System.EventHandler(this.btnInject_MouseEnter);
            this.btnInject.MouseLeave += new System.EventHandler(this.btnInject_MouseLeave);
            // 
            // TimerOpacity
            // 
            this.TimerOpacity.Enabled = true;
            this.TimerOpacity.Interval = 20;
            this.TimerOpacity.Tick += new System.EventHandler(this.TimerOpacity_Tick);
            // 
            // btnDllPath
            // 
            this.btnDllPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnDllPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDllPath.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDllPath.FlatAppearance.BorderSize = 2;
            this.btnDllPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDllPath.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDllPath.ForeColor = System.Drawing.Color.Silver;
            this.btnDllPath.Location = new System.Drawing.Point(324, 118);
            this.btnDllPath.Name = "btnDllPath";
            this.btnDllPath.Size = new System.Drawing.Size(78, 27);
            this.btnDllPath.TabIndex = 2;
            this.btnDllPath.Text = "Import";
            this.btnDllPath.UseVisualStyleBackColor = false;
            this.btnDllPath.Click += new System.EventHandler(this.btnDllPath_Click);
            this.btnDllPath.MouseEnter += new System.EventHandler(this.btnSelect_MouseEnter);
            this.btnDllPath.MouseLeave += new System.EventHandler(this.btnSelect_MouseLeave);
            // 
            // txtDllPath
            // 
            this.txtDllPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.txtDllPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDllPath.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDllPath.Location = new System.Drawing.Point(92, 122);
            this.txtDllPath.Name = "txtDllPath";
            this.txtDllPath.ReadOnly = true;
            this.txtDllPath.Size = new System.Drawing.Size(226, 20);
            this.txtDllPath.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(1, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dll Path:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(1, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Process Name:";
            // 
            // txtProcessName
            // 
            this.txtProcessName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.txtProcessName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProcessName.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcessName.Location = new System.Drawing.Point(92, 91);
            this.txtProcessName.Name = "txtProcessName";
            this.txtProcessName.Size = new System.Drawing.Size(226, 20);
            this.txtProcessName.TabIndex = 7;
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelect.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSelect.FlatAppearance.BorderSize = 2;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ForeColor = System.Drawing.Color.Silver;
            this.btnSelect.Location = new System.Drawing.Point(324, 87);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(78, 27);
            this.btnSelect.TabIndex = 6;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            this.btnSelect.MouseEnter += new System.EventHandler(this.btnSelect_MouseEnter);
            this.btnSelect.MouseLeave += new System.EventHandler(this.btnSelect_MouseLeave);
            // 
            // TimerState
            // 
            this.TimerState.Enabled = true;
            this.TimerState.Interval = 300;
            this.TimerState.Tick += new System.EventHandler(this.TimerState_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UWPDllinjector.Properties.Resources.uwpico;
            this.pictureBox1.Location = new System.Drawing.Point(9, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(412, 194);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtProcessName);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDllPath);
            this.Controls.Add(this.btnDllPath);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Opacity = 0D;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Timer TimerOpacity;
        private System.Windows.Forms.Label lblMinimize;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblPid;
        private System.Windows.Forms.Button btnInject;
        private System.Windows.Forms.Button btnDllPath;
        private System.Windows.Forms.TextBox txtDllPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Timer TimerState;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox txtProcessName;
    }
}

