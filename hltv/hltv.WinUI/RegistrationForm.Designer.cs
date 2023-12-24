namespace hltv.WinUI
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            txtNewUsername = new TextBox();
            txtNewPassword = new TextBox();
            btnRegistration = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtNewUsername
            // 
            txtNewUsername.BackColor = Color.FromArgb(255, 224, 192);
            txtNewUsername.Location = new Point(97, 84);
            txtNewUsername.Name = "txtNewUsername";
            txtNewUsername.Size = new Size(125, 27);
            txtNewUsername.TabIndex = 0;
            // 
            // txtNewPassword
            // 
            txtNewPassword.BackColor = Color.FromArgb(255, 224, 192);
            txtNewPassword.Location = new Point(97, 203);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(125, 27);
            txtNewPassword.TabIndex = 1;
            // 
            // btnRegistration
            // 
            btnRegistration.BackColor = Color.FromArgb(192, 255, 192);
            btnRegistration.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistration.Location = new Point(69, 283);
            btnRegistration.Name = "btnRegistration";
            btnRegistration.Size = new Size(172, 29);
            btnRegistration.TabIndex = 2;
            btnRegistration.Text = "Registration";
            btnRegistration.UseVisualStyleBackColor = false;
            btnRegistration.Click += btnRegistration_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 224, 192);
            label1.Location = new Point(97, 47);
            label1.Name = "label1";
            label1.Size = new Size(130, 24);
            label1.TabIndex = 3;
            label1.Text = "Write name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(255, 224, 192);
            label2.Location = new Point(69, 165);
            label2.Name = "label2";
            label2.Size = new Size(180, 24);
            label2.TabIndex = 4;
            label2.Text = "Write password";
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(311, 349);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRegistration);
            Controls.Add(txtNewPassword);
            Controls.Add(txtNewUsername);
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNewUsername;
        private TextBox txtNewPassword;
        private Button btnRegistration;
        private Label label1;
        private Label label2;
    }
}