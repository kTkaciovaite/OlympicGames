using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using OlympicGames.Domain;

namespace OlympicGames.DataAccess
{
    public class CountryDataService
    {
        public Country Get(int id)
        {
            using (var context = new OlympicGamesContext())
            {
                return context.Country.FirstOrDefault(a => a.Id == id);
            }
        }

        public List<Country> GetAll()
        {
            using (var context = new OlympicGamesContext())
            {
                return context.Country.ToList();
            }
        }

        public void Add(Country country)
        {
            using (var context = new OlympicGamesContext())
            {
                context.Country.AddOrUpdate(country);
                context.SaveChanges();
            }
        }

        public void Update(Country country)
        {
            using (var context = new OlympicGamesContext())
            {
                context.Country.AddOrUpdate(country);
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
