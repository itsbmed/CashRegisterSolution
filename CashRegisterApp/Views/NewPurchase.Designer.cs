namespace CashRegisterApp.Views
{
    partial class newPurchase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newPurchase));
            panel1 = new Panel();
            settingsBtn = new Button();
            purchaseBtn = new Button();
            homeBtn = new Button();
            Logo = new PictureBox();
            SearchBox = new RichTextBox();
            addItemBtn = new Button();
            discountTxt = new RichTextBox();
            LbUsername = new Label();
            label1 = new Label();
            GobackBtn = new Button();
            panel2 = new Panel();
            label6 = new Label();
            quantityTxt = new RichTextBox();
            CashierwlcmName = new Label();
            label2 = new Label();
            panel3 = new Panel();
            clearBtn = new Button();
            button3 = new Button();
            finalpriceTxt = new Label();
            discountshowTxt = new Label();
            subTotalTxt = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            PurchasedItemsDataGridView = new DataGridView();
            ProductName = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Discount = new DataGridViewTextBoxColumn();
            pricePerUnit = new DataGridViewTextBoxColumn();
            totalPrice = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PurchasedItemsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(settingsBtn);
            panel1.Controls.Add(purchaseBtn);
            panel1.Controls.Add(homeBtn);
            panel1.Controls.Add(Logo);
            panel1.Location = new Point(1, 1);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(103, 661);
            panel1.TabIndex = 1;
            // 
            // settingsBtn
            // 
            settingsBtn.BackColor = Color.Transparent;
            settingsBtn.BackgroundImage = (Image)resources.GetObject("settingsBtn.BackgroundImage");
            settingsBtn.BackgroundImageLayout = ImageLayout.Stretch;
            settingsBtn.Location = new Point(21, 388);
            settingsBtn.Margin = new Padding(4, 3, 4, 3);
            settingsBtn.Name = "settingsBtn";
            settingsBtn.Size = new Size(63, 51);
            settingsBtn.TabIndex = 16;
            settingsBtn.UseVisualStyleBackColor = false;
            settingsBtn.Click += button4_Click;
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
            // SearchBox
            // 
            SearchBox.BackColor = SystemColors.GradientInactiveCaption;
            SearchBox.BorderStyle = BorderStyle.None;
            SearchBox.Location = new Point(52, 273);
            SearchBox.Margin = new Padding(4, 3, 4, 3);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(289, 46);
            SearchBox.TabIndex = 2;
            SearchBox.Text = "";
            // 
            // addItemBtn
            // 
            addItemBtn.BackColor = SystemColors.Highlight;
            addItemBtn.ForeColor = SystemColors.ButtonFace;
            addItemBtn.Location = new Point(52, 453);
            addItemBtn.Margin = new Padding(4, 3, 4, 3);
            addItemBtn.Name = "addItemBtn";
            addItemBtn.Size = new Size(101, 48);
            addItemBtn.TabIndex = 7;
            addItemBtn.Text = "Add";
            addItemBtn.UseVisualStyleBackColor = false;
            addItemBtn.Click += addItemBtn_Click;
            // 
            // discountTxt
            // 
            discountTxt.BackColor = SystemColors.GradientInactiveCaption;
            discountTxt.BorderStyle = BorderStyle.None;
            discountTxt.Location = new Point(240, 372);
            discountTxt.Margin = new Padding(4, 3, 4, 3);
            discountTxt.Name = "discountTxt";
            discountTxt.Size = new Size(101, 46);
            discountTxt.TabIndex = 8;
            discountTxt.Text = "";
            // 
            // LbUsername
            // 
            LbUsername.AutoSize = true;
            LbUsername.ForeColor = SystemColors.ControlDarkDark;
            LbUsername.Location = new Point(49, 242);
            LbUsername.Margin = new Padding(4, 0, 4, 0);
            LbUsername.Name = "LbUsername";
            LbUsername.Size = new Size(83, 15);
            LbUsername.TabIndex = 12;
            LbUsername.Text = "Product Code:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(236, 341);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 13;
            label1.Text = "Discount (%)";
            // 
            // GobackBtn
            // 
            GobackBtn.BackColor = Color.Transparent;
            GobackBtn.BackgroundImage = (Image)resources.GetObject("GobackBtn.BackgroundImage");
            GobackBtn.BackgroundImageLayout = ImageLayout.Stretch;
            GobackBtn.Location = new Point(52, 61);
            GobackBtn.Margin = new Padding(4, 3, 4, 3);
            GobackBtn.Name = "GobackBtn";
            GobackBtn.Size = new Size(43, 37);
            GobackBtn.TabIndex = 15;
            GobackBtn.UseVisualStyleBackColor = false;
            GobackBtn.Click += GobackBtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(quantityTxt);
            panel2.Controls.Add(CashierwlcmName);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(LbUsername);
            panel2.Controls.Add(GobackBtn);
            panel2.Controls.Add(SearchBox);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(addItemBtn);
            panel2.Controls.Add(discountTxt);
            panel2.Location = new Point(152, 37);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(407, 579);
            panel2.TabIndex = 14;
            panel2.Paint += panel2_Paint;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(48, 339);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 19;
            label6.Text = "Quantity";
            // 
            // quantityTxt
            // 
            quantityTxt.BackColor = SystemColors.GradientInactiveCaption;
            quantityTxt.BorderStyle = BorderStyle.None;
            quantityTxt.Location = new Point(52, 370);
            quantityTxt.Margin = new Padding(4, 3, 4, 3);
            quantityTxt.Name = "quantityTxt";
            quantityTxt.Size = new Size(139, 46);
            quantityTxt.TabIndex = 18;
            quantityTxt.Text = "";
            // 
            // CashierwlcmName
            // 
            CashierwlcmName.AutoSize = true;
            CashierwlcmName.Font = new Font("Roboto Mono", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            CashierwlcmName.ForeColor = SystemColors.Highlight;
            CashierwlcmName.Location = new Point(47, 156);
            CashierwlcmName.Margin = new Padding(4, 0, 4, 0);
            CashierwlcmName.Name = "CashierwlcmName";
            CashierwlcmName.Size = new Size(181, 28);
            CashierwlcmName.TabIndex = 17;
            CashierwlcmName.Text = "searching it!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto Mono", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(46, 119);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(285, 28);
            label2.TabIndex = 16;
            label2.Text = "Add a new purchase by";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(clearBtn);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(finalpriceTxt);
            panel3.Controls.Add(discountshowTxt);
            panel3.Controls.Add(subTotalTxt);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(PurchasedItemsDataGridView);
            panel3.Location = new Point(583, 37);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(609, 579);
            panel3.TabIndex = 15;
            // 
            // clearBtn
            // 
            clearBtn.BackColor = Color.IndianRed;
            clearBtn.ForeColor = SystemColors.ButtonFace;
            clearBtn.Location = new Point(319, 491);
            clearBtn.Margin = new Padding(4, 3, 4, 3);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(124, 39);
            clearBtn.TabIndex = 17;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = false;
            clearBtn.Click += clearBtn_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Highlight;
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(188, 491);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(124, 39);
            button3.TabIndex = 16;
            button3.Text = "Print Recip";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // finalpriceTxt
            // 
            finalpriceTxt.AutoSize = true;
            finalpriceTxt.Location = new Point(392, 453);
            finalpriceTxt.Margin = new Padding(4, 0, 4, 0);
            finalpriceTxt.Name = "finalpriceTxt";
            finalpriceTxt.Size = new Size(37, 15);
            finalpriceTxt.TabIndex = 6;
            finalpriceTxt.Text = "$1150";
            // 
            // discountshowTxt
            // 
            discountshowTxt.AutoSize = true;
            discountshowTxt.Location = new Point(404, 424);
            discountshowTxt.Margin = new Padding(4, 0, 4, 0);
            discountshowTxt.Name = "discountshowTxt";
            discountshowTxt.Size = new Size(25, 15);
            discountshowTxt.TabIndex = 5;
            discountshowTxt.Text = "$50";
            discountshowTxt.TextAlign = ContentAlignment.TopCenter;
            // 
            // subTotalTxt
            // 
            subTotalTxt.AutoSize = true;
            subTotalTxt.Location = new Point(392, 394);
            subTotalTxt.Margin = new Padding(4, 0, 4, 0);
            subTotalTxt.Name = "subTotalTxt";
            subTotalTxt.Size = new Size(37, 15);
            subTotalTxt.TabIndex = 4;
            subTotalTxt.Text = "$1200";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(188, 453);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 3;
            label5.Text = "FinalPrice (€) :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(188, 424);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 2;
            label4.Text = "Discount";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(187, 394);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 1;
            label3.Text = "SubTotal (€) :";
            // 
            // PurchasedItemsDataGridView
            // 
            PurchasedItemsDataGridView.BackgroundColor = SystemColors.GradientInactiveCaption;
            PurchasedItemsDataGridView.BorderStyle = BorderStyle.None;
            PurchasedItemsDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            PurchasedItemsDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            PurchasedItemsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PurchasedItemsDataGridView.Columns.AddRange(new DataGridViewColumn[] { ProductName, Quantity, Discount, pricePerUnit, totalPrice });
            PurchasedItemsDataGridView.GridColor = SystemColors.GradientActiveCaption;
            PurchasedItemsDataGridView.Location = new Point(31, 48);
            PurchasedItemsDataGridView.Margin = new Padding(4, 3, 4, 3);
            PurchasedItemsDataGridView.Name = "PurchasedItemsDataGridView";
            PurchasedItemsDataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            PurchasedItemsDataGridView.Size = new Size(551, 308);
            PurchasedItemsDataGridView.TabIndex = 0;
            // 
            // ProductName
            // 
            ProductName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ProductName.HeaderText = "Product Name";
            ProductName.Name = "ProductName";
            // 
            // Quantity
            // 
            Quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Quantity.HeaderText = "Quantity";
            Quantity.Name = "Quantity";
            // 
            // Discount
            // 
            Discount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Discount.HeaderText = "Discount (%)";
            Discount.Name = "Discount";
            // 
            // pricePerUnit
            // 
            pricePerUnit.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            pricePerUnit.HeaderText = "Price per Unit (€)";
            pricePerUnit.Name = "pricePerUnit";
            // 
            // totalPrice
            // 
            totalPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            totalPrice.HeaderText = "Total Price (€)";
            totalPrice.Name = "totalPrice";
            // 
            // newPurchase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1206, 663);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "newPurchase";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New Purchase";
            Load += newPurchase_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PurchasedItemsDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button purchaseBtn;
        private Button homeBtn;
        private PictureBox Logo;
        private RichTextBox SearchBox;
        private Button addItemBtn;
        private RichTextBox discountTxt;
        private Label LbUsername;
        private Label label1;
        private Button GobackBtn;
        private Panel panel2;
        private Label CashierwlcmName;
        private Label label2;
        private Panel panel3;
        private Label finalpriceTxt;
        private Label discountshowTxt;
        private Label subTotalTxt;
        private Label label5;
        private Label label4;
        private Label label3;
        private DataGridView PurchasedItemsDataGridView;
        private Button button3;
        private Button settingsBtn;
        private Label label6;
        private RichTextBox quantityTxt;
        private Button clearBtn;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Discount;
        private DataGridViewTextBoxColumn pricePerUnit;
        private DataGridViewTextBoxColumn totalPrice;
    }
}