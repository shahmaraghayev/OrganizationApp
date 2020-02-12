using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrganizationDal.ViewModel;
using OrganizationDal.DAL;
using OrganizationDal.Domain;

namespace OrganizationApp.Controls
{
    public partial class ucUsers : UserControl
    {
        CommonDal common;
        UsersDal usersCrud;
        User _users;
        public ucUsers()
        {
            InitializeComponent();
            usersCrud = new UsersDal();
            common = new CommonDal();
            cbPersonnel.DataSource = common.GetPersonnelsByIdName();
            cbPersonnel.SelectedIndex = -1;
        }

        private void dgwUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dgwUsers.Rows[rowIndex];
            var users = (UsersViewModel)row.DataBoundItem;

            _users = usersCrud.GetById(users.Id);

            txtName.Text = _users.Name;
            txtPassword.Text = _users.Password;
            txtStatus.Text = Convert.ToString(_users.Status);
            cbPersonnel.SelectedValue = _users.PersonnelId;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
           User user = new User();
            user.Name = txtName.Text;
            user.Password= txtPassword.Text;
            user.PersonnelId = Convert.ToInt32(cbPersonnel.SelectedValue);
            user.Status = Convert.ToInt32(txtStatus.Text);
            usersCrud.Insert(user);
            ucUsers_Load(null, null);
        }

        private void btnChange_Click(object sender, EventArgs e)
        {

            if (_users != null)
            {
                _users.Name = txtName.Text;
                _users.Status = Convert.ToInt32(txtStatus.Text);
                _users.Password = txtPassword.Text;
                _users.PersonnelId = Convert.ToInt32(cbPersonnel.SelectedValue);
                 usersCrud.Update(_users);
                 ucUsers_Load(null, null);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_users != null)
            {
               usersCrud.Delete(_users.Id);
               ucUsers_Load(null, null);
            }
        }

        private void ucUsers_Load(object sender, EventArgs e)
        {
            dgwUsers.DataSource = usersCrud.GetAll();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
