namespace TheDuckingDocs
{
    partial class DoctorManagementForm
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
            System.Windows.Forms.Button btnClearFields;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorManagementForm));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxLastName = new System.Windows.Forms.TextBox();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtboxAge = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxPassword = new System.Windows.Forms.TextBox();
            this.txtboxUsername = new System.Windows.Forms.TextBox();
            this.txtboxIdCardNum = new System.Windows.Forms.TextBox();
            this.txtboxPhoneNum = new System.Windows.Forms.TextBox();
            this.datetimeStartDate = new System.Windows.Forms.DateTimePicker();
            this.datetimeEndDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripItemSpecializations = new System.Windows.Forms.ToolStripMenuItem();
            this.lstboxSpecializations = new System.Windows.Forms.ListBox();
            this.btnAddSpecialization = new System.Windows.Forms.Button();
            this.btnDeleteSpecialization = new System.Windows.Forms.Button();
            this.btnAddDoctor = new System.Windows.Forms.Button();
            this.btnDeleteDoctor = new System.Windows.Forms.Button();
            this.btnEditDoctor = new System.Windows.Forms.Button();
            this.cmboxSpecializations = new System.Windows.Forms.ComboBox();
            this.specializationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._TheDuckingDocs_Model1DataSet = new TheDuckingDocs._TheDuckingDocs_Model1DataSet();
            this.specializationsTableAdapter = new TheDuckingDocs._TheDuckingDocs_Model1DataSetTableAdapters.SpecializationsTableAdapter();
            this.appointmentsTableAdapter = new TheDuckingDocs._TheDuckingDocs_Model1DataSetTableAdapters.AppointmentsTableAdapter();
            btnClearFields = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtboxAge)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.specializationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._TheDuckingDocs_Model1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClearFields
            // 
            btnClearFields.Location = new System.Drawing.Point(756, 267);
            btnClearFields.Name = "btnClearFields";
            btnClearFields.Size = new System.Drawing.Size(95, 23);
            btnClearFields.TabIndex = 46;
            btnClearFields.Text = "پاکسازی فیلدها";
            btnClearFields.UseVisualStyleBackColor = true;
            btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "نام خانوادگی";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "نام";
            // 
            // txtboxLastName
            // 
            this.txtboxLastName.Location = new System.Drawing.Point(270, 47);
            this.txtboxLastName.Name = "txtboxLastName";
            this.txtboxLastName.Size = new System.Drawing.Size(194, 20);
            this.txtboxLastName.TabIndex = 1;
            // 
            // txtboxName
            // 
            this.txtboxName.Location = new System.Drawing.Point(8, 47);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(193, 20);
            this.txtboxName.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 296);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(843, 282);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // txtboxAge
            // 
            this.txtboxAge.Location = new System.Drawing.Point(8, 140);
            this.txtboxAge.Name = "txtboxAge";
            this.txtboxAge.Size = new System.Drawing.Size(194, 20);
            this.txtboxAge.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(271, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "رمز ورود";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "نام کاربری";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "سن";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "کد ملی";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "شماره همراه";
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.Location = new System.Drawing.Point(270, 191);
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.Size = new System.Drawing.Size(194, 20);
            this.txtboxPassword.TabIndex = 6;
            // 
            // txtboxUsername
            // 
            this.txtboxUsername.Location = new System.Drawing.Point(8, 191);
            this.txtboxUsername.Name = "txtboxUsername";
            this.txtboxUsername.Size = new System.Drawing.Size(194, 20);
            this.txtboxUsername.TabIndex = 5;
            // 
            // txtboxIdCardNum
            // 
            this.txtboxIdCardNum.Location = new System.Drawing.Point(270, 90);
            this.txtboxIdCardNum.Name = "txtboxIdCardNum";
            this.txtboxIdCardNum.Size = new System.Drawing.Size(193, 20);
            this.txtboxIdCardNum.TabIndex = 3;
            // 
            // txtboxPhoneNum
            // 
            this.txtboxPhoneNum.Location = new System.Drawing.Point(8, 90);
            this.txtboxPhoneNum.Name = "txtboxPhoneNum";
            this.txtboxPhoneNum.Size = new System.Drawing.Size(193, 20);
            this.txtboxPhoneNum.TabIndex = 2;
            // 
            // datetimeStartDate
            // 
            this.datetimeStartDate.Location = new System.Drawing.Point(8, 241);
            this.datetimeStartDate.Name = "datetimeStartDate";
            this.datetimeStartDate.Size = new System.Drawing.Size(200, 20);
            this.datetimeStartDate.TabIndex = 7;
            // 
            // datetimeEndDate
            // 
            this.datetimeEndDate.Location = new System.Drawing.Point(270, 241);
            this.datetimeEndDate.Name = "datetimeEndDate";
            this.datetimeEndDate.Size = new System.Drawing.Size(200, 20);
            this.datetimeEndDate.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "تاریخ شروع";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(271, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "تاریخ پایان";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.CadetBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripItemSpecializations});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(865, 24);
            this.menuStrip1.TabIndex = 41;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripItemSpecializations
            // 
            this.toolStripItemSpecializations.Name = "toolStripItemSpecializations";
            this.toolStripItemSpecializations.Size = new System.Drawing.Size(113, 20);
            this.toolStripItemSpecializations.Text = "مدیریت تخصص ها";
            this.toolStripItemSpecializations.Click += new System.EventHandler(this.toolStripItemSpecializations_Click);
            // 
            // lstboxSpecializations
            // 
            this.lstboxSpecializations.FormattingEnabled = true;
            this.lstboxSpecializations.Items.AddRange(new object[] {
            "لطفا یک ردیف را انتخاب کنید"});
            this.lstboxSpecializations.Location = new System.Drawing.Point(719, 12);
            this.lstboxSpecializations.Name = "lstboxSpecializations";
            this.lstboxSpecializations.Size = new System.Drawing.Size(134, 134);
            this.lstboxSpecializations.TabIndex = 42;
            // 
            // btnAddSpecialization
            // 
            this.btnAddSpecialization.Location = new System.Drawing.Point(770, 152);
            this.btnAddSpecialization.Name = "btnAddSpecialization";
            this.btnAddSpecialization.Size = new System.Drawing.Size(83, 23);
            this.btnAddSpecialization.TabIndex = 43;
            this.btnAddSpecialization.Text = "افرودن تخصص";
            this.btnAddSpecialization.UseVisualStyleBackColor = true;
            this.btnAddSpecialization.Click += new System.EventHandler(this.btnAddSpecialization_Click);
            // 
            // btnDeleteSpecialization
            // 
            this.btnDeleteSpecialization.Location = new System.Drawing.Point(630, 123);
            this.btnDeleteSpecialization.Name = "btnDeleteSpecialization";
            this.btnDeleteSpecialization.Size = new System.Drawing.Size(83, 23);
            this.btnDeleteSpecialization.TabIndex = 44;
            this.btnDeleteSpecialization.Text = "حذف تخصص";
            this.btnDeleteSpecialization.UseVisualStyleBackColor = true;
            this.btnDeleteSpecialization.Click += new System.EventHandler(this.btnDeleteSpecialization_Click);
            // 
            // btnAddDoctor
            // 
            this.btnAddDoctor.Location = new System.Drawing.Point(8, 267);
            this.btnAddDoctor.Name = "btnAddDoctor";
            this.btnAddDoctor.Size = new System.Drawing.Size(75, 23);
            this.btnAddDoctor.TabIndex = 9;
            this.btnAddDoctor.Text = "افزودن دکتر";
            this.btnAddDoctor.UseVisualStyleBackColor = true;
            this.btnAddDoctor.Click += new System.EventHandler(this.btnAddDoctor_Click);
            // 
            // btnDeleteDoctor
            // 
            this.btnDeleteDoctor.Location = new System.Drawing.Point(9, 585);
            this.btnDeleteDoctor.Name = "btnDeleteDoctor";
            this.btnDeleteDoctor.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteDoctor.TabIndex = 11;
            this.btnDeleteDoctor.Text = "حذف دکتر";
            this.btnDeleteDoctor.UseVisualStyleBackColor = true;
            this.btnDeleteDoctor.Click += new System.EventHandler(this.btnDeleteDoctor_Click);
            // 
            // btnEditDoctor
            // 
            this.btnEditDoctor.Location = new System.Drawing.Point(91, 584);
            this.btnEditDoctor.Name = "btnEditDoctor";
            this.btnEditDoctor.Size = new System.Drawing.Size(93, 23);
            this.btnEditDoctor.TabIndex = 12;
            this.btnEditDoctor.Text = "ویرایش مشخصات";
            this.btnEditDoctor.UseVisualStyleBackColor = true;
            this.btnEditDoctor.Click += new System.EventHandler(this.btnEditDoctor_Click);
            // 
            // cmboxSpecializations
            // 
            this.cmboxSpecializations.DataSource = this.specializationsBindingSource;
            this.cmboxSpecializations.DisplayMember = "Name";
            this.cmboxSpecializations.FormattingEnabled = true;
            this.cmboxSpecializations.Location = new System.Drawing.Point(732, 181);
            this.cmboxSpecializations.Name = "cmboxSpecializations";
            this.cmboxSpecializations.Size = new System.Drawing.Size(121, 21);
            this.cmboxSpecializations.TabIndex = 45;
            this.cmboxSpecializations.ValueMember = "SpecializationId";
            // 
            // specializationsBindingSource
            // 
            this.specializationsBindingSource.DataMember = "Specializations";
            this.specializationsBindingSource.DataSource = this._TheDuckingDocs_Model1DataSet;
            // 
            // _TheDuckingDocs_Model1DataSet
            // 
            this._TheDuckingDocs_Model1DataSet.DataSetName = "_TheDuckingDocs_Model1DataSet";
            this._TheDuckingDocs_Model1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // specializationsTableAdapter
            // 
            this.specializationsTableAdapter.ClearBeforeFill = true;
            // 
            // appointmentsTableAdapter
            // 
            this.appointmentsTableAdapter.ClearBeforeFill = true;
            // 
            // DoctorManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(865, 620);
            this.Controls.Add(btnClearFields);
            this.Controls.Add(this.cmboxSpecializations);
            this.Controls.Add(this.btnEditDoctor);
            this.Controls.Add(this.btnDeleteDoctor);
            this.Controls.Add(this.btnAddDoctor);
            this.Controls.Add(this.btnDeleteSpecialization);
            this.Controls.Add(this.btnAddSpecialization);
            this.Controls.Add(this.lstboxSpecializations);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.datetimeEndDate);
            this.Controls.Add(this.datetimeStartDate);
            this.Controls.Add(this.txtboxAge);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtboxPassword);
            this.Controls.Add(this.txtboxUsername);
            this.Controls.Add(this.txtboxIdCardNum);
            this.Controls.Add(this.txtboxPhoneNum);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxLastName);
            this.Controls.Add(this.txtboxName);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DoctorManagementForm";
            this.Text = "مدریت دکتر ها";
            this.Load += new System.EventHandler(this.DoctorManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtboxAge)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.specializationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._TheDuckingDocs_Model1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxLastName;
        private System.Windows.Forms.TextBox txtboxName;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown txtboxAge;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtboxPassword;
        private System.Windows.Forms.TextBox txtboxUsername;
        private System.Windows.Forms.TextBox txtboxIdCardNum;
        private System.Windows.Forms.TextBox txtboxPhoneNum;
        private System.Windows.Forms.DateTimePicker datetimeStartDate;
        private System.Windows.Forms.DateTimePicker datetimeEndDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripItemSpecializations;
        private System.Windows.Forms.ListBox lstboxSpecializations;
        private System.Windows.Forms.Button btnAddSpecialization;
        private System.Windows.Forms.Button btnDeleteSpecialization;
        private System.Windows.Forms.Button btnAddDoctor;
        private System.Windows.Forms.Button btnDeleteDoctor;
        private System.Windows.Forms.Button btnEditDoctor;
        private System.Windows.Forms.ComboBox cmboxSpecializations;
        private _TheDuckingDocs_Model1DataSet _TheDuckingDocs_Model1DataSet;
        private System.Windows.Forms.BindingSource specializationsBindingSource;
        private _TheDuckingDocs_Model1DataSetTableAdapters.SpecializationsTableAdapter specializationsTableAdapter;
        private _TheDuckingDocs_Model1DataSetTableAdapters.AppointmentsTableAdapter appointmentsTableAdapter;
    }
}