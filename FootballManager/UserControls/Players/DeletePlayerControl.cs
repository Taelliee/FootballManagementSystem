using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using FootballManager.Models;

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
            if (FootballData.Teams.Count > 0)
            {
                teamComboBox.Items.AddRange(FootballData.Teams.Keys.ToArray());
            }
        }

        private void teamComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            fullNameComboBox.Items.Clear();
            fullNameComboBox.Text = "";

            if (teamComboBox.SelectedItem == null) return;

            string selectedTeam = teamComboBox.SelectedItem.ToString();

            // LINQ
            var playersInTeam = FootballData.Players
                .Where(p => p.TeamName == selectedTeam)
                .Select(p => p.FullName)
                .ToArray();

            fullNameComboBox.Items.AddRange(playersInTeam);

            if (fullNameComboBox.Items.Count > 0)
                fullNameComboBox.SelectedIndex = 0;
            else
                fullNameComboBox.Text = "No players found";
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (teamComboBox.SelectedItem == null)
            {
                MessageBox.Show("Select a team first!");
                return;
            }
            if (string.IsNullOrWhiteSpace(fullNameComboBox.Text))
            {
                MessageBox.Show("Select a player!");
                return;
            }

            string selectedTeam = teamComboBox.SelectedItem.ToString();
            string selectedPlayerName = fullNameComboBox.Text;

            var playerToDelete = FootballData.Players
                .FirstOrDefault(p => p.FullName == selectedPlayerName && p.TeamName == selectedTeam);

            if (playerToDelete == null)
            {
                MessageBox.Show("Player not found!");
                return;
            }

            var result = MessageBox.Show(
                $"Are you sure you want to delete {playerToDelete.FullName}?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                FootballData.RemovePlayer(playerToDelete);
                FootballData.SaveData();

                MessageBox.Show("Player deleted!");

                teamComboBox_SelectedIndexChanged(sender, e);
            }
        }
    }
}