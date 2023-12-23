namespace TheDuckingDocs
{
    partial class DoctorsListForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lstboxSpecializations = new System.Windows.Forms.ListBox();
            this.btnAddAppointment = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtboxSpecializations = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(557, 243);
            this.dataGridView1.TabIndex = 0;
            // 
            // lstboxSpecializations
            // 
            this.lstboxSpecializations.FormattingEnabled = true;
            this.lstboxSpecializations.Location = new System.Drawing.Point(668, 23);
            this.lstboxSpecializations.Name = "lstboxSpecializations";
            this.lstboxSpecializations.Size = new System.Drawing.Size(120, 95);
            this.lstboxSpecializations.TabIndex = 28;
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.Location = new System.Drawing.Point(12, 273);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(75, 23);
            this.btnAddAppointment.TabIndex = 29;
            this.btnAddAppointment.Text = "ثبت نوبت";
            this.btnAddAppointment.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(365, 274);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 30;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtboxSpecializations
            // 
            this.txtboxSpecializations.Location = new System.Drawing.Point(446, 276);
            this.txtboxSpecializations.Name = "txtboxSpecializations";
            this.txtboxSpecializations.Size = new System.Drawing.Size(123, 20);
            this.txtboxSpecializations.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(702, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "تخصص های دکتر";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(455, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "جستجو بر اساس تخصص";
            // 
            // DoctorsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 318);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxSpecializations);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAddAppointment);
            this.Controls.Add(this.lstboxSpecializations);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DoctorsListForm";
            this.Text = "DoctorsListForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox lstboxSpecializations;
        private System.Windows.Forms.Button btnAddAppointment;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtboxSpecializations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}