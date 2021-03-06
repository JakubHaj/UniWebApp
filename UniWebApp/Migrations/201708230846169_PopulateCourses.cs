namespace UniWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCourses : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Courses ON INSERT INTO Courses (Id, Name) VALUES (1, 'Zrównoważony rozwój energetyczny')");
            Sql("INSERT INTO Courses (Id, Name) VALUES (2, 'Urządzenia, sieci i systemy elektroenergetyczne')");
            Sql("INSERT INTO Courses (Id, Name) VALUES (3, 'Energetyka wodorowa')");
            Sql("INSERT INTO Courses (Id, Name) VALUES (4, 'Modelowanie komputerowe w energetyce')");
            Sql("INSERT INTO Courses (Id, Name) VALUES (5, 'Systemy, maszyny i urządzenia energetyczne')");
            Sql("INSERT INTO Courses (Id, Name) VALUES (6, 'Ciepłownictwo, ogrzewnictwo i klimatyzacja')");

            Sql("INSERT INTO Courses (Id, Name) VALUES (7, 'Procesy spalania')");
            Sql("INSERT INTO Courses (Id, Name) VALUES (8, 'Technologie energetyczne')");
            Sql("INSERT INTO Courses (Id, Name) VALUES (9, 'Magazynowanie energii')");
            Sql("INSERT INTO Courses (Id, Name) VALUES (10, 'Konstrukcja i eksploatacja maszyn i urządzeń') SET IDENTITY_INSERT Courses OFF ");
        }

        public override void Down()
        {
        }
    }
}
