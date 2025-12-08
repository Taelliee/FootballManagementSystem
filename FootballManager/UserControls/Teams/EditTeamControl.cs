using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using FootballManager.Models;
using FootballManager.Enums;

namespace FootballManager.UserControls.Teams
{
    public partial class EditTeamControl : UserControl
    {
        private Team selectedTeam;
        private string originalTeamName;

        public EditTeamControl()
        {
            InitializeComponent();
            LoadData();
            teamComboBox.SelectedIndexChanged += teamComboBox_SelectedIndexChanged;
        }

        private void LoadData()
        {
            countryComboBox.DataSource = Enum.GetValues(typeof(Country));

            teamComboBox.Items.Clear();
            if (FootballData.Teams.Count > 0)
                teamComboBox.Items.AddRange(FootballData.Teams.Keys.ToArray());
        }

        private void teamComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (teamComboBox.SelectedItem == null) return;

            string teamName = teamComboBox.SelectedItem.ToString();

            if (FootballData.Teams.TryGetValue(teamName, out selectedTeam))
            {
                originalTeamName = teamName;

                if (this.Controls.ContainsKey("nameTextBox"))
                    this.Controls["nameTextBox"].Text = selectedTeam.Name;

                coachTextBox.Text = selectedTeam.CoachName;
                countryComboBox.SelectedItem = selectedTeam.Country;
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (selectedTeam == null)
            {
                MessageBox.Show("Select a team first!");
                return;
            }

            string newName = "";
            if (this.Controls.ContainsKey("nameTextBox"))
                newName = this.Controls["nameTextBox"].Text.Trim();
            else
                newName = originalTeamName;

            string newCoach = coachTextBox.Text.Trim();
            Country newCountry = (Country)countryComboBox.SelectedItem;

            if (string.IsNullOrWhiteSpace(newName)) { MessageBox.Show("Team name required!"); return; }

            if (newName != originalTeamName)
            {
                if (FootballData.Teams.ContainsKey(newName))
                {
                    MessageBox.Show("A team with this new name already exists!");
                    return;
                }

                FootballData.Teams.Remove(originalTeamName);

                selectedTeam.Name = newName;
                selectedTeam.CoachName = newCoach;
                selectedTeam.Country = newCountry;

                FootballData.Teams.Add(newName, selectedTeam);

                // updating players' info
                foreach (var player in FootballData.Players)
                {
                    if (player.TeamName == originalTeamName)
                    {
                        player.TeamName = newName;
                    }
                }
            }
            else
            {
                selectedTeam.CoachName = newCoach;
                selectedTeam.Country = newCountry;
            }

            FootballData.SaveData();
            FootballData.ActionHistory.Push($"Edited team: {newName}");

            MessageBox.Show("Team updated successfully!");

            LoadData();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}