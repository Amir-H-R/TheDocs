namespace TheDuckingDocs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripItemReservation = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripItemDoctors = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripItemNews = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripItemManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripItemDocsManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripItemAppointmentsManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAboutUs = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripItemReservation,
            this.toolStripItemDoctors,
            this.toolStripItemNews,
            this.toolStripItemManagement,
            this.toolStripItemDocsManagement,
            this.toolStripItemAppointmentsManagement});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripItemReservation
            // 
            this.toolStripItemReservation.Name = "toolStripItemReservation";
            this.toolStripItemReservation.Size = new System.Drawing.Size(71, 20);
            this.toolStripItemReservation.Text = "نوبت دهی";
            this.toolStripItemReservation.Click += new System.EventHandler(this.toolStripItemReservation_Click);
            // 
            // toolStripItemDoctors
            // 
            this.toolStripItemDoctors.Name = "toolStripItemDoctors";
            this.toolStripItemDoctors.Size = new System.Drawing.Size(86, 20);
            this.toolStripItemDoctors.Text = "لیست پزشکان";
            this.toolStripItemDoctors.Click += new System.EventHandler(this.toolStripItemDoctors_Click);
            // 
            // toolStripItemNews
            // 
            this.toolStripItemNews.Name = "toolStripItemNews";
            this.toolStripItemNews.Size = new System.Drawing.Size(104, 20);
            this.toolStripItemNews.Text = "اخبار و اطلاعیه ها";
            // 
            // toolStripItemManagement
            // 
            this.toolStripItemManagement.Name = "toolStripItemManagement";
            this.toolStripItemManagement.Size = new System.Drawing.Size(93, 20);
            this.toolStripItemManagement.Text = "مدیریت کاربران";
            this.toolStripItemManagement.Visible = false;
            this.toolStripItemManagement.Click += new System.EventHandler(this.toolStripItemManagement_Click);
            // 
            // toolStripItemDocsManagement
            // 
            this.toolStripItemDocsManagement.Name = "toolStripItemDocsManagement";
            this.toolStripItemDocsManagement.Size = new System.Drawing.Size(95, 20);
            this.toolStripItemDocsManagement.Text = "مدیریت دکتر ها";
            this.toolStripItemDocsManagement.Visible = false;
            this.toolStripItemDocsManagement.Click += new System.EventHandler(this.toolStripItemDocsManagement_Click);
            // 
            // toolStripItemAppointmentsManagement
            // 
            this.toolStripItemAppointmentsManagement.Name = "toolStripItemAppointmentsManagement";
            this.toolStripItemAppointmentsManagement.Size = new System.Drawing.Size(99, 20);
            this.toolStripItemAppointmentsManagement.Text = "مدیریت نوبت ها";
            this.toolStripItemAppointmentsManagement.Click += new System.EventHandler(this.toolStripItemAppointmentsManagement_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.MediumSpringGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button1.Location = new System.Drawing.Point(1133, 646);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "توصیه های بهداشتی";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.MediumSpringGreen;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(12, 613);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 27);
            this.button3.TabIndex = 2;
            this.button3.Text = "تماس با ما";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Red;
            this.btnLogout.Location = new System.Drawing.Point(12, 646);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(91, 27);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "خروج از حساب";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1264, 681);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnAboutUs
            // 
            this.btnAboutUs.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAboutUs.FlatAppearance.BorderColor = System.Drawing.Color.MediumSpringGreen;
            this.btnAboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAboutUs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAboutUs.Location = new System.Drawing.Point(12, 580);
            this.btnAboutUs.Name = "btnAboutUs";
            this.btnAboutUs.Size = new System.Drawing.Size(71, 27);
            this.btnAboutUs.TabIndex = 2;
            this.btnAboutUs.Text = "درباره ما";
            this.btnAboutUs.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnAboutUs);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "بیمارستان....";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripItemReservation;
        private System.Windows.Forms.ToolStripMenuItem toolStripItemDoctors;
        private System.Windows.Forms.ToolStripMenuItem toolStripItemNews;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ToolStripMenuItem toolStripItemManagement;
        private System.Windows.Forms.ToolStripMenuItem toolStripItemDocsManagement;
        private System.Windows.Forms.ToolStripMenuItem toolStripItemAppointmentsManagement;
        private System.Windows.Forms.Button btnAboutUs;
    }
}

