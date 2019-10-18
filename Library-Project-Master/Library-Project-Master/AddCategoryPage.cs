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
    public partial class AddCategoryPage : Form
    {
        public AddCategoryPage()
        {
            InitializeComponent();
        }

        ProjectContext db = new ProjectContext();

        public void TextBoxEraser()
        {
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            foreach (Control item in groupBox3.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            foreach (Control item in groupBox4.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        public void CategoryTakeList()
        {
            dataGridView1.DataSource = db.Categories.Where(x => x.Status == Status.Active || x.Status == Status.Updated).ToList();
        }

        
        

        

        private void btnAddCategory_Click_1(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Name = txtAddName.Text;
            category.Description = txtAddDescription.Text;

            db.Categories.Add(category);
            db.SaveChanges();

            CategoryTakeList();
            TextBoxEraser();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddBookPage addBookPage = new AddBookPage();
            addBookPage.Show();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            Category category = db.Categories.FirstOrDefault(x => x.ID == id);
            category.Name = txtUpdateName.Text;
            category.Description = txtUpdateDescription.Text;
            category.UpdateDate = DateTime.Now;
            category.Status = Status.Updated;
            db.SaveChanges();
            CategoryTakeList();
            TextBoxEraser();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Category category = db.Categories.FirstOrDefault(x => x.ID == id);
            category.Status = Status.Deleted;
            category.DeleteDate = DateTime.Now;
            db.SaveChanges();
            CategoryTakeList();
            TextBoxEraser();
        }

        private void AddCategoryPage_Load_1(object sender, EventArgs e)
        {
            CategoryTakeList();
        }

        int id;
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtUpdateName.Text = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
            txtUpdateDescription.Text = dataGridView1.CurrentRow.Cells["Description"].Value.ToString();
            id = int.Parse(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
            txtDelete.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
        }
    }
}
