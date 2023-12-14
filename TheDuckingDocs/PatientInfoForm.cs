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
using TheDuckingDocs.Properties;

namespace TheDuckingDocs
{
    public partial class PatientInfoForm : Form
    {
        IModel1 model1 = new Model1();
        Person user;
        public PatientInfoForm()
        {
            InitializeComponent();
        }

        private void PatientInfoForm_Load(object sender, EventArgs e)
        {
            var username = Settings.Default.Username;
             user = model1.People.Where(p => p.UserName == username).FirstOrDefault();
            txtboxName.Text = user.Name;
            txtboxLastName.Text = user.LastName;
            txtboxPassword.Text = user.Password;
            txtboxIdCardNum.Text = user.IdCardNumber;
            txtboxPhoneNum.Text = user.PhoneNumber;
            txtboxAge.Value = user.Age;
            txtboxUsername.Text = user.UserName;
            var patientInfo = model1.Patients.Where(p => p.PatientInfo.UserName == user.UserName).FirstOrDefault();
            if (patientInfo != null)
            {
                //txtboxAddress = patientInfo.PersonAddress
            }
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            EditUserService userService = new EditUserService(model1);
            userService.Execute(new UserDto
            {
                Id = user.PersonId,
                Age = (int)txtboxAge.Value,
                Name = txtboxName.Text,
                LastName = txtboxLastName.Text,
                Password = txtboxPassword.Text,
                RePassword = txtboxPassword.Text,
                IdCardNumber = txtboxIdCardNum.Text,
                PhoneNumber = txtboxPhoneNum.Text,
                Username = txtboxUsername.Text
            });
            
            Patient patient = new Patient() 
            {
                Address = txtboxAddress.Text,
                BirthDate = datetimeBirthDate.Value,
                PatientInfo = user,
                PatientId = user.PersonId
            };
            model1.Patients.Add(patient);
            model1.SaveChanges();
            MessageBox.Show("اطلاعات با موفقیت ثبت شد");
            this.Close();
        }
    }
}
