namespace AuctionWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cartsaddbuyerattribute : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Carts", "Buyer_Id", c => c.Int());
            CreateIndex("dbo.Carts", "Buyer_Id");
            AddForeignKey("dbo.Carts", "Buyer_Id", "dbo.Buyers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Carts", "Buyer_Id", "dbo.Buyers");
            DropIndex("dbo.Carts", new[] { "Buyer_Id" });
            DropColumn("dbo.Carts", "Buyer_Id");
        }
    }
}
