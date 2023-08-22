namespace CashRegisterApp.Views
{
    partial class NewCashier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewCashier));
            FirstTimePanel = new Panel();
            GobackBtn = new Button();
            ShowPass = new CheckBox();
            label4 = new Label();
            lbPassword = new Label();
            label3 = new Label();
            LbUsername = new Label();
            lastnameTxt = new RichTextBox();
            passwordTxt = new RichTextBox();
            usernameTxt = new RichTextBox();
            firstnameTxt = new RichTextBox();
            AddCashierBtn = new Button();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            settingsBtn = new Button();
            cashierBtn = new Button();
            homeBtn = new Button();
            Logo = new PictureBox();
            FirstTimePanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // FirstTimePanel
            // 
            FirstTimePanel.BackColor = Color.White;
            FirstTimePanel.Controls.Add(GobackBtn);
            FirstTimePanel.Controls.Add(ShowPass);
            FirstTimePanel.Controls.Add(label4);
            FirstTimePanel.Controls.Add(lbPassword);
            FirstTimePanel.Controls.Add(label3);
            FirstTimePanel.Controls.Add(LbUsername);
            FirstTimePanel.Controls.Add(lastnameTxt);
            FirstTimePanel.Controls.Add(passwordTxt);
            FirstTimePanel.Controls.Add(usernameTxt);
            FirstTimePanel.Controls.Add(firstnameTxt);
            FirstTimePanel.Controls.Add(AddCashierBtn);
            FirstTimePanel.Controls.Add(label2);
            FirstTimePanel.Controls.Add(label1);
            FirstTimePanel.Location = new Point(153, 59);
            FirstTimePanel.Margin = new Padding(4, 3, 4, 3);
            FirstTimePanel.Name = "FirstTimePanel";
            FirstTimePanel.Size = new Size(997, 540);
            FirstTimePanel.TabIndex = 2;
            // 
            // GobackBtn
            // 
            GobackBtn.BackColor = Color.Transparent;
            GobackBtn.BackgroundImage = (Image)resources.GetObject("GobackBtn.BackgroundImage");
            GobackBtn.BackgroundImageLayout = ImageLayout.Stretch;
            GobackBtn.Location = new Point(42, 53);
            GobackBtn.Margin = new Padding(4, 3, 4, 3);
            GobackBtn.Name = "GobackBtn";
            GobackBtn.Size = new Size(43, 37);
            GobackBtn.TabIndex = 14;
            GobackBtn.UseVisualStyleBackColor = false;
            GobackBtn.Click += GobackBtn_Click;
            // 
            // ShowPass
            // 
            ShowPass.AutoSize = true;
            ShowPass.BackColor = Color.Transparent;
            ShowPass.Location = new Point(497, 352);
            ShowPass.Margin = new Padding(4, 3, 4, 3);
            ShowPass.Name = "ShowPass";
            ShowPass.Size = new Size(108, 19);
            ShowPass.TabIndex = 13;
            ShowPass.Text = "Show Password";
            ShowPass.UseVisualStyleBackColor = false;
            ShowPass.CheckedChanged += ShowPass_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(493, 258);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 12;
            label4.Text = "Password";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.ForeColor = SystemColors.ControlDarkDark;
            lbPassword.Location = new Point(493, 141);
            lbPassword.Margin = new Padding(4, 0, 4, 0);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(63, 15);
            lbPassword.TabIndex = 12;
            lbPassword.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(236, 258);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 11;
            label3.Text = "Username";
            // 
            // LbUsername
            // 
            LbUsername.AutoSize = true;
            LbUsername.ForeColor = SystemColors.ControlDarkDark;
            LbUsername.Location = new Point(236, 141);
            LbUsername.Margin = new Padding(4, 0, 4, 0);
            LbUsername.Name = "LbUsername";
            LbUsername.Size = new Size(64, 15);
            LbUsername.TabIndex = 11;
            LbUsername.Text = "First Name";
            // 
            // lastnameTxt
            // 
            lastnameTxt.BackColor = SystemColors.GradientInactiveCaption;
            lastnameTxt.BorderStyle = BorderStyle.None;
            lastnameTxt.Location = new Point(497, 181);
            lastnameTxt.Margin = new Padding(4, 3, 4, 3);
            lastnameTxt.Name = "lastnameTxt";
            lastnameTxt.Size = new Size(230, 42);
            lastnameTxt.TabIndex = 10;
            lastnameTxt.Text = "";
            // 
            // passwordTxt
            // 
            passwordTxt.BackColor = SystemColors.GradientInactiveCaption;
            passwordTxt.BorderStyle = BorderStyle.None;
            passwordTxt.Location = new Point(497, 291);
            passwordTxt.Margin = new Padding(4, 3, 4, 3);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.Size = new Size(230, 42);
            passwordTxt.TabIndex = 9;
            passwordTxt.Text = "";
            passwordTxt.KeyPress += passwordTxt_KeyPress;
            // 
            // usernameTxt
            // 
            usernameTxt.BackColor = SystemColors.GradientInactiveCaption;
            usernameTxt.BorderStyle = BorderStyle.None;
            usernameTxt.Location = new Point(239, 291);
            usernameTxt.Margin = new Padding(4, 3, 4, 3);
            usernameTxt.Name = "usernameTxt";
            usernameTxt.Size = new Size(230, 42);
            usernameTxt.TabIndex = 8;
            usernameTxt.Text = "";
            // 
            // firstnameTxt
            // 
            firstnameTxt.BackColor = SystemColors.GradientInactiveCaption;
            firstnameTxt.BorderStyle = BorderStyle.None;
            firstnameTxt.Location = new Point(239, 181);
            firstnameTxt.Margin = new Padding(4, 3, 4, 3);
            firstnameTxt.Name = "firstnameTxt";
            firstnameTxt.Size = new Size(230, 42);
            firstnameTxt.TabIndex = 6;
            firstnameTxt.Text = "";
            // 
            // AddCashierBtn
            // 
            AddCashierBtn.BackColor = SystemColors.Highlight;
            AddCashierBtn.ForeColor = SystemColors.ButtonFace;
            AddCashierBtn.Location = new Point(408, 387);
            AddCashierBtn.Margin = new Padding(4, 3, 4, 3);
            AddCashierBtn.Name = "AddCashierBtn";
            AddCashierBtn.Size = new Size(147, 48);
            AddCashierBtn.TabIndex = 5;
            AddCashierBtn.Text = "Add Cashier";
            AddCashierBtn.UseVisualStyleBackColor = false;
            AddCashierBtn.Click += AddCashierBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto Mono", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(538, 53);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(126, 32);
            label2.TabIndex = 1;
            label2.Text = "Cashier!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto Mono", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(280, 53);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(224, 32);
            label1.TabIndex = 0;
            label1.Text = "Let’s add a new";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(settingsBtn);
            panel1.Controls.Add(cashierBtn);
            panel1.Controls.Add(homeBtn);
            panel1.Controls.Add(Logo);
            panel1.Location = new Point(-4, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(103, 661);
            panel1.TabIndex = 3;
            // 
            // settingsBtn
            // 
            settingsBtn.BackColor = Color.Transparent;
            settingsBtn.BackgroundImage = (Image)resources.GetObject("settingsBtn.BackgroundImage");
            settingsBtn.BackgroundImageLayout = ImageLayout.Stretch;
            settingsBtn.Location = new Point(20, 411);
            settingsBtn.Margin = new Padding(4, 3, 4, 3);
            settingsBtn.Name = "settingsBtn";
            settingsBtn.Size = new Size(63, 51);
            settingsBtn.TabIndex = 4;
            settingsBtn.UseVisualStyleBackColor = false;
            settingsBtn.Click += settingsBtn_Click;
            // 
            // cashierBtn
            // 
            cashierBtn.BackColor = Color.Transparent;
            cashierBtn.BackgroundImage = (Image)resources.GetObject("cashierBtn.BackgroundImage");
            cashierBtn.BackgroundImageLayout = ImageLayout.Stretch;
            cashierBtn.Location = new Point(20, 323);
            cashierBtn.Margin = new Padding(4, 3, 4, 3);
            cashierBtn.Name = "cashierBtn";
            cashierBtn.Size = new Size(63, 51);
            cashierBtn.TabIndex = 2;
            cashierBtn.UseVisualStyleBackColor = false;
            cashierBtn.Click += cashierBtn_Click;
            // 
            // homeBtn
            // 
            homeBtn.BackColor = Color.Transparent;
            homeBtn.BackgroundImage = (Image)resources.GetObject("homeBtn.BackgroundImage");
            homeBtn.BackgroundImageLayout = ImageLayout.Stretch;
            homeBtn.Location = new Point(21, 233);
            homeBtn.Margin = new Padding(4, 3, 4, 3);
            homeBtn.Name = "homeBtn";
            homeBtn.Size = new Size(63, 51);
            homeBtn.TabIndex = 1;
            homeBtn.UseVisualStyleBackColor = false;
            homeBtn.Click += button2_Click;
            // 
            // Logo
            // 
            Logo.BackgroundImage = (Image)resources.GetObject("Logo.BackgroundImage");
            Logo.BackgroundImageLayout = ImageLayout.Stretch;
            Logo.Location = new Point(21, 13);
            Logo.Margin = new Padding(4, 3, 4, 3);
            Logo.Name = "Logo";
            Logo.Size = new Size(63, 55);
            Logo.TabIndex = 0;
            Logo.TabStop = false;
            // 
            // NewCashier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1209, 663);
            Controls.Add(panel1);
            Controls.Add(FirstTimePanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "NewCashier";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New Cashier";
            FirstTimePanel.ResumeLayout(false);
            FirstTimePanel.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel FirstTimePanel;
        private CheckBox ShowPass;
        private Label label4;
        private Label lbPassword;
        private Label label3;
        private Label LbUsername;
        private RichTextBox lastnameTxt;
        private RichTextBox passwordTxt;
        private RichTextBox usernameTxt;
        private RichTextBox firstnameTxt;
        private Button AddCashierBtn;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Button cashierBtn;
        private Button homeBtn;
        private PictureBox Logo;
        private Button GobackBtn;
        private Button settingsBtn;
    }
}