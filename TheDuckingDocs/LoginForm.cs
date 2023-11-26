using Persistance.Common;
using Persistance.Entities;
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
using TheDuckingDocs.Properties;

namespace TheDuckingDocs
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MainForm mainForm1 = new MainForm();
            IModel1 model = new Model1();
            Person user = model.People.Include(p => p.PeopleRoles).Where(p => p.UserName == txtboxUsername.Text && p.Password == txtboxPassword.Text).FirstOrDefault();
            if (user != null)
            {
                if (chckbxRememberMe.Checked)
                {
                    Settings.Default.Username = txtboxUsername.Text;
                    Settings.Default.Password = txtboxUsername.Text;
                    Settings.Default.Save();
                }
                if (user.PeopleRoles.FirstOrDefault().RoleId == 1)
                {
                    mainForm1.ManagementVisibility = true;
                }
                this.Hide();
                mainForm1.ShowDialog();
                this.Close();
            }

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (Settings.Default.Username != null)
            {
                txtboxUsername.Text = Settings.Default.Username;
                txtboxPassword.Text = Settings.Default.Password;
            }
        }
    }
}
