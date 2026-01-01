using System;
using System.Windows.Forms;
using FootballManager.Models;
using FootballManager.Enums;
using System.Linq;
using System.Collections.Generic;
using FootballManager.Services;

namespace FootballManager.UserControls.Competitions
{
    public partial class EditCompetitionControl : UserControl
    {
        private Competition selectedCompetition;

        public EditCompetitionControl()
        {
            InitializeComponent();
            LoadData();
            competitionComboBox.SelectedIndexChanged += competitionComboBox_SelectedIndexChanged;
        }

        private void LoadData()
        {
            // Load competitions
            competitionComboBox.Items.Clear();
            competitionComboBox.DisplayMember = "Description"; // Custom description for easy selection
            var competitions = FootballDataService.GetCompetitions(includeAll: true)
                .Select(c => new
                {
                    Competition = c,
                    Description = $"{c.MatchDate:dd.MM.yyyy} - {c.Stadium?.Name ?? "N/A"}"
                }).ToList();

            if (competitions.Any())
            {
                competitionComboBox.ValueMember = "Competition";
                competitionComboBox.Items.AddRange(competitions.ToArray());
            }

            // Load related data for editing
            playerComboBox.DataSource = FootballDataService.GetPlayers();
            playerComboBox.DisplayMember = "FullName";

            refereeComboBox.DataSource = FootballDataService.GetStaff().Where(s => s.Role.Equals(StaffPosition.Referee)).ToList();
            refereeComboBox.DisplayMember = "FullName";

            stadiumComboBox.DataSource = FootballDataService.GetStadiums();
            stadiumComboBox.DisplayMember = "Name";

            countryComboBox.DataSource = Enum.GetValues(typeof(Country));
        }

        private void competitionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Use reflection to get the anonymous type's property
            var selectedItem = competitionComboBox.SelectedItem;
            if (selectedItem == null) return;

            var competitionProperty = selectedItem.GetType().GetProperty("Competition");
            if (competitionProperty?.GetValue(selectedItem) is not Competition comp) return;

            selectedCompetition = comp;

            // Populate fields with the selected competition's data
            playerComboBox.SelectedItem = ((playerComboBox.DataSource) as System.Collections.IList)
                .OfType<Player>().FirstOrDefault(p => p.Id == selectedCompetition.PlayerId);

            refereeComboBox.SelectedItem = ((refereeComboBox.DataSource) as System.Collections.IList)
                .OfType<Models.Staff>().FirstOrDefault(s => s.Id == selectedCompetition.StaffId);

            stadiumComboBox.SelectedItem = ((stadiumComboBox.DataSource) as System.Collections.IList)
                .OfType<Stadium>().FirstOrDefault(s => s.Id == selectedCompetition.StadiumId);

            countryComboBox.SelectedItem = selectedCompetition.HostCountry;
            matchDateTimePicker.Value = selectedCompetition.MatchDate;
            goalsScoredNumericUpDown.Value = selectedCompetition.GoalsScored;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (selectedCompetition == null)
            {
                MessageBox.Show("Please select a competition to edit.");
                return;
            }

            // Update the properties of the selected competition object
            selectedCompetition.PlayerId = (playerComboBox.SelectedItem as Player)?.Id ?? 0;
            selectedCompetition.StaffId = (refereeComboBox.SelectedItem as Models.Staff)?.Id ?? 0;
            selectedCompetition.StadiumId = (stadiumComboBox.SelectedItem as Stadium)?.Id ?? 0;
            selectedCompetition.HostCountry = (Country)countryComboBox.SelectedItem;
            selectedCompetition.MatchDate = matchDateTimePicker.Value;
            selectedCompetition.GoalsScored = (int)goalsScoredNumericUpDown.Value;

            // Save changes to the database
            if (MessageBox.Show("Save changes?", "Confirm Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FootballDataService.UpdateCompetition(selectedCompetition);
                MessageBox.Show("Competition updated successfully!");

                // Refresh the form
                int selectedIndex = competitionComboBox.SelectedIndex;
                LoadData();
                competitionComboBox.SelectedIndex = selectedIndex;
            }
        }
    }
}