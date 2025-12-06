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
        public Position Role { get; set; }

        public Staff(int id, string name, Country country, Position role)
        {
            Id = id;
            FullName = name;
            Country = country;
            Role = role;
        }

        public Staff() { }
    }
}
