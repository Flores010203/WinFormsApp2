namespace WinFormsApp2
{
    partial class Inventory
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnAddProduct = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtProductName = new TextBox();
            txtQuantity = new TextBox();
            txtSellPrice = new TextBox();
            cbCategory = new ComboBox();
            dtPickerMfgDate = new DateTimePicker();
            dtPickerExpDate = new DateTimePicker();
            richTxtDescription = new RichTextBox();
            label8 = new Label();
            gridViewProductList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridViewProductList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(246, 54);
            label1.TabIndex = 0;
            label1.Text = "Add Product";
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(840, 297);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(133, 33);
            btnAddProduct.TabIndex = 1;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 92);
            label2.Name = "label2";
            label2.Size = new Size(74, 25);
            label2.TabIndex = 2;
            label2.Text = "Product";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 128);
            label3.Name = "label3";
            label3.Size = new Size(84, 25);
            label3.TabIndex = 3;
            label3.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 172);
            label4.Name = "label4";
            label4.Size = new Size(91, 25);
            label4.TabIndex = 4;
            label4.Text = "Mfg. Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 215);
            label5.Name = "label5";
            label5.Size = new Size(86, 25);
            label5.TabIndex = 5;
            label5.Text = "Exp. Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 257);
            label6.Name = "label6";
            label6.Size = new Size(45, 25);
            label6.TabIndex = 6;
            label6.Text = "Qty.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 297);
            label7.Name = "label7";
            label7.Size = new Size(81, 25);
            label7.TabIndex = 7;
            label7.Text = "Sell Price";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(108, 89);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(313, 31);
            txtProductName.TabIndex = 8;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(108, 254);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(313, 31);
            txtQuantity.TabIndex = 9;
            // 
            // txtSellPrice
            // 
            txtSellPrice.Location = new Point(108, 294);
            txtSellPrice.Name = "txtSellPrice";
            txtSellPrice.Size = new Size(313, 31);
            txtSellPrice.TabIndex = 10;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(108, 128);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(313, 33);
            cbCategory.TabIndex = 11;
            // 
            // dtPickerMfgDate
            // 
            dtPickerMfgDate.Location = new Point(108, 167);
            dtPickerMfgDate.Name = "dtPickerMfgDate";
            dtPickerMfgDate.Size = new Size(313, 31);
            dtPickerMfgDate.TabIndex = 12;
            // 
            // dtPickerExpDate
            // 
            dtPickerExpDate.Location = new Point(108, 210);
            dtPickerExpDate.Name = "dtPickerExpDate";
            dtPickerExpDate.Size = new Size(313, 31);
            dtPickerExpDate.TabIndex = 13;
            // 
            // richTxtDescription
            // 
            richTxtDescription.Location = new Point(629, 92);
            richTxtDescription.Name = "richTxtDescription";
            richTxtDescription.Size = new Size(344, 197);
            richTxtDescription.TabIndex = 14;
            richTxtDescription.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(629, 62);
            label8.Name = "label8";
            label8.Size = new Size(102, 25);
            label8.TabIndex = 15;
            label8.Text = "Description";
            // 
            // gridViewProductList
            // 
            gridViewProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewProductList.Location = new Point(12, 336);
            gridViewProductList.Name = "gridViewProductList";
            gridViewProductList.RowHeadersWidth = 62;
            gridViewProductList.RowTemplate.Height = 33;
            gridViewProductList.Size = new Size(961, 240);
            gridViewProductList.TabIndex = 16;
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 579);
            Controls.Add(gridViewProductList);
            Controls.Add(label8);
            Controls.Add(richTxtDescription);
            Controls.Add(dtPickerExpDate);
            Controls.Add(dtPickerMfgDate);
            Controls.Add(cbCategory);
            Controls.Add(txtSellPrice);
            Controls.Add(txtQuantity);
            Controls.Add(txtProductName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnAddProduct);
            Controls.Add(label1);
            Name = "Inventory";
            Text = "frmAddProduct";
            Load += Inventory_Load;
            ((System.ComponentModel.ISupportInitialize)gridViewProductList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAddProduct;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtProductName;
        private TextBox txtQuantity;
        private TextBox txtSellPrice;
        private ComboBox cbCategory;
        private DateTimePicker dtPickerMfgDate;
        private DateTimePicker dtPickerExpDate;
        private RichTextBox richTxtDescription;
        private Label label8;
        private DataGridView gridViewProductList;
    }
}