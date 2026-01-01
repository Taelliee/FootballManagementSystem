using System;
using System.Windows.Forms;
using FootballManager.Models;
using FootballManager.Enums;
using System.Linq;
using FootballManager.Services;

namespace FootballManager.UserControls.Stadiums
{
    public partial class AddStadiumControl : UserControl
    {
        public AddStadiumControl()
        {
            InitializeComponent();

            capacityTextBox.KeyPress += (s, e) => { if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true; };

            LoadData();
        }

        private void LoadData()
        {
            countryComboBox.DataSource = Enum.GetValues(typeof(Country));

            // Load teams into the new teamComboBox
            teamComboBox.DataSource = null;
            teamComboBox.DisplayMember = "Name";
            teamComboBox.ValueMember = "Id";
            teamComboBox.DataSource = FootballDataService.GetTeams();
            teamComboBox.SelectedIndex = 0;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text.Trim();
            string capacityStr = capacityTextBox.Text.Trim();
            int teamId; 

            if (teamComboBox.SelectedItem is Team selectedTeam)
            {
                teamId = selectedTeam.Id;
            }
            else
            {
                MessageBox.Show("Home team is required!");
                return;
            }

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(capacityStr))
            {
                MessageBox.Show("Name and Capacity are required!");
                return;
            }

            if (!int.TryParse(capacityStr, out int capacity))
            {
                MessageBox.Show("Capacity must be a valid integer!");
                return;
            }

            Country country = (Country)countryComboBox.SelectedItem;

            Stadium newStadium = new Stadium
            (
                //FootballData.GetNextStadiumId(),
                name,
                country,
                teamId,
                capacity
            );

            //FootballData.Stadiums.Add(newStadium);
            //FootballData.SaveData();
            FootballDataService.AddStadium(newStadium);

            MessageBox.Show("Stadium added successfully!");

            nameTextBox.Clear();
            capacityTextBox.Clear();
            teamComboBox.SelectedIndex = 0;
        }
    }
}