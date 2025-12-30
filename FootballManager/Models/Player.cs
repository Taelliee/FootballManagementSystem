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

        // Foreign key for Team
        public int TeamId { get; set; }

        // Navigation property for Team
        public Team Team { get; set; }

        public PlayerPosition Position { get; set; }

        // Navigation property for Competitions
        public ICollection<Competition> Competitions { get; set; }

        public Player(int id, string name, Country country, int shirtNum, int teamId, PlayerPosition position)
        : base(id, name, country)
        {
            ShirtNumber = shirtNum;
            TeamId = teamId;
            Position = position;
        }

        public Player(string name, Country country, int shirtNum, int teamId, PlayerPosition position)
        : base(name, country)
        {
            ShirtNumber = shirtNum;
            TeamId = teamId;
            Position = position;
        }

        public Player()
        {
        }

        public override string ToString()
        {
            return $"{FullName} ({Position}) - Team: {Team?.Name ?? "No Team"}";
        }
    }
}