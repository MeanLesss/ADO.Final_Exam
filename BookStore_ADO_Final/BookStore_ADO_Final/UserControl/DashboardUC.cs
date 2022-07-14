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
    public partial class DashboardUC : System.Windows.Forms.UserControl
    {
        public DashboardUC()
        {
            InitializeComponent();
        }

        private void LoadDashboard()
        {
            using (var db = new DataContext())
            {
                for (int i = 0; i < 15; i++)
                {
                    panelNewRelease.Controls.Add(new BookCardUC());
                }
                for (int i = 0; i < 15; i++)
                {
                    panelBestSeller.Controls.Add(new BookCardUC());
                }
                for (int i = 0; i < 15; i++)
                {
                    panelPopGenre.Controls.Add(new BookCardUC());
                }

                //convert object to string to display
                var popName = new List<string>();
                foreach (var popAuth in GetBookCountAuthors())
                {
                    popName.Add(popAuth.ID.ToString() + " " + popAuth.Firstname + " " + popAuth.Lastname);
                }

                listBoxPopAuthor.DataSource = popName;

            }
        }
        private List<int> GetBookCountAuthors()
        {
            var popAuthors = new List<int>();

            //fix here
            using (var db = new DataContext())
            {
                
            }
            return popAuthors;
        }

        private void DashboardUC_Load(object sender, EventArgs e)
        {
            LoadDashboard();
        }
    }
}
/*
 * //get count of the number of author in the bookauthors
(from ba in BookAuthors
where ba.Author_ID == 1
group ba by ba.Author_ID into g
select new
{
	AuthorID = g.Select(s => s.Author_ID).Take(1),
	Count = g.Select(s =>s.Author_ID).Count()	
})
*/