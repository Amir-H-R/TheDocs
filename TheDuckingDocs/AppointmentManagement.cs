using Persistance.Common;
using Persistance.Entities;
using Persistance.Entities.Dtos;
using Persistance.Services.UserServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheDuckingDocs
{
    public partial class AppointmentManagement : Form
    {
        IModel1 model1 = new Model1();
        int id;
        int appointmentId;
        public AppointmentManagement()
        {
            InitializeComponent();
        }
        public AppointmentManagement(int doctorId)
        {
            id = doctorId;
            InitializeComponent();
        }
        private void FillDGV()
        {
            var doc = model1.Doctors.Where(p => p.DoctorId == id).FirstOrDefault();
            if (doc != null)
            {
                datetimeAppointment.MinDate = doc.StartTime;
                datetimeAppointment.MaxDate = doc.EndTime;
            }

            datetimeAppointment.Format = DateTimePickerFormat.Custom;
            datetimeAppointment.CustomFormat = "dd/MM/yyyy hh:mm";

            model1 = new Model1();
            var doctorAppointments = model1.Appointments.Where(p => p.DoctorId == id).Select(p => new AppointmentDto
            {
                AppointmentId = p.AppointmentId,
                DoctorId = p.DoctorId,
                DoctorName = p.Doctor.DoctorInfo.Name,
                PatientId = p.PatientId,
                PatientName = p.Patient.PatientInfo.Name,
                Status = p.Status,
                AppointmentDate = p.AppointmentDate,
            }).ToList();
            var allAppointments = model1.Appointments.Select(p => new AppointmentDto
            {
                AppointmentId = p.AppointmentId,
                DoctorId = p.DoctorId,
                DoctorName = p.Doctor.DoctorInfo.Name,
                PatientId = p.PatientId,
                PatientName = p.Patient.PatientInfo.Name,
                Status = p.Status,
                AppointmentDate = p.AppointmentDate
            }).ToList();
            if (doctorAppointments.Count != 0)
                dataGridView1.DataSource = doctorAppointments;
            else
                dataGridView1.DataSource = allAppointments;

            var patients = model1.People.Select(p => new
            {
                PersonId = p.PersonId,
                Name = p.Name,
            }).ToList();
            cmboxPatients.DataSource = patients;
            cmboxPatients.ValueMember = "PersonId";
            cmboxPatients.DisplayMember = "Name";

            var doctors = model1.Doctors.Select(p => new
            {
                DoctorId = p.DoctorId,
                Name = p.DoctorInfo.Name
            }).ToList();

            cmboxDoctors.DataSource = doctors;
          //  cmboxDoctors.ValueMember = "DoctorId";
           // cmboxDoctors.DisplayMember = "Name";

            comboBox1.DataSource = Enum.GetValues(typeof(Status));

        }
        private void AppointmentManagement_Load(object sender, EventArgs e)
        {
            FillDGV();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Status status;
            Enum.TryParse(comboBox1.SelectedValue.ToString(), out status);
            AddAppointmentService appointmentService = new AddAppointmentService(model1);
            Appointment appointment = new Appointment()
            {
                AppointmentDate = datetimeAppointment.Value,
                DoctorId = (int)cmboxDoctors.SelectedValue,
                PatientId = (int)cmboxPatients.SelectedValue,
                Status = status
            };
            var result = appointmentService.Execute(appointment);
            MessageBox.Show(result.Message);
            FillDGV();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var docId = (int)dataGridView1.Rows[e.RowIndex].Cells[2].Value;
            var doc = model1.Doctors.Where(p=>p.DoctorId == docId).FirstOrDefault();
            appointmentId = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            datetimeAppointment.Value = (DateTime)dataGridView1.Rows[e.RowIndex].Cells[5].Value;
            datetimeAppointment.MinDate = doc.StartTime;
            datetimeAppointment.MaxDate = doc.EndTime;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("از حذف این نوبت مطمعن هستید؟", "حذف نوبت", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var appointment = model1.Appointments.Where(p => p.AppointmentId == appointmentId).FirstOrDefault();
                model1.Appointments.Remove(appointment);
                model1.SaveChanges();
                MessageBox.Show("نوبت حذف شد");
                FillDGV();
            }
        }

        private void cmboxDoctors_SelectedIndexChanged(object sender, EventArgs e)
        {
            var docId = cmboxDoctors.SelectedValue;
            var doc = model1.Doctors.Where(p=>p.DoctorId == (int)docId).FirstOrDefault();
            datetimeAppointment.MinDate=doc.StartTime;
            datetimeAppointment.MaxDate=doc.EndTime;
        }
    }
    public class ComboBoxItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
