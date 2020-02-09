namespace OrganizationApp.Controls
{
    partial class ucDepartment
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
            this.dgwDepartments = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.pnLeft = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbOrganization = new System.Windows.Forms.ComboBox();
            this.cbHeadDepartment = new System.Windows.Forms.ComboBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDepartments)).BeginInit();
            this.pnLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwDepartments
            // 
            this.dgwDepartments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDepartments.Location = new System.Drawing.Point(415, 24);
            this.dgwDepartments.Name = "dgwDepartments";
            this.dgwDepartments.Size = new System.Drawing.Size(578, 206);
            this.dgwDepartments.TabIndex = 0;
            this.dgwDepartments.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgwDepartments_RowHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Departamentlər";
            // 
            // pnLeft
            // 
            this.pnLeft.Controls.Add(this.label5);
            this.pnLeft.Controls.Add(this.label4);
            this.pnLeft.Controls.Add(this.cbOrganization);
            this.pnLeft.Controls.Add(this.cbHeadDepartment);
            this.pnLeft.Controls.Add(this.txtStatus);
            this.pnLeft.Controls.Add(this.label3);
            this.pnLeft.Controls.Add(this.txtName);
            this.pnLeft.Controls.Add(this.label2);
            this.pnLeft.Controls.Add(this.button3);
            this.pnLeft.Controls.Add(this.button2);
            this.pnLeft.Controls.Add(this.button1);
            this.pnLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnLeft.Location = new System.Drawing.Point(0, 26);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(409, 221);
            this.pnLeft.TabIndex = 2;
    
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Təşkilat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Baş idarə";
            // 
            // cbOrganization
            // 
            this.cbOrganization.DisplayMember = "Name";
            this.cbOrganization.FormattingEnabled = true;
            this.cbOrganization.Location = new System.Drawing.Point(86, 124);
            this.cbOrganization.Name = "cbOrganization";
            this.cbOrganization.Size = new System.Drawing.Size(311, 24);
            this.cbOrganization.TabIndex = 11;
            this.cbOrganization.ValueMember = "Id";
            // 
            // cbHeadDepartment
            // 
            this.cbHeadDepartment.DisplayMember = "Name";
            this.cbHeadDepartment.FormattingEnabled = true;
            this.cbHeadDepartment.Location = new System.Drawing.Point(87, 89);
            this.cbHeadDepartment.Name = "cbHeadDepartment";
            this.cbHeadDepartment.Size = new System.Drawing.Size(311, 24);
            this.cbHeadDepartment.TabIndex = 10;
            this.cbHeadDepartment.ValueMember = "Id";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(87, 50);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(4);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(311, 21);
            this.txtStatus.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Status";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(86, 21);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(311, 21);
            this.txtName.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ad";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(143, 167);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 37);
            this.button3.TabIndex = 5;
            this.button3.Text = "Dəyiş";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PaleVioletRed;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(285, 167);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 37);
            this.button2.TabIndex = 4;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(17, 167);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Əlavə et";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ucDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnLeft);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwDepartments);
            this.Name = "ucDepartment";
            this.Size = new System.Drawing.Size(1005, 408);
            this.Load += new System.EventHandler(this.ucDepartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwDepartments)).EndInit();
            this.pnLeft.ResumeLayout(false);
            this.pnLeft.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwDepartments;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbOrganization;
        private System.Windows.Forms.ComboBox cbHeadDepartment;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
    }
}
