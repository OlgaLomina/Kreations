namespace AuctionWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cart : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Carts", "Buyer_Id", "dbo.Buyers");
            DropIndex("dbo.Carts", new[] { "Buyer_Id" });
            RenameColumn(table: "dbo.Carts", name: "Buyer_Id", newName: "BuyerId");
            AlterColumn("dbo.Carts", "BuyerId", c => c.Int(nullable: false));
            CreateIndex("dbo.Carts", "BuyerId");
            AddForeignKey("dbo.Carts", "BuyerId", "dbo.Buyers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Carts", "BuyerId", "dbo.Buyers");
            DropIndex("dbo.Carts", new[] { "BuyerId" });
            AlterColumn("dbo.Carts", "BuyerId", c => c.Int());
            RenameColumn(table: "dbo.Carts", name: "BuyerId", newName: "Buyer_Id");
            CreateIndex("dbo.Carts", "Buyer_Id");
            AddForeignKey("dbo.Carts", "Buyer_Id", "dbo.Buyers", "Id");
        }
    }
}
