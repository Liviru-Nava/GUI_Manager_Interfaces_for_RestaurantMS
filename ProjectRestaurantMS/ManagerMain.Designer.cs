namespace ProjectRestaurantMS
{
    partial class ManagerMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerMain));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lbl_ManagerName = new System.Windows.Forms.Label();
            this.btn_Employee_register = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Statistics = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Employee_details = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Reports = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Logout = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2CirclePictureBox2);
            this.guna2Panel1.Controls.Add(this.lbl_ManagerName);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(929, 124);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2CirclePictureBox2
            // 
            this.guna2CirclePictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox2.Image")));
            this.guna2CirclePictureBox2.ImageRotate = 0F;
            this.guna2CirclePictureBox2.Location = new System.Drawing.Point(12, 12);
            this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox2.Size = new System.Drawing.Size(104, 102);
            this.guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox2.TabIndex = 4;
            this.guna2CirclePictureBox2.TabStop = false;
            // 
            // lbl_ManagerName
            // 
            this.lbl_ManagerName.AutoSize = true;
            this.lbl_ManagerName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ManagerName.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ManagerName.Location = new System.Drawing.Point(374, 39);
            this.lbl_ManagerName.Name = "lbl_ManagerName";
            this.lbl_ManagerName.Size = new System.Drawing.Size(106, 45);
            this.lbl_ManagerName.TabIndex = 2;
            this.lbl_ManagerName.Text = "label1";
            // 
            // btn_Employee_register
            // 
            this.btn_Employee_register.Animated = true;
            this.btn_Employee_register.AnimatedGIF = true;
            this.btn_Employee_register.BackColor = System.Drawing.Color.Transparent;
            this.btn_Employee_register.BorderColor = System.Drawing.Color.White;
            this.btn_Employee_register.BorderRadius = 15;
            this.btn_Employee_register.BorderThickness = 2;
            this.btn_Employee_register.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Employee_register.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Employee_register.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Employee_register.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Employee_register.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(10)))), ((int)(((byte)(16)))));
            this.btn_Employee_register.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Employee_register.ForeColor = System.Drawing.Color.White;
            this.btn_Employee_register.Image = ((System.Drawing.Image)(resources.GetObject("btn_Employee_register.Image")));
            this.btn_Employee_register.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Employee_register.ImageOffset = new System.Drawing.Point(10, -50);
            this.btn_Employee_register.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_Employee_register.Location = new System.Drawing.Point(126, 156);
            this.btn_Employee_register.Name = "btn_Employee_register";
            this.btn_Employee_register.Size = new System.Drawing.Size(273, 203);
            this.btn_Employee_register.TabIndex = 1;
            this.btn_Employee_register.Text = "Employee Registration";
            this.btn_Employee_register.Click += new System.EventHandler(this.btn_Employee_register_Click);
            // 
            // btn_Statistics
            // 
            this.btn_Statistics.Animated = true;
            this.btn_Statistics.AnimatedGIF = true;
            this.btn_Statistics.BackColor = System.Drawing.Color.Transparent;
            this.btn_Statistics.BorderColor = System.Drawing.Color.White;
            this.btn_Statistics.BorderRadius = 15;
            this.btn_Statistics.BorderThickness = 2;
            this.btn_Statistics.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Statistics.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Statistics.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Statistics.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Statistics.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btn_Statistics.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Statistics.ForeColor = System.Drawing.Color.White;
            this.btn_Statistics.Image = ((System.Drawing.Image)(resources.GetObject("btn_Statistics.Image")));
            this.btn_Statistics.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Statistics.ImageOffset = new System.Drawing.Point(10, -50);
            this.btn_Statistics.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_Statistics.Location = new System.Drawing.Point(503, 156);
            this.btn_Statistics.Name = "btn_Statistics";
            this.btn_Statistics.Size = new System.Drawing.Size(273, 203);
            this.btn_Statistics.TabIndex = 2;
            this.btn_Statistics.Text = "Daily Statistics";
            this.btn_Statistics.Click += new System.EventHandler(this.btn_Statistics_Click);
            // 
            // btn_Employee_details
            // 
            this.btn_Employee_details.Animated = true;
            this.btn_Employee_details.AnimatedGIF = true;
            this.btn_Employee_details.BackColor = System.Drawing.Color.Transparent;
            this.btn_Employee_details.BorderColor = System.Drawing.Color.White;
            this.btn_Employee_details.BorderRadius = 15;
            this.btn_Employee_details.BorderThickness = 2;
            this.btn_Employee_details.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Employee_details.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Employee_details.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Employee_details.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Employee_details.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btn_Employee_details.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Employee_details.ForeColor = System.Drawing.Color.White;
            this.btn_Employee_details.Image = ((System.Drawing.Image)(resources.GetObject("btn_Employee_details.Image")));
            this.btn_Employee_details.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Employee_details.ImageOffset = new System.Drawing.Point(10, -50);
            this.btn_Employee_details.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_Employee_details.Location = new System.Drawing.Point(126, 428);
            this.btn_Employee_details.Name = "btn_Employee_details";
            this.btn_Employee_details.Size = new System.Drawing.Size(273, 203);
            this.btn_Employee_details.TabIndex = 3;
            this.btn_Employee_details.Text = "Employee Details";
            this.btn_Employee_details.Click += new System.EventHandler(this.btn_Employee_details_Click);
            // 
            // btn_Reports
            // 
            this.btn_Reports.Animated = true;
            this.btn_Reports.AnimatedGIF = true;
            this.btn_Reports.BackColor = System.Drawing.Color.Transparent;
            this.btn_Reports.BorderColor = System.Drawing.Color.White;
            this.btn_Reports.BorderRadius = 15;
            this.btn_Reports.BorderThickness = 2;
            this.btn_Reports.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Reports.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Reports.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Reports.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Reports.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(192)))), ((int)(((byte)(35)))));
            this.btn_Reports.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reports.ForeColor = System.Drawing.Color.White;
            this.btn_Reports.Image = ((System.Drawing.Image)(resources.GetObject("btn_Reports.Image")));
            this.btn_Reports.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Reports.ImageOffset = new System.Drawing.Point(10, -50);
            this.btn_Reports.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_Reports.Location = new System.Drawing.Point(503, 428);
            this.btn_Reports.Name = "btn_Reports";
            this.btn_Reports.Size = new System.Drawing.Size(273, 203);
            this.btn_Reports.TabIndex = 4;
            this.btn_Reports.Text = "Reports";
            this.btn_Reports.Click += new System.EventHandler(this.btn_Reports_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.Transparent;
            this.btn_Logout.BorderRadius = 15;
            this.btn_Logout.BorderThickness = 1;
            this.btn_Logout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Logout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Logout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Logout.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Logout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Logout.FillColor = System.Drawing.Color.Red;
            this.btn_Logout.FillColor2 = System.Drawing.Color.OrangeRed;
            this.btn_Logout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.White;
            this.btn_Logout.Location = new System.Drawing.Point(699, 647);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(180, 45);
            this.btn_Logout.TabIndex = 5;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // ManagerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(929, 714);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.btn_Reports);
            this.Controls.Add(this.btn_Employee_details);
            this.Controls.Add(this.btn_Statistics);
            this.Controls.Add(this.btn_Employee_register);
            this.Controls.Add(this.guna2Panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManagerMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerMain";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btn_Employee_register;
        private Guna.UI2.WinForms.Guna2Button btn_Statistics;
        private Guna.UI2.WinForms.Guna2Button btn_Employee_details;
        private Guna.UI2.WinForms.Guna2Button btn_Reports;
        private System.Windows.Forms.Label lbl_ManagerName;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Logout;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
    }
}