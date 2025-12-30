using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FootballManager.Enums;

namespace FootballManager.Models
{
    public class Staff : Person
    {
        public StaffPosition Role { get; set; }

        // Navigation property for Competitions
        public ICollection<Competition> Competitions { get; set; }

        public Staff(int id, string name, Country country, StaffPosition role)
            : base(id, name, country)
        {
            Role = role;
        }

        public Staff() { }
    }
}
