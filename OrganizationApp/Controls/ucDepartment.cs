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
    public partial class ucDepartment : UserControl
    {
        DepartmentsDal departmentCrud;
        Department _department;
        public ucDepartment()
        {
            InitializeComponent();
            departmentCrud = new DepartmentsDal();

            cbHeadDepartment.DataSource = departmentCrud.GetDepartmentsByIdName();
            cbHeadDepartment.SelectedIndex = -1;

            cbOrganization.DataSource = departmentCrud.GeOrganizationsByIdName();
            cbOrganization.SelectedIndex = -1;
        }

        private void ucDepartment_Load(object sender, EventArgs e)
        {
            dgwDepartments.DataSource = departmentCrud.GetAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Department department = new Department();
            department.Name = txtName.Text;
            department.Status = Convert.ToInt32(txtStatus.Text);
            department.OrganizationId =Convert.ToInt32(cbOrganization.SelectedValue);
            department.TopId = Convert.ToInt32(cbHeadDepartment.SelectedValue);
            departmentCrud.Insert(department);

            ucDepartment_Load(null, null);
        }

        private void dgwDepartments_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dgwDepartments.Rows[rowIndex];
            var department  = (DepartmentViewModel)row.DataBoundItem;

            _department = departmentCrud.GetById(department.Id);

            txtName.Text = _department.Name;
            txtStatus.Text = Convert.ToString(_department.Status);
            cbHeadDepartment.SelectedValue = _department.TopId;
            cbOrganization.SelectedValue = _department.OrganizationId;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_department != null)
            {
                departmentCrud.Delete(_department.Id);
                ucDepartment_Load(null, null);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_department != null)
            {
                _department.Name = txtName.Text;
                _department.Status = Convert.ToInt32(txtStatus.Text);
                _department.OrganizationId = Convert.ToInt32(cbOrganization.SelectedValue);
                _department.TopId = Convert.ToInt32(cbHeadDepartment.SelectedValue);
                departmentCrud.Update(_department);

                ucDepartment_Load(null, null);
            }
        }
    }
}
