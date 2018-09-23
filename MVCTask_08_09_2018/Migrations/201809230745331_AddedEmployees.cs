namespace MVCTask_08_09_2018.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedEmployees : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 255),
                        LastName = c.String(nullable: false, maxLength: 255),
                        Age = c.Int(nullable: false),
                        SexId = c.Int(nullable: false),
                        DepartmentId = c.Int(nullable: false),
                        ProgrammingLanguageId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: true)
                .ForeignKey("dbo.ProgrammingLanguages", t => t.ProgrammingLanguageId, cascadeDelete: true)
                .ForeignKey("dbo.Sexes", t => t.SexId, cascadeDelete: true)
                .Index(t => t.SexId)
                .Index(t => t.DepartmentId)
                .Index(t => t.ProgrammingLanguageId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "SexId", "dbo.Sexes");
            DropForeignKey("dbo.Employees", "ProgrammingLanguageId", "dbo.ProgrammingLanguages");
            DropForeignKey("dbo.Employees", "DepartmentId", "dbo.Departments");
            DropIndex("dbo.Employees", new[] { "ProgrammingLanguageId" });
            DropIndex("dbo.Employees", new[] { "DepartmentId" });
            DropIndex("dbo.Employees", new[] { "SexId" });
            DropTable("dbo.Employees");
        }
    }
}
