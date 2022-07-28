namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedNewFieldsOfMovies : DbMigration
    {
        public override void Up()
        {
            //Sql("UPDATE Movies SET DateAdded='2011-12-01 00:00:00:000',ReleaseDate='2012-01-01 00:00:00:000',NumberInStock=50 WHERE   Id=3");
            //Sql("UPDATE Movies SET DateAdded='2012-12-02 00:00:00:000',ReleaseDate='2013-01-02 00:00:00:000',NumberInStock=50 WHERE   Id=4");
            //Sql("UPDATE Movies SET DateAdded='2013-12-03 00:00:00:000',ReleaseDate='2014-01-03 00:00:00:000',NumberInStock=50 WHERE   Id=5");
            //Sql("UPDATE Movies SET DateAdded='2014-12-04 00:00:00:000',ReleaseDate='2015-01-04 00:00:00:000',NumberInStock=50 WHERE   Id=6");
        }
        
        public override void Down()
        {
        }
    }
}
