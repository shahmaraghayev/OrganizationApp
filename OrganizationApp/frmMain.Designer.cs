using System.Drawing;

namespace OrganizationApp
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnToggle = new System.Windows.Forms.Button();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnƏməkdaslarınSəlahiyyətləri = new System.Windows.Forms.Button();
            this.btnRoles = new System.Windows.Forms.Button();
            this.btnPersonnel = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnDepartment = new System.Windows.Forms.Button();
            this.btnOrganization = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnChangedPassword = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(78)))));
            this.pnlTop.Controls.Add(this.btnChangedPassword);
            this.pnlTop.Controls.Add(this.btnToggle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(208, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(780, 35);
            this.pnlTop.TabIndex = 0;
            // 
            // btnToggle
            // 
            this.btnToggle.BackColor = System.Drawing.Color.Transparent;
            this.btnToggle.BackgroundImage = global::OrganizationApp.Properties.Resources.menu48;
            this.btnToggle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnToggle.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggle.Location = new System.Drawing.Point(0, 0);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(34, 35);
            this.btnToggle.TabIndex = 0;
            this.btnToggle.UseVisualStyleBackColor = false;
            this.btnToggle.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(78)))));
            this.pnlLeft.Controls.Add(this.btnƏməkdaslarınSəlahiyyətləri);
            this.pnlLeft.Controls.Add(this.btnRoles);
            this.pnlLeft.Controls.Add(this.btnPersonnel);
            this.pnlLeft.Controls.Add(this.btnUsers);
            this.pnlLeft.Controls.Add(this.btnDepartment);
            this.pnlLeft.Controls.Add(this.btnOrganization);
            this.pnlLeft.Controls.Add(this.splitter1);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(208, 454);
            this.pnlLeft.TabIndex = 1;
            // 
            // btnƏməkdaslarınSəlahiyyətləri
            // 
            this.btnƏməkdaslarınSəlahiyyətləri.BackColor = System.Drawing.Color.Gainsboro;
            this.btnƏməkdaslarınSəlahiyyətləri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnƏməkdaslarınSəlahiyyətləri.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnƏməkdaslarınSəlahiyyətləri.Image = ((System.Drawing.Image)(resources.GetObject("btnƏməkdaslarınSəlahiyyətləri.Image")));
            this.btnƏməkdaslarınSəlahiyyətləri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnƏməkdaslarınSəlahiyyətləri.Location = new System.Drawing.Point(16, 351);
            this.btnƏməkdaslarınSəlahiyyətləri.Name = "btnƏməkdaslarınSəlahiyyətləri";
            this.btnƏməkdaslarınSəlahiyyətləri.Size = new System.Drawing.Size(186, 28);
            this.btnƏməkdaslarınSəlahiyyətləri.TabIndex = 2;
            this.btnƏməkdaslarınSəlahiyyətləri.Text = "İstifadəçilərin Səlahiyyətləri";
            this.btnƏməkdaslarınSəlahiyyətləri.UseVisualStyleBackColor = false;
            this.btnƏməkdaslarınSəlahiyyətləri.Click += new System.EventHandler(this.btnƏməkdaslarınSəlahiyyətləri_Click);
            // 
            // btnRoles
            // 
            this.btnRoles.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoles.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnRoles.Image = ((System.Drawing.Image)(resources.GetObject("btnRoles.Image")));
            this.btnRoles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoles.Location = new System.Drawing.Point(16, 297);
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.Size = new System.Drawing.Size(186, 28);
            this.btnRoles.TabIndex = 2;
            this.btnRoles.Text = "Səlahiyyətlər";
            this.btnRoles.UseVisualStyleBackColor = false;
            this.btnRoles.Click += new System.EventHandler(this.btnRoles_Click);
            // 
            // btnPersonnel
            // 
            this.btnPersonnel.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPersonnel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonnel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnPersonnel.Image = ((System.Drawing.Image)(resources.GetObject("btnPersonnel.Image")));
            this.btnPersonnel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonnel.Location = new System.Drawing.Point(16, 238);
            this.btnPersonnel.Name = "btnPersonnel";
            this.btnPersonnel.Size = new System.Drawing.Size(186, 28);
            this.btnPersonnel.TabIndex = 2;
            this.btnPersonnel.Text = "Əməkdaşlar";
            this.btnPersonnel.UseVisualStyleBackColor = false;
            this.btnPersonnel.Click += new System.EventHandler(this.btnPersonnel_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.Gainsboro;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnUsers.Image")));
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Location = new System.Drawing.Point(16, 177);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(186, 28);
            this.btnUsers.TabIndex = 2;
            this.btnUsers.Text = "İstifadəçilər";
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnDepartment
            // 
            this.btnDepartment.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartment.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnDepartment.Image = ((System.Drawing.Image)(resources.GetObject("btnDepartment.Image")));
            this.btnDepartment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepartment.Location = new System.Drawing.Point(16, 117);
            this.btnDepartment.Name = "btnDepartment";
            this.btnDepartment.Size = new System.Drawing.Size(186, 28);
            this.btnDepartment.TabIndex = 2;
            this.btnDepartment.Text = "Departament";
            this.btnDepartment.UseVisualStyleBackColor = false;
            this.btnDepartment.Click += new System.EventHandler(this.btnDepartment_Click);
            // 
            // btnOrganization
            // 
            this.btnOrganization.BackColor = System.Drawing.Color.Gainsboro;
            this.btnOrganization.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrganization.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnOrganization.Image = ((System.Drawing.Image)(resources.GetObject("btnOrganization.Image")));
            this.btnOrganization.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrganization.Location = new System.Drawing.Point(16, 59);
            this.btnOrganization.Name = "btnOrganization";
            this.btnOrganization.Size = new System.Drawing.Size(186, 28);
            this.btnOrganization.TabIndex = 1;
            this.btnOrganization.Text = "Təşkilat";
            this.btnOrganization.UseVisualStyleBackColor = false;
            this.btnOrganization.Click += new System.EventHandler(this.btnOrganization_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 454);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(0, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(10, 419);
            this.splitter2.TabIndex = 0;
            this.splitter2.TabStop = false;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.splitter2);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(208, 35);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(780, 419);
            this.pnlMain.TabIndex = 2;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(208, 432);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(780, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btnChangedPassword
            // 
            this.btnChangedPassword.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnChangedPassword.Location = new System.Drawing.Point(705, 0);
            this.btnChangedPassword.Name = "btnChangedPassword";
            this.btnChangedPassword.Size = new System.Drawing.Size(75, 35);
            this.btnChangedPassword.TabIndex = 1;
            this.btnChangedPassword.Text = "Şifrəni dəyiş";
            this.btnChangedPassword.UseVisualStyleBackColor = true;
            this.btnChangedPassword.Click += new System.EventHandler(this.btnChangedPassword_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 454);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlLeft);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "Təşkilat";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlTop.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btnToggle;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnOrganization;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnDepartment;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnƏməkdaslarınSəlahiyyətləri;
        private System.Windows.Forms.Button btnRoles;
        private System.Windows.Forms.Button btnPersonnel;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnChangedPassword;
    }
}

