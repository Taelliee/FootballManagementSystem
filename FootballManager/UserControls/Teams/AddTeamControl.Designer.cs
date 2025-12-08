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
            label1 = new Label();
            countryLabel = new Label();
            fullNameLabel = new Label();
            countryComboBox = new ComboBox();
            nameTextBox = new TextBox();
            addButton = new Button();
            uploadButton = new Button();
            badgePictureBox = new PictureBox();
            label3 = new Label();
            coachComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)badgePictureBox).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(226, 315);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 31;
            label2.Text = "Head Coach";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(263, 35);
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
            countryLabel.Location = new Point(252, 237);
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
            fullNameLabel.Location = new Point(267, 165);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(50, 20);
            fullNameLabel.TabIndex = 27;
            fullNameLabel.Text = "Name";
            // 
            // countryComboBox
            // 
            countryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            countryComboBox.FormattingEnabled = true;
            countryComboBox.Location = new Point(353, 234);
            countryComboBox.Name = "countryComboBox";
            countryComboBox.Size = new Size(200, 28);
            countryComboBox.TabIndex = 26;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(353, 162);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(200, 27);
            nameTextBox.TabIndex = 25;
            // 
            // addButton
            // 
            addButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            addButton.ForeColor = Color.DarkRed;
            addButton.Location = new Point(353, 501);
            addButton.Name = "addButton";
            addButton.Size = new Size(115, 40);
            addButton.TabIndex = 24;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // uploadButton
            // 
            uploadButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            uploadButton.ForeColor = Color.DarkRed;
            uploadButton.Location = new Point(501, 393);
            uploadButton.Name = "uploadButton";
            uploadButton.Size = new Size(84, 40);
            uploadButton.TabIndex = 34;
            uploadButton.Text = "Upload";
            uploadButton.UseVisualStyleBackColor = true;
            uploadButton.Click += uploadButton_Click;
            // 
            // badgePictureBox
            // 
            badgePictureBox.BorderStyle = BorderStyle.FixedSingle;
            badgePictureBox.Location = new Point(353, 380);
            badgePictureBox.Name = "badgePictureBox";
            badgePictureBox.Size = new Size(115, 64);
            badgePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            badgePictureBox.TabIndex = 33;
            badgePictureBox.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.ForeColor = Color.DarkRed;
            label3.Location = new Point(223, 403);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 32;
            label3.Text = "Team Badge";
            // 
            // coachComboBox
            // 
            coachComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            coachComboBox.FormattingEnabled = true;
            coachComboBox.Location = new Point(353, 312);
            coachComboBox.Name = "coachComboBox";
            coachComboBox.Size = new Size(200, 28);
            coachComboBox.TabIndex = 35;
            // 
            // AddTeamControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            Controls.Add(coachComboBox);
            Controls.Add(uploadButton);
            Controls.Add(badgePictureBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(countryLabel);
            Controls.Add(fullNameLabel);
            Controls.Add(countryComboBox);
            Controls.Add(nameTextBox);
            Controls.Add(addButton);
            Name = "AddTeamControl";
            Size = new Size(825, 626);
            ((System.ComponentModel.ISupportInitialize)badgePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label countryLabel;
        private Label fullNameLabel;
        private ComboBox countryComboBox;
        private TextBox nameTextBox;
        private Button addButton;
        private Button uploadButton;
        private PictureBox badgePictureBox;
        private Label label3;
        private ComboBox coachComboBox;
    }
}
