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
    public partial class ManagementForm : Form
    {
        IModel1 model = new Model1();
        public ManagementForm()
        {
            this.Icon = Properties.Resources.hospital_icon_7294_Windows;
            InitializeComponent();
        }
        int id;
        private void FillUserRolesListBox()
        {
            lstboxRoles.Items.Clear();

            var roles = model.PeopleRoles.Where(p => p.PersonId == id).ToList();
            foreach (var item in roles)
            {
                var role = model.Roles.Where(p => p.RoleId == item.RoleId).FirstOrDefault().Name;
                lstboxRoles.Items.Add(role);
            }
        }
        private void ClearFields()
        {
            id = 0;
            txtboxName.Text = "";
            txtboxLastName.Text = "";
            txtboxAge.Value = 0;
            txtboxPhoneNum.Text = "";
            txtboxUsername.Text = "";
            txtboxPassword.Text = "";
            txtboxIdCardNum.Text = "";
            lstboxRoles.Items.Clear();
        }
        private void ManagementForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_TheDuckingDocs_Model1DataSet.Roles' table. You can move, or remove it, as needed.
            this.rolesTableAdapter.Fill(this._TheDuckingDocs_Model1DataSet.Roles);
            IModel1 model = new Model1();
            // TODO: This line of code loads data into the '_TheDuckingDocs_Model1DataSet.People' table. You can move, or remove it, as needed.
            this.peopleTableAdapter.Fill(this._TheDuckingDocs_Model1DataSet.People);
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            var selectedRole = cmboxRoles.SelectedItem;

            UserDto person = new UserDto()
            {
                Name = txtboxName.Text,
                LastName = txtboxLastName.Text,
                IdCardNumber = txtboxIdCardNum.Text,
                Password = txtboxPassword.Text,
                RePassword = txtboxPassword.Text,
                Username = txtboxUsername.Text,
                PhoneNumber = txtboxPhoneNum.Text,
                Age = (int)txtboxAge.Value,
                Roles = new List<Role> { new Role { RoleId = (int)cmboxRoles.SelectedValue } }
            };
            AddUserService addUserService = new AddUserService(model);
            ResultDto<Person> result = addUserService.Execute(person);
            MessageBox.Show(result.Message);
            this.peopleTableAdapter.Fill(this._TheDuckingDocs_Model1DataSet.People);

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
            FillUserRolesListBox();
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            EditUserService userService = new EditUserService(model);

            UserDto userDto = new UserDto()
            {
                Id = id,
                Name = txtboxName.Text,
                LastName = txtboxLastName.Text,
                IdCardNumber = txtboxIdCardNum.Text,
                Password = txtboxPassword.Text,
                RePassword = txtboxPassword.Text,
                Username = txtboxUsername.Text,
                PhoneNumber = txtboxPhoneNum.Text,
                Age = (int)txtboxAge.Value
            };
            var result = userService.Execute(userDto);
            MessageBox.Show(result.Message);
            this.peopleTableAdapter.Fill(this._TheDuckingDocs_Model1DataSet.People);
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("از حذف این کاربر مطمعن هستید؟", "حذف کاربر", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DeleteUserService userService = new DeleteUserService(model);
                var result = userService.Execute(id);
                MessageBox.Show(result.Message);
                this.peopleTableAdapter.Fill(this._TheDuckingDocs_Model1DataSet.People);
            }
        }

        private void btnAddRole_Click(object sender, EventArgs e)
        {
            var user = model.People.Where(p => p.PersonId == id).FirstOrDefault();
            if (user != null)
            {
                var selectedRole = (int)cmboxRoles.SelectedValue;
                var role = model.Roles.Where(p => p.RoleId == selectedRole).FirstOrDefault();
                PeopleRoles personRole = new PeopleRoles()
                {
                    Person = user,
                    PersonId = user.PersonId,
                    RoleId = role.RoleId,
                    Role = role
                };
                model.PeopleRoles.Add(personRole);
                model.SaveChanges();
                MessageBox.Show("نقش کاربر با موفقیت اضافه شد");

                //Add user as a doctor if the slected role is Doctor
                if (role.Name == "Doctor")
                {
                    Doctor doctor = new Doctor()
                    {
                        DoctorInfo = user,
                        StartTime = DateTime.Now,
                        EndTime = DateTime.Now,
                    };
                    model.Doctors.Add(doctor);
                    model.SaveChanges();
                }
                FillUserRolesListBox();
            }
            else
                MessageBox.Show("لطفا یک کاربر را انتخاب کنید");

        }

        private void btnDeleteRole_Click(object sender, EventArgs e)
        {

            var user = model.People.Where(p => p.PersonId == id).FirstOrDefault();
            if (user != null)
            {
                var dialogResult = MessageBox.Show("از حذف این نقش مطمعن هستید؟", "حذف نقش", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var selectedRole = lstboxRoles.SelectedItem.ToString();
                    var role = model.Roles.Where(p => p.Name == selectedRole).FirstOrDefault();
                    var personRole = model.PeopleRoles.Where(p => p.PersonId == user.PersonId && p.RoleId == role.RoleId).FirstOrDefault();
                    model.PeopleRoles.Remove(personRole);
                    model.SaveChanges();
                    FillUserRolesListBox();
                    MessageBox.Show("نقش کاربر با موفقیت حذف شد");
                }
            }
            else
                MessageBox.Show("لطفا یک کاربر را انتخاب کنید");

        }
    }
}
