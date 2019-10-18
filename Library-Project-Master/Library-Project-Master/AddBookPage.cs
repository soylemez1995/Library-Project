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
    public partial class AddBookPage : Form
    {
        public AddBookPage()
        {
            InitializeComponent();
        }

        ProjectContext db = new ProjectContext();

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            Book Addbook = new Book();
            Addbook.Title = txtAddTitle.Text;
            Addbook.Content = txtAddTitle.Text;
            Addbook.AppUser = (AppUser)cmbAddUser.SelectedItem;
            Addbook.Category = (Category)cmbBookCategories.SelectedItem;
            db.Books.Add(Addbook);
            db.SaveChanges();
            TakeBooks();
        }

        private void TakeBooks()
        {
            dataGridView1.DataSource = db.Books.Where(x => x.Status == Status.Active || x.Status == Status.Updated).ToList();
        }

        private void GetCategories()
        {
            cmbBookCategories.DataSource = db.Categories.Where(x => x.Status == Status.Active || x.Status == Status.Updated).ToList(); ;
            cmbBookCategories.DisplayMember = "Name";
            cmbBookCategories.ValueMember = "ID";
            cmbBookCategories.SelectedIndex = -1;
        }

        private void GetUsers()
        {
            cmbAddUser.DataSource = db.AppUsers.Where(x => x.Status == Status.Active || x.Status == Status.Updated).ToList(); ;
            cmbAddUser.DisplayMember = "Name";
            cmbAddUser.ValueMember = "ID";
            cmbAddUser.SelectedIndex = -1;
        }

        private void AddBookPage_Load(object sender, EventArgs e)
        {
            TakeBooks();
            GetUsers();
            GetCategories();
        }

        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Book updateBooks = db.Books.FirstOrDefault(x => x.ID == id);
            updateBooks.Status = Status.Updated;
            updateBooks.Title = txtUpdateBook.Text;
            updateBooks.Content = txtUpdateContent.Text;
            updateBooks.UpdateDate = DateTime.Now;
            updateBooks.AppUser = (AppUser)cmbUpdateUser.SelectedItem;
            updateBooks.Category = (Category)cmbUpdateCategory.SelectedItem;
            db.SaveChanges();
            TakeBooks();
        }

        int id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
            txtUpdateBook.Text = dataGridView1.CurrentRow.Cells["Title"].Value.ToString();
            txtUpdateContent.Text = dataGridView1.CurrentRow.Cells["Content"].Value.ToString();
            txtDelete.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Book DeleteBooks = db.Books.FirstOrDefault(x => x.ID == id);
            db.Books.Remove(DeleteBooks);
            db.SaveChanges();
            TakeBooks();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddCategoryPage addCategoryPage = new AddCategoryPage();
            addCategoryPage.Show();
        }
    }
}
