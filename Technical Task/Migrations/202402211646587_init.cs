namespace Technical_Task.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TotalSums",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SumValue = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TotalSums");
        }
    }
}
