namespace Library_Project_Master
{
    partial class AppUserPage
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
            this.grpAddUser = new System.Windows.Forms.GroupBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.cmbAddUser = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpUpdateUser = new System.Windows.Forms.GroupBox();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.cmbUpdateRole = new System.Windows.Forms.ComboBox();
            this.txtUpdatePassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grpDeleteUser = new System.Windows.Forms.GroupBox();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.txtDeleteUser = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGoLogin = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpAddUser.SuspendLayout();
            this.grpUpdateUser.SuspendLayout();
            this.grpDeleteUser.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpAddUser
            // 
            this.grpAddUser.Controls.Add(this.btnAddUser);
            this.grpAddUser.Controls.Add(this.cmbAddUser);
            this.grpAddUser.Controls.Add(this.txtPassword);
            this.grpAddUser.Controls.Add(this.txtUserName);
            this.grpAddUser.Controls.Add(this.txtLastName);
            this.grpAddUser.Controls.Add(this.txtFirstName);
            this.grpAddUser.Controls.Add(this.label5);
            this.grpAddUser.Controls.Add(this.label4);
            this.grpAddUser.Controls.Add(this.label3);
            this.grpAddUser.Controls.Add(this.label2);
            this.grpAddUser.Controls.Add(this.label1);
            this.grpAddUser.Location = new System.Drawing.Point(105, 39);
            this.grpAddUser.Name = "grpAddUser";
            this.grpAddUser.Size = new System.Drawing.Size(309, 316);
            this.grpAddUser.TabIndex = 0;
            this.grpAddUser.TabStop = false;
            this.grpAddUser.Text = "Add User";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(124, 243);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(146, 49);
            this.btnAddUser.TabIndex = 10;
            this.btnAddUser.Text = "Press-Add-User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // cmbAddUser
            // 
            this.cmbAddUser.FormattingEnabled = true;
            this.cmbAddUser.Location = new System.Drawing.Point(124, 189);
            this.cmbAddUser.Name = "cmbAddUser";
            this.cmbAddUser.Size = new System.Drawing.Size(146, 24);
            this.cmbAddUser.TabIndex = 9;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(125, 149);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(146, 22);
            this.txtPassword.TabIndex = 8;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(124, 110);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(146, 22);
            this.txtUserName.TabIndex = 7;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(124, 73);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(146, 22);
            this.txtLastName.TabIndex = 6;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(125, 36);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(146, 22);
            this.txtFirstName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(18, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Role:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(18, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(18, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(18, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(18, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // grpUpdateUser
            // 
            this.grpUpdateUser.Controls.Add(this.btnUpdateUser);
            this.grpUpdateUser.Controls.Add(this.cmbUpdateRole);
            this.grpUpdateUser.Controls.Add(this.txtUpdatePassword);
            this.grpUpdateUser.Controls.Add(this.label7);
            this.grpUpdateUser.Controls.Add(this.label6);
            this.grpUpdateUser.Location = new System.Drawing.Point(532, 48);
            this.grpUpdateUser.Name = "grpUpdateUser";
            this.grpUpdateUser.Size = new System.Drawing.Size(314, 307);
            this.grpUpdateUser.TabIndex = 1;
            this.grpUpdateUser.TabStop = false;
            this.grpUpdateUser.Text = "Update User";
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Location = new System.Drawing.Point(19, 192);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(268, 59);
            this.btnUpdateUser.TabIndex = 15;
            this.btnUpdateUser.Text = "Press-Update-User";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // cmbUpdateRole
            // 
            this.cmbUpdateRole.FormattingEnabled = true;
            this.cmbUpdateRole.Location = new System.Drawing.Point(152, 100);
            this.cmbUpdateRole.Name = "cmbUpdateRole";
            this.cmbUpdateRole.Size = new System.Drawing.Size(135, 24);
            this.cmbUpdateRole.TabIndex = 14;
            // 
            // txtUpdatePassword
            // 
            this.txtUpdatePassword.Location = new System.Drawing.Point(152, 51);
            this.txtUpdatePassword.Name = "txtUpdatePassword";
            this.txtUpdatePassword.Size = new System.Drawing.Size(135, 22);
            this.txtUpdatePassword.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(16, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "Role:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(16, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Password:";
            // 
            // grpDeleteUser
            // 
            this.grpDeleteUser.Controls.Add(this.btnDeleteUser);
            this.grpDeleteUser.Controls.Add(this.txtDeleteUser);
            this.grpDeleteUser.Controls.Add(this.label8);
            this.grpDeleteUser.Location = new System.Drawing.Point(943, 48);
            this.grpDeleteUser.Name = "grpDeleteUser";
            this.grpDeleteUser.Size = new System.Drawing.Size(315, 307);
            this.grpDeleteUser.TabIndex = 2;
            this.grpDeleteUser.TabStop = false;
            this.grpDeleteUser.Text = "Delete User";
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(45, 139);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(201, 71);
            this.btnDeleteUser.TabIndex = 15;
            this.btnDeleteUser.Text = "Press-Delete-User";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // txtDeleteUser
            // 
            this.txtDeleteUser.Location = new System.Drawing.Point(125, 47);
            this.txtDeleteUser.Name = "txtDeleteUser";
            this.txtDeleteUser.Size = new System.Drawing.Size(135, 22);
            this.txtDeleteUser.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(19, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 12;
            this.label8.Text = "ID:";
            // 
            // btnGoLogin
            // 
            this.btnGoLogin.Location = new System.Drawing.Point(532, 620);
            this.btnGoLogin.Name = "btnGoLogin";
            this.btnGoLogin.Size = new System.Drawing.Size(325, 67);
            this.btnGoLogin.TabIndex = 4;
            this.btnGoLogin.Text = "Go Login Page";
            this.btnGoLogin.UseVisualStyleBackColor = true;
            this.btnGoLogin.Click += new System.EventHandler(this.btnGoLogin_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(105, 380);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1153, 216);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List Of Users";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1140, 188);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // AppUserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 699);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGoLogin);
            this.Controls.Add(this.grpDeleteUser);
            this.Controls.Add(this.grpUpdateUser);
            this.Controls.Add(this.grpAddUser);
            this.Name = "AppUserPage";
            this.Text = "AppUser";
            this.Load += new System.EventHandler(this.AppUserPage_Load);
            this.grpAddUser.ResumeLayout(false);
            this.grpAddUser.PerformLayout();
            this.grpUpdateUser.ResumeLayout(false);
            this.grpUpdateUser.PerformLayout();
            this.grpDeleteUser.ResumeLayout(false);
            this.grpDeleteUser.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAddUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.ComboBox cmbAddUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpUpdateUser;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.ComboBox cmbUpdateRole;
        private System.Windows.Forms.TextBox txtUpdatePassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpDeleteUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.TextBox txtDeleteUser;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGoLogin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

