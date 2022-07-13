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
    public partial class AddPopUP : Form
    {
        private System.Windows.Forms.UserControl _display;
        public AddPopUP(System.Windows.Forms.UserControl Display)
        {
            InitializeComponent();
            _display = Display;
        }

        private void AddPopUP_Load(object sender, EventArgs e)
        {
            this.Controls.Add(_display);
        }
    }
}
