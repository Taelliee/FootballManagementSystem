using System;
using System.Windows.Forms;
using FootballManager.Models;
using FootballManager.Enums;
using System.Linq;

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

            teamComboBox.Items.Clear();
            if (FootballData.Teams.Count > 0)
                teamComboBox.Items.AddRange(FootballData.Teams.Keys.ToArray());
            teamComboBox.DropDownStyle = ComboBoxStyle.DropDown;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text.Trim();
            string capacityStr = capacityTextBox.Text.Trim();
            string team = teamComboBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(capacityStr))
            {
                MessageBox.Show("Name and Capacity are required!");
                return;
            }

            Stadium newStadium = new Stadium
            (
                FootballData.GetNextStadiumId(),
                name,
                team,
                (Country)countryComboBox.SelectedItem,
                int.Parse(capacityStr)
            );

            string msg = $"Confirm Stadium:\nName: {name}\nTeam: {team}\nCapacity: {capacityStr}";
            if (MessageBox.Show(msg, "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                FootballData.AddStadium(newStadium);
                FootballData.SaveData();
                MessageBox.Show("Stadium added!");

                nameTextBox.Clear();
                capacityTextBox.Clear();
                teamComboBox.Text = "";
            }
        }
    }
}