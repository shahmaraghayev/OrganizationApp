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
    public partial class ucRoles : UserControl
    {
      RolesDal rolesCrud;
        CommonDal common;
      Role _role;
        public ucRoles()
        {
            InitializeComponent();
          rolesCrud = new RolesDal();
            common = new CommonDal();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;

            DataGridViewRow row = dgwRoles.Rows[rowIndex];

            var roles = (RolesViewModel)row.DataBoundItem;

            _role = rolesCrud.GetById(roles.Id);

            txtName.Text = _role.Name;
           

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Role role = new Role();
            role.Name = txtName.Text;
        
           rolesCrud.Insert(role);
            ucRoles_Load(null, null);
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (_role != null)
            {
                _role.Name = txtName.Text;
              rolesCrud.Update(_role);
                ucRoles_Load(null, null);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (_role != null)
            {
                rolesCrud.Delete(_role.Id);
                ucRoles_Load(null, null);
            }
        }

        private void ucRoles_Load(object sender, EventArgs e)
        {
            dgwRoles.DataSource = rolesCrud.GetAll();
        }
    }
}
