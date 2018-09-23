namespace MVCTask_08_09_2018.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateDepartments : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Departments VALUES ('Development', 3)");
            Sql("INSERT INTO Departments VALUES ('Software Testing', 2)");
            Sql("INSERT INTO Departments VALUES ('Application Analysis', 4)");
            Sql("INSERT INTO Departments VALUES ('Software Prototyping', 3)");
            Sql("INSERT INTO Departments VALUES ('Data Migration', 4)");
        }
        
        public override void Down()
        {
        }
    }
}
