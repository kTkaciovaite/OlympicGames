using System;

namespace OlympicGames.Domain
{
    public class Match
    {
        public DateTime Start { get; set; }
        public Team FirstTeam { get; set; }
        public Team SecondTeam { get; set; }

        public int? FirstTeamPoints { get; set; }
        public int? SecondTeamPoints { get; set; }

        public string MatchResult()
        {
            if (FirstTeamPoints == null || SecondTeamPoints == null)
            {
                return "TBA";
            }
            else if (FirstTeamPoints < SecondTeamPoints)
            {
                return SecondTeam.Country.CountryCode;
            }
            else if (FirstTeamPoints > SecondTeamPoints)
            {
                return FirstTeam.Country.CountryCode;
            }
            else
            {
                return "Draw";
            }
        }
    }
}
