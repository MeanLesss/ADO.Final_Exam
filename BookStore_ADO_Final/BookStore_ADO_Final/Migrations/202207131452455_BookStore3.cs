namespace BookStore_ADO_Final.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BookStore3 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Books", "AuthorName");
            DropColumn("dbo.Books", "PublisherName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "PublisherName", c => c.String());
            AddColumn("dbo.Books", "AuthorName", c => c.String());
        }
    }
}
