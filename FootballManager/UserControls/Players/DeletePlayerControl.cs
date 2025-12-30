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
            teamComboBox.DisplayMember = "Name";
            if (FootballData.Teams.Count > 0)
            {
                teamComboBox.Items.AddRange(FootballData.Teams.ToArray());
            }
        }

        private void teamComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            fullNameComboBox.Items.Clear();
            fullNameComboBox.Text = "";

            if (teamComboBox.SelectedItem == null) return;

            Team selectedTeam = (Team)teamComboBox.SelectedItem;

            // LINQ
            var playersInTeam = FootballData.Players
                .Where(p => p.TeamId == selectedTeam.Id)
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

            Team selectedTeam = (Team)teamComboBox.SelectedItem;
            string selectedPlayerName = fullNameComboBox.Text;

            var playerToDelete = FootballData.Players
                .FirstOrDefault(p => p.FullName == selectedPlayerName && p.TeamId == selectedTeam.Id);

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