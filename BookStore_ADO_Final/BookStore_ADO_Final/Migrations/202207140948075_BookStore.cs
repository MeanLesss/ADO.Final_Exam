namespace BookStore_ADO_Final.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BookStore : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Firstname = c.String(),
                        Lastname = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.BookAuthors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Author_ID = c.Int(),
                        Book_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Authors", t => t.Author_ID)
                .ForeignKey("dbo.Books", t => t.Book_ID)
                .Index(t => t.Author_ID)
                .Index(t => t.Book_ID);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        PrimeCost = c.Double(nullable: false),
                        SalePrice = c.Double(nullable: false),
                        Pages = c.Int(nullable: false),
                        Genre = c.String(),
                        BookCoverDir = c.String(),
                        PublishDate = c.DateTime(nullable: false),
                        Sequel = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Publishers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PublisherName = c.String(),
                        PublishDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        PhotoDir = c.String(),
                        Role = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PublisherBooks",
                c => new
                    {
                        Publisher_ID = c.Int(nullable: false),
                        Book_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Publisher_ID, t.Book_ID })
                .ForeignKey("dbo.Publishers", t => t.Publisher_ID, cascadeDelete: true)
                .ForeignKey("dbo.Books", t => t.Book_ID, cascadeDelete: true)
                .Index(t => t.Publisher_ID)
                .Index(t => t.Book_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BookAuthors", "Book_ID", "dbo.Books");
            DropForeignKey("dbo.PublisherBooks", "Book_ID", "dbo.Books");
            DropForeignKey("dbo.PublisherBooks", "Publisher_ID", "dbo.Publishers");
            DropForeignKey("dbo.BookAuthors", "Author_ID", "dbo.Authors");
            DropIndex("dbo.PublisherBooks", new[] { "Book_ID" });
            DropIndex("dbo.PublisherBooks", new[] { "Publisher_ID" });
            DropIndex("dbo.BookAuthors", new[] { "Book_ID" });
            DropIndex("dbo.BookAuthors", new[] { "Author_ID" });
            DropTable("dbo.PublisherBooks");
            DropTable("dbo.Users");
            DropTable("dbo.Publishers");
            DropTable("dbo.Books");
            DropTable("dbo.BookAuthors");
            DropTable("dbo.Authors");
        }
    }
}
