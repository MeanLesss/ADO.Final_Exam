namespace BookStore_ADO_Final.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BookStore1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SellerLogBooks",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SoldQuantity = c.Int(nullable: false),
                        Seller_ID = c.Int(),
                        Stock_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.Seller_ID)
                .ForeignKey("dbo.Stocks", t => t.Stock_ID)
                .Index(t => t.Seller_ID)
                .Index(t => t.Stock_ID);
            
            CreateTable(
                "dbo.Stocks",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        BookQuantity = c.Int(nullable: false),
                        Book_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Books", t => t.Book_ID)
                .Index(t => t.Book_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SellerLogBooks", "Stock_ID", "dbo.Stocks");
            DropForeignKey("dbo.Stocks", "Book_ID", "dbo.Books");
            DropForeignKey("dbo.SellerLogBooks", "Seller_ID", "dbo.Users");
            DropIndex("dbo.Stocks", new[] { "Book_ID" });
            DropIndex("dbo.SellerLogBooks", new[] { "Stock_ID" });
            DropIndex("dbo.SellerLogBooks", new[] { "Seller_ID" });
            DropTable("dbo.Stocks");
            DropTable("dbo.SellerLogBooks");
        }
    }
}
