namespace FootballManager.UserControls.Teams
{
    partial class EditTeamControl
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
            label3 = new Label();
            nameTextBox = new TextBox();
            label2 = new Label();
            coachTextBox = new TextBox();
            label1 = new Label();
            countryLabel = new Label();
            teamLabel = new Label();
            teamComboBox = new ComboBox();
            countryComboBox = new ComboBox();
            editButton = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.ForeColor = Color.DarkRed;
            label3.Location = new Point(230, 433);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 43;
            label3.Text = "New name";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(353, 430);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(200, 27);
            nameTextBox.TabIndex = 42;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(226, 348);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 41;
            label2.Text = "Head Coach";
            // 
            // coachTextBox
            // 
            coachTextBox.Location = new Point(353, 345);
            coachTextBox.Name = "coachTextBox";
            coachTextBox.Size = new Size(200, 27);
            coachTextBox.TabIndex = 40;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(267, 35);
            label1.Name = "label1";
            label1.Size = new Size(318, 81);
            label1.TabIndex = 39;
            label1.Text = "Edit Team";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            countryLabel.ForeColor = Color.DarkRed;
            countryLabel.Location = new Point(252, 182);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(65, 20);
            countryLabel.TabIndex = 38;
            countryLabel.Text = "Country";
            // 
            // teamLabel
            // 
            teamLabel.AutoSize = true;
            teamLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            teamLabel.ForeColor = Color.DarkRed;
            teamLabel.Location = new Point(267, 264);
            teamLabel.Name = "teamLabel";
            teamLabel.Size = new Size(45, 20);
            teamLabel.TabIndex = 37;
            teamLabel.Text = "Team";
            // 
            // teamComboBox
            // 
            teamComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            teamComboBox.FormattingEnabled = true;
            teamComboBox.Location = new Point(353, 261);
            teamComboBox.Name = "teamComboBox";
            teamComboBox.Size = new Size(200, 28);
            teamComboBox.TabIndex = 36;
            // 
            // countryComboBox
            // 
            countryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            countryComboBox.FormattingEnabled = true;
            countryComboBox.Location = new Point(353, 179);
            countryComboBox.Name = "countryComboBox";
            countryComboBox.Size = new Size(200, 28);
            countryComboBox.TabIndex = 35;
            // 
            // editButton
            // 
            editButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            editButton.ForeColor = Color.DarkRed;
            editButton.Location = new Point(353, 514);
            editButton.Name = "editButton";
            editButton.Size = new Size(115, 40);
            editButton.TabIndex = 34;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            // 
            // EditTeamControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            Controls.Add(label3);
            Controls.Add(nameTextBox);
            Controls.Add(label2);
            Controls.Add(coachTextBox);
            Controls.Add(label1);
            Controls.Add(countryLabel);
            Controls.Add(teamLabel);
            Controls.Add(teamComboBox);
            Controls.Add(countryComboBox);
            Controls.Add(editButton);
            Name = "EditTeamControl";
            Size = new Size(845, 605);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox nameTextBox;
        private Label label2;
        private TextBox coachTextBox;
        private Label label1;
        private Label countryLabel;
        private Label teamLabel;
        private ComboBox teamComboBox;
        private ComboBox countryComboBox;
        private Button editButton;
    }
}
