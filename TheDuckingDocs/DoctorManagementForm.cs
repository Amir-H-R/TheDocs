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

namespace TheDuckingDocs
{
    public partial class DoctorManagementForm : Form
    {
        IModel1 model1 = new Model1();
        public DoctorManagementForm()
        {
            InitializeComponent();
        }

        private void DoctorManagementForm_Load(object sender, EventArgs e)
        {
            var people = model1.People.Include(p => p.PeopleRoles).ToList();
            var docs = people.Where(p=>p.PeopleRoles.Any(i=>i.RoleId==4)).ToList();
          
            dataGridView1.DataSource = docs;
            // TODO: This line of code loads data into the '_TheDuckingDocs_Model1DataSet.People' table. You can move, or remove it, as needed.
           // this.peopleTableAdapter.Fill(this._TheDuckingDocs_Model1DataSet.People);
            // TODO: This line of code loads data into the '_TheDuckingDocs_Model1DataSet.Doctors' table. You can move, or remove it, as needed.
            //this.doctorsTableAdapter.Fill(this._TheDuckingDocs_Model1DataSet.Doctors);

        }
    }
}
