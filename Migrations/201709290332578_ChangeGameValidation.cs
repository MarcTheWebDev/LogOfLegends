namespace LogOfLegends.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeGameValidation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Games", "Description", c => c.String(maxLength: 500));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Games", "Description", c => c.String());
        }
    }
}
