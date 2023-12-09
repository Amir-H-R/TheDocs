namespace TheDuckingDocs
{
    partial class ManagementForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.peopleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._TheDuckingDocs_Model1DataSet = new TheDuckingDocs._TheDuckingDocs_Model1DataSet();
            this.theDuckingDocsModel1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.peopleTableAdapter = new TheDuckingDocs._TheDuckingDocs_Model1DataSetTableAdapters.PeopleTableAdapter();
            this.txtboxAge = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxPassword = new System.Windows.Forms.TextBox();
            this.txtboxUsername = new System.Windows.Forms.TextBox();
            this.txtboxIdCardNum = new System.Windows.Forms.TextBox();
            this.txtboxPhoneNum = new System.Windows.Forms.TextBox();
            this.txtboxLastName = new System.Windows.Forms.TextBox();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.lstboxRoles = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDeleteRole = new System.Windows.Forms.Button();
            this.btnAddRole = new System.Windows.Forms.Button();
            this.cmboxRoles = new System.Windows.Forms.ComboBox();
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rolesTableAdapter = new TheDuckingDocs._TheDuckingDocs_Model1DataSetTableAdapters.RolesTableAdapter();
            this.PersonId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCardNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._TheDuckingDocs_Model1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theDuckingDocsModel1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtboxAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PersonId,
            this.nameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.idCardNumberDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.peopleBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Location = new System.Drawing.Point(12, 271);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Size = new System.Drawing.Size(745, 347);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // peopleBindingSource
            // 
            this.peopleBindingSource.DataMember = "People";
            this.peopleBindingSource.DataSource = this._TheDuckingDocs_Model1DataSet;
            // 
            // _TheDuckingDocs_Model1DataSet
            // 
            this._TheDuckingDocs_Model1DataSet.DataSetName = "_TheDuckingDocs_Model1DataSet";
            this._TheDuckingDocs_Model1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // theDuckingDocsModel1DataSetBindingSource
            // 
            this.theDuckingDocsModel1DataSetBindingSource.DataSource = this._TheDuckingDocs_Model1DataSet;
            this.theDuckingDocsModel1DataSetBindingSource.Position = 0;
            // 
            // peopleTableAdapter
            // 
            this.peopleTableAdapter.ClearBeforeFill = true;
            // 
            // txtboxAge
            // 
            this.txtboxAge.Location = new System.Drawing.Point(16, 126);
            this.txtboxAge.Name = "txtboxAge";
            this.txtboxAge.Size = new System.Drawing.Size(194, 20);
            this.txtboxAge.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(279, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "رمز ورود";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "نام کاربری";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "سن";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "کد ملی";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "شماره همراه";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "نام خانوادگی";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "نام";
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.Location = new System.Drawing.Point(278, 177);
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.Size = new System.Drawing.Size(194, 20);
            this.txtboxPassword.TabIndex = 15;
            // 
            // txtboxUsername
            // 
            this.txtboxUsername.Location = new System.Drawing.Point(12, 177);
            this.txtboxUsername.Name = "txtboxUsername";
            this.txtboxUsername.Size = new System.Drawing.Size(194, 20);
            this.txtboxUsername.TabIndex = 14;
            // 
            // txtboxIdCardNum
            // 
            this.txtboxIdCardNum.Location = new System.Drawing.Point(278, 76);
            this.txtboxIdCardNum.Name = "txtboxIdCardNum";
            this.txtboxIdCardNum.Size = new System.Drawing.Size(193, 20);
            this.txtboxIdCardNum.TabIndex = 12;
            // 
            // txtboxPhoneNum
            // 
            this.txtboxPhoneNum.Location = new System.Drawing.Point(12, 76);
            this.txtboxPhoneNum.Name = "txtboxPhoneNum";
            this.txtboxPhoneNum.Size = new System.Drawing.Size(193, 20);
            this.txtboxPhoneNum.TabIndex = 11;
            // 
            // txtboxLastName
            // 
            this.txtboxLastName.Location = new System.Drawing.Point(278, 22);
            this.txtboxLastName.Name = "txtboxLastName";
            this.txtboxLastName.Size = new System.Drawing.Size(194, 20);
            this.txtboxLastName.TabIndex = 10;
            // 
            // txtboxName
            // 
            this.txtboxName.Location = new System.Drawing.Point(12, 22);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(193, 20);
            this.txtboxName.TabIndex = 9;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(12, 242);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(75, 23);
            this.btnAddUser.TabIndex = 23;
            this.btnAddUser.Text = "افزودن";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Location = new System.Drawing.Point(12, 645);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateUser.TabIndex = 24;
            this.btnUpdateUser.Text = "ویرایش";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(93, 645);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteUser.TabIndex = 25;
            this.btnDeleteUser.Text = "حذف";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnClearFields
            // 
            this.btnClearFields.Location = new System.Drawing.Point(661, 242);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(96, 23);
            this.btnClearFields.TabIndex = 26;
            this.btnClearFields.Text = "پاکسازی فیلدها";
            this.btnClearFields.UseVisualStyleBackColor = true;
            this.btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // lstboxRoles
            // 
            this.lstboxRoles.FormattingEnabled = true;
            this.lstboxRoles.Location = new System.Drawing.Point(637, 28);
            this.lstboxRoles.Name = "lstboxRoles";
            this.lstboxRoles.Size = new System.Drawing.Size(120, 95);
            this.lstboxRoles.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(718, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "نقش ها";
            // 
            // btnDeleteRole
            // 
            this.btnDeleteRole.Location = new System.Drawing.Point(556, 100);
            this.btnDeleteRole.Name = "btnDeleteRole";
            this.btnDeleteRole.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteRole.TabIndex = 28;
            this.btnDeleteRole.Text = "حذف نقش";
            this.btnDeleteRole.UseVisualStyleBackColor = true;
            // 
            // btnAddRole
            // 
            this.btnAddRole.Location = new System.Drawing.Point(682, 129);
            this.btnAddRole.Name = "btnAddRole";
            this.btnAddRole.Size = new System.Drawing.Size(75, 23);
            this.btnAddRole.TabIndex = 29;
            this.btnAddRole.Text = "افرودن نقش";
            this.btnAddRole.UseVisualStyleBackColor = true;
            this.btnAddRole.Click += new System.EventHandler(this.btnAddRole_Click);
            // 
            // cmboxRoles
            // 
            this.cmboxRoles.DataSource = this.rolesBindingSource;
            this.cmboxRoles.DisplayMember = "Name";
            this.cmboxRoles.FormattingEnabled = true;
            this.cmboxRoles.Location = new System.Drawing.Point(636, 153);
            this.cmboxRoles.Name = "cmboxRoles";
            this.cmboxRoles.Size = new System.Drawing.Size(121, 21);
            this.cmboxRoles.TabIndex = 30;
            this.cmboxRoles.ValueMember = "RoleId";
            // 
            // rolesBindingSource
            // 
            this.rolesBindingSource.DataMember = "Roles";
            this.rolesBindingSource.DataSource = this.theDuckingDocsModel1DataSetBindingSource;
            // 
            // rolesTableAdapter
            // 
            this.rolesTableAdapter.ClearBeforeFill = true;
            // 
            // PersonId
            // 
            this.PersonId.DataPropertyName = "PersonId";
            this.PersonId.HeaderText = "PersonId";
            this.PersonId.Name = "PersonId";
            this.PersonId.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idCardNumberDataGridViewTextBoxColumn
            // 
            this.idCardNumberDataGridViewTextBoxColumn.DataPropertyName = "IdCardNumber";
            this.idCardNumberDataGridViewTextBoxColumn.HeaderText = "IdCardNumber";
            this.idCardNumberDataGridViewTextBoxColumn.Name = "idCardNumberDataGridViewTextBoxColumn";
            this.idCardNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(766, 680);
            this.Controls.Add(this.cmboxRoles);
            this.Controls.Add(this.btnAddRole);
            this.Controls.Add(this.btnDeleteRole);
            this.Controls.Add(this.lstboxRoles);
            this.Controls.Add(this.btnClearFields);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.btnUpdateUser);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.txtboxAge);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxPassword);
            this.Controls.Add(this.txtboxUsername);
            this.Controls.Add(this.txtboxIdCardNum);
            this.Controls.Add(this.txtboxPhoneNum);
            this.Controls.Add(this.txtboxLastName);
            this.Controls.Add(this.txtboxName);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManagementForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "مدریت کاربران";
            this.Load += new System.EventHandler(this.ManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._TheDuckingDocs_Model1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theDuckingDocsModel1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtboxAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource theDuckingDocsModel1DataSetBindingSource;
        private _TheDuckingDocs_Model1DataSet _TheDuckingDocs_Model1DataSet;
        private System.Windows.Forms.BindingSource peopleBindingSource;
        private _TheDuckingDocs_Model1DataSetTableAdapters.PeopleTableAdapter peopleTableAdapter;
        private System.Windows.Forms.NumericUpDown txtboxAge;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxPassword;
        private System.Windows.Forms.TextBox txtboxUsername;
        private System.Windows.Forms.TextBox txtboxIdCardNum;
        private System.Windows.Forms.TextBox txtboxPhoneNum;
        private System.Windows.Forms.TextBox txtboxLastName;
        private System.Windows.Forms.TextBox txtboxName;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.ListBox lstboxRoles;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDeleteRole;
        private System.Windows.Forms.Button btnAddRole;
        private System.Windows.Forms.ComboBox cmboxRoles;
        private System.Windows.Forms.BindingSource rolesBindingSource;
        private _TheDuckingDocs_Model1DataSetTableAdapters.RolesTableAdapter rolesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonId;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCardNumberDataGridViewTextBoxColumn;
    }
}