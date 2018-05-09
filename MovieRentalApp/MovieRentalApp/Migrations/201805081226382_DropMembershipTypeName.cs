namespace MovieRentalApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropMembershipTypeName : DbMigration
    {
        public override void Up()
        {
            
            DropColumn("dbo.MembershipTypes", "MembershipTypeName");
        }
        
        public override void Down()
        {
            
            DropColumn("dbo.MembershipTypes", "Name");
        }
    }
}
