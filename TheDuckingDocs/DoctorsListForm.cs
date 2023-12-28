using Persistance.Common;
using Persistance.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheDuckingDocs
{
    public partial class DoctorsListForm : Form
    {
        IModel1 model1 = new Model1();
        int? Id;
        public DoctorsListForm()
        {
            this.Icon = Properties.Resources.hospital_icon_7294_Windows;
            InitializeComponent();
        }
        private void FillSpecialization()
        {
            model1 = new Model1();

            var doctor = model1.Doctors.Include(p => p.DoctorInfo).Where(p => p.DoctorId == Id).FirstOrDefault();
            if (doctor != null)
            {
                var specializations = model1.DoctorSpecializations.Where(p => p.DoctorId == doctor.DoctorId).ToList();
                lstboxSpecializations.Items.Clear();
                foreach (var item in specializations)
                {
                    var specialization = model1.Specializations.Where(p => p.SpecializationId == item.SpecializationId).FirstOrDefault();
                    lstboxSpecializations.Items.Add(specialization.Name);
                }
            }
        }
        private void DoctorsListForm_Load(object sender, EventArgs e)
        {
            var doctors = model1.Doctors.Select(p => new
            {
                Id = p.DoctorId,
                DoctorName = p.DoctorInfo.Name,
                StartDate = p.StartTime,
                Enddate = p.EndTime,

            }).ToList();
            dataGridView1.DataSource = doctors;

            var specializations = model1.Specializations.ToList();
            cmboxSpecializations.DataSource = specializations;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;

            FillSpecialization();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var selectedSpecializations = cmboxSpecializations.SelectedValue.ToString();
            var specialization = model1.Specializations.Where(p => p.Name == selectedSpecializations).FirstOrDefault();

            var doctors = model1.Doctors.Include(p => p.DoctorSpecializations).ToList();
            var doctorsWithSpecialization = new List<Doctor>();
            foreach (var doctor in doctors)
            {
                var doc = doctor.DoctorSpecializations.Where(p => p.SpecializationId == specialization.SpecializationId).FirstOrDefault();
                if (doc != null)
                    doctorsWithSpecialization.Add(doc.Doctor);
            }

            dataGridView1.DataSource = doctorsWithSpecialization.Select(p => new
            {
                Id = p.DoctorId,
                DoctorName = p.DoctorInfo.Name,
                StartDate = p.StartTime,
                Enddate = p.EndTime,

            }).ToList();
        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            var doctor = model1.Doctors.FirstOrDefault(p => p.DoctorId == Id);
            AppointmentReservationForm reservationForm = new AppointmentReservationForm(doctor.DoctorId);
            reservationForm.ShowDialog();
        }
    }
}
