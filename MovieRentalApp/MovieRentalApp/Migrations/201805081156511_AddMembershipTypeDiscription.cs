namespace MovieRentalApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembershipTypeDiscription : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "MembershipTypeDiscription", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "MembershipTypeDiscription");
        }
    }
}
