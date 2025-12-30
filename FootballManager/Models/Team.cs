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

        public Team(int id, string name, string coachName, Country country, string imagePath)
        {
            Id = id;
            Name = name;
            CoachName = coachName;
            Country = country;
            ImagePath = imagePath;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string CoachName { get; set; }
        public Country Country { get; set; }
        public string ImagePath { get; set; }  // team badge

        // Navigation property for Players
        public ICollection<Player> Players { get; set; }

        public Image GetImageSafe()
        {
            if (!string.IsNullOrEmpty(ImagePath) && File.Exists(ImagePath))
            {
                return Image.FromFile(ImagePath);
            }
            return null; // Or return Properties.Resources.DefaultBadge
        }
    }
}
