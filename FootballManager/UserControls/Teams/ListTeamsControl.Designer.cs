namespace FootballManager.UserControls.Teams
{
    partial class ListTeamsControl
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
            teamsDataGridView = new DataGridView();
            FullName = new DataGridViewTextBoxColumn();
            Country = new DataGridViewTextBoxColumn();
            HeadCoach = new DataGridViewTextBoxColumn();
            Image = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)teamsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(278, 17);
            label1.Name = "label1";
            label1.Size = new Size(263, 54);
            label1.TabIndex = 14;
            label1.Text = "List of teams";
            // 
            // teamsDataGridView
            // 
            teamsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            teamsDataGridView.BackgroundColor = Color.BurlyWood;
            teamsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            teamsDataGridView.Columns.AddRange(new DataGridViewColumn[] { FullName, Country, HeadCoach, Image });
            teamsDataGridView.Location = new Point(50, 92);
            teamsDataGridView.Name = "teamsDataGridView";
            teamsDataGridView.RowHeadersWidth = 51;
            teamsDataGridView.Size = new Size(708, 447);
            teamsDataGridView.TabIndex = 13;
            // 
            // FullName
            // 
            FullName.HeaderText = "Name";
            FullName.MinimumWidth = 6;
            FullName.Name = "FullName";
            // 
            // Country
            // 
            Country.HeaderText = "Country";
            Country.MinimumWidth = 6;
            Country.Name = "Country";
            // 
            // HeadCoach
            // 
            HeadCoach.HeaderText = "Head Coach";
            HeadCoach.MinimumWidth = 6;
            HeadCoach.Name = "HeadCoach";
            // 
            // Image
            // 
            Image.HeaderText = "Team Badge";
            Image.MinimumWidth = 6;
            Image.Name = "Image";
            // 
            // ListTeamsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            Controls.Add(label1);
            Controls.Add(teamsDataGridView);
            Name = "ListTeamsControl";
            Size = new Size(812, 570);
            ((System.ComponentModel.ISupportInitialize)teamsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView teamsDataGridView;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Country;
        private DataGridViewTextBoxColumn HeadCoach;
        private DataGridViewImageColumn Image;
    }
}
