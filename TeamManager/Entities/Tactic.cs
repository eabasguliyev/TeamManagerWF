using System.Collections.Generic;
using System.Drawing;
using Newtonsoft.Json;

namespace TeamManager.Entities
{
    public class Tactic
    {
        public string CountryName { get; set; }
        public string Name { get; set; }
        public List<string> Positions { get; set; }

        [JsonIgnore]

        public List<Point> PositionsLocation { get; set; }
        [JsonIgnore]
        public List<string> PositionColors { get; set; }
        public List<Player> Players { get; set; }
        public Tactic()
        {
            Positions = new List<string>();
            PositionColors = new List<string>();
            PositionsLocation = new List<Point>();
            Players = new List<Player>();
        }
    }
}