namespace MovieRentalApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipTypeName : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MEMBERSHIPTYPES SET Name = ('Pay As You Go') WHERE Id = 1 ");
            Sql("UPDATE MEMBERSHIPTYPES SET Name = ('Monthly') WHERE Id = 2 ");
            Sql("UPDATE MEMBERSHIPTYPES SET Name = ('Quarterly') WHERE Id = 3 ");
            Sql("UPDATE MEMBERSHIPTYPES SET Name = ('Annual') WHERE Id = 4 ");


        }
        
        public override void Down()
        {
        }
    }
}
