namespace FootballManager.UserControls.Players
{
    partial class ListPlayersControl
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
            components = new System.ComponentModel.Container();
            teamBindingSource = new BindingSource(components);
            label1 = new Label();
            playersDataGridView = new DataGridView();
            FullName = new DataGridViewTextBoxColumn();
            Team = new DataGridViewTextBoxColumn();
            Country = new DataGridViewTextBoxColumn();
            ShirtNumber = new DataGridViewTextBoxColumn();
            Position = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)teamBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playersDataGridView).BeginInit();
            SuspendLayout();
            // 
            // teamBindingSource
            // 
            teamBindingSource.DataSource = typeof(Models.Team);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(269, 20);
            label1.Name = "label1";
            label1.Size = new Size(287, 54);
            label1.TabIndex = 12;
            label1.Text = "List of players";
            // 
            // playersDataGridView
            // 
            playersDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            playersDataGridView.BackgroundColor = Color.BurlyWood;
            playersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            playersDataGridView.Columns.AddRange(new DataGridViewColumn[] { FullName, Team, Country, ShirtNumber, Position });
            playersDataGridView.Location = new Point(47, 101);
            playersDataGridView.Name = "playersDataGridView";
            playersDataGridView.RowHeadersWidth = 51;
            playersDataGridView.Size = new Size(741, 437);
            playersDataGridView.TabIndex = 8;
            // 
            // FullName
            // 
            FullName.HeaderText = "Full Name";
            FullName.MinimumWidth = 6;
            FullName.Name = "FullName";
            // 
            // Team
            // 
            Team.HeaderText = "Team";
            Team.MinimumWidth = 6;
            Team.Name = "Team";
            // 
            // Country
            // 
            Country.HeaderText = "Country";
            Country.MinimumWidth = 6;
            Country.Name = "Country";
            // 
            // ShirtNumber
            // 
            ShirtNumber.HeaderText = "Shirt Number";
            ShirtNumber.MinimumWidth = 6;
            ShirtNumber.Name = "ShirtNumber";
            // 
            // Position
            // 
            Position.HeaderText = "Position";
            Position.MinimumWidth = 6;
            Position.Name = "Position";
            // 
            // ListPlayersControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            Controls.Add(label1);
            Controls.Add(playersDataGridView);
            Name = "ListPlayersControl";
            Size = new Size(830, 580);
            ((System.ComponentModel.ISupportInitialize)teamBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)playersDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource teamBindingSource;
        private Label label1;
        private DataGridView playersDataGridView;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Team;
        private DataGridViewTextBoxColumn Country;
        private DataGridViewTextBoxColumn ShirtNumber;
        private DataGridViewTextBoxColumn Position;
    }
}
