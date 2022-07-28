namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedMovies : DbMigration
    {
        public override void Up()
        {

            //Sql("Insert Into Movies (Name,GenreId)VALUES('Dhoom',2)");
            //Sql("Insert Into Movies (Name,GenreId)VALUES('Baghban',4)");
            //Sql("Insert Into Movies (Name,GenreId)VALUES('Aashiqui2',3)");
            //Sql("Insert Into Movies (Name,GenreId)VALUES('Hunted',5)");
        }
        
        public override void Down()
        {
        }
    }
}
