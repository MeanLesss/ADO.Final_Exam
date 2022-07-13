using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookStore_ADO_Final.Database;
using BookStore_ADO_Final.Model;

namespace BookStore_ADO_Final.UserControl
{
    public partial class AuthorUC : System.Windows.Forms.UserControl
    {
        public AuthorUC()
        {
            InitializeComponent();
        }

        private void iconButtonSaveAuth_Click(object sender, EventArgs e)
        {
            using (DataContext db = new DataContext())
            {
                db.Authors.Add(new Author
                {
                    Firstname = textBoxAuthFirstname.Text,
                    Lastname = textBoxAuthLastname.Text
                });
                db.SaveChanges();
            }

            MessageBox.Show("Author added!");
            textBoxAuthFirstname.Clear();
            textBoxAuthLastname.Clear();
        }
    }
}
