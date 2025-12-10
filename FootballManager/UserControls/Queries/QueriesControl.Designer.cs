namespace FootballManager.UserControls.Queries
{
    partial class QueriesControl
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dgvAllPeople = new DataGridView();
            tabPage2 = new TabPage();
            btnCount = new Button();
            cmbCompStadium = new ComboBox();
            cmbCompCountry = new ComboBox();
            dtpEnd = new DateTimePicker();
            dtpStart = new DateTimePicker();
            lblCompResult = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage3 = new TabPage();
            chartPlaceholderPanel = new Panel();
            tabPage4 = new TabPage();
            dgvFilteredPlayers = new DataGridView();
            btnSearch = new Button();
            txtFilterValue = new TextBox();
            cmbFilterType = new ComboBox();
            label6 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAllPeople).BeginInit();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFilteredPlayers).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(826, 570);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvAllPeople);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(818, 537);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "All People";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvAllPeople
            // 
            dgvAllPeople.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAllPeople.BackgroundColor = Color.Linen;
            dgvAllPeople.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAllPeople.Dock = DockStyle.Fill;
            dgvAllPeople.Location = new Point(3, 3);
            dgvAllPeople.Name = "dgvAllPeople";
            dgvAllPeople.RowHeadersWidth = 51;
            dgvAllPeople.Size = new Size(812, 531);
            dgvAllPeople.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Linen;
            tabPage2.Controls.Add(btnCount);
            tabPage2.Controls.Add(cmbCompStadium);
            tabPage2.Controls.Add(cmbCompCountry);
            tabPage2.Controls.Add(dtpEnd);
            tabPage2.Controls.Add(dtpStart);
            tabPage2.Controls.Add(lblCompResult);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(818, 537);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Competitions Count";
            // 
            // btnCount
            // 
            btnCount.Location = new Point(355, 319);
            btnCount.Name = "btnCount";
            btnCount.Size = new Size(94, 29);
            btnCount.TabIndex = 9;
            btnCount.Text = "Calculate";
            btnCount.UseVisualStyleBackColor = true;
            btnCount.Click += btnCount_Click;
            // 
            // cmbCompStadium
            // 
            cmbCompStadium.FormattingEnabled = true;
            cmbCompStadium.Location = new Point(502, 194);
            cmbCompStadium.Name = "cmbCompStadium";
            cmbCompStadium.Size = new Size(250, 28);
            cmbCompStadium.TabIndex = 8;
            // 
            // cmbCompCountry
            // 
            cmbCompCountry.FormattingEnabled = true;
            cmbCompCountry.Location = new Point(502, 78);
            cmbCompCountry.Name = "cmbCompCountry";
            cmbCompCountry.Size = new Size(250, 28);
            cmbCompCountry.TabIndex = 7;
            // 
            // dtpEnd
            // 
            dtpEnd.Location = new Point(122, 195);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(250, 27);
            dtpEnd.TabIndex = 6;
            // 
            // dtpStart
            // 
            dtpStart.Location = new Point(122, 78);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(250, 27);
            dtpStart.TabIndex = 5;
            dtpStart.Value = new DateTime(2025, 12, 9, 21, 22, 0, 0);
            // 
            // lblCompResult
            // 
            lblCompResult.AutoSize = true;
            lblCompResult.Location = new Point(265, 422);
            lblCompResult.Name = "lblCompResult";
            lblCompResult.Size = new Size(52, 20);
            lblCompResult.TabIndex = 4;
            lblCompResult.Text = "Result:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(428, 203);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 3;
            label4.Text = "Stadium";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(428, 86);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 2;
            label3.Text = "Country";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 203);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "End Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 86);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 0;
            label1.Text = "Start Date";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(chartPlaceholderPanel);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(818, 537);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Chart";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // chartPlaceholderPanel
            // 
            chartPlaceholderPanel.Dock = DockStyle.Fill;
            chartPlaceholderPanel.Location = new Point(0, 0);
            chartPlaceholderPanel.Name = "chartPlaceholderPanel";
            chartPlaceholderPanel.Size = new Size(818, 537);
            chartPlaceholderPanel.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.Linen;
            tabPage4.Controls.Add(dgvFilteredPlayers);
            tabPage4.Controls.Add(btnSearch);
            tabPage4.Controls.Add(txtFilterValue);
            tabPage4.Controls.Add(cmbFilterType);
            tabPage4.Controls.Add(label6);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(818, 537);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Filter Players";
            // 
            // dgvFilteredPlayers
            // 
            dgvFilteredPlayers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFilteredPlayers.BackgroundColor = Color.Tan;
            dgvFilteredPlayers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFilteredPlayers.Location = new Point(38, 65);
            dgvFilteredPlayers.Name = "dgvFilteredPlayers";
            dgvFilteredPlayers.RowHeadersWidth = 51;
            dgvFilteredPlayers.Size = new Size(741, 434);
            dgvFilteredPlayers.TabIndex = 4;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(628, 18);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtFilterValue
            // 
            txtFilterValue.Location = new Point(397, 20);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new Size(156, 27);
            txtFilterValue.TabIndex = 2;
            // 
            // cmbFilterType
            // 
            cmbFilterType.FormattingEnabled = true;
            cmbFilterType.Items.AddRange(new object[] { "Goals Scored >=", "Shirt Number", "Coach Name" });
            cmbFilterType.Location = new Point(195, 19);
            cmbFilterType.Name = "cmbFilterType";
            cmbFilterType.Size = new Size(151, 28);
            cmbFilterType.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(84, 22);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 0;
            label6.Text = "Filter By";
            // 
            // QueriesControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Name = "QueriesControl";
            Size = new Size(826, 570);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAllPeople).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFilteredPlayers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dgvAllPeople;
        private TabPage tabPage2;
        private Button btnCount;
        private ComboBox cmbCompStadium;
        private ComboBox cmbCompCountry;
        private DateTimePicker dtpEnd;
        private DateTimePicker dtpStart;
        private Label lblCompResult;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabPage tabPage3;
        private Panel chartPlaceholderPanel;
        private TabPage tabPage4;
        private DataGridView dgvFilteredPlayers;
        private Button btnSearch;
        private TextBox txtFilterValue;
        private ComboBox cmbFilterType;
        private Label label6;
    }
}
