namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies1 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, RelaseDate, CreatedAt, NumberInStock, GenreId) VALUES ('Hangover', 2009-06-11, 2019-12-23, 5, 1)");
            Sql("INSERT INTO Movies (Name, RelaseDate, CreatedAt, NumberInStock, GenreId) VALUES ('Die Hard', 1990-06-05, 2019-12-23, 10, 2)");
            Sql("INSERT INTO Movies (Name, RelaseDate, CreatedAt, NumberInStock, GenreId) VALUES ('The Terminator', 1985-01-01, 2019-12-23, 4, 2)");
            Sql("INSERT INTO Movies (Name, RelaseDate, CreatedAt, NumberInStock, GenreId) VALUES ('Toy Story', 1998-02-02, 2019-12-23, 15, 3)");
            Sql("INSERT INTO Movies (Name, RelaseDate, CreatedAt, NumberInStock, GenreId) VALUES ('Titanic', 1999-12-12, 2019-12-23, 10, 2)");
        }
        
        public override void Down()
        {
        }
    }
}
