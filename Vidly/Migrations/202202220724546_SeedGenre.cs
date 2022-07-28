namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedGenre : DbMigration
    {
        public override void Up()
        {

            //Sql("Insert Into Genres (Name)VALUES('Action')");
            //Sql("Insert Into Genres (Name)VALUES('Romance')");
            //Sql("Insert Into Genres (Name)VALUES('Family')");
            //Sql("Insert Into Genres (Name)VALUES('Horror')");
        }
        
        public override void Down()
        {
        }
    }
}
