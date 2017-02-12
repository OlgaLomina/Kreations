namespace AuctionWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deleteendtimeattributeintheauction : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Auctions", "EndTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Auctions", "EndTime", c => c.DateTime(nullable: false));
        }
    }
}
