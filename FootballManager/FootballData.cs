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
        public static List<Stadium> Stadiums { get; set; } = new List<Stadium>();
        public static List<Team> Teams { get; set; } = new List<Team>();
        public static Stack<string> ActionHistory { get; set; } = new Stack<string>();

        // --- SAVE / LOAD LOGIC ---
        private static string playersFile = "players.txt";
        private static string staffFile = "staff.txt";
        private static string teamsFile = "teams.txt";
        private static string competitionsFile = "competitions.txt";
        private static string stadiumsFile = "stadiums.txt";

        public static void SaveData()
        {
            using (StreamWriter sw = new StreamWriter(playersFile))
            {
                foreach (var p in Players)
                {
                    // Format: ID|Name|Country|ShirtNum|TeamId|Position
                    sw.WriteLine($"{p.Id}|{p.FullName}|{p.Country}|{p.ShirtNumber}|{p.TeamId}|{p.Position}");
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

            using (StreamWriter sw = new StreamWriter(teamsFile))
            {
                foreach (var team in Teams)
                {
                    // Format: ID|Name|CoachId|Country|ImagePath
                    sw.WriteLine($"{team.Id}|{team.Name}|{team.CoachId}|{team.Country}|{team.ImagePath}");
                }
            }

            using (StreamWriter sw = new StreamWriter(competitionsFile))
            {
                foreach (var c in Competitions)
                {
                    // Format: EventId|StaffId|PlayerId|Date|Country|Stadium|Goals
                    sw.WriteLine($"{c.Id}|{c.StaffId}|{c.PlayerId}|{c.MatchDate}|{c.HostCountry}|{c.StadiumId}|{c.GoalsScored}");
                }
            }

            using (StreamWriter sw = new StreamWriter(stadiumsFile))
            {
                foreach (var s in Stadiums)
                {
                    // Format: Id|Name|Country|Capacity
                    sw.WriteLine($"{s.Id}|{s.Name}|{s.Country}|{s.Capacity}");
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
                    if (parts.Length >= 6)
                    {
                        Player p = new Player();
                        p.Id = int.Parse(parts[0]);
                        p.FullName = parts[1];
                        Enum.TryParse(parts[2], out Country c);
                        p.Country = c;
                        p.ShirtNumber = int.Parse(parts[3]);
                        p.TeamId = int.Parse(parts[4]);
                        Enum.TryParse(parts[5], out PlayerPosition pos);
                        p.Position = pos;

                        Players.Add(p);

                        if (!Teams.Any(t => t.Name == p.Team?.Name))
                        {
                            Teams.Add(new Team { Id = p.TeamId, Name = p.Team?.Name ?? "Unknown", Country = p.Country });
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
                        Enum.TryParse(parts[3], out StaffPosition r);
                        s.Role = r;

                        StaffMembers.Add(s);
                    }
                }
            }

            if (File.Exists(teamsFile))
            {
                Teams.Clear();
                var lines = File.ReadAllLines(teamsFile);
                foreach (var line in lines)
                {
                    var parts = line.Split('|');
                    if (parts.Length >= 5)
                    {
                        Team t = new Team();
                        t.Id = int.Parse(parts[0]);
                        t.Name = parts[1];
                        t.CoachId = int.Parse(parts[2]);
                        Enum.TryParse(parts[3], out Country c);
                        t.Country = c;
                        t.ImagePath = parts[4];

                        if (!Teams.Any(team => team.Name == t.Name))
                        {
                            Teams.Add(t);
                        }
                    }
                }
            }

            if (File.Exists(competitionsFile))
            {
                Competitions.Clear();
                var lines = File.ReadAllLines(competitionsFile);
                foreach (var line in lines)
                {
                    var parts = line.Split('|');
                    if (parts.Length >= 7)
                    {
                        Competition c = new Competition();
                        c.Id = int.Parse(parts[0]);
                        c.StaffId = int.Parse(parts[1]);
                        c.PlayerId = int.Parse(parts[2]);
                        c.MatchDate = DateTime.Parse(parts[3]);
                        Enum.TryParse(parts[4], out Country country);
                        c.HostCountry = country;
                        c.StadiumId = int.Parse(parts[5]);
                        c.GoalsScored = int.Parse(parts[6]);

                        Competitions.Add(c);
                    }
                }
            }

            if (File.Exists(stadiumsFile))
            {
                Stadiums.Clear();
                var lines = File.ReadAllLines(stadiumsFile);
                foreach (var line in lines)
                {
                    var parts = line.Split('|');
                    if (parts.Length >= 4)
                    {
                        Stadium s = new Stadium();
                        s.Id = int.Parse(parts[0]);
                        s.Name = parts[1];
                        Enum.TryParse(parts[2], out Country c);
                        s.Country = c;
                        s.Capacity = int.Parse(parts[3]);

                        Stadiums.Add(s);
                    }
                }
            }

            foreach (var player in Players)
            {
                player.Team = Teams.FirstOrDefault(t => t.Id == player.TeamId);
            }
        }

        // --- Helpers ---
        public static void AddPlayer(Player p)
        {
            Players.Add(p);
            ActionHistory.Push($"Added player: {p.FullName} at {DateTime.Now}");

            if (!Teams.Any(t => t.Name == p.Team?.Name))
            {
                Teams.Add(new Team { Id = p.TeamId, Name = p.Team?.Name ?? "Unknown", Country = p.Country });
            }
        }

        public static void AddStaff(Staff s)
        {
            StaffMembers.Add(s);
            ActionHistory.Push($"Added staff: {s.FullName} ({s.Role})");
        }

        public static void AddCompetition(Competition comp)
        {
            Competitions.Add(comp);
            ActionHistory.Push($"Added competition ID: {comp.Id}");
        }

        public static void AddStadium(Stadium s)
        {
            Stadiums.Add(s);
            ActionHistory.Push($"Added stadium: {s.Name}");
        }

        // get id
        public static int GetNextPlayerId()
        {
            return Players.Any() ? Players.Max(p => p.Id) + 1 : 1;
        }

        public static int GetNextStaffId()
        {
            return StaffMembers.Any() ? StaffMembers.Max(s => s.Id) + 1 : 1;
        }

        public static int GetNextCompetitionId()
        {
            return Competitions.Any() ? Competitions.Max(c => c.Id) + 1 : 1;
        }

        public static int GetNextStadiumId()
        {
            return Stadiums.Any() ? Stadiums.Max(s => s.Id) + 1 : 1;
        }

        public static int GetNextTeamId()
        {
            return Stadiums.Any() ? Teams.Max(s => s.Id) + 1 : 1;
        }

        // remove
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
            var team = Teams.FirstOrDefault(t => t.Name == teamName);
            if (team != null)
            {
                foreach (var player in Players)
                {
                    if (player.TeamId == team.Id)
                    {
                        player.TeamId = 0; // Set to "No Team" equivalent
                    }
                }

                Teams.Remove(team);

                ActionHistory.Push($"Deleted team: {teamName}. Players are now free agents.");
            }
        }

        public static void RemoveStaff(Staff staff)
        {
            if (staff != null && StaffMembers.Contains(staff))
            {
                StaffMembers.Remove(staff);
                ActionHistory.Push($"Deleted staff: {staff.FullName}");
            }
        }

        public static void RemoveCompetition(Competition comp)
        {
            if (comp != null && Competitions.Contains(comp))
            {
                Competitions.Remove(comp);
                ActionHistory.Push($"Deleted competition ID: {comp.Id}");
            }
        }

        public static void RemoveStadium(Stadium stadium)
        {
            if (stadium != null && Stadiums.Contains(stadium))
            {
                Stadiums.Remove(stadium);
                ActionHistory.Push($"Deleted stadium: {stadium.Name}");
            }
        }
    }
}