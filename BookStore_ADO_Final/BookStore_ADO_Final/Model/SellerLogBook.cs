using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore_ADO_Final.Model
{
    public class SellerLogBook
    {
        public int ID { get; set; }
        public int SoldQuantity { get; set; }
        public virtual Stock Stock { get; set; }
        public virtual User Seller { get; set; }
    }
}
