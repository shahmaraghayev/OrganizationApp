namespace OrganizationApp.Controls
{
    partial class ucUsersRoles
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgwUsersRoles = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbRoles = new System.Windows.Forms.ComboBox();
            this.cbUsers = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnİnsert = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUsersRoles)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwUsersRoles
            // 
            this.dgwUsersRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUsersRoles.Location = new System.Drawing.Point(446, 43);
            this.dgwUsersRoles.Name = "dgwUsersRoles";
            this.dgwUsersRoles.Size = new System.Drawing.Size(250, 165);
            this.dgwUsersRoles.TabIndex = 0;
            this.dgwUsersRoles.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgwUserRole_RowHeaderMouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbRoles);
            this.panel1.Controls.Add(this.cbUsers);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnChange);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnİnsert);
            this.panel1.Location = new System.Drawing.Point(15, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 165);
            this.panel1.TabIndex = 1;
            // 
            // cbRoles
            // 
            this.cbRoles.DisplayMember = "Name";
            this.cbRoles.FormattingEnabled = true;
            this.cbRoles.Location = new System.Drawing.Point(78, 70);
            this.cbRoles.Name = "cbRoles";
            this.cbRoles.Size = new System.Drawing.Size(331, 21);
            this.cbRoles.TabIndex = 3;
            this.cbRoles.ValueMember = "Id";
            // 
            // cbUsers
            // 
            this.cbUsers.DisplayMember = "Name";
            this.cbUsers.FormattingEnabled = true;
            this.cbUsers.Location = new System.Drawing.Point(78, 24);
            this.cbUsers.Name = "cbUsers";
            this.cbUsers.Size = new System.Drawing.Size(331, 21);
            this.cbUsers.TabIndex = 2;
            this.cbUsers.ValueMember = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Səlahiyyətlər";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İstifadəçilər";
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Location = new System.Drawing.Point(200, 107);
            this.btnChange.Margin = new System.Windows.Forms.Padding(4);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(88, 24);
            this.btnChange.TabIndex = 16;
            this.btnChange.Text = "Dəyiş";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(321, 107);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 24);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnİnsert
            // 
            this.btnİnsert.BackColor = System.Drawing.Color.LimeGreen;
            this.btnİnsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnİnsert.ForeColor = System.Drawing.Color.Black;
            this.btnİnsert.Location = new System.Drawing.Point(78, 107);
            this.btnİnsert.Margin = new System.Windows.Forms.Padding(4);
            this.btnİnsert.Name = "btnİnsert";
            this.btnİnsert.Size = new System.Drawing.Size(88, 24);
            this.btnİnsert.TabIndex = 14;
            this.btnİnsert.Text = "Əlavə et";
            this.btnİnsert.UseVisualStyleBackColor = false;
            this.btnİnsert.Click += new System.EventHandler(this.btnİnsert_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dgwUsersRoles);
            this.groupBox1.Location = new System.Drawing.Point(83, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(715, 252);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İstifadəçilər səlayiyyətlər";
            // 
            // ucUsersRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "ucUsersRoles";
            this.Size = new System.Drawing.Size(933, 557);
            this.Load += new System.EventHandler(this.ucUsersRoles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwUsersRoles)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwUsersRoles;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbRoles;
        private System.Windows.Forms.ComboBox cbUsers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnİnsert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
