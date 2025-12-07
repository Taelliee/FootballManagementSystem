using System;
using System.Windows.Forms;
using FootballManager.Models;
using FootballManager.Enums;
using System.Linq;
using System.Data;

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
            positionComboBox.DataSource = Enum.GetValues(typeof(Position));

            nameComboBox.Items.Clear();
            foreach (var s in FootballData.StaffMembers)
            {
                nameComboBox.Items.Add(s.FullName);
            }
        }

        private void nameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nameComboBox.SelectedItem == null) return;

            string name = nameComboBox.SelectedItem.ToString();

            selectedStaff = FootballData.StaffMembers.FirstOrDefault(s => s.FullName == name);

            if (selectedStaff != null)
            {
                countryComboBox.SelectedItem = selectedStaff.Country;
                positionComboBox.SelectedItem = selectedStaff.Role;
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (selectedStaff == null)
            {
                MessageBox.Show("Select a staff member first!");
                return;
            }

            string newName = nameComboBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(newName))
            {
                MessageBox.Show("Name cannot be empty!");
                return;
            }

            Country newCountry = (Country)countryComboBox.SelectedItem;
            Position newRole = (Position)positionComboBox.SelectedItem;

            selectedStaff.FullName = newName;
            selectedStaff.Country = newCountry;
            selectedStaff.Role = newRole;

            // save
            if (MessageBox.Show("Save changes?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FootballData.SaveData();
                FootballData.ActionHistory.Push($"Edited staff: {selectedStaff.FullName}");

                MessageBox.Show("Updated successfully!");

                LoadData();

                nameComboBox.Text = "";
                selectedStaff = null;
            }
        }
    }
}