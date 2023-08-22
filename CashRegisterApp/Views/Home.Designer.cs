namespace CashRegisterApp.Views
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            panel1 = new Panel();
            settingsBtn = new Button();
            logoutBtn = new Button();
            purchaseBtn = new Button();
            homeBtn = new Button();
            Logo = new PictureBox();
            newPurchaseBtn = new Button();
            fullnameLbl = new Label();
            panel2 = new Panel();
            label2 = new Label();
            label3 = new Label();
            userLogo = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userLogo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(settingsBtn);
            panel1.Controls.Add(logoutBtn);
            panel1.Controls.Add(purchaseBtn);
            panel1.Controls.Add(homeBtn);
            panel1.Controls.Add(Logo);
            panel1.Location = new Point(4, 1);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(103, 661);
            panel1.TabIndex = 0;
            // 
            // settingsBtn
            // 
            settingsBtn.BackColor = Color.Transparent;
            settingsBtn.BackgroundImage = (Image)resources.GetObject("settingsBtn.BackgroundImage");
            settingsBtn.BackgroundImageLayout = ImageLayout.Stretch;
            settingsBtn.Location = new Point(20, 396);
            settingsBtn.Margin = new Padding(4, 3, 4, 3);
            settingsBtn.Name = "settingsBtn";
            settingsBtn.Size = new Size(63, 51);
            settingsBtn.TabIndex = 4;
            settingsBtn.UseVisualStyleBackColor = false;
            settingsBtn.Click += settingsBtn_Click;
            // 
            // logoutBtn
            // 
            logoutBtn.BackColor = Color.Transparent;
            logoutBtn.BackgroundImage = (Image)resources.GetObject("logoutBtn.BackgroundImage");
            logoutBtn.BackgroundImageLayout = ImageLayout.Stretch;
            logoutBtn.Location = new Point(36, 593);
            logoutBtn.Margin = new Padding(4, 3, 4, 3);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(47, 43);
            logoutBtn.TabIndex = 3;
            logoutBtn.UseVisualStyleBackColor = false;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // purchaseBtn
            // 
            purchaseBtn.BackColor = Color.Transparent;
            purchaseBtn.BackgroundImage = (Image)resources.GetObject("purchaseBtn.BackgroundImage");
            purchaseBtn.BackgroundImageLayout = ImageLayout.Stretch;
            purchaseBtn.Location = new Point(20, 305);
            purchaseBtn.Margin = new Padding(4, 3, 4, 3);
            purchaseBtn.Name = "purchaseBtn";
            purchaseBtn.Size = new Size(63, 51);
            purchaseBtn.TabIndex = 2;
            purchaseBtn.UseVisualStyleBackColor = false;
            purchaseBtn.Click += purchaseBtn_Click;
            // 
            // homeBtn
            // 
            homeBtn.BackColor = Color.Transparent;
            homeBtn.BackgroundImage = (Image)resources.GetObject("homeBtn.BackgroundImage");
            homeBtn.BackgroundImageLayout = ImageLayout.Stretch;
            homeBtn.Location = new Point(21, 215);
            homeBtn.Margin = new Padding(4, 3, 4, 3);
            homeBtn.Name = "homeBtn";
            homeBtn.Size = new Size(63, 51);
            homeBtn.TabIndex = 1;
            homeBtn.UseVisualStyleBackColor = false;
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
            // newPurchaseBtn
            // 
            newPurchaseBtn.BackColor = SystemColors.Highlight;
            newPurchaseBtn.ForeColor = SystemColors.ButtonFace;
            newPurchaseBtn.Location = new Point(318, 259);
            newPurchaseBtn.Margin = new Padding(4, 3, 4, 3);
            newPurchaseBtn.Name = "newPurchaseBtn";
            newPurchaseBtn.Size = new Size(147, 48);
            newPurchaseBtn.TabIndex = 6;
            newPurchaseBtn.Text = "New Purchase";
            newPurchaseBtn.UseVisualStyleBackColor = false;
            newPurchaseBtn.Click += newPurchaseBtn_Click;
            // 
            // fullnameLbl
            // 
            fullnameLbl.AutoSize = true;
            fullnameLbl.Font = new Font("Roboto Mono", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            fullnameLbl.ForeColor = SystemColors.Highlight;
            fullnameLbl.Location = new Point(914, 34);
            fullnameLbl.Margin = new Padding(4, 0, 4, 0);
            fullnameLbl.Name = "fullnameLbl";
            fullnameLbl.Size = new Size(210, 25);
            fullnameLbl.TabIndex = 8;
            fullnameLbl.Text = "Mohammed Belachhab";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(newPurchaseBtn);
            panel2.Location = new Point(259, 105);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(782, 420);
            panel2.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto Mono", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(189, 200);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(420, 32);
            label2.TabIndex = 11;
            label2.Text = "Let's Begin Ringing Up Sales!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto Mono", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(156, 152);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(490, 32);
            label3.TabIndex = 10;
            label3.Text = "Welcome to Your Cash Register App!";
            // 
            // userLogo
            // 
            userLogo.BackgroundImage = (Image)resources.GetObject("userLogo.BackgroundImage");
            userLogo.BackgroundImageLayout = ImageLayout.Stretch;
            userLogo.Location = new Point(1132, 19);
            userLogo.Margin = new Padding(4, 3, 4, 3);
            userLogo.Name = "userLogo";
            userLogo.Size = new Size(53, 50);
            userLogo.TabIndex = 9;
            userLogo.TabStop = false;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1209, 663);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(fullnameLbl);
            Controls.Add(userLogo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            FormClosed += Home_FormClosed;
            Load += Home_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox Logo;
        private Button homeBtn;
        private Button purchaseBtn;
        private Button logoutBtn;
        private Button newPurchaseBtn;
        private Label fullnameLbl;
        private Panel panel2;
        private PictureBox userLogo;
        private Button settingsBtn;
        private Label label2;
        private Label label3;
    }
}