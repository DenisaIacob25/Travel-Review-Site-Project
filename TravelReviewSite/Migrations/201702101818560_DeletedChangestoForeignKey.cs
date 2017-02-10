namespace TravelReviewSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeletedChangestoForeignKey : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Reviews", "ActivityType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reviews", "ActivityType", c => c.String());
        }
    }
}
