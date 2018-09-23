namespace MVCTask_08_09_2018.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedNames : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Names",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Value = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Names");
        }
    }
}
