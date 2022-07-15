using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore_ADO_Final.Model
{
    public class Stock
    {
        public int ID { get; set; }
        public int BookQuantity { get; set; }
        public virtual Book Book { get; set; }
    }
}
