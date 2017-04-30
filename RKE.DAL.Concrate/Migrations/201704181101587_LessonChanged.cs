namespace RKE.DAL.Concrate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LessonChanged : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tbLessonChanged",
                c => new
                    {
                        cId = c.Int(nullable: false, identity: true),
                        cIdOfUser = c.String(maxLength: 128),
                        cIdOfLesson = c.Int(nullable: false),
                        cDateOfLesson = c.DateTime(nullable: false),
                        cNumberOfLesson = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.cId)
                .ForeignKey("dbo.tbLesson", t => t.cIdOfLesson, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.cIdOfUser)
                .Index(t => t.cIdOfUser)
                .Index(t => t.cIdOfLesson);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tbLessonChanged", "cIdOfUser", "dbo.AspNetUsers");
            DropForeignKey("dbo.tbLessonChanged", "cIdOfLesson", "dbo.tbLesson");
            DropIndex("dbo.tbLessonChanged", new[] { "cIdOfLesson" });
            DropIndex("dbo.tbLessonChanged", new[] { "cIdOfUser" });
            DropTable("dbo.tbLessonChanged");
        }
    }
}
