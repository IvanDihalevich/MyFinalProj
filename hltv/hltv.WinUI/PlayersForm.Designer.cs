
namespace hltv.WinUI
{
    partial class PlayersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayersForm));
            buttonBack = new Button();
            listBoxPlayer = new ListBox();
            buttonAddPlayer = new Button();
            buttonUpdate = new Button();
            SuspendLayout();
            // 
            // buttonBack
            // 
            buttonBack.BackgroundImage = (Image)resources.GetObject("buttonBack.BackgroundImage");
            buttonBack.BackgroundImageLayout = ImageLayout.Stretch;
            buttonBack.Location = new Point(1778, 12);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(102, 56);
            buttonBack.TabIndex = 0;
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click_1;
            // 
            // listBoxPlayer
            // 
            listBoxPlayer.BackColor = Color.FromArgb(47, 110, 164);
            listBoxPlayer.BorderStyle = BorderStyle.None;
            listBoxPlayer.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            listBoxPlayer.ForeColor = Color.FromArgb(255, 255, 128);
            listBoxPlayer.FormattingEnabled = true;
            listBoxPlayer.ItemHeight = 35;
            listBoxPlayer.Location = new Point(267, 132);
            listBoxPlayer.Name = "listBoxPlayer";
            listBoxPlayer.Size = new Size(1335, 805);
            listBoxPlayer.TabIndex = 1;
            listBoxPlayer.SelectedIndexChanged += listBoxPlayer_SelectedIndexChanged_1;
            // 
            // buttonAddPlayer
            // 
            buttonAddPlayer.BackColor = Color.FromArgb(192, 255, 192);
            buttonAddPlayer.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddPlayer.Location = new Point(403, 59);
            buttonAddPlayer.Name = "buttonAddPlayer";
            buttonAddPlayer.Size = new Size(511, 49);
            buttonAddPlayer.TabIndex = 2;
            buttonAddPlayer.Text = "Add";
            buttonAddPlayer.UseVisualStyleBackColor = false;
            buttonAddPlayer.Click += buttonAddPlayer_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.FromArgb(255, 255, 192);
            buttonUpdate.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonUpdate.Location = new Point(955, 59);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(498, 49);
            buttonUpdate.TabIndex = 3;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // PlayersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1902, 1033);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonAddPlayer);
            Controls.Add(listBoxPlayer);
            Controls.Add(buttonBack);
            ForeColor = SystemColors.ControlText;
            Name = "PlayersForm";
            Text = "PlayersForm";
            Load += PlayersForm_Load_1;
            ResumeLayout(false);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button buttonBack;
        private ListBox listBoxPlayer;
        private Button buttonAddPlayer;
        private Button buttonUpdate;
    }
}