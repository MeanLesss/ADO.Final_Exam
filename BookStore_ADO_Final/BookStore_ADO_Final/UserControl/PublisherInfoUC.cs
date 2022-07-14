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
    public partial class PublisherInfoUC : System.Windows.Forms.UserControl
    {
        public PublisherInfoUC()
        {
            InitializeComponent();
        }
        private void LoadPublisher()
        {
            using (var db = new DataContext())
            {
                var fullname = new List<string>();
                foreach (var pub in db.Publishers.ToList())
                {
                    fullname.Add(pub.ID.ToString() + "-" + pub.PublisherName + "/" + pub.PublishDate);
                }
                listBoxPublisher.DataSource = fullname;
            }
        }
        private void PublisherInfoUC_Load(object sender, EventArgs e)
        {
            LoadPublisher();
        }
        private void iconButtonRefresh_Click(object sender, EventArgs e)
        {
            LoadPublisher();
        }
        private void iconButtonSearch_Click(object sender, EventArgs e)
        {
            using (var db = new DataContext())
            {
                var foundPub = new List<string>();
                var searchList = db.Publishers.ToList();

                foreach (var pub in searchList)
                {
                    if ((pub.PublisherName).ToLower()
                        .Equals(textBoxSearch.Text.ToLower()))
                    {
                        foundPub.Add(pub.ID.ToString() + "-" + pub.PublisherName + "/" + pub.PublishDate);
                    }
                }
                if (!(foundPub is null))
                {
                    foreach (var item in foundPub)
                    {
                        listBoxPublisher.DataSource = foundPub;
                    }
                }
            }
        }

        private void iconButtonAddPub_Click(object sender, EventArgs e)
        {
            new AddPopUP(new PublisherUC()).Show();
        }

        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
        }

        private void listBoxPublisher_Click(object sender, EventArgs e)
        {
            string text = listBoxPublisher.GetItemText(listBoxPublisher.SelectedItem);

            var author = new Publisher
            {
                ID = int.Parse(text.Split('-')[0].Trim()),
                PublisherName = text.Split('-')[1].Split('/')[0].Trim(),
                PublishDate = DateTime.Now.Date
            };
            new AddPopUP(new PublisherUC(author, true)).Show();
        }
    }
}
