namespace hltv.WinUI
{
    partial class PlayerDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerDetailsForm));
            labelPlayerName = new Label();
            buttonBack = new Button();
            linkLabelStats = new LinkLabel();
            dataGridView1 = new DataGridView();
            BtnSaveChanges = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // labelPlayerName
            // 
            labelPlayerName.AutoSize = true;
            labelPlayerName.BackColor = Color.Transparent;
            labelPlayerName.Font = new Font("Stencil", 36F, FontStyle.Bold, GraphicsUnit.Point);
            labelPlayerName.ForeColor = Color.FromArgb(255, 255, 192);
            labelPlayerName.Location = new Point(226, 9);
            labelPlayerName.Name = "labelPlayerName";
            labelPlayerName.Size = new Size(435, 71);
            labelPlayerName.TabIndex = 0;
            labelPlayerName.Text = "Player Name";
            // 
            // buttonBack
            // 
            buttonBack.BackgroundImage = (Image)resources.GetObject("buttonBack.BackgroundImage");
            buttonBack.BackgroundImageLayout = ImageLayout.Stretch;
            buttonBack.Location = new Point(841, 6);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(107, 74);
            buttonBack.TabIndex = 1;
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // linkLabelStats
            // 
            linkLabelStats.ActiveLinkColor = Color.FromArgb(255, 255, 192);
            linkLabelStats.AutoSize = true;
            linkLabelStats.BackColor = Color.Transparent;
            linkLabelStats.Font = new Font("Showcard Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabelStats.Location = new Point(12, 6);
            linkLabelStats.Name = "linkLabelStats";
            linkLabelStats.Size = new Size(208, 74);
            linkLabelStats.TabIndex = 2;
            linkLabelStats.TabStop = true;
            linkLabelStats.Text = "Stats";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.MidnightBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 134);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(936, 127);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // BtnSaveChanges
            // 
            BtnSaveChanges.BackColor = Color.PaleGreen;
            BtnSaveChanges.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSaveChanges.Location = new Point(371, 99);
            BtnSaveChanges.Name = "BtnSaveChanges";
            BtnSaveChanges.Size = new Size(247, 29);
            BtnSaveChanges.TabIndex = 4;
            BtnSaveChanges.Text = "Save";
            BtnSaveChanges.UseVisualStyleBackColor = false;
            BtnSaveChanges.Click += BtnSaveChanges_Click;
            // 
            // PlayerDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(960, 273);
            Controls.Add(BtnSaveChanges);
            Controls.Add(dataGridView1);
            Controls.Add(linkLabelStats);
            Controls.Add(buttonBack);
            Controls.Add(labelPlayerName);
            Name = "PlayerDetailsForm";
            Text = "PlayerDetailsForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPlayerName;
        private Button buttonBack;
        private LinkLabel linkLabelStats;
        private DataGridView dataGridView1;
        private Button BtnSaveChanges;
    }
}