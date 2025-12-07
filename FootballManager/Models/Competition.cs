using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FootballManager.Enums;

namespace FootballManager.Models
{
    public class Competition
    {
        public int EventId { get; set; }

        public int StaffId { get; set; }

        public int PlayerId { get; set; }

        public DateTime MatchDate { get; set; }

        public Country HostCountry { get; set; }

        public string Stadium { get; set; }

        public int GoalsScored { get; set; }

        public override string ToString()
        {
            return $"Event #{EventId} @ {Stadium}";
        }
    }
}
