namespace RKE.DAL.Concrate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LessonChanged1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tbLessonChanged", "cComment", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.tbLessonChanged", "cComment");
        }
    }
}
