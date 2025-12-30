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

            nameComboBox.Items.Clear();
            nameComboBox.DisplayMember = "Name"; // Use DisplayMember
            var stadiums = FootballDataService.GetStadiums();
            if (stadiums.Any())
            {
                nameComboBox.Items.AddRange(stadiums.ToArray());
            }

            newNameTextBox.Clear();
        }

        private void nameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nameComboBox.SelectedItem is not Stadium stadium) return;

            selectedStadium = stadium;

            countryComboBox.SelectedItem = selectedStadium.Country;
            capacityTextBox.Text = selectedStadium.Capacity.ToString();
            newNameTextBox.Text = selectedStadium.Name;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (selectedStadium == null)
            {
                MessageBox.Show("Select a stadium first!");
                return;
            }

            string newName = newNameTextBox.Text.Trim();
            string newCapacityStr = capacityTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(newName) || string.IsNullOrWhiteSpace(newCapacityStr))
            {
                MessageBox.Show("Name and Capacity are required!");
                return;
            }

            // Update the properties of the selected stadium object
            selectedStadium.Name = newName;
            selectedStadium.Country = (Country)countryComboBox.SelectedItem;
            selectedStadium.Capacity = int.Parse(newCapacityStr);

            // Save changes to the database
            if (MessageBox.Show("Save changes?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FootballDataService.UpdateStadium(selectedStadium);

                MessageBox.Show("Updated successfully!");

                // Refresh the form
                int selectedIndex = nameComboBox.SelectedIndex;
                LoadData();
                nameComboBox.SelectedIndex = selectedIndex;
            }
        }
    }
}