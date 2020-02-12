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
    public partial class ucOrganization : UserControl
    {

        OrganizationsDal organizationCrud;
        Organization _organization;
        public ucOrganization()
        {
            InitializeComponent();
            organizationCrud = new OrganizationsDal();
        }

        private void ucOrganization_Load(object sender, EventArgs e)
        {
            dgwOrganizations.DataSource = organizationCrud.GetAll();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

          Organization organization = new Organization();
            organization.Name = txtName.Text;
            organization.Status = Convert.ToInt32(txtStatus.Text);
            organizationCrud.Insert(organization);

            ucOrganization_Load(null, null);
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (_organization != null)
            {
                _organization.Name = txtName.Text;
                _organization.Status = Convert.ToInt32(txtStatus.Text);
                organizationCrud.Update(_organization);

                ucOrganization_Load(null, null);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (_organization != null)
            {
                organizationCrud.Delete(_organization.Id);
                ucOrganization_Load(null, null);
            }
        }

        private void dgwOrganizations_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            int rowIndex = e.RowIndex;
            DataGridViewRow row = dgwOrganizations.Rows[rowIndex];
            var organization = (OrganizationViewModel)row.DataBoundItem;

            _organization = organizationCrud.GetById(organization.Id);

            txtName.Text = _organization.Name;
            txtStatus.Text = Convert.ToString(_organization.Status);
          
      
        }

    }
}