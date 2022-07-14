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
using System.Data.Entity.Migrations;

namespace BookStore_ADO_Final.UserControl
{
    public partial class BookInfoUC : System.Windows.Forms.UserControl
    {
        
        private static string PHOTODIR = @"..\..\BookCover\";
        private static string PHOTODEFAULT = @"..\..\BookCover\default.png";

        private List<string> authorName;
        private List<string> publisherName;

        private Book _book = null;
        private readonly bool _update = false;

        private FileInfo fileInfo = null;
        private Panel _panel;
        public BookInfoUC()
        {
            InitializeComponent();
        }
        public BookInfoUC(Book book,bool update)
        {
            InitializeComponent();
            _book = book;
            _update = update;

            comboBoxAuthor.Visible = false;
            comboBoxPublisher.Visible = false;

            textBoxTitle.Text = _book.Title;
            textBoxGenre.Text = _book.Genre;
            textBoxPages.Text = _book.Pages.ToString();
            textBoxPrimeCost.Text = _book.PrimeCost.ToString();
            textBoxSalePrice.Text = _book.SalePrice.ToString();
            checkBoxSequel.Checked = _book.Sequel;
            iconPictureBoxBookCover.Image = Image.FromFile(_book.BookCoverDir);
        }
        public BookInfoUC(Panel panel)
        {
            InitializeComponent();
            _panel = panel;
        }

        private void iconPictureBoxBookCover_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Graphics File|*.bmp;*.gif;*.png;*jpg";
            openFileDialog.FileName = "";
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                iconPictureBoxBookCover.Image = Image.FromFile(openFileDialog.FileName);
                fileInfo = new FileInfo(openFileDialog.FileName);
            }
        }
        private void iconButtonCancelAdd_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void iconButtonSaveAdd_Click(object sender, EventArgs e)
        {
            bool i = checkBoxSequel.Checked == true;
            string dir;
            
            if (fileInfo is null)
            {
                fileInfo = new FileInfo(PHOTODIR + "default.png");
                dir = PHOTODIR + fileInfo.Name;

                if(_update is true)
                {
                    dir = _book.BookCoverDir;
                }
            }
            else
            {
                var name = fileInfo.Name;
                if (Directory.Exists(PHOTODIR + name))
                {
                    dir = PHOTODIR + fileInfo.Name;
                }
                else
                {
                    File.Copy(fileInfo.FullName, PHOTODIR + fileInfo.Name, true);
                    dir = PHOTODIR + fileInfo.Name;
                }
            }

            using (DataContext db = new DataContext())
            {
                /*var publisherBook = db.Publishers
                    .Include(p => p.Books.Select(b => b.ID));*/
                var prime = double.Parse(textBoxPrimeCost.Text);
                var sale = double.Parse(textBoxSalePrice.Text);
                var pages = int.Parse(textBoxPages.Text);

                var publish = db.Publishers
                    .FirstOrDefault(p => p.PublisherName
                        .Equals(comboBoxPublisher.Text));

                var author = db.Authors
                    .FirstOrDefault(a => (a.Firstname + " " + a.Lastname) == comboBoxAuthor.Text);

                ICollection<Publisher> publishers = new List<Publisher>();
                publishers.Add(publish);

                ICollection<Author> authors = new List<Author>();
                authors.Add(author);

                if (_update is false)
                {
                    var book = new Book
                    {
                        Title = textBoxTitle.Text,
                        PrimeCost = prime,
                        SalePrice = sale,
                        Pages = pages,
                        Genre = textBoxGenre.Text,
                        PublishDate = dateTimePicker1.Value.Date,
                        Sequel = i,
                        BookCoverDir = dir,
                        Publishers = publishers,
                        //Authors = authors
                    };
                    db.Books.Add(book);
                    var auth = new BookAuthors
                    {
                        Book = book,
                        Author = author,
                    };
                    db.BookAuthors.Add(auth);
                    db.SaveChanges();
                }
                else
                {
                    var editBook = db.Books.FirstOrDefault(b => b.ID == _book.ID);
                    editBook.Title = textBoxTitle.Text;
                    editBook.PrimeCost = prime;
                    editBook.SalePrice = sale;
                    editBook.Pages = pages;
                    editBook.Genre = textBoxGenre.Text;
                    editBook.PublishDate = dateTimePicker1.Value.Date;
                    editBook.Sequel = i;
                    editBook.BookCoverDir = dir;

                    db.Books.AddOrUpdate(editBook);
                    db.SaveChanges();

                }
            }

            ClearText();
            MessageBox.Show("Books Created!");
        }

        private void ClearText()
        {
            textBoxTitle.Clear();
            textBoxGenre.Clear();
            textBoxPages.Clear();
            textBoxPrimeCost.Clear();
            textBoxSalePrice.Clear();
            comboBoxAuthor.DataSource = authorName;
            comboBoxPublisher.DataSource = publisherName;
            checkBoxSequel.Checked = false;
            iconPictureBoxBookCover.ResetImeMode();
        }
        private void BookInfoUC_Load(object sender, EventArgs e)
        {
            ComboLoad();
        }
        private void ComboLoad()
        {
            authorName = new List<string>();
            publisherName = new List<string>();
            using (DataContext db = new DataContext())
            {
                db.Authors.ToList().
                    ForEach(author => authorName.
                        Add(author.Firstname + " " + author.Lastname));

                db.Publishers.ToList()
                    .ForEach(pub => publisherName
                        .Add(pub.PublisherName));

                comboBoxAuthor.DataSource = authorName;
                comboBoxPublisher.DataSource = publisherName;
            }
        }
        private void iconButtonAddAuthor_Click(object sender, EventArgs e)
        {
            new AddPopUP(new AuthorUC()).Show();
        }

        private void iconButtonAddPublisher_Click(object sender, EventArgs e)
        {
            new AddPopUP(new PublisherUC()).Show();
        }

        private void iconButtonRefresh_Click(object sender, EventArgs e)
        {
            ComboLoad();
        }

        private void comboBoxAuthor_Click(object sender, EventArgs e)
        {
            ComboLoad();
        }

        private void comboBoxPublisher_Click(object sender, EventArgs e)
        {
            ComboLoad();
        }

        
    }
}
