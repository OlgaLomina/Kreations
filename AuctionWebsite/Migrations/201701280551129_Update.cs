namespace AuctionWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Auctions", "EndTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Auctions", "MinIncrement", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Auctions", "MinIncrement");
            DropColumn("dbo.Auctions", "EndTime");
        }
    }
}
