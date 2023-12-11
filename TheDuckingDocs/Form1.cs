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
        public MainForm()
        {
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

        }
    }
}
