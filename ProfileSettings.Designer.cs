namespace Project
{
    partial class ProfileSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileSettings));
            btnChange = new Button();
            label1 = new Label();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            txtUsername = new TextBox();
            txtEmail = new TextBox();
            txtContact = new TextBox();
            label8 = new Label();
            btnBack = new Button();
            SuspendLayout();
            // 
            // btnChange
            // 
            btnChange.BackColor = Color.MidnightBlue;
            btnChange.Font = new Font("Rockwell", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChange.ForeColor = SystemColors.ButtonHighlight;
            btnChange.Location = new Point(440, 319);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(199, 29);
            btnChange.TabIndex = 0;
            btnChange.Text = "Change Details";
            btnChange.UseVisualStyleBackColor = false;
            btnChange.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(328, 30);
            label1.Name = "label1";
            label1.Size = new Size(117, 38);
            label1.TabIndex = 1;
            label1.Text = "Profile";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(118, 98);
            label4.Name = "label4";
            label4.Size = new Size(116, 24);
            label4.TabIndex = 4;
            label4.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(118, 150);
            label2.Name = "label2";
            label2.Size = new Size(75, 24);
            label2.TabIndex = 5;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(118, 207);
            label3.Name = "label3";
            label3.Size = new Size(180, 24);
            label3.TabIndex = 6;
            label3.Text = "Contact Number:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(118, 324);
            label5.Name = "label5";
            label5.Size = new Size(295, 24);
            label5.TabIndex = 7;
            label5.Text = "Need to change your details?";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(328, 95);
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(216, 27);
            txtUsername.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(328, 147);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(216, 27);
            txtEmail.TabIndex = 10;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(328, 207);
            txtContact.Name = "txtContact";
            txtContact.ReadOnly = true;
            txtContact.Size = new Size(216, 27);
            txtContact.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Magneto", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(287, 424);
            label8.Name = "label8";
            label8.Size = new Size(126, 17);
            label8.TabIndex = 19;
            label8.Text = "Airline AviateX";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Brown;
            btnBack.Font = new Font("Rockwell", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = SystemColors.ButtonHighlight;
            btnBack.Location = new Point(660, 394);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(113, 33);
            btnBack.TabIndex = 20;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // ProfileSettings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(label8);
            Controls.Add(txtContact);
            Controls.Add(txtEmail);
            Controls.Add(txtUsername);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(btnChange);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProfileSettings";
            Text = "ProfileSettings";
            Load += ProfileSettings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnChange;
        private Label label1;
        private Label label4;
        private Label label2;
        private Label label3;
        private Label label5;
        private TextBox txtUsername;
        private TextBox txtEmail;
        private TextBox txtContact;
        private Label label8;
        private Button btnBack;
    }
}