namespace FootballManager.UserControls.Teams
{
    partial class DeleteTeamControl
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
            countryComboBox = new ComboBox();
            label2 = new Label();
            nameComboBox = new ComboBox();
            label1 = new Label();
            fullNameLabel = new Label();
            deleteButton = new Button();
            SuspendLayout();
            // 
            // countryComboBox
            // 
            countryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            countryComboBox.FormattingEnabled = true;
            countryComboBox.Location = new Point(340, 254);
            countryComboBox.Name = "countryComboBox";
            countryComboBox.Size = new Size(200, 28);
            countryComboBox.TabIndex = 38;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(254, 257);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 37;
            label2.Text = "Country";
            // 
            // nameComboBox
            // 
            nameComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            nameComboBox.FormattingEnabled = true;
            nameComboBox.Location = new Point(340, 346);
            nameComboBox.Name = "nameComboBox";
            nameComboBox.Size = new Size(200, 28);
            nameComboBox.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(218, 58);
            label1.Name = "label1";
            label1.Size = new Size(388, 81);
            label1.TabIndex = 35;
            label1.Text = "Delete Team";
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            fullNameLabel.ForeColor = Color.DarkRed;
            fullNameLabel.Location = new Point(254, 349);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(50, 20);
            fullNameLabel.TabIndex = 34;
            fullNameLabel.Text = "Name";
            // 
            // deleteButton
            // 
            deleteButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            deleteButton.ForeColor = Color.DarkRed;
            deleteButton.Location = new Point(340, 491);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(115, 40);
            deleteButton.TabIndex = 33;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // DeleteTeamControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            Controls.Add(countryComboBox);
            Controls.Add(label2);
            Controls.Add(nameComboBox);
            Controls.Add(label1);
            Controls.Add(fullNameLabel);
            Controls.Add(deleteButton);
            Name = "DeleteTeamControl";
            Size = new Size(824, 602);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox countryComboBox;
        private Label label2;
        private ComboBox nameComboBox;
        private Label label1;
        private Label fullNameLabel;
        private Button deleteButton;
    }
}
