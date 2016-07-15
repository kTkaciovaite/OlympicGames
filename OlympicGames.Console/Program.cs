using System;
using OlympicGames.DataAccess;
using OlympicGames.Domain;


namespace OlympicGames.Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var sportsperson1 = new Sportsperson
            {
                Height = 185,
                Weight = 90,
                Name = "Vardas",
                Surname = "Pavarde",
                Gender = 0,
                Country = new Country
                {
                    Name = "Lithuania",
                    CountryCode = "LTU"
                }
            };

            var coach1 = new Coach
            {
                Name = "Vardas",
                Surname = "Pavarde",
                Gender = 0,
                Country = new Country
                {
                    Name = "Lithuania",
                    CountryCode = "LTU"
                },
                //Nationality = "Lithuanian"
            };

            //System.Console.WriteLine(sportsperson1.Summary());
            //System.Console.WriteLine(coach1.Summary());
            var articleById = new ArticleDataService();
            System.Console.WriteLine(articleById.Get(1).Text);

            var allArticles = new ArticleDataService();
            System.Console.WriteLine(allArticles.GetAll().Count);

            var article1 = new Article()
            {
                Text = "It is a new article",
                Created = DateTime.Now
            };

            var addArticle = new ArticleDataService();
            addArticle.Add(article1);
            System.Console.WriteLine(addArticle.Get(6).Text);
            System.Console.WriteLine(allArticles.GetAll().Count);

            /*using (var context = new OlympicGamesContext())
            {
                context.Article.Add(new Article {Created = DateTime.Now, Text = "kakak"});
                context.SaveChanges();
            }*/

            System.Console.ReadKey();
        }
    }
}
