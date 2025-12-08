using System;
using System.Windows.Forms;
using FootballManager.Models;
using FootballManager.Enums;
using System.Collections.Generic;
using System.Linq;

namespace FootballManager.UserControls.Competitions
{
    public partial class AddCompetitionControl : UserControl
    {
        public AddCompetitionControl()
        {
            InitializeComponent();

            goalsScoredTextBox.KeyPress += (s, e) => { if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true; };

            stadiumComboBox.DropDownStyle = ComboBoxStyle.DropDown;

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
            if (FootballData.Stadiums.Count > 0)
            {
                var stadiumNames = FootballData.Stadiums
                                    .Select(s => s.Name)
                                    .ToArray();

                stadiumComboBox.Items.AddRange(stadiumNames);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string stadium = stadiumComboBox.Text.Trim();
            string goalsStr = goalsScoredTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(stadium) || string.IsNullOrWhiteSpace(goalsStr))
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            if (staffComboBox.SelectedItem == null || playerComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select Staff and Player!");
                return;
            }

            int selectedStaffId = (int)staffComboBox.SelectedValue;
            int selectedPlayerId = (int)playerComboBox.SelectedValue;

            string staffName = ((FootballManager.Models.Staff)staffComboBox.SelectedItem).FullName;
            string playerName = ((Player)playerComboBox.SelectedItem).FullName;

            Country selectedCountry = (Country)countryComboBox.SelectedItem;
            DateTime date = matchDateTimePicker.Value;

            Competition comp = new Competition
            {
                EventId = FootballData.GetNextEventId(),
                StaffId = selectedStaffId,
                PlayerId = selectedPlayerId,
                MatchDate = date,
                HostCountry = selectedCountry,
                Stadium = stadium,
                GoalsScored = int.Parse(goalsStr)
            };

            string msg = $"Confirm Match:\n\n" +
                         $"Stadium: {stadium}\n" +
                         $"Goals: {goalsStr}\n" +
                         $"Referee: {staffName}\n" +
                         $"Player: {playerName}";

            if (MessageBox.Show(msg, "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                FootballData.AddCompetition(comp);
                FootballData.SaveData();

                MessageBox.Show("Competition added successfully!");

                stadiumComboBox.Text = "";
                goalsScoredTextBox.Clear();

                LoadData();
            }
        }
    }
}