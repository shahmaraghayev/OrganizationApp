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
    public partial class ucUsersRoles : UserControl
    {
       
        CommonDal common;
        UsersRolesDal _userRoleDal;
        UserRole _userRole;

        public ucUsersRoles()
        {
           
            InitializeComponent();
            _userRoleDal = new UsersRolesDal();
            common = new CommonDal();
            cbUsers.DataSource = common.GetUsersByIdName();
            cbUsers.SelectedIndex = -1;
            cbRoles.DataSource = common.GetRolesByIdName();
            cbRoles.SelectedIndex = -1;
        }

        private void dgwUserRole_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dgwUsersRoles.Rows[rowIndex];
            var usersR = (UserRoleViewModel)row.DataBoundItem;

            _userRole = _userRoleDal.GetById(usersR.Id);

            cbUsers.SelectedValue = _userRole.UserId;
            cbRoles.SelectedValue = _userRole.RoleId;
      
        }

        private void ucUsersRoles_Load(object sender, EventArgs e)
        {
            dgwUsersRoles.DataSource = _userRoleDal.GetAll();
        }

        private void btnİnsert_Click(object sender, EventArgs e)
        {
            UserRole userRole = new UserRole();
            userRole.UserId = Convert.ToInt32(cbUsers.SelectedValue);
            userRole.RoleId = Convert.ToInt32(cbRoles.SelectedValue);
            _userRoleDal.Insert(userRole);
            ucUsersRoles_Load(null, null);
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (_userRole != null)
            {
                _userRole.UserId = Convert.ToInt32(cbUsers.SelectedValue);
                _userRole.RoleId = Convert.ToInt32(cbRoles.SelectedValue);
                _userRoleDal.Update(_userRole);
                ucUsersRoles_Load(null, null);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_userRole != null)
            {
                _userRoleDal.Delete(_userRole.Id);
                ucUsersRoles_Load(null, null);
            }
        }
    }
}
