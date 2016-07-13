using System.Collections.Generic;
using System.Dynamic;

namespace OlympicGames.Domain
{
    public class Team
    {
        public Coach Coach { get; set; }
        public Country Country { get; set; }
        public List<Sportsperson> Sportspeople { get; set; }
    }
}
