using System;
using System.Windows.Forms;
using System.Linq;

namespace FootballManager.UserControls.Staff
{
    public partial class DeleteStaffControl : UserControl
    {
        public DeleteStaffControl()
        {
            InitializeComponent();
            LoadStaffList();
        }

        private void LoadStaffList()
        {
            nameComboBox.Items.Clear();
            foreach (var s in FootballData.StaffMembers)
            {
                nameComboBox.Items.Add(s.FullName);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (nameComboBox.SelectedItem == null)
            {
                MessageBox.Show("Select a staff member to delete!");
                return;
            }

            string name = nameComboBox.SelectedItem.ToString();
            var staffToDelete = FootballData.StaffMembers.FirstOrDefault(s => s.FullName == name);

            if (staffToDelete != null)
            {
                if (MessageBox.Show($"Are you sure you want to delete {name}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    FootballData.RemoveStaff(staffToDelete);
                    FootballData.SaveData();

                    MessageBox.Show("Deleted successfully!");

                    nameComboBox.Text = "";
                    LoadStaffList();
                }
            }
        }
    }
}