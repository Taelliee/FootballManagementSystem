using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FootballManager.Enums;

namespace FootballManager.Models
{
    public class Player : Person
    {
        public int ShirtNumber { get; set; }
        public string TeamName { get; set; }

        public string ImagePath { get; set; }  // team badge

        public PlayerPosition Position { get; set; }

        public Player(int id, string name, Country country, int shirtNum, string team, string imgPath, PlayerPosition position)
        {
            Id = id;
            FullName = name;
            Country = country;
            ShirtNumber = shirtNum;
            TeamName = team;
            ImagePath = imgPath;
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
