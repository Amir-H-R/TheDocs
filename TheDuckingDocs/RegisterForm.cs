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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            UserDto userDto = new UserDto()
            {
                Name = txtboxName.Text,
                LastName = txtboxLastName.Text,
                Age = int.Parse(txtboxAge.Text),
                IdCardNumebr = txtboxIdCardNum.Text,
                PhoneNumber = txtboxPhoneNum.Text,
                Password = txtboxPassword.Text,
                RePassword = txtboxRePassword.Text,
                Username = txtboxUsername.Text,
                Roles = new List<Role> { new Role { Name="User"} }
            };

            Model1 model = new Model1();
            AddUserService addUser = new AddUserService(model);
            ResultDto result = addUser.Execute(userDto);
            MessageBox.Show(result.Message);
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var loginForm = Application.OpenForms.Cast<Form>().FirstOrDefault(p => p is LoginForm);
            if (loginForm != null)
            {
                loginForm.Show();
            }
            //LoginForm loginForm = new LoginForm();
            //loginForm.Show();
        }
    }
}
