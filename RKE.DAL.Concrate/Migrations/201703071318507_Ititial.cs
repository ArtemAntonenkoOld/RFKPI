namespace RKE.DAL.Concrate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ititial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tbGroup",
                c => new
                    {
                        cId = c.Int(nullable: false, identity: true),
                        cNameOfGroup = c.String(),
                        cRozkladLink = c.String(),
                        Type = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.cId);
            
            CreateTable(
                "dbo.tbLessonForExternalStudents",
                c => new
                    {
                        cId = c.Int(nullable: false, identity: true),
                        cDate = c.DateTime(nullable: false),
                        cNameOfLesson = c.String(),
                        cAud = c.String(),
                        cNumberOfLesson = c.Int(nullable: false),
                        Group_Id = c.Int(),
                        Teacher_Id = c.Int(),
                    })
                .PrimaryKey(t => t.cId)
                .ForeignKey("dbo.tbGroup", t => t.Group_Id)
                .ForeignKey("dbo.tbTeacher", t => t.Teacher_Id)
                .Index(t => t.Group_Id)
                .Index(t => t.Teacher_Id);
            
            CreateTable(
                "dbo.tbSession",
                c => new
                    {
                        cId = c.Int(nullable: false, identity: true),
                        cDate = c.DateTime(nullable: false),
                        cNameOfLesson = c.String(),
                        cAud = c.String(),
                        cNumberOfLesson = c.Int(nullable: false),
                        Group_Id = c.Int(),
                        Teacher_Id = c.Int(),
                    })
                .PrimaryKey(t => t.cId)
                .ForeignKey("dbo.tbGroup", t => t.Group_Id)
                .ForeignKey("dbo.tbTeacher", t => t.Teacher_Id)
                .Index(t => t.Group_Id)
                .Index(t => t.Teacher_Id);
            
            CreateTable(
                "dbo.tbWeek",
                c => new
                    {
                        cId = c.Int(nullable: false, identity: true),
                        cNumberOfWeek = c.Int(nullable: false),
                        Group_Id = c.Int(),
                    })
                .PrimaryKey(t => t.cId)
                .ForeignKey("dbo.tbGroup", t => t.Group_Id)
                .Index(t => t.Group_Id);
            
            CreateTable(
                "dbo.tbLesson",
                c => new
                    {
                        cId = c.Int(nullable: false, identity: true),
                        cDay = c.Int(nullable: false),
                        cNumberOfLesson = c.Int(nullable: false),
                        сAud = c.String(),
                        cType = c.String(),
                        Week_Id = c.Int(),
                        Teacher_Id = c.Int(),
                    })
                .PrimaryKey(t => t.cId)
                .ForeignKey("dbo.tbWeek", t => t.Week_Id)
                .ForeignKey("dbo.tbTeacher", t => t.Teacher_Id)
                .Index(t => t.Week_Id)
                .Index(t => t.Teacher_Id);
            
            CreateTable(
                "dbo.tbTeacher",
                c => new
                    {
                        cId = c.Int(nullable: false, identity: true),
                        cName = c.String(),
                        cFullName = c.String(),
                        cShortName = c.String(),
                        cPosition = c.String(),
                        cLink = c.String(),
                    })
                .PrimaryKey(t => t.cId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tbSession", "Teacher_Id", "dbo.tbTeacher");
            DropForeignKey("dbo.tbLesson", "Teacher_Id", "dbo.tbTeacher");
            DropForeignKey("dbo.tbLessonForExternalStudents", "Teacher_Id", "dbo.tbTeacher");
            DropForeignKey("dbo.tbWeek", "Group_Id", "dbo.tbGroup");
            DropForeignKey("dbo.tbLesson", "Week_Id", "dbo.tbWeek");
            DropForeignKey("dbo.tbSession", "Group_Id", "dbo.tbGroup");
            DropForeignKey("dbo.tbLessonForExternalStudents", "Group_Id", "dbo.tbGroup");
            DropIndex("dbo.tbLesson", new[] { "Teacher_Id" });
            DropIndex("dbo.tbLesson", new[] { "Week_Id" });
            DropIndex("dbo.tbWeek", new[] { "Group_Id" });
            DropIndex("dbo.tbSession", new[] { "Teacher_Id" });
            DropIndex("dbo.tbSession", new[] { "Group_Id" });
            DropIndex("dbo.tbLessonForExternalStudents", new[] { "Teacher_Id" });
            DropIndex("dbo.tbLessonForExternalStudents", new[] { "Group_Id" });
            DropTable("dbo.tbTeacher");
            DropTable("dbo.tbLesson");
            DropTable("dbo.tbWeek");
            DropTable("dbo.tbSession");
            DropTable("dbo.tbLessonForExternalStudents");
            DropTable("dbo.tbGroup");
        }
    }
}
