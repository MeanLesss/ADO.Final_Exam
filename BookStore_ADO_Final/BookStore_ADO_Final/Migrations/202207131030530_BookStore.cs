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
                "dbo.Books",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        PrimeCost = c.Double(nullable: false),
                        SalePrice = c.Double(),
                        Pages = c.Int(nullable: false),
                        Genre = c.String(),
                        BookCoverDir = c.String(),
                        AuthorName = c.String(),
                        PublisherName = c.String(),
                        Author_ID = c.Int(nullable: false),
                        Sequel = c.Boolean(),
                        Publish_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Authors", t => t.Author_ID)
                .ForeignKey("dbo.Publishers", t => t.Publish_ID)
                .Index(t => t.Author_ID)
                .Index(t => t.Publish_ID);
            
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "Publish_ID", "dbo.Publishers");
            DropForeignKey("dbo.Books", "Author_ID1", "dbo.Authors");
            DropIndex("dbo.Books", new[] { "Publish_ID" });
            DropIndex("dbo.Books", new[] { "Author_ID1" });
            DropTable("dbo.Users");
            DropTable("dbo.Publishers");
            DropTable("dbo.Books");
            DropTable("dbo.Authors");
        }
    }
}
