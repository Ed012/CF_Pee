namespace CF_Pee.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTeacher : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        IdTeacher = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LastName = c.String(),
                        Address = c.String(),
                        Email = c.String(),
                        Pass = c.String(),
                        DNI = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdTeacher);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Teachers");
        }
    }
}
