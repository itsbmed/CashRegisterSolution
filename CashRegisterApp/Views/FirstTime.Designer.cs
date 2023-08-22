namespace CashRegisterApp.Views
{
    partial class firstTimeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(firstTimeForm));
            FirstTimePanel = new Panel();
            ShowPass = new CheckBox();
            label4 = new Label();
            lbPassword = new Label();
            label3 = new Label();
            LbUsername = new Label();
            lastnameTxt = new RichTextBox();
            passwordTxt = new RichTextBox();
            usernameTxt = new RichTextBox();
            firstnameTxt = new RichTextBox();
            addCashier = new Button();
            label2 = new Label();
            label1 = new Label();
            FirstTimePanel.SuspendLayout();
            SuspendLayout();
            // 
            // FirstTimePanel
            // 
            FirstTimePanel.BackColor = Color.Transparent;
            FirstTimePanel.Controls.Add(ShowPass);
            FirstTimePanel.Controls.Add(label4);
            FirstTimePanel.Controls.Add(lbPassword);
            FirstTimePanel.Controls.Add(label3);
            FirstTimePanel.Controls.Add(LbUsername);
            FirstTimePanel.Controls.Add(lastnameTxt);
            FirstTimePanel.Controls.Add(passwordTxt);
            FirstTimePanel.Controls.Add(usernameTxt);
            FirstTimePanel.Controls.Add(firstnameTxt);
            FirstTimePanel.Controls.Add(addCashier);
            FirstTimePanel.Controls.Add(label2);
            FirstTimePanel.Controls.Add(label1);
            FirstTimePanel.Location = new Point(136, 64);
            FirstTimePanel.Margin = new Padding(4, 3, 4, 3);
            FirstTimePanel.Name = "FirstTimePanel";
            FirstTimePanel.Size = new Size(941, 533);
            FirstTimePanel.TabIndex = 1;
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
            ShowPass.CheckedChanged += checkBox1_CheckedChanged;
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
            lastnameTxt.BackColor = Color.White;
            lastnameTxt.BorderStyle = BorderStyle.None;
            lastnameTxt.Font = new Font("Roboto Mono", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lastnameTxt.Location = new Point(497, 181);
            lastnameTxt.Margin = new Padding(4, 3, 4, 3);
            lastnameTxt.Name = "lastnameTxt";
            lastnameTxt.Size = new Size(230, 42);
            lastnameTxt.TabIndex = 10;
            lastnameTxt.Text = "";
            // 
            // passwordTxt
            // 
            passwordTxt.BackColor = Color.White;
            passwordTxt.BorderStyle = BorderStyle.None;
            passwordTxt.Font = new Font("Roboto Mono", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
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
            usernameTxt.BackColor = Color.White;
            usernameTxt.BorderStyle = BorderStyle.None;
            usernameTxt.Font = new Font("Roboto Mono", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            usernameTxt.Location = new Point(239, 291);
            usernameTxt.Margin = new Padding(4, 3, 4, 3);
            usernameTxt.Name = "usernameTxt";
            usernameTxt.Size = new Size(230, 42);
            usernameTxt.TabIndex = 8;
            usernameTxt.Text = "";
            // 
            // firstnameTxt
            // 
            firstnameTxt.BackColor = Color.White;
            firstnameTxt.BorderStyle = BorderStyle.None;
            firstnameTxt.Font = new Font("Roboto Mono", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            firstnameTxt.Location = new Point(239, 181);
            firstnameTxt.Margin = new Padding(4, 3, 4, 3);
            firstnameTxt.Name = "firstnameTxt";
            firstnameTxt.Size = new Size(230, 42);
            firstnameTxt.TabIndex = 6;
            firstnameTxt.Text = "";
            // 
            // addCashier
            // 
            addCashier.BackColor = SystemColors.Highlight;
            addCashier.ForeColor = SystemColors.ButtonFace;
            addCashier.Location = new Point(408, 387);
            addCashier.Margin = new Padding(4, 3, 4, 3);
            addCashier.Name = "addCashier";
            addCashier.Size = new Size(147, 48);
            addCashier.TabIndex = 5;
            addCashier.Text = "Add Cashier";
            addCashier.UseVisualStyleBackColor = false;
            addCashier.Click += addCashier_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto Mono", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(516, 67);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(143, 35);
            label2.TabIndex = 1;
            label2.Text = "Cashier!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto Mono", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(286, 67);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(255, 35);
            label1.TabIndex = 0;
            label1.Text = "Add Your First ";
            
            // 
            // firstTimeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1209, 663);
            Controls.Add(FirstTimePanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "firstTimeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Welcome";
            FirstTimePanel.ResumeLayout(false);
            FirstTimePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel FirstTimePanel;
        private Button addCashier;
        private Label label2;
        private Label label1;
        private RichTextBox lastnameTxt;
        private RichTextBox passwordTxt;
        private RichTextBox usernameTxt;
        private RichTextBox firstnameTxt;
        private Label lbPassword;
        private Label LbUsername;
        private Label label4;
        private Label label3;
        private CheckBox ShowPass;
    }
}