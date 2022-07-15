using BookStore_ADO_Final.Database;
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
    public partial class ReportUC : System.Windows.Forms.UserControl
    {
        public ReportUC()
        {
            InitializeComponent();
        }

        private void ReportUC_Load(object sender, EventArgs e)
        {
            using (var db = new DataContext())
            {
                var reports = new List<string>();
                foreach (var report in db.SellerLogBooks.ToList())
                {
                    reports.Add(report.ReportDate.ToString() + "=> " +
                            report.Seller.Username + " : " + report.Stock.Book.Title + " * " + report.SoldQuantity
                            + " = $" + report.TotalPrice);
                }
                listBoxReport.DataSource = reports;
            }
        }
    }
}
