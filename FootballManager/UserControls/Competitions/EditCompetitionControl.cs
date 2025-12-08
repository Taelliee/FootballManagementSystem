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
            var usedStadiumIds = FootballData.Competitions.Select(c => c.StadiumId).Distinct();
            var stadiumObjects = FootballData.Stadiums
                                             .Where(s => usedStadiumIds.Contains(s.Id))
                                             .ToList();

            stadiumComboBox.DataSource = null; //reset first
            stadiumComboBox.DataSource = stadiumObjects;

            stadiumComboBox.DisplayMember = "Name";
            stadiumComboBox.ValueMember = "Id";

            RefreshMatchSelector();
        }

        private void RefreshMatchSelector()
        {
            var matchList = FootballData.Competitions.Select(c =>
            {
                var stadium = FootballData.Stadiums.FirstOrDefault(s => s.Id == c.StadiumId);

                string stadiumName = stadium != null ? stadium.Name : "Unknown ID";

                return new
                {
                    Id = c.Id,
                    Description = $"{c.MatchDate.ToShortDateString()} - {stadiumName} (Goals: {c.GoalsScored})"
                };
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
                selectedMatch = FootballData.Competitions.FirstOrDefault(c => c.Id == matchId);

                if (selectedMatch != null)
                {
                    // old info
                    goalsScoredTextBox.Text = selectedMatch.GoalsScored.ToString();
                    matchDateTimePicker.Value = selectedMatch.MatchDate;
                    countryComboBox.SelectedItem = selectedMatch.HostCountry;

                    staffComboBox.SelectedValue = selectedMatch.StaffId;
                    playerComboBox.SelectedValue = selectedMatch.PlayerId;
                    stadiumComboBox.SelectedValue = selectedMatch.StadiumId;
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

            string newGoalsStr = goalsScoredTextBox.Text.Trim();

            if (stadiumComboBox.SelectedItem == null || string.IsNullOrWhiteSpace(newGoalsStr))
            {
                MessageBox.Show("Fields cannot be empty!");
                return;
            }

            selectedMatch.GoalsScored = int.Parse(newGoalsStr);
            selectedMatch.MatchDate = matchDateTimePicker.Value;
            selectedMatch.HostCountry = (Country)countryComboBox.SelectedItem;

            selectedMatch.StaffId = (int)staffComboBox.SelectedValue;
            selectedMatch.PlayerId = (int)playerComboBox.SelectedValue;
            selectedMatch.StadiumId = (int)stadiumComboBox.SelectedValue;


            if (MessageBox.Show("Save changes to this match?", "Confirm Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FootballData.SaveData();
                FootballData.ActionHistory.Push($"Edited match ID: {selectedMatch.Id}");

                MessageBox.Show("Match updated successfully!");

                RefreshMatchSelector();
            }
        }

        private void ClearFields()
        {
            stadiumComboBox.SelectedIndex = -1;
            goalsScoredTextBox.Clear();
            staffComboBox.SelectedIndex = -1;
            playerComboBox.SelectedIndex = -1;
            matchDateTimePicker.Value = DateTime.Now;
            selectedMatch = null;
        }
    }
}