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
                Nationality = "Lithuanian"
            };

            System.Console.WriteLine(sportsperson1.Summary());
            System.Console.WriteLine(coach1.Summary());
            System.Console.ReadKey();
        }
    }
}
