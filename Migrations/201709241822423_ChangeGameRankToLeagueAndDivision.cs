namespace LogOfLegends.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeGameRankToLeagueAndDivision : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Games", "League", c => c.String());
            AddColumn("dbo.Games", "Division", c => c.String());
            DropColumn("dbo.Games", "Rank");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Games", "Rank", c => c.String());
            DropColumn("dbo.Games", "Division");
            DropColumn("dbo.Games", "League");
        }
    }
}
