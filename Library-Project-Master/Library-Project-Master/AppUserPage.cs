using Library_Project_Master.DAL.ORM.Concrete;
using Library_Project_Master.DAL.ORM.Context;
using Library_Project_Master.DAL.ORM.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Project_Master
{
    public partial class AppUserPage : Form
    {
        public AppUserPage()
        {
            InitializeComponent();
        }

        ProjectContext db = new ProjectContext();

        public void TextBoxEraser() 
        {
            foreach (Control item in grpAddUser.Controls)
            {
                if (item is TextBox || item is ComboBox)
                {
                    item.Text = "";
                }

            }
            foreach (Control item in grpUpdateUser.Controls)
            {
                if (item is TextBox || item is ComboBox)
                {
                    item.Text = "";
                }
            }
            foreach (Control item in grpDeleteUser.Controls)
            {
                if (item is TextBox || item is ComboBox)
                {
                    item.Text = "";

                }
            }
        }
        public void TakeRoles() 
        {
            foreach (var item in Enum.GetNames(typeof(Role)))
            {
                cmbAddUser.DataSource = null;
                cmbAddUser.Items.Add(item);
                cmbUpdateRole.Items.Add(item);
            }
        }
        public void UserTakeList() 
        {
            dataGridView1.DataSource = db.AppUsers.Where(x => x.Status == Status.Active || x.Status == Status.Updated).ToList(); 
        }

        int id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUpdatePassword.Text = dataGridView1.CurrentRow.Cells["Password"].Value.ToString();
            cmbUpdateRole.Text = dataGridView1.CurrentRow.Cells["Role"].Value.ToString();
            id = int.Parse(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
            txtDeleteUser.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AppUser Adduser = new AppUser();
            Adduser.AddDate = DateTime.Now;
            Adduser.FirstName = txtFirstName.Text;
            Adduser.LastName = txtLastName.Text;
            Adduser.Password = txtPassword.Text;
            Adduser.Role = (Role)Enum.Parse(typeof(Role), cmbAddUser.SelectedItem.ToString());
            Adduser.UserName = txtUserName.Text;

            db.AppUsers.Add(Adduser);
            db.SaveChanges();
            UserTakeList();
            TextBoxEraser();
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            AppUser UpdateUser = db.AppUsers.FirstOrDefault(x => x.ID == id);
            UpdateUser.Password = txtUpdatePassword.Text;
            UpdateUser.Role = (Role)cmbUpdateRole.SelectedItem;
            UpdateUser.Status = Status.Updated;
            UpdateUser.UpdateDate = DateTime.Now;
            db.SaveChanges();
            UserTakeList();
            TextBoxEraser();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            AppUser DeleteUser = db.AppUsers.FirstOrDefault(x => x.ID == id);
            db.AppUsers.Remove(DeleteUser);
            db.SaveChanges();
            UserTakeList();
            TextBoxEraser();
        }

        private void AppUserPage_Load(object sender, EventArgs e)
        {
            TakeRoles();
            UserTakeList();

            
            
        }

        private void btnGoLogin_Click(object sender, EventArgs e)
        {
            LoginPage lp = new LoginPage();
            lp.Show();
            this.Hide();
        }
    }
}
