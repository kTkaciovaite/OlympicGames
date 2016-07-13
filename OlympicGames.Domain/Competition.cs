using System.Collections.Generic;

namespace OlympicGames.Domain
{
    public class Competition
    {
        public SportType SportType { get; set; }
        public List<Team> Teams { get; set; }
        public List<Match> Matches { get; set; }
    }
}