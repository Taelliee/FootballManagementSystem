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
        public string Name { get; set; }
        public string CoachName { get; set; }
        public Country Country { get; set; }
    }
}
