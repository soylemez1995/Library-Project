using Library_Project_Master.DAL.ORM.Abstract;
using Library_Project_Master.DAL.ORM.Concrete;
using Library_Project_Master.DAL.ORM.Context;
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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        ProjectContext db = new ProjectContext();
        AppUser loginUser = new AppUser();

        public void EnumList()
        {
            cmbSelectRole.Items.AddRange(Enum.GetNames(typeof(Role)));
            cmbSelectRole.SelectedIndex = 0;
        }
        private void LoginPage_Load(object sender, EventArgs e)
        {
            EnumList();
        }

        

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (txtUserName.Text == string.Empty)
            {
                MessageBox.Show("Lütfen Kullanıcı Adı Giriniz!");
                return;
            }
            else
            {
                if (db.AppUsers.Where(x => x.UserName == txtUserName.Text).ToList().Count > 0)
                {
                    loginUser = db.AppUsers.FirstOrDefault(x => x.UserName == txtUserName.Text);
                    if (loginUser.Password == txtPassword.Text)
                    {
                        if (Role.Admin == (Role)Enum.Parse(typeof(Role),cmbSelectRole.SelectedItem.ToString()))
                        {
                            this.Hide();
                            AddCategoryPage addCategoryPage = new AddCategoryPage();
                            addCategoryPage.Show();
                        }
                        else
                        {

                        }
                    }
                    else
                    {
                        MessageBox.Show("Yanlış Şifre Girdiniz!Admin girişi yapmalısınız.");
                    }
                }
                else
                {
                    MessageBox.Show("Yanlış Kullancı Adı.");
                    return;
                }

            }
        }
    }
}
