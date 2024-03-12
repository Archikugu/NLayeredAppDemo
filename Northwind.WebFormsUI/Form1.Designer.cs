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
            ((System.ComponentModel.ISupportInitialize)dgwProduct).BeginInit();
            gbxCategory.SuspendLayout();
            gbxProductName.SuspendLayout();
            SuspendLayout();
            // 
            // dgwProduct
            // 
            dgwProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwProduct.Location = new Point(12, 192);
            dgwProduct.Name = "dgwProduct";
            dgwProduct.Size = new Size(950, 202);
            dgwProduct.TabIndex = 0;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 517);
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
    }
}
