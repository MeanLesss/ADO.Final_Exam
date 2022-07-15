using BookStore_ADO_Final.Database;
using BookStore_ADO_Final.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore_ADO_Final.UserControl
{
    public partial class BookStockCard : System.Windows.Forms.UserControl
    {
        private readonly Book _book;
        private readonly string _btName;

        public BookStockCard()
        {
            InitializeComponent();
        }
        public BookStockCard(Book book, string btName)
        {
            InitializeComponent();
            _book = book;
            _btName = btName;

            iconButtonSave.Text = _btName;
        }

        private void BookStockCard_Load(object sender, EventArgs e)
        {
            iconPictureBoxBookCover.Image = Image.FromFile(_book.BookCoverDir);
            textBoxTitle.Text = _book.Title;
            using (var db = new DataContext())
            {
                var stocks = db.Stocks.Where(x => x.Book.ID == _book.ID).FirstOrDefault();
                textBoxQuantity.Text = stocks.BookQuantity.ToString();
            }
        }

        private void iconButtonAddQuantity_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(textBoxQuantity.Text);
            quantity++;
            textBoxQuantity.Text = quantity.ToString();
        }

        private void iconButtonMinus_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(textBoxQuantity.Text);
            quantity--;
            if(quantity < 0) quantity = 0;
            textBoxQuantity.Text = quantity.ToString();
        }

        private void iconButtonSave_Click(object sender, EventArgs e)
        {
            using (var db = new DataContext())
            {
                var stock = db.Stocks.Where(x => x.Book.ID == _book.ID).FirstOrDefault();
                stock.BookQuantity = int.Parse(textBoxQuantity.Text);
                db.Stocks.AddOrUpdate(stock);
                db.SaveChanges();
            }
            MessageBox.Show("Update saved !");
        }
    }
}
