namespace TheDuckingDocs
{
    partial class RegisterForm
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
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.txtboxLastName = new System.Windows.Forms.TextBox();
            this.txtboxPhoneNum = new System.Windows.Forms.TextBox();
            this.txtboxIdCardNum = new System.Windows.Forms.TextBox();
            this.txtboxAge = new System.Windows.Forms.TextBox();
            this.txtboxUsername = new System.Windows.Forms.TextBox();
            this.txtboxPassword = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtboxName
            // 
            this.txtboxName.Location = new System.Drawing.Point(13, 13);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(193, 20);
            this.txtboxName.TabIndex = 0;
            this.txtboxName.Text = "نام";
            // 
            // txtboxLastName
            // 
            this.txtboxLastName.Location = new System.Drawing.Point(12, 39);
            this.txtboxLastName.Name = "txtboxLastName";
            this.txtboxLastName.Size = new System.Drawing.Size(194, 20);
            this.txtboxLastName.TabIndex = 1;
            this.txtboxLastName.Text = "نام خانوادگی";
            // 
            // txtboxPhoneNum
            // 
            this.txtboxPhoneNum.Location = new System.Drawing.Point(13, 65);
            this.txtboxPhoneNum.Name = "txtboxPhoneNum";
            this.txtboxPhoneNum.Size = new System.Drawing.Size(193, 20);
            this.txtboxPhoneNum.TabIndex = 2;
            this.txtboxPhoneNum.Text = "شماره همراه";
            // 
            // txtboxIdCardNum
            // 
            this.txtboxIdCardNum.Location = new System.Drawing.Point(13, 91);
            this.txtboxIdCardNum.Name = "txtboxIdCardNum";
            this.txtboxIdCardNum.Size = new System.Drawing.Size(193, 20);
            this.txtboxIdCardNum.TabIndex = 3;
            this.txtboxIdCardNum.Text = "کد ملی";
            // 
            // txtboxAge
            // 
            this.txtboxAge.Location = new System.Drawing.Point(12, 117);
            this.txtboxAge.Name = "txtboxAge";
            this.txtboxAge.Size = new System.Drawing.Size(194, 20);
            this.txtboxAge.TabIndex = 4;
            this.txtboxAge.Text = "سن";
            // 
            // txtboxUsername
            // 
            this.txtboxUsername.Location = new System.Drawing.Point(12, 166);
            this.txtboxUsername.Name = "txtboxUsername";
            this.txtboxUsername.Size = new System.Drawing.Size(194, 20);
            this.txtboxUsername.TabIndex = 5;
            this.txtboxUsername.Text = "نام کاربری";
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.Location = new System.Drawing.Point(12, 192);
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.Size = new System.Drawing.Size(194, 20);
            this.txtboxPassword.TabIndex = 6;
            this.txtboxPassword.Text = "رمز ورود";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(13, 219);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "ثبت نام";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(348, 249);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtboxPassword);
            this.Controls.Add(this.txtboxUsername);
            this.Controls.Add(this.txtboxAge);
            this.Controls.Add(this.txtboxIdCardNum);
            this.Controls.Add(this.txtboxPhoneNum);
            this.Controls.Add(this.txtboxLastName);
            this.Controls.Add(this.txtboxName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisterForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فرم ثبت نام";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegisterForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxName;
        private System.Windows.Forms.TextBox txtboxLastName;
        private System.Windows.Forms.TextBox txtboxPhoneNum;
        private System.Windows.Forms.TextBox txtboxIdCardNum;
        private System.Windows.Forms.TextBox txtboxAge;
        private System.Windows.Forms.TextBox txtboxUsername;
        private System.Windows.Forms.TextBox txtboxPassword;
        private System.Windows.Forms.Button btnRegister;
    }
}