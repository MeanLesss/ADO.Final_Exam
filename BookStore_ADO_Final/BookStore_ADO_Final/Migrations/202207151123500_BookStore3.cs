namespace BookStore_ADO_Final.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BookStore3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SellerLogBooks", "ReportDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SellerLogBooks", "ReportDate");
        }
    }
}
