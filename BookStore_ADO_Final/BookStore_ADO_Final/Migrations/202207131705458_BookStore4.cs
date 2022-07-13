namespace BookStore_ADO_Final.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BookStore4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Books", "Author_ID", "dbo.Authors");
            DropIndex("dbo.Books", new[] { "Author_ID" });
            AddColumn("dbo.Authors", "Book_ID", c => c.Int());
            CreateIndex("dbo.Authors", "Book_ID");
            AddForeignKey("dbo.Authors", "Book_ID", "dbo.Books", "ID");
            DropColumn("dbo.Books", "Author_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "Author_ID", c => c.Int());
            DropForeignKey("dbo.Authors", "Book_ID", "dbo.Books");
            DropIndex("dbo.Authors", new[] { "Book_ID" });
            DropColumn("dbo.Authors", "Book_ID");
            CreateIndex("dbo.Books", "Author_ID");
            AddForeignKey("dbo.Books", "Author_ID", "dbo.Authors", "ID");
        }
    }
}
