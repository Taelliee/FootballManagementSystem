namespace FootballManager.UserControls.Stadiums
{
    partial class ListStadiumsControl
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
            stadiumsDataGridView = new DataGridView();
            FullName = new DataGridViewTextBoxColumn();
            Country = new DataGridViewTextBoxColumn();
            Capacity = new DataGridViewTextBoxColumn();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)stadiumsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // stadiumsDataGridView
            // 
            stadiumsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            stadiumsDataGridView.BackgroundColor = Color.BurlyWood;
            stadiumsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            stadiumsDataGridView.Columns.AddRange(new DataGridViewColumn[] { FullName, Country, Capacity });
            stadiumsDataGridView.Location = new Point(36, 110);
            stadiumsDataGridView.Name = "stadiumsDataGridView";
            stadiumsDataGridView.RowHeadersWidth = 51;
            stadiumsDataGridView.Size = new Size(744, 427);
            stadiumsDataGridView.TabIndex = 20;
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
            // Capacity
            // 
            Capacity.HeaderText = "Capacity";
            Capacity.MinimumWidth = 6;
            Capacity.Name = "Capacity";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(249, 38);
            label1.Name = "label1";
            label1.Size = new Size(321, 54);
            label1.TabIndex = 19;
            label1.Text = "List of stadiums";
            // 
            // ListStadiumsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            Controls.Add(stadiumsDataGridView);
            Controls.Add(label1);
            Name = "ListStadiumsControl";
            Size = new Size(817, 574);
            ((System.ComponentModel.ISupportInitialize)stadiumsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView stadiumsDataGridView;
        private Label label1;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Country;
        private DataGridViewTextBoxColumn Capacity;
    }
}
