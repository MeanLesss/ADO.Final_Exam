using System.Data.Entity;
using BookStore_ADO_Final.Model;

namespace BookStore_ADO_Final.Database
{
    public class DataContext : DbContext
    {
        public DataContext():base("BookStore")
        {
            
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }

        public DbSet<BookAuthors> BookAuthors { get; set; }
    }
    /*protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        // Configure Student & StudentAddress entity
        modelBuilder.Entity<Book>()
            .HasRequired(s => s.AuthorName)
            .WithRequiredPrincipal(s => ad); 
    }*/
}