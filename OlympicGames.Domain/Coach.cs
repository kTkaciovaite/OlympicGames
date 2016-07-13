namespace OlympicGames.Domain
{
    public class Coach : Person
    {
        public string Nationality { get; set; }

        public override string Summary()
        {
            return $"{Name} {Surname} {Gender} {Nationality} {Country.Name} {Country.CountryCode}";
        }
    }
}
