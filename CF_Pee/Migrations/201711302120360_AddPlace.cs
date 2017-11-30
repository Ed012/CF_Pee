namespace CF_Pee.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPlace : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Places",
                c => new
                    {
                        IdPlace = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.IdPlace);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Places");
        }
    }
}
