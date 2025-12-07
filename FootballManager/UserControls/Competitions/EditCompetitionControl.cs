using System;
using System.Windows.Forms;
using FootballManager.Models;
using FootballManager.Enums;
using System.Linq;
using System.Collections.Generic;

namespace FootballManager.UserControls.Competitions
{
    public partial class EditCompetitionControl : UserControl
    {
        private Competition selectedMatch;

        public EditCompetitionControl()
        {
            InitializeComponent();

            goalsScoredTextBox.KeyPress += (s, e) => { if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true; };

            stadiumComboBox.DropDownStyle = ComboBoxStyle.DropDown;

            matchSelectorComboBox.SelectedIndexChanged += matchSelectorComboBox_SelectedIndexChanged;

            LoadData();
        }

        private void LoadData()
        {
            countryComboBox.DataSource = Enum.GetValues(typeof(Country));

            staffComboBox.DataSource = null;
            staffComboBox.DataSource = FootballData.StaffMembers;
            staffComboBox.DisplayMember = "FullName";
            staffComboBox.ValueMember = "Id";

            playerComboBox.DataSource = null;
            playerComboBox.DataSource = FootballData.Players;
            playerComboBox.DisplayMember = "FullName";
            playerComboBox.ValueMember = "Id";

            stadiumComboBox.Items.Clear();
            var existingStadiums = FootballData.Competitions.Select(c => c.Stadium).Distinct().ToArray();
            stadiumComboBox.Items.AddRange(existingStadiums);

            RefreshMatchSelector();
        }

        private void RefreshMatchSelector()
        {
            var matchList = FootballData.Competitions.Select(c => new
            {
                Id = c.EventId,
                Description = $"{c.MatchDate.ToShortDateString()} - {c.Stadium} (Goals: {c.GoalsScored})"
            }).ToList();

            matchSelectorComboBox.DataSource = null;
            matchSelectorComboBox.DataSource = matchList;
            matchSelectorComboBox.DisplayMember = "Description";
            matchSelectorComboBox.ValueMember = "Id";

            matchSelectorComboBox.SelectedIndex = -1;
            ClearFields();
        }

        private void matchSelectorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (matchSelectorComboBox.SelectedValue == null) return;

            if (matchSelectorComboBox.SelectedValue is int matchId)
            {
                selectedMatch = FootballData.Competitions.FirstOrDefault(c => c.EventId == matchId);

                if (selectedMatch != null)
                {
                    // old info
                    stadiumComboBox.Text = selectedMatch.Stadium;
                    goalsScoredTextBox.Text = selectedMatch.GoalsScored.ToString();
                    matchDateTimePicker.Value = selectedMatch.MatchDate;
                    countryComboBox.SelectedItem = selectedMatch.HostCountry;

                    staffComboBox.SelectedValue = selectedMatch.StaffId;
                    playerComboBox.SelectedValue = selectedMatch.PlayerId;
                }
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (selectedMatch == null)
            {
                MessageBox.Show("Please select a match to edit first!");
                return;
            }

            string newStadium = stadiumComboBox.Text.Trim();
            string newGoalsStr = goalsScoredTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(newStadium) || string.IsNullOrWhiteSpace(newGoalsStr))
            {
                MessageBox.Show("Fields cannot be empty!");
                return;
            }

            selectedMatch.Stadium = newStadium;
            selectedMatch.GoalsScored = int.Parse(newGoalsStr);
            selectedMatch.MatchDate = matchDateTimePicker.Value;
            selectedMatch.HostCountry = (Country)countryComboBox.SelectedItem;

            selectedMatch.StaffId = (int)staffComboBox.SelectedValue;
            selectedMatch.PlayerId = (int)playerComboBox.SelectedValue;

            if (MessageBox.Show("Save changes to this match?", "Confirm Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FootballData.SaveData();
                FootballData.ActionHistory.Push($"Edited match ID: {selectedMatch.EventId}");

                MessageBox.Show("Match updated successfully!");

                RefreshMatchSelector();
            }
        }

        private void ClearFields()
        {
            stadiumComboBox.Text = "";
            goalsScoredTextBox.Clear();
            staffComboBox.SelectedIndex = -1;
            playerComboBox.SelectedIndex = -1;
            matchDateTimePicker.Value = DateTime.Now;
            selectedMatch = null;
        }
    }
}