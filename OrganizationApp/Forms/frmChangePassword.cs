using OrganizationApp.Sessions;
using OrganizationApp.Utils;
using OrganizationDal.DAL;
using OrganizationDal.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrganizationApp.Forms
{
    public partial class frmChangePassword : Form
    {
        UsersDal userDal;
        public frmChangePassword()
        {
            userDal = new UsersDal();
            InitializeComponent();
        }
        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            var x = LoginSession.LoginUser;
            if (x.Password == Helper.GenerateSHA256Hash(txtOldPassword.Text, x.Salt))
            {
                if (txtNewPassword.Text == txtCheckPassword.Text)
                {
                    User user = new User();
                    user.Id = x.Id;
                    user.Name = x.Name;
                    user.Salt = Helper.CreateSalt(10);
                    user.Password = Helper.GenerateSHA256Hash(txtNewPassword.Text, user.Salt);
                    user.Status = x.Status;
                    user.PersonnelId = x.PersonnelId;
                    userDal.UpdatePassword(user);
                    MessageBox.Show("Muvəffəqiyyətlə şifrə yeniləndi");
                }
                else
                {
                    MessageBox.Show("Təsdiq doğru deyil");
                }
            }
            else
            {
                MessageBox.Show("Köhnə parol sehv daxil edildi");
            }
        }

        private void txtCheckPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOldPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCheckPassword_Click(object sender, EventArgs e)
        {

        }

        private void lblNewPassword_Click(object sender, EventArgs e)
        {

        }

        private void lblOldPassword_Click(object sender, EventArgs e)
        {

        }
    }
}

