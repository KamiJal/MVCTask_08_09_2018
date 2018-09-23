namespace MVCTask_08_09_2018.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateProgrammingLanguage : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO ProgrammingLanguages VALUES ('C#')");
            Sql("INSERT INTO ProgrammingLanguages VALUES ('Java')");
            Sql("INSERT INTO ProgrammingLanguages VALUES ('C++')");
            Sql("INSERT INTO ProgrammingLanguages VALUES ('Python')");
            Sql("INSERT INTO ProgrammingLanguages VALUES ('JavaScript')");
            Sql("INSERT INTO ProgrammingLanguages VALUES ('Ruby')");
            Sql("INSERT INTO ProgrammingLanguages VALUES ('1C')");
        }
        
        public override void Down()
        {
        }
    }
}
