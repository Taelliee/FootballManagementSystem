using System;
using System.Windows.Forms;
using FootballManager.Models;
using FootballManager.Enums;
using System.Linq;
using System.Data;
using FootballManager.Services;

namespace FootballManager.UserControls.Staff
{
    public partial class EditStaffControl : UserControl
    {
        private Models.Staff selectedStaff;

        public EditStaffControl()
        {
            InitializeComponent();
            LoadData();

            nameComboBox.SelectedIndexChanged += nameComboBox_SelectedIndexChanged;
        }

        private void LoadData()
        {
            countryComboBox.DataSource = Enum.GetValues(typeof(Country));
            positionComboBox.DataSource = Enum.GetValues(typeof(StaffPosition));

            nameComboBox.Items.Clear();
            nameComboBox.DisplayMember = "FullName"; // Use DisplayMember
            var staffList = FootballManager.Services.FootballDataService.GetStaff();
            if (staffList.Any())
            {
                nameComboBox.Items.AddRange(staffList.ToArray());
            }

            ClearFields();
        }

        private void nameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nameComboBox.SelectedItem is not Models.Staff staff) return;

            selectedStaff = staff;

            countryComboBox.SelectedItem = selectedStaff.Country;
            positionComboBox.SelectedItem = selectedStaff.Role;
            newNameTextBox.Text = selectedStaff.FullName;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (selectedStaff == null)
            {
                MessageBox.Show("Select a staff member first!");
                return;
            }

            string newName = newNameTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(newName))
            {
                MessageBox.Show("Name cannot be empty!");
                return;
            }

            // Update the properties of the selected staff object
            selectedStaff.FullName = newName;
            selectedStaff.Country = (Country)countryComboBox.SelectedItem;
            selectedStaff.Role = (StaffPosition)positionComboBox.SelectedItem;

            // Save changes to the database
            if (MessageBox.Show("Save changes?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FootballManager.Services.FootballDataService.UpdateStaff(selectedStaff);

                MessageBox.Show("Updated successfully!");

                // Refresh the form
                int selectedIndex = nameComboBox.SelectedIndex;
                LoadData();
                nameComboBox.SelectedIndex = selectedIndex;
            }
        }

        private void ClearFields()
        {
            nameComboBox.Text = "";
            newNameTextBox.Clear();
            selectedStaff = null;
        }
    }
}