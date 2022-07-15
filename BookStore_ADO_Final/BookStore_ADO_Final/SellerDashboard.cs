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

namespace BookStore_ADO_Final
{
    public partial class SellerDashboard : Form
    {
        private readonly User _user;
        public SellerDashboard()
        {
            InitializeComponent();
        }
        public SellerDashboard(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void iconButtonUserConf_Click(object sender, EventArgs e)
        {
            using (var db = new DataContext())
            {
                var admin = db.Users.FirstOrDefault(z => z.ID == _user.ID);

                new AddPopUP(new SignUpUC(admin, "Seller", true)).Show();
            }
        }
    }
}
