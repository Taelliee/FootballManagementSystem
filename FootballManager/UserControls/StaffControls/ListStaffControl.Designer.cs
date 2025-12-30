namespace FootballManager.UserControls.Staff
{
    partial class ListStaffControl
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
            staffDataGridView = new DataGridView();
            FullName = new DataGridViewTextBoxColumn();
            Country = new DataGridViewTextBoxColumn();
            Position = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)staffDataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(214, 18);
            label1.Name = "label1";
            label1.Size = new Size(419, 54);
            label1.TabIndex = 18;
            label1.Text = "List of staff members";
            // 
            // staffDataGridView
            // 
            staffDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            staffDataGridView.BackgroundColor = Color.BurlyWood;
            staffDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            staffDataGridView.Columns.AddRange(new DataGridViewColumn[] { FullName, Country, Position });
            staffDataGridView.Location = new Point(54, 92);
            staffDataGridView.Name = "staffDataGridView";
            staffDataGridView.RowHeadersWidth = 51;
            staffDataGridView.Size = new Size(711, 429);
            staffDataGridView.TabIndex = 17;
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
            // Position
            // 
            Position.HeaderText = "Position";
            Position.MinimumWidth = 6;
            Position.Name = "Position";
            // 
            // ListStaffControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            Controls.Add(label1);
            Controls.Add(staffDataGridView);
            Name = "ListStaffControl";
            Size = new Size(820, 563);
            ((System.ComponentModel.ISupportInitialize)staffDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView staffDataGridView;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Country;
        private DataGridViewTextBoxColumn Position;
    }
}
