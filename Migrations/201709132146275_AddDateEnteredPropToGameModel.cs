namespace LogOfLegends.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDateEnteredPropToGameModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Games", "DateEntered", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Games", "DateEntered");
        }
    }
}
