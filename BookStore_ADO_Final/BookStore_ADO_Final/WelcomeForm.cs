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
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelWelcome.Controls.Add(new LogInUC(this,this.panelWelcome));
        }

        private void WelcomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
           Application.Exit();
        }
    }
}
