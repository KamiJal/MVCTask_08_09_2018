namespace MVCTask_08_09_2018.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateSexes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Sexes VALUES ('male')");
            Sql("INSERT INTO Sexes VALUES ('female')");
        }
        
        public override void Down()
        {
        }
    }
}
