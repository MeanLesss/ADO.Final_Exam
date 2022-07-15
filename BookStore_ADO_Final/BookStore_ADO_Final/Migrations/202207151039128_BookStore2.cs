namespace BookStore_ADO_Final.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BookStore2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SellerLogBooks", "TotalPrice", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SellerLogBooks", "TotalPrice");
        }
    }
}
