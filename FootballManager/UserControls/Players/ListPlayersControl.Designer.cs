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
            label2 = new Label();
            label1 = new Label();
            positionRadioButton = new RadioButton();
            countryRadioButton = new RadioButton();
            teamRadioButton = new RadioButton();
            dataGridView1 = new DataGridView();
            FullName = new DataGridViewTextBoxColumn();
            Team = new DataGridViewTextBoxColumn();
            Country = new DataGridViewTextBoxColumn();
            ShirtNumber = new DataGridViewTextBoxColumn();
            Position = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)teamBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // teamBindingSource
            // 
            teamBindingSource.DataSource = typeof(Models.Team);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(128, 89);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 13;
            label2.Text = "Show players by:";
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
            // positionRadioButton
            // 
            positionRadioButton.AutoSize = true;
            positionRadioButton.ForeColor = Color.DarkRed;
            positionRadioButton.Location = new Point(569, 87);
            positionRadioButton.Name = "positionRadioButton";
            positionRadioButton.Size = new Size(82, 24);
            positionRadioButton.TabIndex = 11;
            positionRadioButton.TabStop = true;
            positionRadioButton.Text = "Position";
            positionRadioButton.UseVisualStyleBackColor = true;
            // 
            // countryRadioButton
            // 
            countryRadioButton.AutoSize = true;
            countryRadioButton.ForeColor = Color.DarkRed;
            countryRadioButton.Location = new Point(426, 87);
            countryRadioButton.Name = "countryRadioButton";
            countryRadioButton.Size = new Size(81, 24);
            countryRadioButton.TabIndex = 10;
            countryRadioButton.TabStop = true;
            countryRadioButton.Text = "Country";
            countryRadioButton.UseVisualStyleBackColor = true;
            // 
            // teamRadioButton
            // 
            teamRadioButton.AutoSize = true;
            teamRadioButton.ForeColor = Color.DarkRed;
            teamRadioButton.Location = new Point(296, 87);
            teamRadioButton.Name = "teamRadioButton";
            teamRadioButton.Size = new Size(66, 24);
            teamRadioButton.TabIndex = 9;
            teamRadioButton.TabStop = true;
            teamRadioButton.Text = "Team";
            teamRadioButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.BurlyWood;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { FullName, Team, Country, ShirtNumber, Position });
            dataGridView1.DataSource = teamBindingSource;
            dataGridView1.Location = new Point(47, 121);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(741, 417);
            dataGridView1.TabIndex = 8;
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
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(positionRadioButton);
            Controls.Add(countryRadioButton);
            Controls.Add(teamRadioButton);
            Controls.Add(dataGridView1);
            Name = "ListPlayersControl";
            Size = new Size(830, 580);
            ((System.ComponentModel.ISupportInitialize)teamBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource teamBindingSource;
        private Label label2;
        private Label label1;
        private RadioButton positionRadioButton;
        private RadioButton countryRadioButton;
        private RadioButton teamRadioButton;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Team;
        private DataGridViewTextBoxColumn Country;
        private DataGridViewTextBoxColumn ShirtNumber;
        private DataGridViewTextBoxColumn Position;
    }
}
