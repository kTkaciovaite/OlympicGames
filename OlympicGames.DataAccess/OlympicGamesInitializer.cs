using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using OlympicGames.Domain;

namespace OlympicGames.DataAccess
{
    internal class OlympicGamesInitializer : DropCreateDatabaseAlways<OlympicGamesContext>
    {
        public override void InitializeDatabase(OlympicGamesContext context)
        {
            context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction
                , string.Format("ALTER DATABASE [{0}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE", context.Database.Connection.Database));

            base.InitializeDatabase(context);
        }

        protected override void Seed(OlympicGamesContext context)
        {
            var country = new List<Country>
            {
                new Country() { CountryCode = "LTU", Name = "Lithuania" },
                new Country() { CountryCode = "ARG", Name = "Argentina" },
                new Country() { CountryCode = "BEL", Name = "Belgium" },
                new Country() { CountryCode = "CHN", Name = "China" },
                new Country() { CountryCode = "DNK", Name = "Denmark" }
            };

            country.ForEach(s => context.Country.AddOrUpdate(s));
            context.SaveChanges();

            var article = new List<Article>
            {
                new Article() { Text = "Article1 Some Text", Created = DateTime.Now },
                new Article() { Text = "Article2 Some Text", Created = DateTime.Now },
                new Article() { Text = "Article3 Some Text", Created = DateTime.Now },
                new Article() { Text = "Article4 Some Text", Created = DateTime.Now },
                new Article() { Text = "Article5 Some Text", Created = DateTime.Now }
            };

            article.ForEach(s => context.Article.AddOrUpdate(s));
            context.SaveChanges();

            var sportsperson = new List<Sportsperson>
            {
                new Sportsperson() { Height = 175, Weight = 65, Name = "Jonas", Surname = "Jonas" },
                new Sportsperson() { Height = 180, Weight = 80, Name = "Bob", Surname = "Bob" },
                new Sportsperson() { Height = 170, Weight = 60, Name = "John", Surname = "John" },
                new Sportsperson() { Height = 162, Weight = 55, Name = "Peter", Surname = "Peter" },
                new Sportsperson() { Height = 190.5, Weight = 100, Name = "Laura", Surname = "Laura" }
            };

            sportsperson.ForEach(s => context.Sportsperson.AddOrUpdate(s));
            context.SaveChanges();

            var coach = new List<Coach>
            {
                new Coach() { Name = "Jonas", Surname = "Jonas", Gender = Gender.Male, Nationality = "Lithuanian", Country = country[1] },
                new Coach() { Name = "Yoko", Surname = "Yoko", Gender = Gender.Female, Nationality = "Lithuanian", Country = country[1] },
                new Coach() { Name = "Bob", Surname = "Bob", Gender = Gender.Male, Nationality = "Lithuanian", Country = country[1] },
                new Coach() { Name = "Frank", Surname = "Frank", Gender = Gender.Male, Nationality = "Lithuanian", Country = country[1] },
                new Coach() { Name = "Sasha", Surname = "Sasha", Gender = Gender.Female, Nationality = "Lithuanian", Country = country[1] }
            };

            coach.ForEach(s => context.Coach.AddOrUpdate(s));
            context.SaveChanges();

            var team = new List<Team>
            {
                new Team() { Coach = coach[2], Country = country[1] },
                new Team() { Coach = coach[2], Country = country[4] },
                new Team() { Coach = coach[1], Country = country[1] },
                new Team() { Coach = coach[3], Country = country[4] },
                new Team() { Coach = coach[1], Country = country[3] },
            };

            team.ForEach(s => context.Team.AddOrUpdate(s));
            context.SaveChanges();
        }
    }
}
