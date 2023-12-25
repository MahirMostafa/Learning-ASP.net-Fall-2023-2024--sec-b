namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PersonDepartments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonId = c.Int(nullable: false),
                        DepartmentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: true)
                .ForeignKey("dbo.People", t => t.PersonId, cascadeDelete: true)
                .Index(t => t.PersonId)
                .Index(t => t.DepartmentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PersonDepartments", "PersonId", "dbo.People");
            DropForeignKey("dbo.PersonDepartments", "DepartmentId", "dbo.Departments");
            DropIndex("dbo.PersonDepartments", new[] { "DepartmentId" });
            DropIndex("dbo.PersonDepartments", new[] { "PersonId" });
            DropTable("dbo.PersonDepartments");
        }
    }
}
