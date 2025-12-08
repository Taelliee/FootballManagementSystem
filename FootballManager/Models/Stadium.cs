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
        public int Id { get; set; }
        public string Name { get; set; }
        public string TeamName { get; set; }
        public Country Country { get; set; }
        public int Capacity { get; set; }
    }
}
