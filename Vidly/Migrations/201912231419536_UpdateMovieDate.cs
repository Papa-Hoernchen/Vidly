namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMovieDate : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET RelaseDate = 2009-06-11 WHERE Id = 3");
            Sql("UPDATE Movies SET RelaseDate = 1990-02-02 WHERE Id = 4");
            Sql("UPDATE Movies SET RelaseDate = 1985-03-06 WHERE Id = 5");
            Sql("UPDATE Movies SET RelaseDate = 1995-04-12 WHERE Id = 6");
            Sql("UPDATE Movies SET RelaseDate = 1999-12-12 WHERE Id = 7");
        }
        
        public override void Down()
        {
        }
    }
}
