namespace TheDuckingDocs
{
    partial class AppointmentManagement
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmboxPatients = new System.Windows.Forms.ComboBox();
            this.cmboxDoctors = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxPatient = new System.Windows.Forms.TextBox();
            this.txtboxDoctor = new System.Windows.Forms.TextBox();
            this.btnSearchDoctor = new System.Windows.Forms.Button();
            this.btnSearchPatient = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.datetimeAppointment = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this._TheDuckingDocs_Model1DataSet = new TheDuckingDocs._TheDuckingDocs_Model1DataSet();
            this.appointmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentsTableAdapter = new TheDuckingDocs._TheDuckingDocs_Model1DataSetTableAdapters.AppointmentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._TheDuckingDocs_Model1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 234);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(843, 258);
            this.dataGridView1.TabIndex = 0;
            // 
            // cmboxPatients
            // 
            this.cmboxPatients.FormattingEnabled = true;
            this.cmboxPatients.Location = new System.Drawing.Point(12, 25);
            this.cmboxPatients.Name = "cmboxPatients";
            this.cmboxPatients.Size = new System.Drawing.Size(181, 21);
            this.cmboxPatients.TabIndex = 1;
            // 
            // cmboxDoctors
            // 
            this.cmboxDoctors.FormattingEnabled = true;
            this.cmboxDoctors.Location = new System.Drawing.Point(240, 25);
            this.cmboxDoctors.Name = "cmboxDoctors";
            this.cmboxDoctors.Size = new System.Drawing.Size(181, 21);
            this.cmboxDoctors.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "دکتر";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "بیمار";
            // 
            // txtboxPatient
            // 
            this.txtboxPatient.Location = new System.Drawing.Point(12, 52);
            this.txtboxPatient.Name = "txtboxPatient";
            this.txtboxPatient.Size = new System.Drawing.Size(100, 20);
            this.txtboxPatient.TabIndex = 4;
            // 
            // txtboxDoctor
            // 
            this.txtboxDoctor.Location = new System.Drawing.Point(240, 52);
            this.txtboxDoctor.Name = "txtboxDoctor";
            this.txtboxDoctor.Size = new System.Drawing.Size(100, 20);
            this.txtboxDoctor.TabIndex = 4;
            // 
            // btnSearchDoctor
            // 
            this.btnSearchDoctor.Location = new System.Drawing.Point(346, 52);
            this.btnSearchDoctor.Name = "btnSearchDoctor";
            this.btnSearchDoctor.Size = new System.Drawing.Size(75, 23);
            this.btnSearchDoctor.TabIndex = 5;
            this.btnSearchDoctor.Text = "جستجو";
            this.btnSearchDoctor.UseVisualStyleBackColor = true;
            // 
            // btnSearchPatient
            // 
            this.btnSearchPatient.Location = new System.Drawing.Point(118, 52);
            this.btnSearchPatient.Name = "btnSearchPatient";
            this.btnSearchPatient.Size = new System.Drawing.Size(75, 23);
            this.btnSearchPatient.TabIndex = 6;
            this.btnSearchPatient.Text = "جستجو";
            this.btnSearchPatient.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(12, 498);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(93, 498);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "افزودن";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(174, 498);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // datetimeAppointment
            // 
            this.datetimeAppointment.Location = new System.Drawing.Point(12, 108);
            this.datetimeAppointment.Name = "datetimeAppointment";
            this.datetimeAppointment.Size = new System.Drawing.Size(200, 20);
            this.datetimeAppointment.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "تاریخ مراجعه";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(375, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = ": وضعیت";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.appointmentsBindingSource;
            this.comboBox1.DisplayMember = "Status";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(240, 107);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // _TheDuckingDocs_Model1DataSet
            // 
            this._TheDuckingDocs_Model1DataSet.DataSetName = "_TheDuckingDocs_Model1DataSet";
            this._TheDuckingDocs_Model1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appointmentsBindingSource
            // 
            this.appointmentsBindingSource.DataMember = "Appointments";
            this.appointmentsBindingSource.DataSource = this._TheDuckingDocs_Model1DataSet;
            // 
            // appointmentsTableAdapter
            // 
            this.appointmentsTableAdapter.ClearBeforeFill = true;
            // 
            // AppointmentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 539);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.datetimeAppointment);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSearchPatient);
            this.Controls.Add(this.btnSearchDoctor);
            this.Controls.Add(this.txtboxDoctor);
            this.Controls.Add(this.txtboxPatient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmboxDoctors);
            this.Controls.Add(this.cmboxPatients);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AppointmentManagement";
            this.Text = "AppointmentManagement";
            this.Load += new System.EventHandler(this.AppointmentManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._TheDuckingDocs_Model1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmboxPatients;
        private System.Windows.Forms.ComboBox cmboxDoctors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxPatient;
        private System.Windows.Forms.TextBox txtboxDoctor;
        private System.Windows.Forms.Button btnSearchDoctor;
        private System.Windows.Forms.Button btnSearchPatient;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DateTimePicker datetimeAppointment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private _TheDuckingDocs_Model1DataSet _TheDuckingDocs_Model1DataSet;
        private System.Windows.Forms.BindingSource appointmentsBindingSource;
        private _TheDuckingDocs_Model1DataSetTableAdapters.AppointmentsTableAdapter appointmentsTableAdapter;
    }
}