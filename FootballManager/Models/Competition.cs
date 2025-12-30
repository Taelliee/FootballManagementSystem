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
        public Competition()
        {
        }

        public Competition(int id, int staffId, int playerId, DateTime matchDate, Country hostCountry, int stadiumId, int goalsScored)
        {
            Id = id;
            StaffId = staffId;
            PlayerId = playerId;
            MatchDate = matchDate;
            HostCountry = hostCountry;
            StadiumId = stadiumId;
            GoalsScored = goalsScored;
        }

        public Competition(int staffId, int playerId, DateTime matchDate, Country hostCountry, int stadiumId, int goalsScored)
        {
            StaffId = staffId;
            PlayerId = playerId;
            MatchDate = matchDate;
            HostCountry = hostCountry;
            StadiumId = stadiumId;
            GoalsScored = goalsScored;
        }

        public int Id { get; set; }

        // Foreign key and navigation property for Staff
        public int StaffId { get; set; }
        public Staff Staff { get; set; }

        // Foreign key and navigation property for Player
        public int PlayerId { get; set; }
        public Player Player { get; set; }

        // Foreign key and navigation property for Stadium
        public int StadiumId { get; set; }
        public Stadium Stadium { get; set; }

        public DateTime MatchDate { get; set; }
        public Country HostCountry { get; set; }
        public int GoalsScored { get; set; }

        public override string ToString()
        {
            return $"Event #{Id} @ {StadiumId}";
        }
    }
}
