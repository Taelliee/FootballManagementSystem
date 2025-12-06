using FootballManager.Models;
using FootballManager.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FootballManager
{
    public static class FootballData
    {
        public static List<Player> Players { get; set; } = new List<Player>();
        public static List<Staff> StaffMembers { get; set; } = new List<Staff>();
        public static List<Competition> Competitions { get; set; } = new List<Competition>();

        public static Dictionary<string, Team> Teams { get; set; } = new Dictionary<string, Team>();

        public static Stack<string> ActionHistory { get; set; } = new Stack<string>();

        public static Queue<string> PendingNotifications { get; set; } = new Queue<string>();



        public static void AddPlayer(Player p)
        {
            Players.Add(p);
            ActionHistory.Push($"Added player: {p.FullName} at {DateTime.Now}");

            if (!Teams.ContainsKey(p.TeamName))
            {
                Teams.Add(p.TeamName, new Team { Name = p.TeamName, Country = p.Country });
            }
        }

        public static void AddStaff(Staff s)
        {
            StaffMembers.Add(s);
            ActionHistory.Push($"Added staff: {s.FullName} ({s.Role})");
        }


        // --- SAVE / LOAD LOGIC ---
        private static string playersFile = "players.txt";
        private static string staffFile = "staff.txt";

        public static void SaveData()
        {
            using (StreamWriter sw = new StreamWriter(playersFile))
            {
                foreach (var p in Players)
                {
                    // Format: ID|Name|Country|ShirtNum|Team|Image
                    sw.WriteLine($"{p.Id}|{p.FullName}|{p.Country}|{p.ShirtNumber}|{p.TeamName}|{p.ImagePath}|{p.Position}");
                }
            }

            using (StreamWriter sw = new StreamWriter(staffFile))
            {
                foreach (var s in StaffMembers)
                {
                    // Format: ID|Name|Country|Role
                    sw.WriteLine($"{s.Id}|{s.FullName}|{s.Country}|{s.Role}");
                }
            }
        }

        public static void LoadData()
        {
            if (File.Exists(playersFile))
            {
                Players.Clear();
                var lines = File.ReadAllLines(playersFile);
                foreach (var line in lines)
                {
                    var parts = line.Split('|');
                    if (parts.Length >= 7)
                    {
                        Player p = new Player();
                        p.Id = int.Parse(parts[0]);
                        p.FullName = parts[1];
                        Enum.TryParse(parts[2], out Country c);
                        p.Country = c;
                        p.ShirtNumber = int.Parse(parts[3]);
                        p.TeamName = parts[4];
                        p.ImagePath = parts[5];
                        Enum.TryParse(parts[6], out PlayerPosition pos);
                        p.Position = pos;

                        Players.Add(p);

                        if (!Teams.ContainsKey(p.TeamName))
                        {
                            Teams.Add(p.TeamName, new Team { Name = p.TeamName, Country = p.Country });
                        }
                    }
                }
            }

            if (File.Exists(staffFile))
            {
                StaffMembers.Clear();
                var lines = File.ReadAllLines(staffFile);
                foreach (var line in lines)
                {
                    var parts = line.Split('|');
                    if (parts.Length >= 4)
                    {
                        Staff s = new Staff();
                        s.Id = int.Parse(parts[0]);
                        s.FullName = parts[1];
                        Enum.TryParse(parts[2], out Country c);
                        s.Country = c;
                        Enum.TryParse(parts[3], out Position r);
                        s.Role = r;

                        StaffMembers.Add(s);
                    }
                }
            }
        }

        // next id (automatic)
        public static int GetNextPlayerId()
        {
            return Players.Any() ? Players.Max(p => p.Id) + 1 : 1;
        }


        public static void RemovePlayer(Player player)
        {
            if (player != null && Players.Contains(player))
            {
                Players.Remove(player);
                ActionHistory.Push($"Deleted player: {player.FullName} (ID: {player.Id})");
            }
        }

        public static void RemoveTeam(string teamName)
        {
            if (Teams.ContainsKey(teamName))
            {
                foreach (var player in Players)
                {
                    if (player.TeamName == teamName)
                    {
                        player.TeamName = "No Team";
                    }
                }

                Teams.Remove(teamName);

                ActionHistory.Push($"Deleted team: {teamName}. Players are now free agents.");
            }
        }
    }
}