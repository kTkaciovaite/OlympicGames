namespace OlympicGames.Domain
{
    public class Sportsperson : Person
    {
        public double Height { get; set; }
        public double Weight { get; set; }

        public override string Summary()
        {
            return $"{Name} {Surname} {Gender} {Height} {Weight} {Country.Name} {Country.CountryCode}";
        }
    }
}
