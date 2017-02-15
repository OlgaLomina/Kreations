namespace AuctionWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class revisedpropertiesnamesinAuctionclass : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Auctions", "WinningBidId", c => c.Int(nullable: false));
            DropColumn("dbo.Auctions", "HighestBidId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Auctions", "HighestBidId", c => c.Int(nullable: false));
            DropColumn("dbo.Auctions", "WinningBidId");
        }
    }
}
