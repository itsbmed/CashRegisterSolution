namespace CashRegisterApp.Views
{
    partial class NewItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewItem));
            panel1 = new Panel();
            settingsBtn = new Button();
            newPurchaseBtn = new Button();
            homeBtn = new Button();
            Logo = new PictureBox();
            FirstTimePanel = new Panel();
            GobackBtn = new Button();
            lbPassword = new Label();
            label3 = new Label();
            LbUsername = new Label();
            ProductPrice = new RichTextBox();
            ProductDescription = new RichTextBox();
            ProductName = new RichTextBox();
            AddProductBtn = new Button();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            FirstTimePanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(settingsBtn);
            panel1.Controls.Add(newPurchaseBtn);
            panel1.Controls.Add(homeBtn);
            panel1.Controls.Add(Logo);
            panel1.Location = new Point(1, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(103, 661);
            panel1.TabIndex = 4;
            // 
            // settingsBtn
            // 
            settingsBtn.BackColor = Color.Transparent;
            settingsBtn.BackgroundImage = (Image)resources.GetObject("settingsBtn.BackgroundImage");
            settingsBtn.BackgroundImageLayout = ImageLayout.Stretch;
            settingsBtn.Location = new Point(21, 407);
            settingsBtn.Margin = new Padding(4, 3, 4, 3);
            settingsBtn.Name = "settingsBtn";
            settingsBtn.Size = new Size(63, 51);
            settingsBtn.TabIndex = 4;
            settingsBtn.UseVisualStyleBackColor = false;
            // 
            // newPurchaseBtn
            // 
            newPurchaseBtn.BackColor = Color.Transparent;
            newPurchaseBtn.BackgroundImage = (Image)resources.GetObject("newPurchaseBtn.BackgroundImage");
            newPurchaseBtn.BackgroundImageLayout = ImageLayout.Stretch;
            newPurchaseBtn.Location = new Point(20, 323);
            newPurchaseBtn.Margin = new Padding(4, 3, 4, 3);
            newPurchaseBtn.Name = "newPurchaseBtn";
            newPurchaseBtn.Size = new Size(63, 51);
            newPurchaseBtn.TabIndex = 2;
            newPurchaseBtn.UseVisualStyleBackColor = false;
            newPurchaseBtn.Click += newPurchaseBtn_Click;
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
            homeBtn.Click += homeBtn_Click;
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
            // FirstTimePanel
            // 
            FirstTimePanel.BackColor = Color.White;
            FirstTimePanel.Controls.Add(GobackBtn);
            FirstTimePanel.Controls.Add(lbPassword);
            FirstTimePanel.Controls.Add(label3);
            FirstTimePanel.Controls.Add(LbUsername);
            FirstTimePanel.Controls.Add(ProductPrice);
            FirstTimePanel.Controls.Add(ProductDescription);
            FirstTimePanel.Controls.Add(ProductName);
            FirstTimePanel.Controls.Add(AddProductBtn);
            FirstTimePanel.Controls.Add(label2);
            FirstTimePanel.Controls.Add(label1);
            FirstTimePanel.Location = new Point(156, 62);
            FirstTimePanel.Margin = new Padding(4, 3, 4, 3);
            FirstTimePanel.Name = "FirstTimePanel";
            FirstTimePanel.Size = new Size(997, 540);
            FirstTimePanel.TabIndex = 5;
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
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.ForeColor = SystemColors.ControlDarkDark;
            lbPassword.Location = new Point(493, 141);
            lbPassword.Margin = new Padding(4, 0, 4, 0);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(33, 15);
            lbPassword.TabIndex = 12;
            lbPassword.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(236, 258);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 11;
            label3.Text = "Discreption";
            // 
            // LbUsername
            // 
            LbUsername.AutoSize = true;
            LbUsername.ForeColor = SystemColors.ControlDarkDark;
            LbUsername.Location = new Point(236, 141);
            LbUsername.Margin = new Padding(4, 0, 4, 0);
            LbUsername.Name = "LbUsername";
            LbUsername.Size = new Size(39, 15);
            LbUsername.TabIndex = 11;
            LbUsername.Text = "Name";
            // 
            // ProductPrice
            // 
            ProductPrice.BackColor = SystemColors.GradientInactiveCaption;
            ProductPrice.BorderStyle = BorderStyle.None;
            ProductPrice.Location = new Point(497, 181);
            ProductPrice.Margin = new Padding(4, 3, 4, 3);
            ProductPrice.Name = "ProductPrice";
            ProductPrice.Size = new Size(230, 42);
            ProductPrice.TabIndex = 10;
            ProductPrice.Text = "";
            // 
            // ProductDescription
            // 
            ProductDescription.BackColor = SystemColors.GradientInactiveCaption;
            ProductDescription.BorderStyle = BorderStyle.None;
            ProductDescription.Location = new Point(239, 291);
            ProductDescription.Margin = new Padding(4, 3, 4, 3);
            ProductDescription.Name = "ProductDescription";
            ProductDescription.Size = new Size(488, 81);
            ProductDescription.TabIndex = 8;
            ProductDescription.Text = "";
            // 
            // ProductName
            // 
            ProductName.BackColor = SystemColors.GradientInactiveCaption;
            ProductName.BorderStyle = BorderStyle.None;
            ProductName.Location = new Point(239, 181);
            ProductName.Margin = new Padding(4, 3, 4, 3);
            ProductName.Name = "ProductName";
            ProductName.Size = new Size(230, 42);
            ProductName.TabIndex = 6;
            ProductName.Text = "";
            // 
            // AddProductBtn
            // 
            AddProductBtn.BackColor = SystemColors.Highlight;
            AddProductBtn.ForeColor = SystemColors.ButtonFace;
            AddProductBtn.Location = new Point(411, 418);
            AddProductBtn.Margin = new Padding(4, 3, 4, 3);
            AddProductBtn.Name = "AddProductBtn";
            AddProductBtn.Size = new Size(147, 48);
            AddProductBtn.TabIndex = 5;
            AddProductBtn.Text = "Add Product";
            AddProductBtn.UseVisualStyleBackColor = false;
            AddProductBtn.Click += AddProductBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto Mono", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(512, 51);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(126, 32);
            label2.TabIndex = 1;
            label2.Text = "Product!";
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
            // 
            // NewItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1209, 663);
            Controls.Add(FirstTimePanel);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "NewItem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New Item";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            FirstTimePanel.ResumeLayout(false);
            FirstTimePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button newPurchaseBtn;
        private Button homeBtn;
        private PictureBox Logo;
        private Panel FirstTimePanel;
        private Button GobackBtn;
        private Label lbPassword;
        private Label label3;
        private Label LbUsername;
        private RichTextBox ProductPrice;
        private RichTextBox ProductDescription;
        private RichTextBox ProductName;
        private Button AddProductBtn;
        private Label label2;
        private Label label1;
        private Button settingsBtn;
    }
}