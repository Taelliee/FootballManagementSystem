using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FootballManager.Enums;

namespace FootballManager.Models
{
    public class Team
    {
        public Team()
        {
        }

        public Team(int id, string name, string coachName, Country country)
        {
            Id = id;
            Name = name;
            CoachName = coachName;
            Country = country;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string CoachName { get; set; }
        public Country Country { get; set; }
    }
}
