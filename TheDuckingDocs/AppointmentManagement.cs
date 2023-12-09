using Persistance.Common;
using Persistance.Entities;
using Persistance.Entities.Dtos;
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

namespace TheDuckingDocs
{
    public partial class AppointmentManagement : Form
    {
        IModel1 model1 = new Model1();
        int id;
        public AppointmentManagement()
        {
            InitializeComponent();
        }
        public AppointmentManagement(int doctorId)
        {
            id = doctorId;
            InitializeComponent();
        }

        private void AppointmentManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_TheDuckingDocs_Model1DataSet.Appointments' table. You can move, or remove it, as needed.
            this.appointmentsTableAdapter.Fill(this._TheDuckingDocs_Model1DataSet.Appointments);
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
            if (doctorAppointments != null)
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
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddAppointmentService appointmentService = new AddAppointmentService(model1);

            Appointment appointment = new Appointment()
            {
                AppointmentDate = datetimeAppointment.Value,
                DoctorId=(int)cmboxDoctors.SelectedValue,
                PatientId = (int)cmboxPatients.SelectedValue,
            };

            //appointmentService.Execute();
        }
    }
    public class ComboBoxItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
