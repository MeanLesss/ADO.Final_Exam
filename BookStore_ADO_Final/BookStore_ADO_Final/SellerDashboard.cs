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
        private readonly Form _form;
        public SellerDashboard()
        {
            InitializeComponent();
        }
        public SellerDashboard(User user,Form form)
        {
            InitializeComponent();
            _user = user;
            _form = form;
        }

        private void iconButtonUserConf_Click(object sender, EventArgs e)
        {
            using (var db = new DataContext())
            {
                var admin = db.Users.FirstOrDefault(z => z.ID == _user.ID);

                new AddPopUP(new SignUpUC(admin, "Seller", true)).Show();
            }
        }

        private void ButtonLogOut_Click(object sender, EventArgs e)
        {
            new WelcomeForm().Show();
            this.Dispose();
        }
    }
}
