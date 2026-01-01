namespace FootballManager.UserControls.Competitions
{
    partial class ListCompetitionsControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            competitionsDataGridView = new DataGridView();
            Player = new DataGridViewTextBoxColumn();
            Referee = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Country = new DataGridViewTextBoxColumn();
            Stadium = new DataGridViewTextBoxColumn();
            Goals = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)competitionsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(216, 27);
            label1.Name = "label1";
            label1.Size = new Size(392, 54);
            label1.TabIndex = 16;
            label1.Text = "List of competitions";
            // 
            // competitionsDataGridView
            // 
            competitionsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            competitionsDataGridView.BackgroundColor = Color.BurlyWood;
            competitionsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            competitionsDataGridView.Columns.AddRange(new DataGridViewColumn[] { Player, Referee, Date, Country, Stadium, Goals });
            competitionsDataGridView.Location = new Point(20, 99);
            competitionsDataGridView.Name = "competitionsDataGridView";
            competitionsDataGridView.RowHeadersWidth = 51;
            competitionsDataGridView.Size = new Size(781, 442);
            competitionsDataGridView.TabIndex = 15;
            // 
            // Player
            // 
            Player.HeaderText = "Player";
            Player.MinimumWidth = 6;
            Player.Name = "Player";
            // 
            // Referee
            // 
            Referee.HeaderText = "Referee";
            Referee.MinimumWidth = 6;
            Referee.Name = "Referee";
            // 
            // Date
            // 
            Date.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Date.HeaderText = "Date";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            Date.Width = 125;
            // 
            // Country
            // 
            Country.HeaderText = "Country";
            Country.MinimumWidth = 6;
            Country.Name = "Country";
            // 
            // Stadium
            // 
            Stadium.HeaderText = "Stadium";
            Stadium.MinimumWidth = 6;
            Stadium.Name = "Stadium";
            // 
            // Goals
            // 
            Goals.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Goals.HeaderText = "Goals";
            Goals.MinimumWidth = 6;
            Goals.Name = "Goals";
            Goals.Width = 60;
            // 
            // ListCompetitionsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            Controls.Add(label1);
            Controls.Add(competitionsDataGridView);
            Name = "ListCompetitionsControl";
            Size = new Size(820, 561);
            ((System.ComponentModel.ISupportInitialize)competitionsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView competitionsDataGridView;
        private DataGridViewTextBoxColumn Staff;
        private DataGridViewTextBoxColumn Player;
        private DataGridViewTextBoxColumn Referee;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Country;
        private DataGridViewTextBoxColumn Stadium;
        private DataGridViewTextBoxColumn Goals;
    }
}
