namespace CF_Pee.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSCycleCourse : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        IdCourse = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        IdCycle = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdCourse)
                .ForeignKey("dbo.Cycles", t => t.IdCycle, cascadeDelete: true)
                .Index(t => t.IdCycle);
            
            CreateTable(
                "dbo.Cycles",
                c => new
                    {
                        IdCycle = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Period = c.String(),
                    })
                .PrimaryKey(t => t.IdCycle);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "IdCycle", "dbo.Cycles");
            DropIndex("dbo.Courses", new[] { "IdCycle" });
            DropTable("dbo.Cycles");
            DropTable("dbo.Courses");
        }
    }
}
