using Persistance.Common;
using Persistance.Entities;
using Persistance.Services.UserServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheDuckingDocs.Properties;

namespace TheDuckingDocs
{
    public partial class AppointmentReservationForm : Form
    {
        IModel1 model1 = new Model1();
        int Id;
        public AppointmentReservationForm()
        {
            this.Icon = Properties.Resources.hospital_icon_7294_Windows;
            InitializeComponent();
        }
        public AppointmentReservationForm(int id)
        {
            this.Icon = Properties.Resources.hospital_icon_7294_Windows;
            Id = id;
            InitializeComponent();
        }

        private void GetUserAppointments()
        {
            var username = Settings.Default.Username;
            var patient = model1.Patients.Where(p => p.PatientInfo.UserName == username).FirstOrDefault();
            var userAppointments = model1.Appointments.Where(p => p.PatientId == patient.PatientId).Select(p => new
            {
                DoctorName = p.Doctor.DoctorInfo.Name,
                AppointmentDate = p.AppointmentDate,
                Status = p.Status
            }).ToList();
            dataGridView1.DataSource = userAppointments;
        }

        private void AppointmentReservationForm_Load(object sender, EventArgs e)
        {
            datetimeAppointment.Format = DateTimePickerFormat.Custom;
            datetimeAppointment.CustomFormat = "dd/MM/yyyy hh:mm";

            var doctor = model1.Doctors.Where(p => p.DoctorId == Id).Select(p => new
            {
                DoctorId = p.DoctorId,
                Name = p.DoctorInfo.Name
            }).ToList();
            var doctors = model1.Doctors.Select(p => new
            {
                DoctorId = p.DoctorId,
                Name = p.DoctorInfo.Name
            }).ToList();
            if (doctor.Count != 0)
            {
                cmboxDoctors.DataSource = doctor;
            }
            else
            {
                cmboxDoctors.DataSource = doctors;
            }
            GetUserAppointments();
        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            AddAppointmentService service = new AddAppointmentService(model1);
            var username = Settings.Default.Username;
            var patient = model1.Patients.FirstOrDefault(p => p.PatientInfo.UserName == username);
            var results = service.Execute(new Appointment
            {
                AppointmentDate = datetimeAppointment.Value,
                DoctorId = (int)cmboxDoctors.SelectedValue,
                PatientId = patient.PatientId,
                Status = Status.Active,
            });
            MessageBox.Show(results.Message);
            GetUserAppointments();
        }

        private void btnSearchDoctor_Click(object sender, EventArgs e)
        {
            var doctorName = txtboxDoctor.Text;
            int doctorId;
            int.TryParse(txtboxDoctor.Text, out doctorId);
            var doctor = model1.Doctors.Where(p => p.DoctorInfo.Name == doctorName || p.DoctorId == doctorId).Select(p => new
            {
                DoctorId = p.DoctorInfo.PersonId,
                Name = p.DoctorInfo.Name
            }).ToList();
            if (doctor != null)
            {
                //cmboxPatients.Items.Clear();
                cmboxDoctors.DataSource = doctor;
                cmboxDoctors.ValueMember = "DoctorId";
                cmboxDoctors.DisplayMember = "Name";
            }
            else
            {
                MessageBox.Show(" دکتر مورد نظر پیدا نشد");
            }
        }

        private void cmboxDoctors_SelectedIndexChanged(object sender, EventArgs e)
        {
            var docId = cmboxDoctors.SelectedValue;
            var doc = model1.Doctors.Where(p => p.DoctorId == (int)docId).FirstOrDefault();

            //reseting the DateTimePicker values
            datetimeAppointment.MinDate = new DateTime(1753, 01, 01);
            datetimeAppointment.MaxDate = new DateTime(9998, 12, 31);

            datetimeAppointment.MinDate = doc.StartTime;
            datetimeAppointment.MaxDate = doc.EndTime;
        }
    }
}
