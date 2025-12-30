using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using FootballManager.Models;
using FootballManager.Enums;

namespace FootballManager.UserControls.Queries
{
    public partial class QueriesControl : UserControl
    {
        private Chart goalsChart;

        public QueriesControl()
        {
            InitializeComponent();

            LoadInitialData();
        }

        private void LoadInitialData()
        {
            // making the chart manually (with panel)
            if (goalsChart == null)
            {
                goalsChart = new Chart();
                goalsChart.Dock = DockStyle.Fill;

                // Area
                ChartArea area = new ChartArea("MainArea");
                goalsChart.ChartAreas.Add(area);

                // Legend
                Legend legend = new Legend("MainLegend");
                goalsChart.Legends.Add(legend);

                // adding chart to panel
                chartPlaceholderPanel.Controls.Add(goalsChart);
            }


            // tab 1
            LoadAllPeopleGrid();

            // tab 2
            if (cmbCompStadium != null)
            {
                cmbCompStadium.Items.Clear();
                var usedStadiumIds = FootballData.Competitions
                                 .Select(c => c.StadiumId)
                                 .Distinct()
                                 .ToList();

                var stadiumObjects = FootballData.Stadiums
                                                 .Where(s => usedStadiumIds.Contains(s.Id))
                                                 .ToArray();
                cmbCompStadium.Items.AddRange(stadiumObjects);
            }

            if (cmbCompCountry != null)
            {
                cmbCompCountry.DataSource = null;
                cmbCompCountry.Items.Clear();

                cmbCompCountry.Items.Add("- All Countries -");

                foreach (var country in Enum.GetValues(typeof(Country)))
                {
                    cmbCompCountry.Items.Add(country);
                }

                cmbCompCountry.SelectedIndex = 0;
            }

            // tab 3 
            LoadChart();

            // tab 4
            PrepareFilterGrid();
        }

        // ----- TAB 1: ALL PEOPLE -----
        private void LoadAllPeopleGrid()
        {
            dgvAllPeople.AllowUserToAddRows = false;

            dgvAllPeople.Rows.Clear();
            dgvAllPeople.Columns.Clear();

            dgvAllPeople.Columns.Add("Type", "Type");
            dgvAllPeople.Columns.Add("Name", "Name");
            dgvAllPeople.Columns.Add("Country", "Country");
            dgvAllPeople.Columns.Add("Team", "Team / Role");

            var allPeople = new List<dynamic>();

            foreach (var p in FootballData.Players)
            {
                allPeople.Add(new { Type = "Player", Name = p.FullName, Country = p.Country, Team = p.Team?.Name ?? "No Team" });
            }

            foreach (var s in FootballData.StaffMembers)
            {
                allPeople.Add(new { Type = "Staff", Name = s.FullName, Country = s.Country, Team = s.Role.ToString() });
            }

            var sortedList = allPeople.OrderBy(x => x.Country).ThenBy(x => x.Team).ToList();

            foreach (var item in sortedList)
            {
                dgvAllPeople.Rows.Add(item.Type, item.Name, item.Country, item.Team);
            }
        }

        // ----- TAB 2: NUMBER OF COMPS -----

        private void btnCount_Click(object sender, EventArgs e)
        {
            DateTime start = dtpStart.Value.Date;
            DateTime end = dtpEnd.Value.Date;
            Stadium stadium = (Stadium)cmbCompStadium.SelectedItem;

            bool filterByCountry = cmbCompCountry.SelectedIndex > 0;

            Country selectedCountry = Country.Bulgaria; // default

            if (filterByCountry)
            {
                selectedCountry = (Country)cmbCompCountry.SelectedItem;
            }

            int count = FootballData.Competitions.Count(c =>
                c.MatchDate.Date >= start &&
                c.MatchDate.Date <= end &&
                (!filterByCountry || c.HostCountry == selectedCountry) &&
                (stadium == null|| c.StadiumId == stadium.Id)
            );

            lblCompResult.Text = $"Result: {count} competitions found";
        }

        // ----- TAB 3: CHART -----
        private void LoadChart()
        {
            if (goalsChart == null) return;

            Dictionary<string, int> teamGoals = new Dictionary<string, int>();

            foreach (var comp in FootballData.Competitions)
            {
                var player = FootballData.Players.FirstOrDefault(p => p.Id == comp.PlayerId);
                if (player != null)
                {
                    string team = player.Team?.Name ?? "No Team";
                    if (!teamGoals.ContainsKey(team))
                        teamGoals[team] = 0;

                    teamGoals[team] += comp.GoalsScored;
                }
            }

            goalsChart.Series.Clear();

            Series series = new Series("Goals");
            series.ChartType = SeriesChartType.Column;

            foreach (var kvp in teamGoals)
            {
                series.Points.AddXY(kvp.Key, kvp.Value);
            }

            goalsChart.Series.Add(series);
        }

        // ----- TAB 4: FILTER PLAYERS -----
        private void PrepareFilterGrid()
        {
            dgvFilteredPlayers.AllowUserToAddRows = false;

            dgvFilteredPlayers.Columns.Clear();
            dgvFilteredPlayers.Columns.Add("Name", "Player Name");
            dgvFilteredPlayers.Columns.Add("Team", "Team");
            dgvFilteredPlayers.Columns.Add("Country", "Country");
            dgvFilteredPlayers.Columns.Add("Info", "Extra Info");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvFilteredPlayers.Rows.Clear();

            string filterType = cmbFilterType.Text;
            string valueStr = txtFilterValue.Text.Trim();

            if (string.IsNullOrEmpty(valueStr))
            {
                MessageBox.Show("Enter a value!");
                return;
            }

            List<Player> result = new List<Player>();
            string extraInfoLabel = "";

            if (filterType.Contains("Goals"))
            {
                if (!int.TryParse(valueStr, out int minGoals))
                {
                    MessageBox.Show("Enter a valid number!");
                    return;
                }

                foreach (var p in FootballData.Players)
                {
                    int totalGoals = FootballData.Competitions
                        .Where(c => c.PlayerId == p.Id)
                        .Sum(c => c.GoalsScored);

                    if (totalGoals >= minGoals)
                    {
                        dgvFilteredPlayers.Rows.Add(p.FullName, p.Team?.Name ?? "No Team", p.Country, $"Goals: {totalGoals}");
                    }
                }
                return;
            }
            else if (filterType.Contains("Shirt"))
            {
                if (!int.TryParse(valueStr, out int num))
                {
                    MessageBox.Show("Enter a valid number!");
                    return;
                }

                result = FootballData.Players.Where(p => p.ShirtNumber == num).ToList();
                extraInfoLabel = $"Shirt: {num}";
            }
            else if (filterType.Contains("Coach"))
            {
                var teamsWithCoach = FootballData.Teams
                    .Where(t => t.CoachName != null && t.CoachName.ToLower().Contains(valueStr.ToLower()))
                    .Select(t => t.Name)
                    .ToList();

                result = FootballData.Players.Where(p => teamsWithCoach.Contains(p.Team?.Name)).ToList();
                extraInfoLabel = $"Coach: {valueStr}";
            }

            foreach (var p in result)
            {
                dgvFilteredPlayers.Rows.Add(p.FullName, p.Team?.Name ?? "No Team", p.Country, extraInfoLabel);
            }
        }
    }
}