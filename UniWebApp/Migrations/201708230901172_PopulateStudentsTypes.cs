namespace UniWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateStudentsTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Students (Name, Age) VALUES ('Wiktor Wilk', 19)");
            Sql("INSERT INTO Students (Name, Age) VALUES ('Monika Kazimierska', 19)");
            Sql("INSERT INTO Students (Name, Age) VALUES ('Paulina Mróz', 19)");
            Sql("INSERT INTO Students (Name, Age) VALUES ('Bogdan Szulc', 19)");
            Sql("INSERT INTO Students (Name, Age) VALUES ('Bartek Marek', 23)");
            Sql("INSERT INTO Students (Name, Age) VALUES ('Jakub Liœæ', 20)");
            Sql("INSERT INTO Students (Name, Age) VALUES ('Adam Kowal', 18)");
            Sql("INSERT INTO Students (Name, Age) VALUES ('Pawe³ Str¹czek', 21)");
            Sql("INSERT INTO Students (Name, Age) VALUES ('Pawe³ Pawlik', 21)");
            Sql("INSERT INTO Students (Name, Age) VALUES ('Piotr Stachurski', 24)");
            Sql("INSERT INTO Students (Name, Age) VALUES ('Kamila Pudzianowska', 22)");
            Sql("INSERT INTO Students (Name, Age) VALUES ('Aleksandra Maj', 24)");
            Sql("INSERT INTO Students (Name, Age) VALUES ('Maciej Piwowarski', 25)");
            Sql("INSERT INTO Students (Name, Age) VALUES ('Adam Biel', 22)");
            Sql("INSERT INTO Students (Name, Age) VALUES ('Krzysztof Adamski', 21)");
            Sql("INSERT INTO Students (Name, Age) VALUES ('Konrad Ul', 23)");
            Sql("INSERT INTO Students (Name, Age) VALUES ('Izabela Tomaszewska', 23)");
            Sql("INSERT INTO Students (Name, Age) VALUES ('Andrzej Urban', 22)");
            Sql("INSERT INTO Students (Name, Age) VALUES ('Pablito Uczynny', 20)");
            Sql("INSERT INTO Students (Name, Age) VALUES ('Wiktor Ca³a', 20)");
            Sql("INSERT INTO Students (Name, Age) VALUES ('Zuzanna Bryl', 20)");




        }

        public override void Down()
        {
        }
    }
}
