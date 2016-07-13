namespace OlympicGames.Domain
{
    public abstract class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Gender Gender { get; set; }
        public Country Country { get; set; }

        public abstract string Summary();
    }
}
