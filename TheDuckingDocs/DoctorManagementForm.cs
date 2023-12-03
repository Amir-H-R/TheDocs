using Persistance.Common;
using Persistance.Entities;
using Persistance.Entities.Dtos;
using Persistance.Services.UserServices;
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
    public partial class DoctorManagementForm : Form
    {
        int? id=null;
        IModel1 model1 = new Model1();
        public DoctorManagementForm()
        {
            InitializeComponent();
        }

        private void DoctorManagementForm_Load(object sender, EventArgs e)
        {
            var people = model1.People.Include(p => p.PeopleRoles).ToList();
            var docs = people.Where(p => p.PeopleRoles.Any(i => i.RoleId == 4)).ToList();

            dataGridView1.DataSource = docs;
            // TODO: This line of code loads data into the '_TheDuckingDocs_Model1DataSet.People' table. You can move, or remove it, as needed.
            // this.peopleTableAdapter.Fill(this._TheDuckingDocs_Model1DataSet.People);
            // TODO: This line of code loads data into the '_TheDuckingDocs_Model1DataSet.Doctors' table. You can move, or remove it, as needed.
            //this.doctorsTableAdapter.Fill(this._TheDuckingDocs_Model1DataSet.Doctors);
            AppointmentManagement management = new AppointmentManagement(2);

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            txtboxName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value as string;
            txtboxLastName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value as string;
            txtboxAge.Value = (int)dataGridView1.Rows[e.RowIndex].Cells[3].Value;
            txtboxPhoneNum.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value as string;
            txtboxUsername.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value as string;
            txtboxPassword.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value as string;
            txtboxIdCardNum.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value as string;

            var doctor = model1.Doctors.Include(p=>p.DoctorInfo).Where(p=>p.DoctorId == id).FirstOrDefault();
            datetimeEndDate.Value = doctor.EndTime;
            datetimeStartDate.Value = doctor.StartTime;
        }

        private void toolStripItemSpecializations_Click(object sender, EventArgs e)
        {
            SpecializationManagementForm form = new SpecializationManagementForm();
            form.ShowDialog();
        }

        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            AddUserService userService = new AddUserService(model1);
            UserDto userDto = new UserDto() 
            {
                Name = txtboxName.Text,
                LastName = txtboxLastName.Text,
                Age = (int)txtboxAge.Value,
                PhoneNumber = txtboxPhoneNum.Text,
                IdCardNumebr= txtboxIdCardNum.Text,
                Username= txtboxUsername.Text,
                Password= txtboxPassword.Text,
                Roles = new List<Role> { new Role { Name= "Doctor",RoleId=4} }
            };
            userService.Execute(userDto);
        }
    }
}
