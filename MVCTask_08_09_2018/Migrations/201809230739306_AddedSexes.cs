namespace MVCTask_08_09_2018.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedSexes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sexes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Sexes");
        }
    }
}
