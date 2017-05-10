namespace RKE.DAL.Concrate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _32 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Lessons", "AudApiId", "dbo.Auds");
            DropForeignKey("dbo.LessonGroups", "LessonId", "dbo.Lessons");
            DropForeignKey("dbo.Lessons", "DisziplinApiId", "dbo.Disziplins");
            DropForeignKey("dbo.LessonGroups", "ApiGroupId", "dbo.Groups");
            DropPrimaryKey("dbo.Auds");
            DropPrimaryKey("dbo.Lessons");
            DropPrimaryKey("dbo.Disziplins");
            DropPrimaryKey("dbo.Groups");
            AddColumn("dbo.Auds", "ApiId", c => c.Int(nullable: false));
            AddColumn("dbo.Disziplins", "ApiId", c => c.Int(nullable: false));
            AddColumn("dbo.Groups", "ApiId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Auds", "ApiId");
            AddPrimaryKey("dbo.Lessons", "Id");
            AddPrimaryKey("dbo.Disziplins", "ApiId");
            AddPrimaryKey("dbo.Groups", "ApiId");
            AddForeignKey("dbo.Lessons", "AudApiId", "dbo.Auds", "ApiId");
            AddForeignKey("dbo.LessonGroups", "LessonId", "dbo.Lessons", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Lessons", "DisziplinApiId", "dbo.Disziplins", "ApiId");
            AddForeignKey("dbo.LessonGroups", "ApiGroupId", "dbo.Groups", "ApiId", cascadeDelete: true);
            DropColumn("dbo.Auds", "IdOfApi");
            DropColumn("dbo.Disziplins", "IdOfApi");
            DropColumn("dbo.Groups", "ApiGroupId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Groups", "ApiGroupId", c => c.Int(nullable: false));
            AddColumn("dbo.Disziplins", "IdOfApi", c => c.Int(nullable: false));
            AddColumn("dbo.Auds", "IdOfApi", c => c.Int(nullable: false));
            DropForeignKey("dbo.LessonGroups", "ApiGroupId", "dbo.Groups");
            DropForeignKey("dbo.Lessons", "DisziplinApiId", "dbo.Disziplins");
            DropForeignKey("dbo.LessonGroups", "LessonId", "dbo.Lessons");
            DropForeignKey("dbo.Lessons", "AudApiId", "dbo.Auds");
            DropPrimaryKey("dbo.Groups");
            DropPrimaryKey("dbo.Disziplins");
            DropPrimaryKey("dbo.Lessons");
            DropPrimaryKey("dbo.Auds");
            DropColumn("dbo.Groups", "ApiId");
            DropColumn("dbo.Disziplins", "ApiId");
            DropColumn("dbo.Auds", "ApiId");
            AddPrimaryKey("dbo.Groups", "ApiGroupId");
            AddPrimaryKey("dbo.Disziplins", "IdOfApi");
            AddPrimaryKey("dbo.Lessons", "ApiId");
            AddPrimaryKey("dbo.Auds", "IdOfApi");
            AddForeignKey("dbo.LessonGroups", "ApiGroupId", "dbo.Groups", "ApiGroupId", cascadeDelete: true);
            AddForeignKey("dbo.Lessons", "DisziplinApiId", "dbo.Disziplins", "IdOfApi");
            AddForeignKey("dbo.LessonGroups", "LessonId", "dbo.Lessons", "ApiId", cascadeDelete: true);
            AddForeignKey("dbo.Lessons", "AudApiId", "dbo.Auds", "IdOfApi");
        }
    }
}
