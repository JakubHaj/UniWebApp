namespace UniWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenamePluralModelNamesToSingular : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Courses", name: "Students_Id", newName: "Student_Id");
            RenameIndex(table: "dbo.Courses", name: "IX_Students_Id", newName: "IX_Student_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Courses", name: "IX_Student_Id", newName: "IX_Students_Id");
            RenameColumn(table: "dbo.Courses", name: "Student_Id", newName: "Students_Id");
        }
    }
}
