using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using OlympicGames.Domain;

namespace OlympicGames.DataAccess
{
    public class ArticleDataService
    {
        public Article Get(int id)
        {
            using (var context = new OlympicGamesContext())
            {
                return context.Article.FirstOrDefault(a => a.Id == id);
            }
        }

        public List<Article> GetAll()
        {
            using (var context = new OlympicGamesContext())
            {
                return context.Article.ToList();
            }
        }

        public void Add(Article article)
        {
            using (var context = new OlympicGamesContext())
            {
                context.Article.AddOrUpdate(article);
                context.SaveChanges();
            }
        }

        public void Update(Article article)
        {
            using (var context = new OlympicGamesContext())
            {
                context.Article.AddOrUpdate(article);
                context.SaveChanges();
            }
        }

        public void Remove(Article article)
        {
            using (var context = new OlympicGamesContext())
            {
                context.Article.Remove(article);
                context.SaveChanges();
            }
        }
    }
}
