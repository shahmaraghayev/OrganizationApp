using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrganizationDal.DAL;
using OrganizationDal.Domain;
using OrganizationDal.ViewModel;

namespace OrganizationApp.Controls
{
    public partial class ucPersonnel : UserControl
    {
       PersonnelsDal personnelCrud;
        CommonDal common;
       Personnel _personnel;
        public ucPersonnel()
        {
            InitializeComponent();
            personnelCrud = new PersonnelsDal();
            common = new CommonDal();
            cbDepartment.DataSource = common.GetDepartmentsByIdName();
            cbDepartment.SelectedIndex = -1;
            cbOrganization.DataSource = common.GetOrganizationsByIdName();
            cbOrganization.SelectedIndex = -1;

        }

        private void ucPersonnel_Load(object sender, EventArgs e)
        {
            dgwPersonnels.DataSource = personnelCrud.GetAll();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

           Personnel personnel = new Personnel();
            personnel.Name = txtName.Text;
            personnel.Surname = txtSurname.Text;
            personnel.Email = txtEmail.Text;
            personnel.OrganizationId = Convert.ToInt32(cbOrganization.SelectedValue);
            personnel.DepartmentId = Convert.ToInt32(cbDepartment.SelectedValue);
            personnel.Status = Convert.ToInt32(txtStatus.Text);
            personnelCrud.Insert(personnel);
            ucPersonnel_Load(null, null);
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (_personnel != null)
            {
                _personnel.Name = txtName.Text;
                _personnel.Status = Convert.ToInt32(txtStatus.Text);
                _personnel.Email = txtEmail.Text;
                _personnel.Surname = txtSurname.Text;
                 personnelCrud.Update(_personnel);
                 ucPersonnel_Load(null, null);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (_personnel != null)
            {
               personnelCrud.Delete(_personnel.Id);
                ucPersonnel_Load(null, null);
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;

            DataGridViewRow row = dgwPersonnels.Rows[rowIndex];

            var personnel = (PersonnelViewModel)row.DataBoundItem;

            _personnel = personnelCrud.GetById(personnel.Id);

            txtName.Text = _personnel.Name;
            txtSurname.Text = _personnel.Surname;
            txtEmail.Text = _personnel.Email;
            cbDepartment.SelectedValue = _personnel.DepartmentId;
            cbOrganization.SelectedValue = _personnel.OrganizationId;
            txtStatus.Text = Convert.ToString(_personnel.Status);

        }

    }
}
