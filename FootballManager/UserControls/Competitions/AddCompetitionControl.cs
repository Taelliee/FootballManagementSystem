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

            stadiumComboBox.DataSource = null;
            stadiumComboBox.DataSource = FootballData.Stadiums;
            stadiumComboBox.DisplayMember = "Name";
            stadiumComboBox.ValueMember = "Id";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string goalsStr = goalsScoredTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(goalsStr))
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            if (stadiumComboBox.SelectedItem == null || staffComboBox.SelectedItem == null || playerComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select Stadium, Staff and Player!");
                return;
            }

            int selectedStaffId = (int)staffComboBox.SelectedValue;
            int selectedPlayerId = (int)playerComboBox.SelectedValue;
            int selectedStadiumId = (int)stadiumComboBox.SelectedValue;

            string staffName = ((Models.Staff)staffComboBox.SelectedItem).FullName;
            string playerName = ((Player)playerComboBox.SelectedItem).FullName;
            string stadiumName = ((Stadium)stadiumComboBox.SelectedItem).Name;

            Country selectedCountry = (Country)countryComboBox.SelectedItem;
            DateTime date = matchDateTimePicker.Value;

            Competition comp = new Competition
            (
                FootballData.GetNextCompetitionId(),
                selectedStaffId,
                selectedPlayerId,
                date,
                selectedCountry,
                selectedStadiumId,
                int.Parse(goalsStr)
            );

            string msg = $"Confirm Match:\n\n" +
                         $"Stadium: {stadiumName}\n" +
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