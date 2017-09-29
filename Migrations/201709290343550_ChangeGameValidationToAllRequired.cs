namespace LogOfLegends.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeGameValidationToAllRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Games", "League", c => c.String(nullable: false));
            AlterColumn("dbo.Games", "Score", c => c.String(nullable: false));
            AlterColumn("dbo.Games", "Champion", c => c.String(nullable: false));
            AlterColumn("dbo.Games", "Role", c => c.String(nullable: false));
            AlterColumn("dbo.Games", "Description", c => c.String(nullable: false, maxLength: 500));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Games", "Description", c => c.String(maxLength: 500));
            AlterColumn("dbo.Games", "Role", c => c.String());
            AlterColumn("dbo.Games", "Champion", c => c.String());
            AlterColumn("dbo.Games", "Score", c => c.String());
            AlterColumn("dbo.Games", "League", c => c.String());
        }
    }
}
