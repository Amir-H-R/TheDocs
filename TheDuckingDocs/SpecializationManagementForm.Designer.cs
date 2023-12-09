namespace TheDuckingDocs
{
    partial class SpecializationManagementForm
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
            this.specializationIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specializationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._TheDuckingDocs_Model1DataSet = new TheDuckingDocs._TheDuckingDocs_Model1DataSet();
            this.specializationsTableAdapter = new TheDuckingDocs._TheDuckingDocs_Model1DataSetTableAdapters.SpecializationsTableAdapter();
            this.btnAddSpecialization = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxSpecialization = new System.Windows.Forms.TextBox();
            this.btnDeleteSpecialization = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._TheDuckingDocs_Model1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.specializationIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.specializationsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(317, 150);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // specializationIdDataGridViewTextBoxColumn
            // 
            this.specializationIdDataGridViewTextBoxColumn.DataPropertyName = "SpecializationId";
            this.specializationIdDataGridViewTextBoxColumn.HeaderText = "SpecializationId";
            this.specializationIdDataGridViewTextBoxColumn.Name = "specializationIdDataGridViewTextBoxColumn";
            this.specializationIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
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
            // btnAddSpecialization
            // 
            this.btnAddSpecialization.Location = new System.Drawing.Point(15, 51);
            this.btnAddSpecialization.Name = "btnAddSpecialization";
            this.btnAddSpecialization.Size = new System.Drawing.Size(75, 23);
            this.btnAddSpecialization.TabIndex = 1;
            this.btnAddSpecialization.Text = "افزودن";
            this.btnAddSpecialization.UseVisualStyleBackColor = true;
            this.btnAddSpecialization.Click += new System.EventHandler(this.btnAddSpecialization_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "نام تخصص";
            // 
            // txtboxSpecialization
            // 
            this.txtboxSpecialization.Location = new System.Drawing.Point(15, 25);
            this.txtboxSpecialization.Name = "txtboxSpecialization";
            this.txtboxSpecialization.Size = new System.Drawing.Size(177, 20);
            this.txtboxSpecialization.TabIndex = 0;
            // 
            // btnDeleteSpecialization
            // 
            this.btnDeleteSpecialization.Location = new System.Drawing.Point(117, 51);
            this.btnDeleteSpecialization.Name = "btnDeleteSpecialization";
            this.btnDeleteSpecialization.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteSpecialization.TabIndex = 3;
            this.btnDeleteSpecialization.Text = "حذف";
            this.btnDeleteSpecialization.UseVisualStyleBackColor = true;
            this.btnDeleteSpecialization.Click += new System.EventHandler(this.btnDeleteSpecialization_Click);
            // 
            // SpecializationManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 275);
            this.Controls.Add(this.btnDeleteSpecialization);
            this.Controls.Add(this.txtboxSpecialization);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddSpecialization);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SpecializationManagementForm";
            this.Text = "مدیریت تخصص ها";
            this.Load += new System.EventHandler(this.SpecializationManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._TheDuckingDocs_Model1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private _TheDuckingDocs_Model1DataSet _TheDuckingDocs_Model1DataSet;
        private System.Windows.Forms.BindingSource specializationsBindingSource;
        private _TheDuckingDocs_Model1DataSetTableAdapters.SpecializationsTableAdapter specializationsTableAdapter;
        private System.Windows.Forms.Button btnAddSpecialization;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxSpecialization;
        private System.Windows.Forms.DataGridViewTextBoxColumn specializationIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnDeleteSpecialization;
    }
}