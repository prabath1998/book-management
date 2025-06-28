using book_management.Models;
using book_management.Repositories.Service;
using System.Data;

namespace book_management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            readBooks();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.Name = this.tbName.Text;
            book.Author = this.tbAuthor.Text;

            var repo = new BooksRepository();

            repo.AddBook(book);
            readBooks();

            this.tbName.Text = string.Empty;
            this.tbAuthor.Text = string.Empty;
            MessageBox.Show("Book added!");
        }

        private void readBooks()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Author", typeof(string));


            var repo = new BooksRepository();
            var books = repo.GetAllBooks();
            foreach (var book in books)
            {
                var row = dt.NewRow();
                row["ID"] = book.Id;
                row["Name"] = book.Name;
                row["Author"] = book.Author;

                dt.Rows.Add(row);
            }

            this.tblBooks.DataSource = dt;
        }
    }
}
