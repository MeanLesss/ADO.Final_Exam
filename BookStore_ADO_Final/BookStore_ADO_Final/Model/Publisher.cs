using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore_ADO_Final.Model
{
    public class Publisher
    {
        public int ID { get; set; }
        public string PublisherName { get; set; }
        public DateTime PublishDate { get; set; }
        public virtual ICollection<Book> Books{ get; set; }
    }
}
