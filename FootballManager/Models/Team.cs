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

        public Team(int id, string name, int? coachId, Country country, string imagePath)
        {
            Id = id;
            Name = name;
            CoachId = coachId;
            Country = country;
            ImagePath = imagePath;
        }

        public Team(string name, int? coachId, Country country, string imagePath)
        {
            Name = name;
            CoachId = coachId;
            Country = country;
            ImagePath = imagePath;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public Country Country { get; set; }
        public string ImagePath { get; set; }  // team badge

        // Foreign key for the Coach (Staff)
        public int? CoachId { get; set; }

        // Navigation property to the Coach
        public Staff Coach { get; set; }

        // Navigation property for Players
        public ICollection<Player> Players { get; set; }

        // Navigation property for the team's home stadium
        public Stadium Stadium { get; set; }

        public Image GetImageSafe()
        {
            if (!string.IsNullOrEmpty(ImagePath) && File.Exists(ImagePath))
            {
                return Image.FromFile(ImagePath);
            }
            return null; // Or return Properties.Resources.DefaultBadge?
        }
    }
}
