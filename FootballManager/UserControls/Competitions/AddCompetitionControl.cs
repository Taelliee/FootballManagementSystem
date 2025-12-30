using System;
using System.Windows.Forms;
using FootballManager.Models;
using FootballManager.Enums;
using System.Collections.Generic;
using System.Linq;
using FootballManager.Services;

namespace FootballManager.UserControls.Competitions
{
    public partial class AddCompetitionControl : UserControl
    {
        public AddCompetitionControl()
        {
            InitializeComponent();

            stadiumComboBox.DropDownStyle = ComboBoxStyle.DropDown;

            LoadData();
        }

        private void LoadData()
        {
            countryComboBox.DataSource = Enum.GetValues(typeof(Country));

            staffComboBox.DataSource = null;
            staffComboBox.DataSource = FootballDataService.GetStaff();
            staffComboBox.DisplayMember = "FullName";
            staffComboBox.ValueMember = "Id";

            playerComboBox.DataSource = null;
            playerComboBox.DataSource = FootballDataService.GetPlayers();
            playerComboBox.DisplayMember = "FullName";
            playerComboBox.ValueMember = "Id";

            stadiumComboBox.DataSource = null;
            stadiumComboBox.DataSource = FootballDataService.GetStadiums();
            stadiumComboBox.DisplayMember = "Name";
            stadiumComboBox.ValueMember = "Id";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // Get the value directly from the NumericUpDown control
            int goalsScored = (int)goalsScoredNumericUpDown.Value;

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
                selectedStaffId,
                selectedPlayerId,
                date,
                selectedCountry,
                selectedStadiumId,
                goalsScored
            );

            string msg = $"Confirm Match:\n\n" +
                         $"Stadium: {stadiumName}\n" +
                         $"Goals: {goalsScored}\n" +
                         $"Referee: {staffName}\n" +
                         $"Player: {playerName}";

            if (MessageBox.Show(msg, "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                FootballDataService.AddCompetition(comp);

                MessageBox.Show("Competition added successfully!");

                // Reset the controls
                stadiumComboBox.Text = "";
                goalsScoredNumericUpDown.Value = 0;

                LoadData();
            }
        }
    }
}