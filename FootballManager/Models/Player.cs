using FootballManager.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.Models
{
    public class Player : Person
    {
        public int ShirtNumber { get; set; }
        public string TeamName { get; set; }
        public PlayerPosition Position { get; set; }

        public Player(int id, string name, Country country, int shirtNum, string team, PlayerPosition position)
        : base(id, name, country)
        {
            ShirtNumber = shirtNum;
            TeamName = team;
            Position = position;
        }

        public Player()
        {
        }

        public override string ToString()
        {
            return $"{FullName} ({Position}) - {TeamName}";
        }
    }
}
