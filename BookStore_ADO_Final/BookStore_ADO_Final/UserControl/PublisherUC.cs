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
    public partial class PublisherUC : System.Windows.Forms.UserControl
    {
        public PublisherUC()
        {
            InitializeComponent();
        }
        
        private void iconButtonSavePub_Click(object sender, EventArgs e)
        {
            using (DataContext db = new DataContext())
            {
                db.Publishers.Add(
                    new Publisher
                    {
                        PublisherName = textBoxPubName.Text,
                        PublishDate = dateTimePickerPubDate.Value.Date
                    });
                db.SaveChanges();
            }
            MessageBox.Show("Publisher added !");
            textBoxPubName.Clear();
            dateTimePickerPubDate.ResetImeMode();
        }
    }
}
