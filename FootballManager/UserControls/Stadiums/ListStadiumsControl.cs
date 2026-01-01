using System;
using System.Linq;
using System.Windows.Forms;
using FootballManager.Models;
using FootballManager.Services;

namespace FootballManager.UserControls.Stadiums
{
    public partial class ListStadiumsControl : UserControl
    {
        public ListStadiumsControl()
        {
            InitializeComponent();
            LoadGrid();
        }

        public void LoadGrid()
        {
            stadiumsDataGridView.AllowUserToAddRows = false;
            stadiumsDataGridView.Rows.Clear();

            // Call the service and include the related Team data
            var stadiums = FootballDataService.GetStadiums(includeTeam: true);

            foreach (var s in stadiums)
            {
                // Safely get the team name. If s.Team is null, display "No Team".
                string teamName = s.Team?.Name ?? "No Team";

                stadiumsDataGridView.Rows.Add(
                    s.Name, 
                    s.Country.ToString(), 
                    teamName, 
                    s.Capacity
                );
            }
        }
    }
}