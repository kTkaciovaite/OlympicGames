using System.Collections.Generic;

namespace OlympicGames.Domain
{
    public class Team
    {
        public int Id { get; set; }

        public virtual Coach Coach { get; set; }
        public virtual Country Country { get; set; }

        public List<Sportsperson> Sportspeople { get; set; }
    }
}
