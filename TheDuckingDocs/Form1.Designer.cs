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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.نوبتدهیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.لیستپزشکانToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اخبارواطلاعیههاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.دربارهماToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ثبتنامToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ثبتنامToolStripMenuItem,
            this.نوبتدهیToolStripMenuItem,
            this.لیستپزشکانToolStripMenuItem,
            this.اخبارواطلاعیههاToolStripMenuItem,
            this.دربارهماToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // نوبتدهیToolStripMenuItem
            // 
            this.نوبتدهیToolStripMenuItem.Name = "نوبتدهیToolStripMenuItem";
            this.نوبتدهیToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.نوبتدهیToolStripMenuItem.Text = "نوبت دهی";
            // 
            // لیستپزشکانToolStripMenuItem
            // 
            this.لیستپزشکانToolStripMenuItem.Name = "لیستپزشکانToolStripMenuItem";
            this.لیستپزشکانToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.لیستپزشکانToolStripMenuItem.Text = "لیست پزشکان";
            // 
            // اخبارواطلاعیههاToolStripMenuItem
            // 
            this.اخبارواطلاعیههاToolStripMenuItem.Name = "اخبارواطلاعیههاToolStripMenuItem";
            this.اخبارواطلاعیههاToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.اخبارواطلاعیههاToolStripMenuItem.Text = "اخبار و اطلاعیه ها";
            // 
            // دربارهماToolStripMenuItem
            // 
            this.دربارهماToolStripMenuItem.Name = "دربارهماToolStripMenuItem";
            this.دربارهماToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.دربارهماToolStripMenuItem.Text = "درباره ما";
            // 
            // ثبتنامToolStripMenuItem
            // 
            this.ثبتنامToolStripMenuItem.Name = "ثبتنامToolStripMenuItem";
            this.ثبتنامToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.ثبتنامToolStripMenuItem.Text = "ثبت نام";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Da";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem نوبتدهیToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem لیستپزشکانToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ثبتنامToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اخبارواطلاعیههاToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem دربارهماToolStripMenuItem;
    }
}

