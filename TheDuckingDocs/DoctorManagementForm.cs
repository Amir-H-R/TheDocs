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
        int? id = null;
        IModel1 model1 = new Model1();
        public DoctorManagementForm()
        {
            InitializeComponent();
        }
        private void FillDGV()
        {
            model1 = new Model1();
            var people = model1.People.Include(p => p.PeopleRoles).ToList();
            var docs = people.Where(p => p.PeopleRoles.Any(i => i.RoleId == 4)).ToList();

            dataGridView1.DataSource = docs;
        }
        private void FillSpecialization()
        {
            model1 = new Model1();

            var doctor = model1.Doctors.Include(p => p.DoctorInfo).Where(p => p.DoctorInfo.PersonId == id).FirstOrDefault();
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
        private void ClearFields()
        {
            id = null;
            txtboxName.Text = "";
            txtboxLastName.Text = "";
            txtboxAge.Value = 0;
            txtboxPhoneNum.Text = "";
            txtboxUsername.Text = "";
            txtboxPassword.Text = "";
            txtboxIdCardNum.Text = "";
            datetimeStartDate.Value = DateTime.Now;
            datetimeEndDate.Value = DateTime.Now;
            lstboxSpecializations.Items.Clear();
            lstboxSpecializations.Items.Add("لطفا یک ردیف را انتخاب کنید");
        }
        private void DoctorManagementForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_TheDuckingDocs_Model1DataSet.Appointments' table. You can move, or remove it, as needed.
            this.appointmentsTableAdapter.Fill(this._TheDuckingDocs_Model1DataSet.Appointments);
            // TODO: This line of code loads data into the '_TheDuckingDocs_Model1DataSet.Specializations' table. You can move, or remove it, as needed.
            this.specializationsTableAdapter.Fill(this._TheDuckingDocs_Model1DataSet.Specializations);
            FillDGV();
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
            var doctor = model1.Doctors.Include(p => p.DoctorInfo).Where(p => p.DoctorInfo.PersonId == id).FirstOrDefault();
            if (doctor == null)
            {
                datetimeEndDate.Value = DateTime.Now;
                datetimeStartDate.Value = DateTime.Now;
            }
            else
            {
                datetimeEndDate.Value = doctor.EndTime;
                datetimeStartDate.Value = doctor.StartTime;
            }

            FillSpecialization();
        }

        private void toolStripItemSpecializations_Click(object sender, EventArgs e)
        {
            SpecializationManagementForm form = new SpecializationManagementForm();
            form.ShowDialog();
        }

        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            try
            {
                AddDoctorService addDoctorService = new AddDoctorService(model1);
                UserDto userDto = new UserDto()
                {
                    Name = txtboxName.Text,
                    LastName = txtboxLastName.Text,
                    Age = (int)txtboxAge.Value,
                    PhoneNumber = txtboxPhoneNum.Text,
                    IdCardNumber = txtboxIdCardNum.Text,
                    Username = txtboxUsername.Text,
                    Password = txtboxPassword.Text,
                    RePassword = txtboxPassword.Text,
                    Roles = new List<Role> { new Role { Name = "Doctor", RoleId = 4 } }
                };
                Doctor doctor = new Doctor()
                {
                    EndTime = datetimeEndDate.Value,
                    StartTime = datetimeStartDate.Value,
                };
                ICollection<Specialization> specializations = new List<Specialization>();
                int selectedSpecialization = (int)cmboxSpecializations.SelectedValue;
                Specialization specialization = model1.Specializations.Where(p => p.SpecializationId == selectedSpecialization).FirstOrDefault();
                specializations.Add(specialization);
                doctor.Specializations = specializations;

                ResultDto result = addDoctorService.Execute(userDto, doctor);
                MessageBox.Show(result.Message);
                FillDGV();
            }
            catch
            {
                MessageBox.Show("لطفا یک ردیف را انتخاب کنید");
            }
        }

        private void btnEditDoctor_Click(object sender, EventArgs e)
        {
            try
            {
                EditDoctorService doctorService = new EditDoctorService(model1);
                UserDto userDto = new UserDto
                {
                    Id = id.Value,
                    Name = txtboxName.Text,
                    LastName = txtboxLastName.Text,
                    Age = (int)txtboxAge.Value,
                    PhoneNumber = txtboxPhoneNum.Text,
                    IdCardNumber = txtboxIdCardNum.Text,
                    Username = txtboxUsername.Text,
                    Password = txtboxPassword.Text,
                    RePassword = txtboxPassword.Text
                };
                Doctor doctorDto = new Doctor
                {
                    EndTime = datetimeEndDate.Value,
                    StartTime = datetimeStartDate.Value,
                };
                var result = doctorService.Execute(userDto, doctorDto);
                MessageBox.Show(result.Message);
                FillDGV();
            }
            catch
            {
                MessageBox.Show("لطفا یک ردیف را انتخاب کنید");
            }
        }

        private void btnAddSpecialization_Click(object sender, EventArgs e)
        {
            try
            {
                AddSpecializationService specializationService = new AddSpecializationService(model1);

                var selectedSpecialization = cmboxSpecializations.SelectedValue;
                var specialization = model1.Specializations.FirstOrDefault(x => x.SpecializationId == (int)selectedSpecialization);
                var result = specializationService.Execute(id.Value, specialization);
                MessageBox.Show(result.Message);
                FillSpecialization();
            }
            catch
            {
                MessageBox.Show("لطفا یک ردیف را انتخاب کنید");
            }
        }

        private void btnDeleteSpecialization_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("از حذف این تخصص مطمعن هستید؟", "حذف تخصص", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var selectedSpecialization = lstboxSpecializations.SelectedItem;
                    var specialization = model1.Specializations.FirstOrDefault(x => x.Name == selectedSpecialization.ToString());
                    var doc = model1.Doctors.Where(p => p.DoctorInfo.PersonId == id.Value).FirstOrDefault();
                    var target = model1.DoctorSpecializations.Where(p => p.DoctorId == doc.DoctorId && p.SpecializationId == specialization.SpecializationId).FirstOrDefault();
                    model1.DoctorSpecializations.Remove(target);
                    model1.SaveChanges();
                    FillSpecialization();
                }
            }
            catch
            {
                MessageBox.Show("لطفا یک ردیف را انتخاب کنید");
            }
        }

        private void btnDeleteDoctor_Click(object sender, EventArgs e)
        {
            try
            {
                var dialogResult = MessageBox.Show("از حذف این دکتر مطمعن هستید؟", "حذف دکتر", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DeleteUserService userService = new DeleteUserService(model1);
                    var result = userService.Execute(id.Value);
                    MessageBox.Show(result.Message);
                    FillDGV();
                }
            }
            catch
            {
                MessageBox.Show("لطفا یک ردیف را انتخاب کنید");
            }
        }
        private void btnClearFields_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
