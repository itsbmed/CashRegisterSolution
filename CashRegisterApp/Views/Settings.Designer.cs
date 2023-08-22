namespace CashRegisterApp.Views
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            panel1 = new Panel();
            button4 = new Button();
            purchase = new Button();
            button1 = new Button();
            Logo = new PictureBox();
            panel2 = new Panel();
            newCashierBtn = new Button();
            label1 = new Label();
            panel3 = new Panel();
            newProductBtn = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(purchase);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(Logo);
            panel1.Location = new Point(2, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(103, 661);
            panel1.TabIndex = 1;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Location = new Point(21, 417);
            button4.Margin = new Padding(4, 3, 4, 3);
            button4.Name = "button4";
            button4.Size = new Size(63, 51);
            button4.TabIndex = 4;
            button4.UseVisualStyleBackColor = false;
            // 
            // purchase
            // 
            purchase.BackColor = Color.Transparent;
            purchase.BackgroundImage = (Image)resources.GetObject("purchase.BackgroundImage");
            purchase.BackgroundImageLayout = ImageLayout.Stretch;
            purchase.Location = new Point(20, 323);
            purchase.Margin = new Padding(4, 3, 4, 3);
            purchase.Name = "purchase";
            purchase.Size = new Size(63, 51);
            purchase.TabIndex = 2;
            purchase.UseVisualStyleBackColor = false;
            purchase.Click += purchase_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(21, 233);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(63, 51);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(newCashierBtn);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(274, 187);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(771, 99);
            panel2.TabIndex = 2;
            // 
            // newCashierBtn
            // 
            newCashierBtn.BackColor = SystemColors.Highlight;
            newCashierBtn.ForeColor = SystemColors.ButtonFace;
            newCashierBtn.Location = new Point(584, 23);
            newCashierBtn.Margin = new Padding(4, 3, 4, 3);
            newCashierBtn.Name = "newCashierBtn";
            newCashierBtn.Size = new Size(147, 48);
            newCashierBtn.TabIndex = 7;
            newCashierBtn.Text = "New Cashier";
            newCashierBtn.UseVisualStyleBackColor = false;
            newCashierBtn.Click += newCashierBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto Mono", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(41, 35);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(112, 32);
            label1.TabIndex = 8;
            label1.Text = "Cashier";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(newProductBtn);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(274, 344);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(771, 99);
            panel3.TabIndex = 3;
            // 
            // newProductBtn
            // 
            newProductBtn.BackColor = SystemColors.Highlight;
            newProductBtn.ForeColor = SystemColors.ButtonFace;
            newProductBtn.Location = new Point(584, 23);
            newProductBtn.Margin = new Padding(4, 3, 4, 3);
            newProductBtn.Name = "newProductBtn";
            newProductBtn.Size = new Size(147, 48);
            newProductBtn.TabIndex = 7;
            newProductBtn.Text = "New Product";
            newProductBtn.UseVisualStyleBackColor = false;
            newProductBtn.Click += newProductBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto Mono", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(41, 35);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(112, 32);
            label2.TabIndex = 8;
            label2.Text = "Product";
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1209, 663);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "Settings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button purchase;
        private Button button1;
        private PictureBox Logo;
        private Panel panel2;
        private Label label1;
        private Button newCashierBtn;
        private Panel panel3;
        private Button newProductBtn;
        private Label label2;
        private Button button4;
    }
}