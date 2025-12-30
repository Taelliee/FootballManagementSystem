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

            var stadiums = FootballDataService.GetStadiums();
            // Note: The Team relationship to Stadium was removed. 

            foreach (var s in stadiums)
            {
                stadiumsDataGridView.Rows.Add(s.Name, s.Country.ToString(), s.Capacity);
            }
        }
    }
}