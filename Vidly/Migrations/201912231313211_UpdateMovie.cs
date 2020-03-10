namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMovie : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET GenreId = 4 WHERE Id = 7");
        }
        
        public override void Down()
        {
        }
    }
}
