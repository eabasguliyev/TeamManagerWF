using System.Drawing;
using Newtonsoft.Json;
using TeamManager.Abstracts;

namespace TeamManager.Entities
{
    public class Player:Id
    {
        public int Number { get; set; }
        public string Position { get; set; }
        [JsonIgnore]
        public Color Color { get; set; }
        public string Fullname { get; set; }
        public bool Capitan { get; set; }

    }
}