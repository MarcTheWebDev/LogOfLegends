namespace LogOfLegends.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeResultGamePropertyToWasWin : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Games", "wasWin", c => c.Boolean(nullable: false));
            DropColumn("dbo.Games", "Result");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Games", "Result", c => c.String());
            DropColumn("dbo.Games", "wasWin");
        }
    }
}
