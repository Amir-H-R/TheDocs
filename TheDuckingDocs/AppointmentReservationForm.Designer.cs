﻿namespace TheDuckingDocs
{
    partial class AppointmentReservationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentReservationForm));
            this.datetimeAppointment = new System.Windows.Forms.DateTimePicker();
            this.btnSearchDoctor = new System.Windows.Forms.Button();
            this.txtboxDoctor = new System.Windows.Forms.TextBox();
            this.cmboxDoctors = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddAppointment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // datetimeAppointment
            // 
            this.datetimeAppointment.Location = new System.Drawing.Point(12, 123);
            this.datetimeAppointment.Name = "datetimeAppointment";
            this.datetimeAppointment.Size = new System.Drawing.Size(201, 20);
            this.datetimeAppointment.TabIndex = 12;
            // 
            // btnSearchDoctor
            // 
            this.btnSearchDoctor.Location = new System.Drawing.Point(118, 53);
            this.btnSearchDoctor.Name = "btnSearchDoctor";
            this.btnSearchDoctor.Size = new System.Drawing.Size(75, 23);
            this.btnSearchDoctor.TabIndex = 11;
            this.btnSearchDoctor.Text = "جستجو";
            this.btnSearchDoctor.UseVisualStyleBackColor = true;
            this.btnSearchDoctor.Click += new System.EventHandler(this.btnSearchDoctor_Click);
            // 
            // txtboxDoctor
            // 
            this.txtboxDoctor.Location = new System.Drawing.Point(12, 53);
            this.txtboxDoctor.Name = "txtboxDoctor";
            this.txtboxDoctor.Size = new System.Drawing.Size(100, 20);
            this.txtboxDoctor.TabIndex = 10;
            // 
            // cmboxDoctors
            // 
            this.cmboxDoctors.DisplayMember = "Name";
            this.cmboxDoctors.FormattingEnabled = true;
            this.cmboxDoctors.Location = new System.Drawing.Point(12, 26);
            this.cmboxDoctors.Name = "cmboxDoctors";
            this.cmboxDoctors.Size = new System.Drawing.Size(181, 21);
            this.cmboxDoctors.TabIndex = 9;
            this.cmboxDoctors.ValueMember = "DoctorId";
            this.cmboxDoctors.SelectedIndexChanged += new System.EventHandler(this.cmboxDoctors_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "تاریخ مراجعه";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "دکتر";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(336, 150);
            this.dataGridView1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "نوبت های کاربر";
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.Location = new System.Drawing.Point(15, 149);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(75, 23);
            this.btnAddAppointment.TabIndex = 16;
            this.btnAddAppointment.Text = "ثبت";
            this.btnAddAppointment.UseVisualStyleBackColor = true;
            this.btnAddAppointment.Click += new System.EventHandler(this.btnAddAppointment_Click);
            // 
            // AppointmentReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(361, 450);
            this.Controls.Add(this.btnAddAppointment);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datetimeAppointment);
            this.Controls.Add(this.btnSearchDoctor);
            this.Controls.Add(this.txtboxDoctor);
            this.Controls.Add(this.cmboxDoctors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AppointmentReservationForm";
            this.Text = "ثبت نوبت";
            this.Load += new System.EventHandler(this.AppointmentReservationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datetimeAppointment;
        private System.Windows.Forms.Button btnSearchDoctor;
        private System.Windows.Forms.TextBox txtboxDoctor;
        private System.Windows.Forms.ComboBox cmboxDoctors;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddAppointment;
    }
}