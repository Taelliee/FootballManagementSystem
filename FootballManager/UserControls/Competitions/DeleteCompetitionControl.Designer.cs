namespace FootballManager.UserControls.Competitions
{
    partial class DeleteCompetitionControl
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
            label6 = new Label();
            matchSelectorComboBox = new ComboBox();
            label1 = new Label();
            deleteButton = new Button();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label6.ForeColor = Color.DarkRed;
            label6.Location = new Point(228, 295);
            label6.Name = "label6";
            label6.Size = new Size(93, 20);
            label6.TabIndex = 58;
            label6.Text = "Competition";
            // 
            // matchSelectorComboBox
            // 
            matchSelectorComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            matchSelectorComboBox.FormattingEnabled = true;
            matchSelectorComboBox.Location = new Point(357, 292);
            matchSelectorComboBox.Name = "matchSelectorComboBox";
            matchSelectorComboBox.Size = new Size(310, 28);
            matchSelectorComboBox.TabIndex = 57;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(144, 92);
            label1.Name = "label1";
            label1.Size = new Size(581, 81);
            label1.TabIndex = 56;
            label1.Text = "Delete Competition";
            // 
            // deleteButton
            // 
            deleteButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            deleteButton.ForeColor = Color.DarkRed;
            deleteButton.Location = new Point(357, 454);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(115, 40);
            deleteButton.TabIndex = 55;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // DeleteCompetitionControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            Controls.Add(label6);
            Controls.Add(matchSelectorComboBox);
            Controls.Add(label1);
            Controls.Add(deleteButton);
            Name = "DeleteCompetitionControl";
            Size = new Size(869, 604);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private ComboBox matchSelectorComboBox;
        private Label label1;
        private Button deleteButton;
    }
}
