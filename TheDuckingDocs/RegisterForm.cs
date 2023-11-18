using Persistance.Entities;
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
            Model1 model = new Model1();
            Role role = model.Roles.Where(p => p.Name == "User").FirstOrDefault();
            Person person = new Person()
            {
                Name = txtboxName.Text,
                LastName = txtboxLastName.Text,
                Age = int.Parse(txtboxAge.Text),
                PhoneNumber = txtboxPhoneNum.Text,
                UserName = txtboxUsername.Text,
                Password = txtboxPassword.Text,
                IdCardNumber = txtboxIdCardNum.Text,
            };
            ICollection<PeopleRoles> roles = new List<PeopleRoles>();
            roles.Add(new PeopleRoles()
            {
                RoleId = role.RoleId,
                Role = role,
                PersonId = person.PersonId,
                Person = person,
            });
            person.PeopleRoles = roles;
            model.People.Add(person);
            model.SaveChanges();
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
