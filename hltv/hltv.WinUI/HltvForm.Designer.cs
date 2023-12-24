namespace hltv.WinUI
{
    partial class HltvForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HltvForm));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label2 = new Label();
            pictureBoxTeam = new PictureBox();
            buttonExit = new Button();
            label1 = new Label();
            pictureBoxPlayer = new PictureBox();
            tabPage2 = new TabPage();
            buttonExit2 = new Button();
            removeButton = new Button();
            addButton = new Button();
            listView1 = new ListView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTeam).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayer).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1902, 1033);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackgroundImage = (Image)resources.GetObject("tabPage1.BackgroundImage");
            tabPage1.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(pictureBoxTeam);
            tabPage1.Controls.Add(buttonExit);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(pictureBoxPlayer);
            tabPage1.ForeColor = SystemColors.ControlText;
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1894, 1000);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Players";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 255, 192);
            label2.Font = new Font("Stencil", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(1291, 206);
            label2.Name = "label2";
            label2.Size = new Size(387, 71);
            label2.TabIndex = 4;
            label2.Text = "Team Stats";
            // 
            // pictureBoxTeam
            // 
            pictureBoxTeam.Image = (Image)resources.GetObject("pictureBoxTeam.Image");
            pictureBoxTeam.Location = new Point(1191, 289);
            pictureBoxTeam.Name = "pictureBoxTeam";
            pictureBoxTeam.Size = new Size(596, 356);
            pictureBoxTeam.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxTeam.TabIndex = 3;
            pictureBoxTeam.TabStop = false;
            pictureBoxTeam.Click += pictureBoxTeam_Click;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.Red;
            buttonExit.Location = new Point(1804, 0);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(94, 80);
            buttonExit.TabIndex = 2;
            buttonExit.Text = "X";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 255, 192);
            label1.Font = new Font("Stencil", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(170, 206);
            label1.Name = "label1";
            label1.Size = new Size(454, 71);
            label1.TabIndex = 1;
            label1.Text = "Player Stats";
            // 
            // pictureBoxPlayer
            // 
            pictureBoxPlayer.Image = (Image)resources.GetObject("pictureBoxPlayer.Image");
            pictureBoxPlayer.Location = new Point(111, 298);
            pictureBoxPlayer.Name = "pictureBoxPlayer";
            pictureBoxPlayer.Size = new Size(582, 347);
            pictureBoxPlayer.TabIndex = 0;
            pictureBoxPlayer.TabStop = false;
            pictureBoxPlayer.Click += pictureBoxPlayer_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackgroundImage = (Image)resources.GetObject("tabPage2.BackgroundImage");
            tabPage2.Controls.Add(buttonExit2);
            tabPage2.Controls.Add(removeButton);
            tabPage2.Controls.Add(addButton);
            tabPage2.Controls.Add(listView1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1894, 1000);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "News";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonExit2
            // 
            buttonExit2.BackColor = Color.Red;
            buttonExit2.Location = new Point(1800, 0);
            buttonExit2.Name = "buttonExit2";
            buttonExit2.Size = new Size(94, 83);
            buttonExit2.TabIndex = 3;
            buttonExit2.Text = "X";
            buttonExit2.UseVisualStyleBackColor = false;
            buttonExit2.Click += buttonExit2_Click;
            // 
            // removeButton
            // 
            removeButton.BackColor = Color.FromArgb(255, 128, 128);
            removeButton.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            removeButton.Location = new Point(854, 28);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(726, 39);
            removeButton.TabIndex = 2;
            removeButton.Text = "REMOVE";
            removeButton.UseVisualStyleBackColor = false;
            removeButton.Click += removeButton_Click;
            // 
            // addButton
            // 
            addButton.BackColor = Color.FromArgb(192, 255, 192);
            addButton.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addButton.Location = new Point(239, 28);
            addButton.Name = "addButton";
            addButton.Size = new Size(618, 39);
            addButton.TabIndex = 1;
            addButton.Text = "ADD";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // listView1
            // 
            listView1.BackColor = Color.FromArgb(47, 110, 164);
            listView1.BackgroundImage = (Image)resources.GetObject("listView1.BackgroundImage");
            listView1.ForeColor = Color.Transparent;
            listView1.Location = new Point(239, 82);
            listView1.Name = "listView1";
            listView1.Size = new Size(1335, 814);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // HltvForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(tabControl1);
            Name = "HltvForm";
            Text = "HltvForm";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTeam).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayer).EndInit();
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private PictureBox pictureBoxPlayer;
        private Label label1;
        private ListView listView1;
        private Button addButton;
        private Button removeButton;
        private Button buttonExit;
        private Button buttonExit2;
        private Label label2;
        private PictureBox pictureBoxTeam;
    }
}