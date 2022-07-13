namespace BookStore_ADO_Final.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BookStore2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Books", "Publish_ID", "dbo.Publishers");
            DropIndex("dbo.Books", new[] { "Publish_ID" });
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
            
            DropColumn("dbo.Books", "Publish_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "Publish_ID", c => c.Int());
            DropForeignKey("dbo.PublisherBooks", "Book_ID", "dbo.Books");
            DropForeignKey("dbo.PublisherBooks", "Publisher_ID", "dbo.Publishers");
            DropIndex("dbo.PublisherBooks", new[] { "Book_ID" });
            DropIndex("dbo.PublisherBooks", new[] { "Publisher_ID" });
            DropTable("dbo.PublisherBooks");
            CreateIndex("dbo.Books", "Publish_ID");
            AddForeignKey("dbo.Books", "Publish_ID", "dbo.Publishers", "ID");
        }
    }
}
