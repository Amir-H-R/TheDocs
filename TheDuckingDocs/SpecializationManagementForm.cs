using Persistance.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Persistance.Entities;

namespace TheDuckingDocs
{
    public partial class SpecializationManagementForm : Form
    {
        IModel1 model = new Model1();
        int? id = null;
        public SpecializationManagementForm()
        {
            this.Icon = Properties.Resources.hospital_icon_7294_Windows;
            InitializeComponent();
        }

        private void SpecializationManagementForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_TheDuckingDocs_Model1DataSet.Specializations' table. You can move, or remove it, as needed.
            this.specializationsTableAdapter.Fill(this._TheDuckingDocs_Model1DataSet.Specializations);

        }

        private void btnAddSpecialization_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtboxSpecialization.Text, out int result))
            {
                model.Specializations.Add(new Specialization
                {
                    Name = txtboxSpecialization.Text,
                });
                model.SaveChanges();
                this.specializationsTableAdapter.Fill(this._TheDuckingDocs_Model1DataSet.Specializations);
            }
            else
            {
                MessageBox.Show("لطفا نام تخصص را درست وارد کنید");
            }
        }

        private void btnDeleteSpecialization_Click(object sender, EventArgs e)
        {
            if (id == null )
                MessageBox.Show("لطفا یک ردیف را انتخاب کنید");
            else
            {
                var dialogResult = MessageBox.Show("آیا از حذف این گزینه مطمعن هستید؟", "حذف تخصص", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var specialization = model.Specializations.Where(p => p.SpecializationId == id).FirstOrDefault();
                    model.Specializations.Remove(specialization);
                    model.SaveChanges();
                    this.specializationsTableAdapter.Fill(this._TheDuckingDocs_Model1DataSet.Specializations);
                }
            }

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
        }
    }
}
