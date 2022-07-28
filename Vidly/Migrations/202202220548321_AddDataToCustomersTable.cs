namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataToCustomersTable : DbMigration
    {
        public override void Up()
        {
            //Sql("Insert Into Customers(Name,IsSubscribedToNewsLater,MembershipTypeId)Values ('Nikita', 0 , 1) ");
            //Sql("Insert Into Customers(Name,IsSubscribedToNewsLater,MembershipTypeId)Values ('Naveen', 1 , 2) ");
            //Sql("Insert Into Customers(Name,IsSubscribedToNewsLater,MembershipTypeId)Values ('Nitin', 1 , 3) ");
            //Sql("Insert Into Customers(Name,IsSubscribedToNewsLater,MembershipTypeId)Values ('Pragati', 1 , 4) ");

        }
        
        public override void Down()
        {
        }
    }
}
