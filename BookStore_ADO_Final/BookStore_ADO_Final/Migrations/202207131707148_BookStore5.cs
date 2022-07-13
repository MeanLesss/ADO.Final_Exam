namespace BookStore_ADO_Final.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BookStore5 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Authors", "Book_ID", "dbo.Books");
            DropIndex("dbo.Authors", new[] { "Book_ID" });
            CreateTable(
                "dbo.BookAuthors",
                c => new
                    {
                        Book_ID = c.Int(nullable: false),
                        Author_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Book_ID, t.Author_ID })
                .ForeignKey("dbo.Books", t => t.Book_ID, cascadeDelete: true)
                .ForeignKey("dbo.Authors", t => t.Author_ID, cascadeDelete: true)
                .Index(t => t.Book_ID)
                .Index(t => t.Author_ID);
            
            DropColumn("dbo.Authors", "Book_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Authors", "Book_ID", c => c.Int());
            DropForeignKey("dbo.BookAuthors", "Author_ID", "dbo.Authors");
            DropForeignKey("dbo.BookAuthors", "Book_ID", "dbo.Books");
            DropIndex("dbo.BookAuthors", new[] { "Author_ID" });
            DropIndex("dbo.BookAuthors", new[] { "Book_ID" });
            DropTable("dbo.BookAuthors");
            CreateIndex("dbo.Authors", "Book_ID");
            AddForeignKey("dbo.Authors", "Book_ID", "dbo.Books", "ID");
        }
    }
}
