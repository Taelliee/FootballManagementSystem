using System;
using System.Windows.Forms;
using FootballManager.Models;
using System.Linq;
using System.Collections.Generic;

namespace FootballManager.UserControls.Competitions
{
    public partial class DeleteCompetitionControl : UserControl
    {
        public DeleteCompetitionControl()
        {
            InitializeComponent();
            LoadCompetitions();
        }

        private void LoadCompetitions()
        {
            var matchList = FootballData.Competitions.Select(c => new
            {
                Id = c.EventId,
                // date - stadium (goals)
                Description = $"{c.MatchDate.ToShortDateString()} - {c.Stadium} (Goals: {c.GoalsScored})"
            }).ToList();

            matchSelectorComboBox.DataSource = null;
            matchSelectorComboBox.DataSource = matchList;
            matchSelectorComboBox.DisplayMember = "Description";
            matchSelectorComboBox.ValueMember = "Id";

            matchSelectorComboBox.SelectedIndex = -1;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (matchSelectorComboBox.SelectedValue == null)
            {
                MessageBox.Show("Please select a match to delete!");
                return;
            }

            int matchId = (int)matchSelectorComboBox.SelectedValue;

            var matchToDelete = FootballData.Competitions.FirstOrDefault(c => c.EventId == matchId);

            if (matchToDelete != null)
            {
                string msg = $"Are you sure you want to delete this match?\n\n" +
                             $"{matchToDelete.MatchDate.ToShortDateString()} @ {matchToDelete.Stadium}";

                if (MessageBox.Show(msg, "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    FootballData.Competitions.Remove(matchToDelete);

                    FootballData.SaveData();
                    FootballData.ActionHistory.Push($"Deleted competition ID: {matchId}");

                    MessageBox.Show("Deleted successfully!");

                    LoadCompetitions();
                    matchSelectorComboBox.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Error: Match not found!");
            }
        }
    }
}