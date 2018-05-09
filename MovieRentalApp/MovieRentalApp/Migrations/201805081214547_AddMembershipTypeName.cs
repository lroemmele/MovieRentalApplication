namespace MovieRentalApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembershipTypeName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "MembershipTypeName", c => c.String(nullable: false));
            DropColumn("dbo.MembershipTypes", "MembershipTypeDiscription");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MembershipTypes", "MembershipTypeDiscription", c => c.String());
            DropColumn("dbo.MembershipTypes", "MembershipTypeName");
        }
    }
}
