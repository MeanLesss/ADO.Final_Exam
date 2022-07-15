using BookStore_ADO_Final.Database;
using BookStore_ADO_Final.Model;
using BookStore_ADO_Final.UserControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore_ADO_Final
{
    public partial class SellerDashboard : Form
    {
        private readonly User _user;
        private readonly Form _form;
        public SellerDashboard()
        {
            InitializeComponent();
        }
        public SellerDashboard(User user,Form form)
        {
            InitializeComponent();
            _user = user;
            _form = form;
        }

        private void iconButtonUserConf_Click(object sender, EventArgs e)
        {
            using (var db = new DataContext())
            {
                var admin = db.Users.FirstOrDefault(z => z.ID == _user.ID);

                new AddPopUP(new SignUpUC(admin, "Seller", true)).Show();
            }
        }

        private void ButtonLogOut_Click(object sender, EventArgs e)
        {
            new WelcomeForm().Show();
            this.Dispose();
        }

        private void SellerDashboard_Load(object sender, EventArgs e)
        {
            iconPictureBoxUser.Image = Image.FromFile(_user.PhotoDir);
            labelUsername.Text = _user.Username;
            labelID.Text = _user.ID.ToString();

            panelOnSale.Controls.Clear();
            using (var db = new DataContext())
            {
                var books = db.Books.ToList();
                foreach (var book in books)
                {
                    panelOnSale.Controls.Add(new BookStockCard(_user,book, "Sell"));
                }
            }
        }

        private void iconButtonRefreshSale_Click(object sender, EventArgs e)
        {
            panelOnSale.Controls.Clear();
            using (var db = new DataContext())
            {
                var books = db.Books.ToList();
                foreach (var book in books)
                {
                    panelOnSale.Controls.Add(new BookStockCard(_user,book, "Sell"));
                }
            }
        }
        private List<Book> GetBooks()
        {
            var db = new DataContext();

            var authors = db.Authors.ToList();
            var bookAuthors = db.BookAuthors.ToList();
            var books = db.Books.ToList();


            return (from a in authors   //get author from the search box
                    where (a.Firstname + " " + a.Lastname).ToLower().Equals(textBoxSearchStock.Text.ToLower())
                    from b in bookAuthors  // search author from the BookAuthor table
                    where b.Author.ID == a.ID
                    from book in books //get book by id from BookAuthor table
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
        private void iconButtonSearchStock_Click(object sender, EventArgs e)
        {
            using (var db = new DataContext())
            {
                var searchBooks = new List<Book>();

                var bookAuth = GetBooks();

                searchBooks = bookAuth;

                foreach (var book in db.Books.ToList())
                {
                    if (book.Title.ToLower().Equals(textBoxSearchStock.Text.ToLower()) ||
                        book.Genre.ToLower().Equals(textBoxSearchStock.Text.ToLower())
                        )
                    {
                        searchBooks.Add(book);
                    }
                }
                if (!(searchBooks is null))
                {
                    panelOnSale.Controls.Clear();
                    foreach (var book in searchBooks)
                    {
                        panelOnSale.Controls.Add(new BookCardUC(book));
                    }
                    return;
                }
                panelOnSale.Controls.Clear();
            }
        }

        private void textBoxSearchStock_Enter(object sender, EventArgs e)
        {
            textBoxSearchStock.Clear();
        }

        private void SellerDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
