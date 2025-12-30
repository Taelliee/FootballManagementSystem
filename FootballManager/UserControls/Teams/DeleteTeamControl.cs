using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using FootballManager.Enums;
using FootballManager.Models;
using FootballManager.Services;

namespace FootballManager.UserControls.Teams
{
    public partial class DeleteTeamControl : UserControl
    {
        public DeleteTeamControl()
        {
            InitializeComponent();
            
            countryComboBox.SelectedIndexChanged += countryComboBox_SelectedIndexChanged;
            
            LoadCountries();
        }

        private void LoadCountries()
        {
            countryComboBox.Items.Clear();
            countryComboBox.Items.Add("- All Countries -");
            foreach (var country in Enum.GetValues(typeof(Country)))
            {
                countryComboBox.Items.Add(country);
            }
            countryComboBox.SelectedIndex = 0;
        }

        private void countryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            teamComboBox.Items.Clear();
            teamComboBox.Text = "";
            teamComboBox.DisplayMember = "Name";

            var teams = FootballDataService.GetTeams();
            if (countryComboBox.SelectedIndex > 0 && countryComboBox.SelectedItem is Country selectedCountry)
            {
                teams = teams.Where(t => t.Country == selectedCountry).ToList();
            }

            if (teams.Any())
            {
                teamComboBox.Items.AddRange(teams.ToArray());
                teamComboBox.SelectedIndex = 0;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (teamComboBox.SelectedItem is not Team teamToDelete)
            {
                MessageBox.Show("Select a team to delete!");
                return;
            }

            var result = MessageBox.Show(
                $"Are you sure you want to delete team '{teamToDelete.Name}'?\nThis cannot be undone.",
                "Confirm Team Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Error);

            if (result == DialogResult.Yes)
            {
                FootballDataService.RemoveTeam(teamToDelete.Id);
                MessageBox.Show("Team deleted successfully!");

                // Refresh the team list
                countryComboBox_SelectedIndexChanged(sender, e);
            }
        }
    }
}