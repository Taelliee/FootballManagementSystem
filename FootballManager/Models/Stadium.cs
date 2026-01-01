using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FootballManager.Enums;

namespace FootballManager.Models
{
    public class Stadium
    {
        public Stadium()
        {
        }

        public Stadium(int id, string name, Country country, int teamId, int capacity)
        {
            Id = id;
            Name = name;
            Country = country;
            TeamId = teamId;
            Capacity = capacity;
        }

        public Stadium(string name, Country country, int teamId, int capacity)
        {
            Name = name;
            Country = country;
            TeamId = teamId;
            Capacity = capacity;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public Country Country { get; set; }
        public int Capacity { get; set; }

        // Foreign key for the Team
        public int? TeamId { get; set; }

        // Navigation property to the Team
        public Team Team { get; set; }

        // Navigation property for Competitions
        public ICollection<Competition> Competitions { get; set; }
        
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
