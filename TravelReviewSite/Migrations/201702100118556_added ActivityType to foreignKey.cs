namespace TravelReviewSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedActivityTypetoforeignKey : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reviews", "ActivityType", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reviews", "ActivityType");
        }
    }
}
