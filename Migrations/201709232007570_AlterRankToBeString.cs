namespace LogOfLegends.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterRankToBeString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Games", "Rank", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Games", "Rank", c => c.Int(nullable: false));
        }
    }
}
