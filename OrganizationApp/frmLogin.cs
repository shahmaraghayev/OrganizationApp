using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrganizationApp
{
    //myForm.BackColor =  ColorTranslator.FromHtml("#3A444C");
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            #region panel at screan center
            this.panel1.Location = new Point(
               this.ClientSize.Width / 2 - this.panel1.Size.Width / 2,
                this.ClientSize.Height / 2 - this.panel1.Size.Height / 2);
            this.panel1.Anchor = AnchorStyles.None;
            #endregion

            #region
            //For txtUserName
            txtUserName.ForeColor = Color.White;
            txtUserName.Text = "İstifadəçi adı";
            this.txtUserName.Leave += new System.EventHandler(this.txtUserName_Leave);
            this.txtUserName.Enter += new System.EventHandler(this.txtUserName_Enter);

            //For txtPassword

            txtPassword.ForeColor = Color.White;
            txtPassword.Text = "Şifrə";
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);

            #endregion
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmMain m = new frmMain();
            m.Show();
            this.Hide();

        }


        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (txtUserName.Text.Length == 0)
            {
                txtUserName.Text = "İstifadəçi adı";
                txtUserName.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if (txtUserName.Text == "İstifadəçi adı")
            {
                txtUserName.Text = "";
                txtUserName.ForeColor = Color.WhiteSmoke;
            }
        }


        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length == 0)
            {
                txtPassword.Text = "Şifrə";
                txtPassword.ForeColor = Color.WhiteSmoke;
                txtPassword.PasswordChar = '\0';
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {

            if (txtPassword.Text == "Şifrə")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.WhiteSmoke;
                txtPassword.PasswordChar = '*';
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
