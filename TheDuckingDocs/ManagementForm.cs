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
    public partial class ManagementForm : Form
    {
        public ManagementForm()
        {
            InitializeComponent();
        }
        int Id;
        private void ClearFields()
        {
            Id = 0;
            txtboxName.Text = "";
            txtboxLastName.Text = "";
            txtboxAge.Value = 0;
            txtboxPhoneNum.Text = "";
            txtboxUsername.Text = "";
            txtboxPassword.Text = "";
            txtboxIdCardNum.Text = "";

        }
        private void ManagementForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_TheDuckingDocs_Model1DataSet.People' table. You can move, or remove it, as needed.
            this.peopleTableAdapter.Fill(this._TheDuckingDocs_Model1DataSet.People);
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            Person person = new Person()
            {

            };
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            txtboxName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value as string;
            txtboxLastName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value as string;
            txtboxAge.Value = (int)dataGridView1.Rows[e.RowIndex].Cells[3].Value;
            txtboxPhoneNum.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value as string;
            txtboxUsername.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value as string;
            txtboxPassword.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value as string;
            txtboxIdCardNum.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value as string;
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
