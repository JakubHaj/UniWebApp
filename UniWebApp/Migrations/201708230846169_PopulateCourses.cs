namespace UniWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCourses : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Courses ON INSERT INTO Courses (Id, Name) VALUES (1, 'Zr�wnowa�ony rozw�j energetyczny')");
            Sql("INSERT INTO Courses (Id, Name) VALUES (2, 'Urz�dzenia, sieci i systemy elektroenergetyczne')");
            Sql("INSERT INTO Courses (Id, Name) VALUES (3, 'Energetyka wodorowa')");
            Sql("INSERT INTO Courses (Id, Name) VALUES (4, 'Modelowanie komputerowe w energetyce')");
            Sql("INSERT INTO Courses (Id, Name) VALUES (5, 'Systemy, maszyny i urz�dzenia energetyczne')");
            Sql("INSERT INTO Courses (Id, Name) VALUES (6, 'Ciep�ownictwo, ogrzewnictwo i klimatyzacja')");

            Sql("INSERT INTO Courses (Id, Name) VALUES (7, 'Procesy spalania')");
            Sql("INSERT INTO Courses (Id, Name) VALUES (8, 'Technologie energetyczne')");
            Sql("INSERT INTO Courses (Id, Name) VALUES (9, 'Magazynowanie energii')");
            Sql("INSERT INTO Courses (Id, Name) VALUES (10, 'Konstrukcja i eksploatacja maszyn i urz�dze�') SET IDENTITY_INSERT Courses OFF ");
        }

        public override void Down()
        {
        }
    }
}
