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
    public partial class PublisherUC : System.Windows.Forms.UserControl
    {
        private Publisher _publisher;
        private bool _update = false;
        public PublisherUC()
        {
            InitializeComponent();
        }
        public PublisherUC(Publisher publisher, bool update)
        {
            InitializeComponent();
            _publisher = publisher;
            _update = update;

            textBoxPubName.Text = _publisher.PublisherName;
            dateTimePickerPubDate.Value = _publisher.PublishDate;
        }
        
        private void iconButtonSavePub_Click(object sender, EventArgs e)
        {
            using (DataContext db = new DataContext())
            {
                if (_update is false)
                {
                    db.Publishers.Add(new Publisher
                    {
                        PublisherName = textBoxPubName.Text,
                        PublishDate = dateTimePickerPubDate.Value.Date
                    });
                    db.SaveChanges();
                }
                else
                {
                    var editPub = db.Publishers.FirstOrDefault(a => a.ID == _publisher.ID);
                    editPub.PublisherName = textBoxPubName.Text;
                    editPub.PublishDate = dateTimePickerPubDate.Value.Date;
                    db.Publishers.AddOrUpdate(editPub);
                    db.SaveChanges();
                }
                
            }
            MessageBox.Show("Publisher added !");
            textBoxPubName.Clear();
            dateTimePickerPubDate.ResetImeMode();
        }
    }
}
