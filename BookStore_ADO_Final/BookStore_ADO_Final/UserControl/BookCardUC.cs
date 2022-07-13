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
        public BookCardUC()
        {
            InitializeComponent();
        }

        private void BookCardUC_Click(object sender, EventArgs e)
        {
            new AddPopUP(new BooksUC());
        }
    }
}
