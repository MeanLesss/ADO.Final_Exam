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
        private readonly User _seller;
        private readonly string _btName;

        public BookStockCard()
        {
            InitializeComponent();
            iconPictureBoxBookCover.Image = Image.FromFile(_book.BookCoverDir);
            textBoxTitle.Text = _book.Title;
            using (var db = new DataContext())
            {
                var stocks = db.Stocks.Where(x => x.Book.ID == _book.ID && x.BookQuantity > 0).FirstOrDefault();
                textBoxQuantity.Text = "0";
                labelPrice.Text = _book.SalePrice.ToString();
            }
        }
        public BookStockCard(User seller,Book book, string btName)
        {
            InitializeComponent();
            _book = book;
            _btName = btName;
            _seller = seller;

            if (_btName.Equals("Sell"))
            {
                iconButtonSave.Text = _btName;

                iconPictureBoxBookCover.Image = Image.FromFile(_book.BookCoverDir);
                textBoxTitle.Text = _book.Title;
                using (var db = new DataContext())
                {
                    var stocks = db.Stocks.Where(x => x.Book.ID == _book.ID && x.BookQuantity > 0).FirstOrDefault();
                    textBoxQuantity.Text = "0";
                    labelPrice.Text = _book.SalePrice.ToString();
                }
            }
        }
        public BookStockCard(Book book, string btName)
        {
            InitializeComponent();
            _book = book;
            _btName = btName;

            if (_btName.Equals("Sell"))
            {
                iconButtonSave.Text = _btName;
                textBoxQuantity.Text = "0";

                
            }
            iconPictureBoxBookCover.Image = Image.FromFile(_book.BookCoverDir);
                textBoxTitle.Text = _book.Title;
            using (var db = new DataContext())
            {
                var stocks = db.Stocks.Where(x => x.Book.ID == _book.ID && x.BookQuantity >= 0).FirstOrDefault();
                textBoxQuantity.Text = stocks.BookQuantity.ToString();
                labelPrice.Text = _book.SalePrice.ToString();
            }
        }
        private void BookStockCard_Load(object sender, EventArgs e)
        {

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
                if (iconButtonSave.Text == "Save")
                {
                    var stock = db.Stocks.Where(x => x.Book.ID == _book.ID).FirstOrDefault();
                    stock.BookQuantity = int.Parse(textBoxQuantity.Text);
                    db.Stocks.AddOrUpdate(stock);
                    db.SaveChanges();
                    MessageBox.Show("Update saved !");
                    return;
                }
                if (iconButtonSave.Text == "Sell")
                {
                    var message = MessageBox.Show("Are you sure you want to buy this?","Confirmatio",
                        MessageBoxButtons.OKCancel);
                    if(message == DialogResult.OK)
                    {
                        //update stock db
                        var quantity = int.Parse(textBoxQuantity.Text);

                        var stock = db.Stocks.FirstOrDefault(x => x.Book.ID == _book.ID);
                        stock.BookQuantity = stock.BookQuantity - quantity;
                        db.Stocks.AddOrUpdate(stock);
                        //var sellerLog = db.SellerLogBooks.FirstOrDefault(x => x.Stock.ID == stock.ID);
                        var sellerLog = new SellerLogBook();
                        sellerLog.Seller = _seller;
                        sellerLog.Stock = stock;
                        sellerLog.SoldQuantity = quantity;
                        sellerLog.TotalPrice = float.Parse(labelPrice.Text) * quantity;

                        db.SellerLogBooks.AddOrUpdate(sellerLog);
                        db.SaveChanges();
                        MessageBox.Show("Book Sold!");
                        textBoxQuantity.Text = "0";
                    }
                    else
                    {
                        textBoxQuantity.Text = "0";
                    }
                    return;
                }
            }
            
        }
    }
}
