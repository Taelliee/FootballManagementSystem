using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using FootballManager.Models;
using FootballManager.Enums;
using FootballManager.Services;

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
                cmbCompStadium.DisplayMember = "Name";
                var competitions = FootballDataService.GetCompetitions();
                var stadiums = FootballDataService.GetStadiums();
                var usedStadiumIds = competitions.Select(c => c.StadiumId).Distinct();
                var stadiumObjects = stadiums.Where(s => usedStadiumIds.Contains(s.Id)).ToArray();
                cmbCompStadium.Items.AddRange(stadiumObjects);
            }

            if (cmbCompCountry != null)
            {
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
            if (dgvAllPeople.Columns.Count == 0)
            {
                dgvAllPeople.Columns.Add("Type", "Type");
                dgvAllPeople.Columns.Add("Name", "Name");
                dgvAllPeople.Columns.Add("Country", "Country");
                dgvAllPeople.Columns.Add("Team", "Team / Role");
            }

            var allPeople = new List<dynamic>();
            var players = FootballDataService.GetPlayers(includeTeam: true);
            foreach (var p in players)
            {
                allPeople.Add(new { Type = "Player", Name = p.FullName, Country = p.Country.ToString(), Team = p.Team?.Name ?? "No Team" });
            }

            var staff = FootballDataService.GetStaff();
            foreach (var s in staff)
            {
                allPeople.Add(new { Type = "Staff", Name = s.FullName, Country = s.Country.ToString(), Team = s.Role.ToString() });
            }

            var sortedList = allPeople.OrderBy(x => x.Country).ThenBy(x => x.Team).ToList();
            foreach (var item in sortedList)
            {
                dgvAllPeople.Rows.Add(item.Type, item.Name, item.Country, item.Team);
            }
        }

        // ----- TAB 2: NUMBER OF COMPETITIONS -----
        private void btnCount_Click(object sender, EventArgs e)
        {
            DateTime start = dtpStart.Value.Date;
            DateTime end = dtpEnd.Value.Date;
            Stadium stadium = (Stadium)cmbCompStadium.SelectedItem;

            bool filterByCountry = cmbCompCountry.SelectedIndex > 0;
            Country selectedCountry = default; // Will only be used if filterByCountry is true

            if (filterByCountry)
            {   
                selectedCountry = (Country)cmbCompCountry.SelectedItem;
            }

            var competitions = FootballDataService.GetCompetitions();

            int count = competitions.Count(c =>
                c.MatchDate.Date >= start &&
                c.MatchDate.Date <= end &&
                (!filterByCountry || c.HostCountry == selectedCountry) &&
                (stadium == null || c.StadiumId == stadium.Id)
            );

            lblCompResult.Text = $"Result: {count} competitions found";
        }

        // ----- TAB 3: CHART -----
        private void LoadChart()
        {
            if (goalsChart == null) return;

            var competitions = FootballDataService.GetCompetitions(includeAll: true);
            var teamGoals = competitions
                .Where(c => c.Player?.Team != null)
                .GroupBy(c => c.Player.Team.Name)
                .ToDictionary(g => g.Key, g => g.Sum(c => c.GoalsScored));

            goalsChart.Series.Clear();
            Series series = new Series("Goals") { ChartType = SeriesChartType.Column };
            foreach (var kvp in teamGoals.OrderByDescending(kvp => kvp.Value))
            {
                series.Points.AddXY(kvp.Key, kvp.Value);
            }
            goalsChart.Series.Add(series);
        }

        // ----- TAB 4: FILTER PLAYERS -----
        private void PrepareFilterGrid()
        {
            dgvFilteredPlayers.AllowUserToAddRows = false;
            if (dgvFilteredPlayers.Columns.Count == 0)
            {
                dgvFilteredPlayers.Columns.Add("Name", "Player Name");
                dgvFilteredPlayers.Columns.Add("Team", "Team");
                dgvFilteredPlayers.Columns.Add("Country", "Country");
                dgvFilteredPlayers.Columns.Add("Info", "Extra Info");
            }
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

            var players = FootballDataService.GetPlayers(includeTeam: true);

            if (filterType.Contains("Goals"))
            {
                if (!int.TryParse(valueStr, out int minGoals))
                {
                    MessageBox.Show("Enter a valid number!");
                    return;
                }
                var competitions = FootballDataService.GetCompetitions();
                var playerGoals = competitions
                    .GroupBy(c => c.PlayerId)
                    .ToDictionary(g => g.Key, g => g.Sum(c => c.GoalsScored));

                foreach (var p in players)
                {
                    if (playerGoals.TryGetValue(p.Id, out int totalGoals) && totalGoals >= minGoals)
                    {
                        dgvFilteredPlayers.Rows.Add(p.FullName, p.Team?.Name ?? "No Team", p.Country.ToString(), $"Goals: {totalGoals}");
                    }
                }
            }
            else if (filterType.Contains("Shirt"))
            {
                if (!int.TryParse(valueStr, out int num))
                {
                    MessageBox.Show("Enter a valid number!");
                    return;
                }
                var result = players.Where(p => p.ShirtNumber == num).ToList();
                foreach (var p in result)
                {
                    dgvFilteredPlayers.Rows.Add(p.FullName, p.Team?.Name ?? "No Team", p.Country.ToString(), $"Shirt: {num}");
                }
            }
            else if (filterType.Contains("Coach"))
            {
                var teams = FootballDataService.GetTeams(includeCoach: true);
                var teamsWithCoach = teams
                    .Where(t => t.Coach != null && t.Coach.FullName.ToLower().Contains(valueStr.ToLower()))
                    .Select(t => t.Id)
                    .ToList();

                var result = players.Where(p => teamsWithCoach.Contains(p.TeamId)).ToList();
                foreach (var p in result)
                {
                    dgvFilteredPlayers.Rows.Add(p.FullName, p.Team?.Name ?? "No Team", p.Country.ToString(), $"Coach contains: {valueStr}");
                }
            }
        }
    }
}