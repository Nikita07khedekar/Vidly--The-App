namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedBirthDateAndMembershipName : DbMigration
    {
        public override void Up()
        {
            //Sql("UPDATE Customers SET BirthDate='2001-05-18 00:00:00.000' where Id=2");
            //Sql("UPDATE Customers SET BirthDate='2000-10-09 00:00:00.000' where Id=3");
            //Sql("UPDATE Customers SET BirthDate='1999-05-15 00:00:00.000' where Id=4");
            //Sql("UPDATE Customers SET BirthDate='1999-08-12 00:00:00.000' where Id=5");
            
            //Sql("UPDATE MembershipTypes SET MembershipName='Pay As You Go' where Id=1");
            //Sql("UPDATE MembershipTypes SET MembershipName='Monthly' where Id=2");
            //Sql("UPDATE MembershipTypes SET MembershipName='Half Yearly' where Id=3");
            //Sql("UPDATE MembershipTypes SET MembershipName='Yearly' where Id=4");
        }
        
        public override void Down()
        {
        }
    }
}
