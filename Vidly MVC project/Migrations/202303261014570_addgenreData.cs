namespace Vidly_MVC_project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addgenreData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id,Name) VALUES ('Comedy')");
            Sql("INSERT INTO Genres (Id,Name) VALUES ('Drama')");
            Sql("INSERT INTO Genres (Id,Name) VALUES ('Action')");
            Sql("INSERT INTO Genres (Id,Name) VALUES ('Romantic')");
        }

        public override void Down()
        {
        }
    }
}
