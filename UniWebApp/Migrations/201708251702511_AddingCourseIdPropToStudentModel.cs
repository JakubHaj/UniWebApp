namespace UniWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingCourseIdPropToStudentModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "CoursesId", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "CoursesId");
        }
    }
}
