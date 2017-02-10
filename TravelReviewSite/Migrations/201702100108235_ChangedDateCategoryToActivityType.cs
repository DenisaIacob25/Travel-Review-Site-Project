namespace TravelReviewSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedDateCategoryToActivityType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "ActivityType", c => c.String());
            DropColumn("dbo.Categories", "DatePosted");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "DatePosted", c => c.DateTime(nullable: false));
            DropColumn("dbo.Categories", "ActivityType");
        }
    }
}
