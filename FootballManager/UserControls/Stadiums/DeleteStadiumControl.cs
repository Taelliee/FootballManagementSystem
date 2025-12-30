using System;
using System.Windows.Forms;
using FootballManager.Models;
using FootballManager.Enums;
using System.Linq;
using System.Data;
using FootballManager.Services;

namespace FootballManager.UserControls.Stadiums
{
    public partial class DeleteStadiumControl : UserControl
    {
        public DeleteStadiumControl()
        {
            InitializeComponent();
            countryComboBox.SelectedIndexChanged += countryComboBox_SelectedIndexChanged;
            LoadCountries();
        }

        // Populate countryComboBox with "- All Countries -" first, then all countries
        private void LoadCountries()
        {
            countryComboBox.Items.Clear();
            countryComboBox.Items.Add("- All Countries -");
            foreach (var country in Enum.GetValues(typeof(Country)))
            {
                countryComboBox.Items.Add(country);
            }
            countryComboBox.SelectedIndex = 0;
        }

        private void countryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            stadiumComboBox.Items.Clear();
            stadiumComboBox.Text = "";
            stadiumComboBox.DisplayMember = "Name";

            var stadiums = FootballDataService.GetStadiums();
            if (countryComboBox.SelectedIndex > 0 && countryComboBox.SelectedItem is Country selectedCountry)
            {
                stadiums = stadiums.Where(s => s.Country == selectedCountry).ToList();
            }

            if (stadiums.Any())
            {
                stadiumComboBox.Items.AddRange(stadiums.ToArray());
                stadiumComboBox.SelectedIndex = 0;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (stadiumComboBox.SelectedItem is not Stadium stadiumToDelete)
            {
                MessageBox.Show("Select a stadium first!");
                return;
            }

            var result = MessageBox.Show(
                $"Are you sure you want to delete the stadium {stadiumToDelete.Name}?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                FootballDataService.RemoveStadium(stadiumToDelete.Id);
                MessageBox.Show("Stadium deleted successfully!");

                // Refresh the list
                countryComboBox_SelectedIndexChanged(sender, e);
            }
        }
    }
}