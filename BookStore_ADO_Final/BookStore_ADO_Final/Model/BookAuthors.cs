using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore_ADO_Final.Model
{
    public class BookAuthors
    {
        /*public int Book_ID { get; set; }
        public int Author_ID { get; set; }*/
        public int ID { get; set; }
        public virtual Book Book { get; set; }
        public virtual Author Author { get; set; }
    }
}
