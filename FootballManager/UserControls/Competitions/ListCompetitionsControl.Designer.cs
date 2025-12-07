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
            dataGridView1 = new DataGridView();
            Player = new DataGridViewTextBoxColumn();
            Staff = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Country = new DataGridViewTextBoxColumn();
            Stadium = new DataGridViewTextBoxColumn();
            Goals = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.BurlyWood;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Player, Staff, Date, Country, Stadium, Goals });
            dataGridView1.Location = new Point(39, 99);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(744, 427);
            dataGridView1.TabIndex = 15;
            // 
            // Player
            // 
            Player.HeaderText = "Player";
            Player.MinimumWidth = 6;
            Player.Name = "Player";
            // 
            // Staff
            // 
            Staff.HeaderText = "Staff";
            Staff.MinimumWidth = 6;
            Staff.Name = "Staff";
            // 
            // Date
            // 
            Date.HeaderText = "Date of match";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
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
            Goals.HeaderText = "Goals scored";
            Goals.MinimumWidth = 6;
            Goals.Name = "Goals";
            // 
            // ListCompetitionsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "ListCompetitionsControl";
            Size = new Size(820, 561);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Player;
        private DataGridViewTextBoxColumn Staff;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Country;
        private DataGridViewTextBoxColumn Stadium;
        private DataGridViewTextBoxColumn Goals;
    }
}
