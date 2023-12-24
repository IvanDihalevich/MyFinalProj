namespace hltv.WinUI
{
    partial class AddPlayerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPlayerForm));
            txtNick = new TextBox();
            cmbCountry = new ComboBox();
            txtStatsLink = new TextBox();
            cmbTeam = new ComboBox();
            btnSave = new Button();
            cmbRoundStatistics = new ComboBox();
            cmbStatistics = new ComboBox();
            buttonCancel = new Button();
            label1 = new Label();
            label2 = new Label();
            Statistics = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // txtNick
            // 
            txtNick.Location = new Point(61, 35);
            txtNick.Name = "txtNick";
            txtNick.Size = new Size(151, 27);
            txtNick.TabIndex = 0;
            // 
            // cmbCountry
            // 
            cmbCountry.FormattingEnabled = true;
            cmbCountry.Location = new Point(431, 35);
            cmbCountry.Name = "cmbCountry";
            cmbCountry.Size = new Size(151, 28);
            cmbCountry.TabIndex = 1;
            // 
            // txtStatsLink
            // 
            txtStatsLink.Location = new Point(61, 114);
            txtStatsLink.Name = "txtStatsLink";
            txtStatsLink.Size = new Size(151, 27);
            txtStatsLink.TabIndex = 2;
            // 
            // cmbTeam
            // 
            cmbTeam.FormattingEnabled = true;
            cmbTeam.Location = new Point(431, 113);
            cmbTeam.Name = "cmbTeam";
            cmbTeam.Size = new Size(151, 28);
            cmbTeam.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(255, 255, 192);
            btnSave.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(615, 112);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // cmbRoundStatistics
            // 
            cmbRoundStatistics.FormattingEnabled = true;
            cmbRoundStatistics.Location = new Point(246, 113);
            cmbRoundStatistics.Name = "cmbRoundStatistics";
            cmbRoundStatistics.Size = new Size(151, 28);
            cmbRoundStatistics.TabIndex = 5;
            // 
            // cmbStatistics
            // 
            cmbStatistics.FormattingEnabled = true;
            cmbStatistics.Location = new Point(246, 35);
            cmbStatistics.Name = "cmbStatistics";
            cmbStatistics.Size = new Size(151, 28);
            cmbStatistics.TabIndex = 6;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.FromArgb(255, 255, 192);
            buttonCancel.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancel.Location = new Point(615, 33);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 7;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 255, 192);
            label1.Location = new Point(107, 9);
            label1.Name = "label1";
            label1.Size = new Size(58, 24);
            label1.TabIndex = 8;
            label1.Text = "Nick";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(255, 255, 192);
            label2.Location = new Point(75, 86);
            label2.Name = "label2";
            label2.Size = new Size(120, 24);
            label2.TabIndex = 9;
            label2.Text = "Stats Link";
            // 
            // Statistics
            // 
            Statistics.AutoSize = true;
            Statistics.BackColor = Color.Transparent;
            Statistics.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Statistics.ForeColor = Color.FromArgb(255, 255, 192);
            Statistics.Location = new Point(269, 9);
            Statistics.Name = "Statistics";
            Statistics.Size = new Size(119, 24);
            Statistics.TabIndex = 10;
            Statistics.Text = "Statistics";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(255, 255, 192);
            label4.Location = new Point(232, 86);
            label4.Name = "label4";
            label4.Size = new Size(191, 24);
            label4.TabIndex = 11;
            label4.Text = "Round Statistics";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(255, 255, 192);
            label5.Location = new Point(462, 10);
            label5.Name = "label5";
            label5.Size = new Size(100, 24);
            label5.TabIndex = 12;
            label5.Text = "Country";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(255, 255, 192);
            label6.Location = new Point(478, 86);
            label6.Name = "label6";
            label6.Size = new Size(62, 24);
            label6.TabIndex = 13;
            label6.Text = "Team";
            // 
            // AddPlayerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(728, 181);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(Statistics);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonCancel);
            Controls.Add(cmbStatistics);
            Controls.Add(cmbRoundStatistics);
            Controls.Add(btnSave);
            Controls.Add(cmbTeam);
            Controls.Add(txtStatsLink);
            Controls.Add(cmbCountry);
            Controls.Add(txtNick);
            Name = "AddPlayerForm";
            Text = "AddPlayerForm";
            Load += AddPlayerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNick;
        private ComboBox cmbCountry;
        private TextBox txtStatsLink;
        private ComboBox cmbTeam;
        private Button btnSave;
        private ComboBox cmbRoundStatistics;
        private ComboBox cmbStatistics;
        private Button buttonCancel;
        private Label label1;
        private Label label2;
        private Label Statistics;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}