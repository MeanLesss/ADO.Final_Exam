using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookStore_ADO_Final.Database;
using BookStore_ADO_Final.Model;

namespace BookStore_ADO_Final
{
    public partial class LogInUC : System.Windows.Forms.UserControl
    {
        private Panel _panel;
        Form _form;
        public LogInUC()
        {
            InitializeComponent();
        }
        public LogInUC(Form form,Panel panel)
        {
            InitializeComponent();
            _form = form;
            _panel = panel;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                iconButtonLogin.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            _panel.Controls.Clear();
            _panel.Controls.Add(new SignUpUC(_form,_panel));
        }

        private void iconButtonLogin_Click(object sender, EventArgs e)
        {
            var user = new UserAuthentication().UserAuthenticating(textBoxUsername.Text, textBoxPass.Text);
            if (!(user is null))
            {
                if (user.Role is "Admin")
                {
                    new Dashboard(user, _form).Show();
                    _form.Hide();
                    return;
                }
                //different dashboard

            }

            MessageBox.Show("User not found!!","Error",MessageBoxButtons.OK);

        }

        private void LogInUC_Load(object sender, EventArgs e)
        {

        }
    }
}
