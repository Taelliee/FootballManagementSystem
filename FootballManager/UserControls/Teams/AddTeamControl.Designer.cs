namespace FootballManager.UserControls.Teams
{
    partial class AddTeamControl
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
            label2 = new Label();
            coachTextBox = new TextBox();
            label1 = new Label();
            countryLabel = new Label();
            fullNameLabel = new Label();
            countryComboBox = new ComboBox();
            nameTextBox = new TextBox();
            addButton = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(217, 392);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 31;
            label2.Text = "Head Coach";
            // 
            // coachTextBox
            // 
            coachTextBox.Location = new Point(344, 389);
            coachTextBox.Name = "coachTextBox";
            coachTextBox.Size = new Size(200, 27);
            coachTextBox.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(258, 74);
            label1.Name = "label1";
            label1.Size = new Size(322, 81);
            label1.TabIndex = 29;
            label1.Text = "Add Team";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            countryLabel.ForeColor = Color.DarkRed;
            countryLabel.Location = new Point(243, 314);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(65, 20);
            countryLabel.TabIndex = 28;
            countryLabel.Text = "Country";
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            fullNameLabel.ForeColor = Color.DarkRed;
            fullNameLabel.Location = new Point(258, 242);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(50, 20);
            fullNameLabel.TabIndex = 27;
            fullNameLabel.Text = "Name";
            // 
            // countryComboBox
            // 
            countryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            countryComboBox.FormattingEnabled = true;
            countryComboBox.Location = new Point(344, 311);
            countryComboBox.Name = "countryComboBox";
            countryComboBox.Size = new Size(200, 28);
            countryComboBox.TabIndex = 26;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(344, 239);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(200, 27);
            nameTextBox.TabIndex = 25;
            // 
            // addButton
            // 
            addButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            addButton.ForeColor = Color.DarkRed;
            addButton.Location = new Point(344, 511);
            addButton.Name = "addButton";
            addButton.Size = new Size(115, 40);
            addButton.TabIndex = 24;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            // 
            // AddTeamControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            Controls.Add(label2);
            Controls.Add(coachTextBox);
            Controls.Add(label1);
            Controls.Add(countryLabel);
            Controls.Add(fullNameLabel);
            Controls.Add(countryComboBox);
            Controls.Add(nameTextBox);
            Controls.Add(addButton);
            Name = "AddTeamControl";
            Size = new Size(825, 626);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox coachTextBox;
        private Label label1;
        private Label countryLabel;
        private Label fullNameLabel;
        private ComboBox countryComboBox;
        private TextBox nameTextBox;
        private Button addButton;
    }
}
