using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment_5._4_BookDll;


namespace Assignment_5._4_Front_End_Book_Repo
{
    public partial class Form1 : Form
    {
        BookRepo repository;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            repository = new BookRepo();
            grdBooks.DataSource = repository.GetBooks().ToList();

        }

        private void grdBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtISBN_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtISBN.Text != string.Empty && txtName.Text != string.Empty && txtAuthor.Text != string.Empty && txtGenre.Text != string.Empty && txtYear.Text != string.Empty)
            {
                Book newbook = new Book();
                repository.AddBook(newbook);
                newbook.ISBN = txtISBN.Text;
                newbook.BookName = txtName.Text;
                newbook.AuthorName = txtAuthor.Text;
                newbook.Genre = txtGenre.Text;
                newbook.Year = Int32.Parse(txtYear.Text);
                RefreshData();
                MessageBox.Show("Book Added succesfully");
            }
            
            else
            {
                MessageBox.Show("Please ensure all fields are filled out");
            }

        }
        private void RefreshData()
        {
            txtISBN.Clear();
            txtName.Clear();
            txtAuthor.Clear();
            txtGenre.Clear();
            txtYear.Clear();
            grdBooks.DataSource = null;
            grdBooks.DataSource = repository.GetBooks().ToList();
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            repository.DeleteBook(grdBooks.CurrentRow.Index);
            grdBooks.DataSource = null;
            grdBooks.DataSource = repository.GetBooks().ToList();
            MessageBox.Show("Successfully deleted the selected entry");

        }

        private void txtAuthor_Leave(object sender, EventArgs e)
        {
            if ((txtAuthor.Text.Length > 50))
            {
                txtAuthor.Clear();
                MessageBox.Show("Please ensure you check the lenght of the Authors Name");
                txtAuthor.Focus();
            }
        }
    }
}
