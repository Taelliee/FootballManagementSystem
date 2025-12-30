using System;
using System.Windows.Forms;
using FootballManager.Models;
using System.Linq;
using System.Collections.Generic;
using FootballManager.Services;

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
            // date - stadium (goals)
            matchSelectorComboBox.DataSource = null;
            matchSelectorComboBox.DisplayMember = "Description";
            matchSelectorComboBox.ValueMember = "Id";

            var matchList = FootballDataService.GetCompetitions(includeAll: true).Select(c => new
            {
                c.Id,
                Description = $"{c.MatchDate:dd.MM.yyyy} - {c.Stadium?.Name ?? "N/A"} (Goals: {c.GoalsScored})"
            }).ToList();

            if (matchList.Any())
            {
                matchSelectorComboBox.DataSource = matchList;
                matchSelectorComboBox.SelectedIndex = -1;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (matchSelectorComboBox.SelectedValue is not int matchId)
            {
                MessageBox.Show("Please select a match to delete!");
                return;
            }

            var matchToDelete = FootballDataService.GetCompetition(matchId);
            if (matchToDelete == null)
            {
                MessageBox.Show("Error: Match not found!");
                return;
            }

            string msg = $"Are you sure you want to delete this match?\n\n" +
                         $"{matchToDelete.MatchDate:dd.MM.yyyy}";

            if (MessageBox.Show(msg, "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                FootballDataService.RemoveCompetition(matchId);
                MessageBox.Show("Deleted successfully!");

                // Refresh the list
                LoadCompetitions();
                matchSelectorComboBox.Text = "";
            }
        }
    }
}