using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using FootballManager.Models;
using FootballManager.Services;

namespace FootballManager.UserControls.Players
{
    public partial class DeletePlayerControl : UserControl
    {
        public DeletePlayerControl()
        {
            InitializeComponent();
            LoadTeams();
            teamComboBox.SelectedIndexChanged += teamComboBox_SelectedIndexChanged;
        }

        private void LoadTeams()
        {
            teamComboBox.Items.Clear();
            teamComboBox.DisplayMember = "Name";
            var teams = FootballDataService.GetTeams();
            if (teams.Any())
            {
                teamComboBox.Items.AddRange(teams.ToArray());
            }
        }

        private void teamComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            fullNameComboBox.Items.Clear();
            fullNameComboBox.Text = "";
            fullNameComboBox.DisplayMember = "FullName";

            if (teamComboBox.SelectedItem is not Team selectedTeam) return;

            var playersInTeam = FootballDataService.GetPlayers().Where(p => p.TeamId == selectedTeam.Id).ToArray();
            if (playersInTeam.Any())
            {
                fullNameComboBox.Items.AddRange(playersInTeam);
                fullNameComboBox.SelectedIndex = 0;
            }
            else
            {
                fullNameComboBox.Text = "No players found";
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (fullNameComboBox.SelectedItem is not Player playerToDelete)
            {
                MessageBox.Show("Select a player to delete!");
                return;
            }

            var result = MessageBox.Show(
                $"Are you sure you want to delete {playerToDelete.FullName}?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                FootballDataService.RemovePlayer(playerToDelete.Id);
                MessageBox.Show("Player deleted!");

                // Refresh the player list for the selected team
                teamComboBox_SelectedIndexChanged(sender, e);
            }
        }
    }
}