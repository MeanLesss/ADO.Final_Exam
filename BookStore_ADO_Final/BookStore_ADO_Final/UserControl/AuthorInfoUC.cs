using BookStore_ADO_Final.Database;
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
    public partial class AuthorInfoUC : System.Windows.Forms.UserControl
    {
        
        public AuthorInfoUC()
        {
            InitializeComponent();
        }
        
        private void LoadAuthor()
        {
            using (var db = new DataContext())
            {
                var fullname = new List<string>();
                foreach (var auth in db.Authors.ToList())
                {
                    fullname.Add(auth.ID.ToString() + " " + auth.Firstname + " " + auth.Lastname);
                }
                listBoxAuthor.DataSource = fullname;
            }
        }
        private void AuthorInfoUC_Load(object sender, EventArgs e)
        {
            LoadAuthor();
        }
        
        private void iconButtonRefresh_Click(object sender, EventArgs e)
        {
            LoadAuthor();
        }

        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
        }

        private void iconButtonSearch_Click(object sender, EventArgs e)
        {
            using (var db = new DataContext())
            {
                var foundAuhtor = new List<string>();
                var searchList = db.Authors.ToList();
                
                foreach (var auth in searchList)
                {
                    if ((auth.Firstname + " " + auth.Lastname).ToLower()
                        .Equals(textBoxSearch.Text.ToLower()))
                    {
                        foundAuhtor.Add(auth.ID.ToString() + ' ' + auth.Firstname +' '+ auth.Lastname);
                    }
                }
                if (!(foundAuhtor is null))
                {
                    foreach (var item in foundAuhtor)
                    {
                        listBoxAuthor.DataSource = foundAuhtor;
                    }
                }
            }
        }

        private void iconButtonAddAuthor_Click(object sender, EventArgs e)
        {
            new AddPopUP(new AuthorUC()).Show();
        }

        private void listBoxAuthor_Click(object sender, EventArgs e)
        {
            string text = listBoxAuthor.GetItemText(listBoxAuthor.SelectedItem);

            var author = new Author
            {
                ID = int.Parse(text.Split(' ')[0].Trim()),
                Firstname = text.Split(' ')[1].Trim(),
                Lastname = text.Split(' ')[2].Trim(),
            };
            new AddPopUP(new AuthorUC(author, true)).Show();
        }
    }
}
