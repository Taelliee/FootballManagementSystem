using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using FootballManager.Enums;
using FootballManager.Models;

namespace FootballManager.UserControls.Teams
{
    public partial class DeleteTeamControl : UserControl
    {
        public DeleteTeamControl()
        {
            InitializeComponent();

            // Populate countryComboBox with "- All Countries -" first, then all countries
            countryComboBox.Items.Clear();
            countryComboBox.Items.Add("- All Countries -");
            foreach (var country in Enum.GetValues(typeof(Country)))
            {
                countryComboBox.Items.Add(country);
            }

            countryComboBox.SelectedIndexChanged += countryComboBox_SelectedIndexChanged;
            countryComboBox.SelectedIndex = 0;
        }

        private void countryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            nameComboBox.Items.Clear();
            nameComboBox.Text = "";

            if (countryComboBox.SelectedIndex == 0)
            {
                // Show all teams if "- All Countries -" is selected
                nameComboBox.Items.AddRange(FootballData.Teams.Select(t => t.Name).ToArray());
                if (nameComboBox.Items.Count > 0)
                    nameComboBox.SelectedIndex = 0;
                return;
            }

            if (countryComboBox.SelectedItem == null) return;

            Country selectedCountry = (Country)countryComboBox.SelectedItem;

            var teamsInCountry = FootballData.Teams
                .Where(t => t.Country == selectedCountry)
                .Select(t => t.Name)
                .ToArray();

            nameComboBox.Items.AddRange(teamsInCountry);

            if (nameComboBox.Items.Count > 0)
                nameComboBox.SelectedIndex = 0;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameComboBox.Text))
            {
                MessageBox.Show("Select a team to delete!");
                return;
            }

            string teamName = nameComboBox.Text;

            // save
            var result = MessageBox.Show(
                $"Are you sure you want to delete team '{teamName}'?\nThis cannot be undone.",
                "Confirm Team Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Error);

            if (result == DialogResult.Yes)
            {
                FootballData.RemoveTeam(teamName);
                FootballData.SaveData();

                MessageBox.Show("Team deleted successfully!");

                countryComboBox_SelectedIndexChanged(sender, e);
            }
        }
    }
}