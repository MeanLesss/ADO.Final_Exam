namespace BookStore_ADO_Final.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BookStore1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "PublishDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "PublishDate");
        }
    }
}
