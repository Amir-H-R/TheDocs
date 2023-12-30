using Persistance.Common;
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
    public partial class MainForm : Form
    {
        IModel1 model1 = new Model1();
        public MainForm()
        {
            this.Icon = Properties.Resources.hospital_icon_7294_Windows;
            InitializeComponent();
        }

        public bool ManagementVisibility
        {
            get { return toolStripItemManagement.Visible; }
            set { toolStripItemManagement.Visible = value; }
        }
        public bool DocsManagementVisibility
        {
            get { return toolStripItemDocsManagement.Visible; }
            set { toolStripItemDocsManagement.Visible = value; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripItemRgister_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
            if (Settings.Default.Username != null)
            {
                Settings.Default.Username = null;
                Settings.Default.Password = null;
                Settings.Default.Save();
            }
        }

        private void toolStripItemManagement_Click(object sender, EventArgs e)
        {
            ManagementForm managementForm = new ManagementForm();
            managementForm.ShowDialog();
        }

        private void toolStripItemDocsManagement_Click(object sender, EventArgs e)
        {
            DoctorManagementForm form = new DoctorManagementForm();
            form.ShowDialog();
        }

        private void toolStripItemAppointmentsManagement_Click(object sender, EventArgs e)
        {
            AppointmentManagement appointments = new AppointmentManagement();
            appointments.ShowDialog();
        }

        private void toolStripItemReservation_Click(object sender, EventArgs e)
        {
            var username = Settings.Default.Username;
            var user = model1.People.Where(p => p.UserName == username).FirstOrDefault();
            var patient = model1.Patients.Where(p => p.PatientInfo.UserName == user.UserName).FirstOrDefault();
            if (user != null)
            {
                if (model1.Patients.Where(p => p.PatientInfo.UserName == user.UserName).FirstOrDefault() == null)
                {
                    PatientInfoForm form = new PatientInfoForm();
                    form.ShowDialog();
                }
                else
                {
                    AppointmentReservationForm form = new AppointmentReservationForm();
                    form.ShowDialog();
                }
            }
        }

        private void toolStripItemDoctors_Click(object sender, EventArgs e)
        {
            DoctorsListForm doctorsList = new DoctorsListForm();
            doctorsList.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ToBeAddedForm form = new ToBeAddedForm();
            form.ShowDialog();
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            ToBeAddedForm form = new ToBeAddedForm();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AboutUsForm form = new AboutUsForm();
            form.ShowDialog();
        }

        private void toolStripItemNews_Click(object sender, EventArgs e)
        {
            ToBeAddedForm form = new ToBeAddedForm();
            form.ShowDialog();
        }
    }
}
