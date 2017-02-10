namespace TravelReviewSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeletedCountryClassReview : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Reviews", "Country");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reviews", "Country", c => c.String());
        }
    }
}
