using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookStore_ADO_Final.Database;
using BookStore_ADO_Final.Model;
using FontAwesome.Sharp;

namespace BookStore_ADO_Final.UserControl
{
    public partial class BooksUC : System.Windows.Forms.UserControl
    {
        private static string PHOTODIR = @"..\..\UserImage\";
        private static string PHOTODEFAULT = @"..\..\UserImage\default.png";

        private List<string> authorName ;
        private List<string> publisherName ;

        private FileInfo fileInfo = null;
        private Panel _panel;
        public BooksUC()
        {
            InitializeComponent();
        }
        public BooksUC(Panel panel)
        {
            InitializeComponent();
            _panel = panel;
        }

        private void BooksUC_Load(object sender, EventArgs e)
        {
            panelBookInfo.Controls.Clear();
            panelBookInfo.Controls.Add(new BookInfoUC());
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            panelBookInfo.Controls.Clear();
            panelBookInfo.Controls.Add(new BookInfoUC());
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            using(var db = new DataContext())
            {
                var books = db.Books.ToList();
                foreach(var book in books)
                {
                    panelDisplayBooks.Controls.Add(new BookCardUC(book));
                }
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            using (var db = new DataContext())
            {

            }
        }

        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
        }

        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            /*textBoxSearch.Text = "Title, Author, Genre";
            textBoxSearch.ForeColor = Color.LightGray;*/
        }

        private void iconButtonSearch_Click(object sender, EventArgs e)
        {
            using (var db = new DataContext())
            {
                var searchBooks = new List<Book>();

                var bookAuth = GetBooks();

                if(!(bookAuth is null))
                {

                    panelDisplayBooks.Controls.Clear();
                    foreach (var book in bookAuth)
                    {
                        panelDisplayBooks.Controls.Add(new BookCardUC(book));
                    }
                    return;
                }

                foreach (var book in db.Books.ToList())
                {
                    if (book.Title.ToLower().Equals(textBoxSearch.Text.ToLower()) ||
                        book.Genre.ToLower().Equals(textBoxSearch.Text.ToLower())
                        )
                    {
                        searchBooks.Add(book);
                    }
                }

                if (!(searchBooks is null))
                {
                    panelDisplayBooks.Controls.Clear();
                    foreach (var book in searchBooks)
                    {
                        panelDisplayBooks.Controls.Add(new BookCardUC(book));
                    }
                    return;
                }
                panelDisplayBooks.Controls.Clear();
            }
        }
        private List<Book> GetBooks()
        {
            var db = new DataContext();

            var authors = db.Authors.ToList();
            var bookAuthors = db.BookAuthors.ToList();
            var books = db.Books.ToList();
            

            return (from a in authors
                    where (a.Firstname + " " + a.Lastname).ToLower() == textBoxSearch.Text.ToLower()

                    from b in bookAuthors
                    where b.Author.ID == a.ID

                    from book in books
                    where book.ID == b.Book.ID
                    select new Book
                    {
                        ID = book.ID,
                        BookCoverDir = book.BookCoverDir,
                        Genre = book.Genre,
                        Pages = book.Pages,
                        PrimeCost = book.PrimeCost,
                        PublishDate = book.PublishDate,
                        Publishers = book.Publishers,
                        SalePrice = book.SalePrice,
                        Sequel = book.Sequel,
                        Title = book.Title
                    }).ToList(); 
        }
    }
}
/*SELECT * FROM Books AS b
INNER JOIN Authors AS a
ON a.Firstname + ' ' + a.Lastname = 'Gerald Helem'
INNER JOIN BookAuthors AS ba
ON ba.Author_ID = a.ID
WHERE b.ID = ba.Book_ID*/