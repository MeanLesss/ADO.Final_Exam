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
using BookStore_ADO_Final.Database;
using BookStore_ADO_Final.Model;

namespace BookStore_ADO_Final.UserControl
{
    public partial class AuthorUC : System.Windows.Forms.UserControl
    {
        private Author _author;
        private bool _update = false;

        public AuthorUC()
        {
            InitializeComponent();
        }
        public AuthorUC(Author author, bool update)
        {
            InitializeComponent();
            _author = author;
            _update = update;

            textBoxAuthFirstname.Text = _author.Firstname;
            textBoxAuthLastname.Text = _author.Lastname;
        }
        private void iconButtonSaveAuth_Click(object sender, EventArgs e)
        {
            using (DataContext db = new DataContext())
            {
                if (_update is false)
                {
                    db.Authors.Add(new Author
                    {
                        Firstname = textBoxAuthFirstname.Text,
                        Lastname = textBoxAuthLastname.Text
                    });
                    db.SaveChanges();
                }
                else
                {
                    var editAuth = db.Authors.FirstOrDefault(a => a.ID == _author.ID);
                    editAuth.Firstname = textBoxAuthFirstname.Text;
                    editAuth.Lastname = textBoxAuthLastname.Text;
                    db.Authors.AddOrUpdate(editAuth);
                    db.SaveChanges();
                }
                
            }

            MessageBox.Show("Author added!");
            textBoxAuthFirstname.Clear();
            textBoxAuthLastname.Clear();
        }
    }
}
