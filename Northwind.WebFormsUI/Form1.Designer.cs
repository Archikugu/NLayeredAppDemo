namespace Northwind.WebFormsUI
{
    partial class Form1
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
            dgwProduct = new DataGridView();
            gbxCategory = new GroupBox();
            cbxCategory = new ComboBox();
            lblCategory = new Label();
            gbxProductName = new GroupBox();
            tbxProductName = new TextBox();
            lblProductName = new Label();
            gbxProductAdd = new GroupBox();
            btnAdd = new Button();
            tbxQuantityPerUnit = new TextBox();
            tbxStock = new TextBox();
            cbxCategoryId = new ComboBox();
            tbxUnitPrice = new TextBox();
            tbxProductName2 = new TextBox();
            lblQuantityPerUnit = new Label();
            lblStock = new Label();
            lblUnitPrice = new Label();
            lblCategoryID = new Label();
            lblProductName2 = new Label();
            groupBox1 = new GroupBox();
            btnUpdate = new Button();
            tbxQuantityPerUnitUpdate = new TextBox();
            tbxStokUpdate = new TextBox();
            cbxCategoryIdUpdate = new ComboBox();
            tbxUnitPriceUpdate = new TextBox();
            tbxProductNameUpdate = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgwProduct).BeginInit();
            gbxCategory.SuspendLayout();
            gbxProductName.SuspendLayout();
            gbxProductAdd.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgwProduct
            // 
            dgwProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwProduct.Location = new Point(12, 192);
            dgwProduct.Name = "dgwProduct";
            dgwProduct.Size = new Size(950, 202);
            dgwProduct.TabIndex = 0;
            dgwProduct.CellClick += dgwProduct_CellClick;
            // 
            // gbxCategory
            // 
            gbxCategory.Controls.Add(cbxCategory);
            gbxCategory.Controls.Add(lblCategory);
            gbxCategory.Location = new Point(12, 12);
            gbxCategory.Name = "gbxCategory";
            gbxCategory.Size = new Size(950, 80);
            gbxCategory.TabIndex = 1;
            gbxCategory.TabStop = false;
            gbxCategory.Text = "Kategoriye Göre Ara";
            // 
            // cbxCategory
            // 
            cbxCategory.FormattingEnabled = true;
            cbxCategory.Location = new Point(82, 23);
            cbxCategory.Name = "cbxCategory";
            cbxCategory.Size = new Size(304, 23);
            cbxCategory.TabIndex = 1;
            cbxCategory.SelectedIndexChanged += cbxCategory_SelectedIndexChanged;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(12, 26);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(64, 15);
            lblCategory.TabIndex = 0;
            lblCategory.Text = "Kategoriler";
            // 
            // gbxProductName
            // 
            gbxProductName.Controls.Add(tbxProductName);
            gbxProductName.Controls.Add(lblProductName);
            gbxProductName.Location = new Point(12, 98);
            gbxProductName.Name = "gbxProductName";
            gbxProductName.Size = new Size(950, 75);
            gbxProductName.TabIndex = 2;
            gbxProductName.TabStop = false;
            gbxProductName.Text = "Ürün  Adına Göre Ara";
            // 
            // tbxProductName
            // 
            tbxProductName.Location = new Point(82, 16);
            tbxProductName.Name = "tbxProductName";
            tbxProductName.Size = new Size(304, 23);
            tbxProductName.TabIndex = 1;
            tbxProductName.TextChanged += tbxProductName_TextChanged;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(12, 19);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(54, 15);
            lblProductName.TabIndex = 0;
            lblProductName.Text = "Ürün Adı";
            // 
            // gbxProductAdd
            // 
            gbxProductAdd.Controls.Add(btnAdd);
            gbxProductAdd.Controls.Add(tbxQuantityPerUnit);
            gbxProductAdd.Controls.Add(tbxStock);
            gbxProductAdd.Controls.Add(cbxCategoryId);
            gbxProductAdd.Controls.Add(tbxUnitPrice);
            gbxProductAdd.Controls.Add(tbxProductName2);
            gbxProductAdd.Controls.Add(lblQuantityPerUnit);
            gbxProductAdd.Controls.Add(lblStock);
            gbxProductAdd.Controls.Add(lblUnitPrice);
            gbxProductAdd.Controls.Add(lblCategoryID);
            gbxProductAdd.Controls.Add(lblProductName2);
            gbxProductAdd.Location = new Point(12, 415);
            gbxProductAdd.Name = "gbxProductAdd";
            gbxProductAdd.Size = new Size(581, 155);
            gbxProductAdd.TabIndex = 3;
            gbxProductAdd.TabStop = false;
            gbxProductAdd.Text = "Yeni Ürün Ekle";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(368, 97);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(189, 23);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Ürünü Kaydet";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // tbxQuantityPerUnit
            // 
            tbxQuantityPerUnit.Location = new Point(368, 68);
            tbxQuantityPerUnit.Name = "tbxQuantityPerUnit";
            tbxQuantityPerUnit.Size = new Size(189, 23);
            tbxQuantityPerUnit.TabIndex = 10;
            // 
            // tbxStock
            // 
            tbxStock.Location = new Point(368, 32);
            tbxStock.Name = "tbxStock";
            tbxStock.Size = new Size(189, 23);
            tbxStock.TabIndex = 9;
            // 
            // cbxCategoryId
            // 
            cbxCategoryId.FormattingEnabled = true;
            cbxCategoryId.Location = new Point(72, 68);
            cbxCategoryId.Name = "cbxCategoryId";
            cbxCategoryId.Size = new Size(189, 23);
            cbxCategoryId.TabIndex = 8;
            // 
            // tbxUnitPrice
            // 
            tbxUnitPrice.Location = new Point(72, 100);
            tbxUnitPrice.Name = "tbxUnitPrice";
            tbxUnitPrice.Size = new Size(189, 23);
            tbxUnitPrice.TabIndex = 7;
            // 
            // tbxProductName2
            // 
            tbxProductName2.Location = new Point(72, 32);
            tbxProductName2.Name = "tbxProductName2";
            tbxProductName2.Size = new Size(189, 23);
            tbxProductName2.TabIndex = 5;
            // 
            // lblQuantityPerUnit
            // 
            lblQuantityPerUnit.AutoSize = true;
            lblQuantityPerUnit.Location = new Point(286, 68);
            lblQuantityPerUnit.Name = "lblQuantityPerUnit";
            lblQuantityPerUnit.Size = new Size(69, 15);
            lblQuantityPerUnit.TabIndex = 4;
            lblQuantityPerUnit.Text = "Birim Adedi";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(286, 35);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(64, 15);
            lblStock.TabIndex = 3;
            lblStock.Text = "Stok Adedi";
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Location = new Point(12, 108);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(32, 15);
            lblUnitPrice.TabIndex = 2;
            lblUnitPrice.Text = "Fiyat";
            // 
            // lblCategoryID
            // 
            lblCategoryID.AutoSize = true;
            lblCategoryID.Location = new Point(12, 71);
            lblCategoryID.Name = "lblCategoryID";
            lblCategoryID.Size = new Size(51, 15);
            lblCategoryID.TabIndex = 1;
            lblCategoryID.Text = "Kategori";
            // 
            // lblProductName2
            // 
            lblProductName2.AutoSize = true;
            lblProductName2.Location = new Point(12, 35);
            lblProductName2.Name = "lblProductName2";
            lblProductName2.Size = new Size(54, 15);
            lblProductName2.TabIndex = 0;
            lblProductName2.Text = "Ürün Adı";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(tbxQuantityPerUnitUpdate);
            groupBox1.Controls.Add(tbxStokUpdate);
            groupBox1.Controls.Add(cbxCategoryIdUpdate);
            groupBox1.Controls.Add(tbxUnitPriceUpdate);
            groupBox1.Controls.Add(tbxProductNameUpdate);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(12, 591);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(581, 155);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ürün Güncelle";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(368, 97);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(189, 23);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Ürünü Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // tbxQuantityPerUnitUpdate
            // 
            tbxQuantityPerUnitUpdate.Location = new Point(368, 68);
            tbxQuantityPerUnitUpdate.Name = "tbxQuantityPerUnitUpdate";
            tbxQuantityPerUnitUpdate.Size = new Size(189, 23);
            tbxQuantityPerUnitUpdate.TabIndex = 10;
            // 
            // tbxStokUpdate
            // 
            tbxStokUpdate.Location = new Point(368, 32);
            tbxStokUpdate.Name = "tbxStokUpdate";
            tbxStokUpdate.Size = new Size(189, 23);
            tbxStokUpdate.TabIndex = 9;
            // 
            // cbxCategoryIdUpdate
            // 
            cbxCategoryIdUpdate.FormattingEnabled = true;
            cbxCategoryIdUpdate.Location = new Point(72, 68);
            cbxCategoryIdUpdate.Name = "cbxCategoryIdUpdate";
            cbxCategoryIdUpdate.Size = new Size(189, 23);
            cbxCategoryIdUpdate.TabIndex = 8;
            // 
            // tbxUnitPriceUpdate
            // 
            tbxUnitPriceUpdate.Location = new Point(72, 100);
            tbxUnitPriceUpdate.Name = "tbxUnitPriceUpdate";
            tbxUnitPriceUpdate.Size = new Size(189, 23);
            tbxUnitPriceUpdate.TabIndex = 7;
            // 
            // tbxProductNameUpdate
            // 
            tbxProductNameUpdate.Location = new Point(72, 32);
            tbxProductNameUpdate.Name = "tbxProductNameUpdate";
            tbxProductNameUpdate.Size = new Size(189, 23);
            tbxProductNameUpdate.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(286, 68);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 4;
            label1.Text = "Birim Adedi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(286, 35);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 3;
            label2.Text = "Stok Adedi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 108);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 2;
            label3.Text = "Fiyat";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 71);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 1;
            label4.Text = "Kategori";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 35);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 0;
            label5.Text = "Ürün Adı";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 811);
            Controls.Add(groupBox1);
            Controls.Add(gbxProductAdd);
            Controls.Add(gbxProductName);
            Controls.Add(gbxCategory);
            Controls.Add(dgwProduct);
            Name = "Form1";
            Text = "Ürünler";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgwProduct).EndInit();
            gbxCategory.ResumeLayout(false);
            gbxCategory.PerformLayout();
            gbxProductName.ResumeLayout(false);
            gbxProductName.PerformLayout();
            gbxProductAdd.ResumeLayout(false);
            gbxProductAdd.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgwProduct;
        private GroupBox gbxCategory;
        private ComboBox cbxCategory;
        private Label lblCategory;
        private GroupBox gbxProductName;
        private TextBox tbxProductName;
        private Label lblProductName;
        private GroupBox gbxProductAdd;
        private Label lblQuantityPerUnit;
        private Label lblStock;
        private Label lblUnitPrice;
        private Label lblCategoryID;
        private Label lblProductName2;
        private TextBox tbxProductName2;
        private TextBox tbxQuantityPerUnit;
        private TextBox tbxStock;
        private ComboBox cbxCategoryId;
        private TextBox tbxUnitPrice;
        private Button btnAdd;
        private GroupBox groupBox1;
        private Button btnUpdate;
        private TextBox tbxQuantityPerUnitUpdate;
        private TextBox tbxStokUpdate;
        private ComboBox cbxCategoryIdUpdate;
        private TextBox tbxUnitPriceUpdate;
        private TextBox tbxProductNameUpdate;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
