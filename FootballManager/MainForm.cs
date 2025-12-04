using FootballManager.Enums;
using FootballManager.UserControls.Players;
using System.Windows.Forms.DataVisualization.Charting;

namespace FootballManager
{
    public partial class MainForm : Form
    {
        private EntityType currentEntity = EntityType.Players;
        private ActionType currentAction = ActionType.Add;
        public MainForm()
        {
            InitializeComponent();
        }

        private void UpdateCenterPanel()
        {
            contentPanel.Controls.Clear();
            UserControl control = new AddPlayerControl(); //default?

            if (currentEntity == EntityType.Players)
            {
                switch (currentAction)
                {
                    case ActionType.Add:
                        control = new AddPlayerControl();
                        break;
                    case ActionType.Edit:
                        control = new EditPlayerControl();
                        break;
                    case ActionType.Delete:
                        control = new DeletePlayerControl();
                        break;
                    case ActionType.List:
                        control = new ListPlayersControl();
                        break;
                }
            }

            // same for Teams, Staff, Competitions, Stadiums, Countries

            control.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(control);
        }

        //entity buttons
        private void playersButton_Click(object sender, EventArgs e)
        {
            currentEntity = EntityType.Players;
            UpdateCenterPanel();
        }

        private void teamsButton_Click(object sender, EventArgs e)
        {
            currentEntity = EntityType.Teams;
            UpdateCenterPanel();
        }

        private void staffButton_Click(object sender, EventArgs e)
        {
            currentEntity = EntityType.Staff;
            UpdateCenterPanel();
        }

        private void competitionsButton_Click(object sender, EventArgs e)
        {
            currentEntity = EntityType.Competitions;
            UpdateCenterPanel();
        }

        private void stadiumsButton_Click(object sender, EventArgs e)
        {
            currentEntity = EntityType.Stadiums;
            UpdateCenterPanel();
        }

        private void countriesButton_Click(object sender, EventArgs e)
        {
            currentEntity = EntityType.Countries;
            UpdateCenterPanel();
        }

        //action buttons
        private void addButton_Click(object sender, EventArgs e)
        {
            currentAction = ActionType.Add;
            UpdateCenterPanel();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            currentAction = ActionType.Edit;
            UpdateCenterPanel();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            currentAction = ActionType.Delete;
            UpdateCenterPanel();
        }

        private void listButton_Click(object sender, EventArgs e)
        {
            currentAction = ActionType.List;
            UpdateCenterPanel();
        }

        private void queriesButton_Click(object sender, EventArgs e)
        {
            //disbale action buttons/panel?
        }

        //private void mainLogo_Click(object sender, EventArgs e)
        //{
        //    gifPictureBox.BringToFront();
        //    welcomeLabel.BringToFront();
        //}

        private void mainLogoPictureBox_Click(object sender, EventArgs e)
        {
            gifPictureBox.BringToFront();
            welcomeLabel.BringToFront();
        }

        private void mainLogo_Click(object sender, EventArgs e)
        {
            gifPictureBox.BringToFront();
            welcomeLabel.BringToFront();
        }

        //private void CreateChart()
        //{
        //    var chart = new Chart
        //    {
        //        Dock = DockStyle.Fill
        //    };
        //    this.Controls.Add(chart);

        //    var chartArea = new ChartArea("MainArea");
        //    chart.ChartAreas.Add(chartArea);

        //    var series = new Series("Goals")
        //    {
        //        ChartType = SeriesChartType.Column
        //    };

        //    // Example data
        //    series.Points.AddXY("Messi", 35);
        //    series.Points.AddXY("Ronaldo", 30);
        //    series.Points.AddXY("Mbappe", 28);
        //    series.Points.AddXY("Haaland", 26);
        //    series.Points.AddXY("Lewandowski", 22);

        //    chart.Series.Add(series);

        //    chart.Titles.Add("Top Scorers");
        //}
    }
}
