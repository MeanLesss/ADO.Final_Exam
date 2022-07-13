using System;
using System.Collections.Generic;

namespace BookStore_ADO_Final.Model
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public double PrimeCost { get; set; }
        public double SalePrice { get; set; }
        public int Pages { get; set; }
        public string Genre { get; set; }
        public string BookCoverDir { get; set; }
        public DateTime PublishDate { get; set; }
        //Author full name search by the AuthorID
        public bool Sequel { get; set; }
        //public virtual Publisher Publish { get; set; }
        public virtual ICollection<Publisher> Publishers { get; set; }
        public virtual ICollection<Author> Authors { get; set; }
        
    }
}
