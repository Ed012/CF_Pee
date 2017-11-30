namespace CF_Pee.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNote : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Notes",
                c => new
                    {
                        IdNote = c.Int(nullable: false, identity: true),
                        First_Test = c.Int(nullable: false),
                        Last_Test = c.Int(nullable: false),
                        IdCourse = c.Int(nullable: false),
                        IdStudent = c.Int(nullable: false),
                        Student_Id = c.Int(),
                    })
                .PrimaryKey(t => t.IdNote)
                .ForeignKey("dbo.Courses", t => t.IdCourse, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.Student_Id)
                .Index(t => t.IdCourse)
                .Index(t => t.Student_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Notes", "Student_Id", "dbo.Students");
            DropForeignKey("dbo.Notes", "IdCourse", "dbo.Courses");
            DropIndex("dbo.Notes", new[] { "Student_Id" });
            DropIndex("dbo.Notes", new[] { "IdCourse" });
            DropTable("dbo.Notes");
        }
    }
}
