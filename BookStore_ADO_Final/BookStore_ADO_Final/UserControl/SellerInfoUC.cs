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
    public partial class SellerInfoUC : System.Windows.Forms.UserControl
    {
        public SellerInfoUC()
        {
            InitializeComponent();
        }
        private void LoadSeller()
        {
            using (var db = new DataContext())
            {
                var fullname = new List<string>();
                var users = db.Users.ToList();
                var sellers = users.Where(u => u.Role == "Seller")
                            .Select(x => new User
                            {
                                ID = x.ID,
                                Username = x.Username,
                                Password = x.Password,
                                Phone = x.Phone,
                                Email = x.Email,
                                PhotoDir = x.PhotoDir,
                                Role = x.Role
                            }).ToList();
                foreach (var seller in sellers)
                {
                    fullname.Add(seller.ID + "-" + seller.Username + "/" + seller.Password);
                }
                listBoxSeller.DataSource = fullname;
            }
        }
        private void SellerInfoUC_Load(object sender, EventArgs e)
        {
            LoadSeller();
        }

        private void iconButtonAddSeller_Click(object sender, EventArgs e)
        {
            new AddPopUP(new SignUpUC("Seller")).Show();
        }

        private void iconButtonRefresh_Click(object sender, EventArgs e)
        {
            LoadSeller();
        }

        private void textBoxSearch_Click(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
        }

        private void listBoxSeller_Click(object sender, EventArgs e)
        {
            string text = listBoxSeller.GetItemText(listBoxSeller.SelectedItem);

            var id = int.Parse(text.Split('-')[0].Trim());

            using (var db = new DataContext())
            {
                var seller = db.Users.FirstOrDefault(x => x.ID == id);

                new AddPopUP(new SignUpUC(seller,"Seller", true)).Show();
            }
        }
    }
}
