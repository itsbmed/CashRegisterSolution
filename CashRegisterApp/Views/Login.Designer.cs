using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CashRegisterApp.Views
{
    partial class loginForm
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
            Label label2;
            Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            LogPanel = new Panel();
            ShowPass = new CheckBox();
            lbPassword = new Label();
            LbUsername = new Label();
            BtnLogin = new System.Windows.Forms.Button();
            txtPassword = new RichTextBox();
            txtUsername = new RichTextBox();
            label2 = new Label();
            label1 = new Label();
            LogPanel.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto Mono", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(502, 75);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(191, 35);
            label2.TabIndex = 1;
            label2.Text = "Log In Now!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto Mono", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(303, 75);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(223, 35);
            label1.TabIndex = 0;
            label1.Text = "Get Started: ";
            // 
            // LogPanel
            // 
            LogPanel.BackColor = Color.Transparent;
            LogPanel.Controls.Add(ShowPass);
            LogPanel.Controls.Add(lbPassword);
            LogPanel.Controls.Add(LbUsername);
            LogPanel.Controls.Add(BtnLogin);
            LogPanel.Controls.Add(txtPassword);
            LogPanel.Controls.Add(txtUsername);
            LogPanel.Controls.Add(label2);
            LogPanel.Controls.Add(label1);
            LogPanel.Location = new Point(105, 63);
            LogPanel.Margin = new Padding(4, 3, 4, 3);
            LogPanel.Name = "LogPanel";
            LogPanel.Size = new Size(997, 540);
            LogPanel.TabIndex = 0;
            LogPanel.Paint += panel1_Paint;
            // 
            // ShowPass
            // 
            ShowPass.AutoSize = true;
            ShowPass.BackColor = Color.Transparent;
            ShowPass.Location = new Point(356, 378);
            ShowPass.Margin = new Padding(4, 3, 4, 3);
            ShowPass.Name = "ShowPass";
            ShowPass.Size = new Size(108, 19);
            ShowPass.TabIndex = 14;
            ShowPass.Text = "Show Password";
            ShowPass.UseVisualStyleBackColor = false;
            ShowPass.CheckedChanged += ShowPass_CheckedChanged;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.ForeColor = SystemColors.ControlDarkDark;
            lbPassword.Location = new Point(352, 272);
            lbPassword.Margin = new Padding(4, 0, 4, 0);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(57, 15);
            lbPassword.TabIndex = 7;
            lbPassword.Text = "Password";
            // 
            // LbUsername
            // 
            LbUsername.AutoSize = true;
            LbUsername.ForeColor = SystemColors.ControlDarkDark;
            LbUsername.Location = new Point(352, 165);
            LbUsername.Margin = new Padding(4, 0, 4, 0);
            LbUsername.Name = "LbUsername";
            LbUsername.Size = new Size(60, 15);
            LbUsername.TabIndex = 6;
            LbUsername.Text = "Username";
            // 
            // BtnLogin
            // 
            BtnLogin.BackColor = SystemColors.Highlight;
            BtnLogin.ForeColor = SystemColors.ControlLight;
            BtnLogin.Location = new Point(425, 427);
            BtnLogin.Margin = new Padding(4, 3, 4, 3);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(145, 47);
            BtnLogin.TabIndex = 5;
            BtnLogin.Text = "Log in";
            BtnLogin.UseVisualStyleBackColor = false;
            BtnLogin.Click += button1_Click;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Roboto Mono", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassword.Location = new Point(356, 306);
            txtPassword.Margin = new Padding(4, 3, 4, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(275, 42);
            txtPassword.TabIndex = 4;
            txtPassword.Text = "";
            txtPassword.KeyPress += txtPassword_KeyPress;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Roboto Mono", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtUsername.Location = new Point(356, 201);
            txtUsername.Margin = new Padding(4, 3, 4, 3);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(275, 42);
            txtUsername.TabIndex = 3;
            txtUsername.Text = "";
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1209, 663);
            Controls.Add(LogPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "loginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log in";
            Load += Form1_Load;
            LogPanel.ResumeLayout(false);
            LogPanel.PerformLayout();
            ResumeLayout(false);
        }


        #endregion

        private Panel LogPanel;
        private RichTextBox txtUsername;
        private System.Windows.Forms.Button BtnLogin;
        private RichTextBox txtPassword;
        private Label lbPassword;
        private Label LbUsername;
        private CheckBox ShowPass;
    }
}

