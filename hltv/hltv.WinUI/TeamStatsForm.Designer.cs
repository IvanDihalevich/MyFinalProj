namespace hltv.WinUI
{
    partial class TeamStatsForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeamStatsForm));
            buttonBack = new Button();
            listBoxTeam = new ListBox();
            comboBoxCountries = new ComboBox();
            buttonUpdate = new Button();
            buttonShowAllTeams = new Button();
            SuspendLayout();
            // 
            // buttonBack
            // 
            buttonBack.BackgroundImage = (Image)resources.GetObject("buttonBack.BackgroundImage");
            buttonBack.BackgroundImageLayout = ImageLayout.Stretch;
            buttonBack.Location = new Point(743, 12);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(102, 56);
            buttonBack.TabIndex = 1;
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // listBoxTeam
            // 
            listBoxTeam.BackColor = Color.MediumPurple;
            listBoxTeam.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point);
            listBoxTeam.FormattingEnabled = true;
            listBoxTeam.ItemHeight = 25;
            listBoxTeam.Location = new Point(97, 73);
            listBoxTeam.Name = "listBoxTeam";
            listBoxTeam.Size = new Size(652, 379);
            listBoxTeam.TabIndex = 2;
            listBoxTeam.SelectedIndexChanged += listBoxTeam_SelectedIndexChanged;
            // 
            // comboBoxCountries
            // 
            comboBoxCountries.BackColor = Color.MediumPurple;
            comboBoxCountries.FormattingEnabled = true;
            comboBoxCountries.Location = new Point(97, 27);
            comboBoxCountries.Name = "comboBoxCountries";
            comboBoxCountries.Size = new Size(172, 28);
            comboBoxCountries.TabIndex = 3;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.FromArgb(192, 255, 192);
            buttonUpdate.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonUpdate.Location = new Point(328, 27);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(146, 29);
            buttonUpdate.TabIndex = 4;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonShowAllTeams
            // 
            buttonShowAllTeams.BackColor = Color.FromArgb(255, 255, 192);
            buttonShowAllTeams.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonShowAllTeams.Location = new Point(507, 27);
            buttonShowAllTeams.Name = "buttonShowAllTeams";
            buttonShowAllTeams.Size = new Size(187, 29);
            buttonShowAllTeams.TabIndex = 5;
            buttonShowAllTeams.Text = "Show All Teams";
            buttonShowAllTeams.UseVisualStyleBackColor = false;
            buttonShowAllTeams.Click += buttonShowAllTeams_Click;
            // 
            // TeamStatsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(857, 503);
            Controls.Add(buttonShowAllTeams);
            Controls.Add(buttonUpdate);
            Controls.Add(comboBoxCountries);
            Controls.Add(listBoxTeam);
            Controls.Add(buttonBack);
            Name = "TeamStatsForm";
            Text = "TeamStatsForm";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonBack;
        private ListBox listBoxTeam;
        private ComboBox comboBoxCountries;
        private Button buttonUpdate;
        private Button buttonShowAllTeams;
    }
}