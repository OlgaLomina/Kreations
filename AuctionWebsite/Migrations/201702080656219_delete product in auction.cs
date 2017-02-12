namespace AuctionWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deleteproductinauction : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Auctions", "Product_Id", "dbo.Products");
            DropIndex("dbo.Auctions", new[] { "Product_Id" });
            DropColumn("dbo.Auctions", "Product_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Auctions", "Product_Id", c => c.Int());
            CreateIndex("dbo.Auctions", "Product_Id");
            AddForeignKey("dbo.Auctions", "Product_Id", "dbo.Products", "Id");
        }
    }
}
