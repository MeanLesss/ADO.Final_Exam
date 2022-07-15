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
using BookStore_ADO_Final.UserControl;

namespace BookStore_ADO_Final
{
    public partial class Dashboard : Form
    {
        private readonly User _user;
        private Form _form;

        public Dashboard()
        {
            InitializeComponent();
        }
        public Dashboard(User user,Form form)
        {
            InitializeComponent();
            _user = user;
            _form = form;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            iconPictureBoxUser.Image = Image.FromFile(_user.PhotoDir);
            labelUsername.Text = _user.Username;
            labelID.Text = _user.ID.ToString();

            //Load Dashboard first
            panelControl.Controls.Clear();
            var uc = new DashboardUC();
            uc.Dock = DockStyle.Fill;
            panelControl.Controls.Add(uc);

        }
        private void ButtonLogOut_Click(object sender, EventArgs e)
        {
            new WelcomeForm().Show();
            this.Dispose();
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void iconButtonBooks_Click(object sender, EventArgs e)
        {
            panelControl.Controls.Clear();
            var uc = new BooksUC(panelControl);
            uc.Dock = DockStyle.Fill;
            panelControl.Controls.Add(uc);
        }

        private void iconButtonAuthors_Click(object sender, EventArgs e)
        {
            panelControl.Controls.Clear();
            var uc = new AuthorInfoUC();
            uc.Dock = DockStyle.Fill;
            panelControl.Controls.Add(uc);
        }

        private void iconButtonPublishers_Click(object sender, EventArgs e)
        {
            panelControl.Controls.Clear();
            var uc = new PublisherInfoUC();
            uc.Dock = DockStyle.Fill;
            panelControl.Controls.Add(uc);
        }

        private void iconButtonDashboard_Click(object sender, EventArgs e)
        {
            panelControl.Controls.Clear();
            var uc = new DashboardUC();
            uc.Dock = DockStyle.Fill;
            panelControl.Controls.Add(uc);
        }

        private void iconButtonSellers_Click(object sender, EventArgs e)
        {
            panelControl.Controls.Clear();
            var uc = new SellerInfoUC();
            uc.Dock = DockStyle.Fill;
            panelControl.Controls.Add(uc);
        }

        private void iconButtonUserConf_Click(object sender, EventArgs e)
        {
            using (var db = new DataContext())
            {
                var admin = db.Users.FirstOrDefault(z => z.ID == _user.ID);

                new AddPopUP(new SignUpUC(admin, "Admin", true)).Show();
            }
        }

        private void iconButtonReport_Click(object sender, EventArgs e)
        {
            panelControl.Controls.Clear();
            var uc = new ReportUC();
            uc.Dock = DockStyle.Fill;
            panelControl.Controls.Add(uc);
        }
    }
}
