using OrganizationApp.Controls;
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlLeft.Visible = !pnlLeft.Visible;
        }

        private void btnOrganization_Click(object sender, EventArgs e)
        {

            DisposeControlsOnPanel();
            var uc = new ucOrganization();
            uc.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(uc);
        }

        private void DisposeControlsOnPanel()
        {
            foreach (Control ctrl in pnlMain.Controls)
            {
                ctrl.Dispose();
            }
        }  
    

        private void btnUsers_Click(object sender, EventArgs e)
        {
            DisposeControlsOnPanel();
            var uc = new ucUsers();
            uc.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(uc);
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            DisposeControlsOnPanel();
            var uc = new ucDepartment();
            uc.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(uc);
        }

        private void btnPersonnel_Click(object sender, EventArgs e)
        {

            DisposeControlsOnPanel();
            var uc = new ucPersonnel();
            uc.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(uc);
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            DisposeControlsOnPanel();
            var uc = new ucRoles();
            uc.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(uc);
        }

        private void btnƏməkdaslarınSəlahiyyətləri_Click(object sender, EventArgs e)
        {
            DisposeControlsOnPanel();
            var uc = new ucUsersRoles();
            uc.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(uc);
        }
    }
}
