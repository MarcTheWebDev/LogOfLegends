namespace LogOfLegends.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddChampionPropToGameModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Games", "Champion", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Games", "Champion");
        }
    }
}
