namespace MVCTask_08_09_2018.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateEmployeeWithDefaultData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Employees VALUES('Kamil', 'Ushurbakiyev', 30, 1, 1, 1)");
            Sql("INSERT INTO Employees VALUES('Bill', 'Gates', 62, 1, 4, 1)");
            Sql("INSERT INTO Employees VALUES('Andrew', 'Houston', 35, 1, 5, 3)");
            Sql("INSERT INTO Employees VALUES('Marissa', 'Mayer', 43, 2, 3, 4)");
            Sql("INSERT INTO Employees VALUES('Mark', 'Zuckerberg', 34, 1, 2, 5)");
        }
        
        public override void Down()
        {
        }
    }
}
