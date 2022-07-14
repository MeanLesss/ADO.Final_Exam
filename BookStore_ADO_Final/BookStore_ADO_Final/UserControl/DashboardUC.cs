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
                //New release book
                for (int i = 0; i < 15; i++)
                {
                    panelNewRelease.Controls.Add(new BookCardUC());
                }
                //Best seller display
                for (int i = 0; i < 15; i++)
                {
                    panelBestSeller.Controls.Add(new BookCardUC());
                }
                //popular genre display
                for (int i = 0; i < 15; i++)
                {
                    panelPopGenre.Controls.Add(new BookCardUC());
                }

                //convert object to string to display
                var popName = new List<string>();
                var authors = db.Authors.ToList();
                var popList = GetBookCountAuthors().OrderByDescending(t => t.Count).Take(10);
                int rank = 1;
                foreach (var popAuth in popList)
                {
                    foreach (var auth in authors)
                    {
                        if (popAuth.AuthorID == auth.ID)
                        {
                            popName.Add(rank++ + " " + auth.Firstname + " " + auth.Lastname + " *Book Count = "
                                                        + popAuth.Count);
                        }
                    }
                }
                rank = 1;

                listBoxPopAuthor.DataSource = popName;
            }
        }
        private List<BookCountForAuthor> GetBookCountAuthors()
        {
            var popAuthors = new List<BookCountForAuthor>();
             
            //fix here
            using (var db = new DataContext())
            {
                var list = new List<BookCountForAuthor>();
                var bookAuthors = db.BookAuthors.ToList();
                var authors = db.Authors.ToList();

                    list = (from ba in bookAuthors
                            from a in authors
                            where ba.Author.ID == a.ID
                            group ba by ba.Author.ID into g
                            select new BookCountForAuthor
                            {
                                AuthorID = g.Select(s => s.Author.ID).ToList()[0],
                                Count = g.Select(s => s.Author.ID).Count()
                            }).ToList();
                 
                popAuthors = list;
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