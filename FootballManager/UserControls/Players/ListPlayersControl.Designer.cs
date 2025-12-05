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
            competitionRadioButton = new RadioButton();
            countryRadioButton = new RadioButton();
            teamRadioButton = new RadioButton();
            dataGridView1 = new DataGridView();
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
            label2.Location = new Point(128, 90);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 13;
            label2.Text = "Show players by:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(252, 19);
            label1.Name = "label1";
            label1.Size = new Size(287, 54);
            label1.TabIndex = 12;
            label1.Text = "List of players";
            // 
            // competitionRadioButton
            // 
            competitionRadioButton.AutoSize = true;
            competitionRadioButton.Location = new Point(569, 88);
            competitionRadioButton.Name = "competitionRadioButton";
            competitionRadioButton.Size = new Size(113, 24);
            competitionRadioButton.TabIndex = 11;
            competitionRadioButton.TabStop = true;
            competitionRadioButton.Text = "Competition";
            competitionRadioButton.UseVisualStyleBackColor = true;
            // 
            // countryRadioButton
            // 
            countryRadioButton.AutoSize = true;
            countryRadioButton.Location = new Point(426, 88);
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
            teamRadioButton.Location = new Point(296, 88);
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
            dataGridView1.BackgroundColor = Color.BurlyWood;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.DataSource = teamBindingSource;
            dataGridView1.Location = new Point(49, 122);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(732, 440);
            dataGridView1.TabIndex = 8;
            // 
            // ListPlayersControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(competitionRadioButton);
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
        private RadioButton competitionRadioButton;
        private RadioButton countryRadioButton;
        private RadioButton teamRadioButton;
        private DataGridView dataGridView1;
    }
}
