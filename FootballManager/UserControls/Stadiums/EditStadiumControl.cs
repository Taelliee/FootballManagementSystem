using System;
using System.Windows.Forms;
using FootballManager.Models;
using FootballManager.Enums;
using System.Linq;
using FootballManager.Services;

namespace FootballManager.UserControls.Stadiums
{
    public partial class EditStadiumControl : UserControl
    {
        private Stadium selectedStadium;

        public EditStadiumControl()
        {
            InitializeComponent();

            capacityTextBox.KeyPress += (s, e) => { if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true; };
            nameComboBox.SelectedIndexChanged += nameComboBox_SelectedIndexChanged;

            LoadData();
        }

        private void LoadData()
        {
            countryComboBox.DataSource = Enum.GetValues(typeof(Country));

            // Load stadiums to select from
            nameComboBox.Items.Clear();
            nameComboBox.DisplayMember = "Name";
            nameComboBox.DataSource = FootballDataService.GetStadiums();

            // Load teams to assign
            teamComboBox.Items.Clear();
            teamComboBox.DisplayMember = "Name";
            teamComboBox.ValueMember = "Id";
            teamComboBox.DataSource = FootballDataService.GetTeams();
        }

        private void nameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nameComboBox.SelectedItem is not Stadium stadium) return;

            selectedStadium = stadium;

            newNameTextBox.Text = selectedStadium.Name;
            countryComboBox.SelectedItem = selectedStadium.Country;
            capacityTextBox.Text = selectedStadium.Capacity.ToString();
            teamComboBox.SelectedValue = selectedStadium.TeamId;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (selectedStadium == null)
            {
                MessageBox.Show("Select a stadium first!");
                return;
            }

            if (teamComboBox.SelectedItem is not Team selectedTeam)
            {
                MessageBox.Show("A team must be selected for the stadium!");
                return;
            }

            string newName = newNameTextBox.Text.Trim();
            string newCapacityStr = capacityTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(newName) || string.IsNullOrWhiteSpace(newCapacityStr))
            {
                MessageBox.Show("Name and Capacity are required!");
                return;
            }

            selectedStadium.Name = newName;
            selectedStadium.Country = (Country)countryComboBox.SelectedItem;
            selectedStadium.Capacity = int.Parse(newCapacityStr);
            selectedStadium.TeamId = selectedTeam.Id;

            if (MessageBox.Show("Save changes?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FootballDataService.UpdateStadium(selectedStadium);
                MessageBox.Show("Updated successfully!");
                LoadData();
            }
        }
    }
}