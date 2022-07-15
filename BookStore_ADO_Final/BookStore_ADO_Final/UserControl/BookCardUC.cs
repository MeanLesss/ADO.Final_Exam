using BookStore_ADO_Final.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore_ADO_Final.UserControl
{
    public partial class BookCardUC : System.Windows.Forms.UserControl
    {

        private readonly Book _book = null;
        public BookCardUC()
        {
            InitializeComponent();
        }
        public BookCardUC(Book book)
        {
            InitializeComponent();
            _book = book;
        }

        private void BookCardUC_Click(object sender, EventArgs e)
        {
            new AddPopUP(new BookInfoUC(_book,true)).Show();
        }

        private void BookCardUC_Load(object sender, EventArgs e)
        {
            if (!(_book is null))
            {
                iconPictureBoxBookCover.Image = Image.FromFile(_book.BookCoverDir);
                textBoxTitle.Text = _book.Title;
            }
        }
    }
}
