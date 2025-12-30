using System;
using System.Windows.Forms;
using FootballManager.Models;
using FootballManager.Enums;
using System.Linq;

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
            foreach (var s in FootballData.Stadiums)
            {
                nameComboBox.Items.Add(s.Name);
            }

            newNameTextBox.Clear();
        }

        private void nameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nameComboBox.SelectedItem == null) return;
            string name = nameComboBox.SelectedItem.ToString();

            selectedStadium = FootballData.Stadiums.FirstOrDefault(s => s.Name == name);

            if (selectedStadium != null)
            {
                countryComboBox.SelectedItem = selectedStadium.Country;
                capacityTextBox.Text = selectedStadium.Capacity.ToString();

                newNameTextBox.Text = selectedStadium.Name;
            }
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

            selectedStadium.Name = newName;
            selectedStadium.Country = (Country)countryComboBox.SelectedItem;
            selectedStadium.Capacity = int.Parse(newCapacityStr);

            // Save changes
            if (MessageBox.Show("Save changes?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FootballData.SaveData();
                FootballData.ActionHistory.Push($"Edited stadium: {selectedStadium.Name}");

                MessageBox.Show("Updated successfully!");

                LoadData();

                nameComboBox.Text = "";
                newNameTextBox.Clear();
                capacityTextBox.Clear();
                selectedStadium = null;
            }
        }
    }
}