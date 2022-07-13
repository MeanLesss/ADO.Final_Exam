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
            
        }

    }
}
