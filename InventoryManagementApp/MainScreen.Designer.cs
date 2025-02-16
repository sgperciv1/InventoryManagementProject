namespace InventoryManagementApp
{
    partial class MainScreen
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
            btnAddProducts = new Button();
            btnModifyProducts = new Button();
            btnDeleteProducts = new Button();
            label3 = new Label();
            label2 = new Label();
            txtProductsSearch = new TextBox();
            btnProductsSearch = new Button();
            txtPartsSearch = new TextBox();
            btnAddParts = new Button();
            btnModifyParts = new Button();
            btnDeleteParts = new Button();
            btnExit = new Button();
            btnPartsSearch = new Button();
            productsGridView = new DataGridView();
            partsGridView = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)productsGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)partsGridView).BeginInit();
            SuspendLayout();
            // 
            // btnAddProducts
            // 
            btnAddProducts.Location = new Point(720, 368);
            btnAddProducts.Name = "btnAddProducts";
            btnAddProducts.Size = new Size(75, 23);
            btnAddProducts.TabIndex = 36;
            btnAddProducts.Text = "Add";
            btnAddProducts.UseVisualStyleBackColor = true;
            btnAddProducts.Click += btnAddProducts_Click;
            // 
            // btnModifyProducts
            // 
            btnModifyProducts.Location = new Point(801, 368);
            btnModifyProducts.Name = "btnModifyProducts";
            btnModifyProducts.Size = new Size(75, 23);
            btnModifyProducts.TabIndex = 35;
            btnModifyProducts.Text = "Modify";
            btnModifyProducts.UseVisualStyleBackColor = true;
            btnModifyProducts.Click += btnModifyProducts_Click;
            // 
            // btnDeleteProducts
            // 
            btnDeleteProducts.Location = new Point(882, 368);
            btnDeleteProducts.Name = "btnDeleteProducts";
            btnDeleteProducts.Size = new Size(75, 23);
            btnDeleteProducts.TabIndex = 34;
            btnDeleteProducts.Text = "Delete";
            btnDeleteProducts.UseVisualStyleBackColor = true;
            btnDeleteProducts.Click += btnDeleteProducts_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(503, 102);
            label3.Name = "label3";
            label3.Size = new Size(71, 21);
            label3.TabIndex = 33;
            label3.Text = "Products";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(30, 104);
            label2.Name = "label2";
            label2.Size = new Size(44, 21);
            label2.TabIndex = 32;
            label2.Text = "Parts";
            // 
            // txtProductsSearch
            // 
            txtProductsSearch.Location = new Point(789, 104);
            txtProductsSearch.Name = "txtProductsSearch";
            txtProductsSearch.Size = new Size(166, 23);
            txtProductsSearch.TabIndex = 31;
            // 
            // btnProductsSearch
            // 
            btnProductsSearch.Location = new Point(708, 102);
            btnProductsSearch.Name = "btnProductsSearch";
            btnProductsSearch.Size = new Size(75, 25);
            btnProductsSearch.TabIndex = 30;
            btnProductsSearch.Text = "Search";
            btnProductsSearch.UseVisualStyleBackColor = true;
            btnProductsSearch.Click += btnProductsSearch_Click;
            // 
            // txtPartsSearch
            // 
            txtPartsSearch.Location = new Point(292, 102);
            txtPartsSearch.Name = "txtPartsSearch";
            txtPartsSearch.Size = new Size(166, 23);
            txtPartsSearch.TabIndex = 29;
            // 
            // btnAddParts
            // 
            btnAddParts.Location = new Point(221, 368);
            btnAddParts.Name = "btnAddParts";
            btnAddParts.Size = new Size(75, 23);
            btnAddParts.TabIndex = 28;
            btnAddParts.Text = "Add";
            btnAddParts.UseVisualStyleBackColor = true;
            btnAddParts.Click += btnAddParts_Click;
            // 
            // btnModifyParts
            // 
            btnModifyParts.Location = new Point(302, 368);
            btnModifyParts.Name = "btnModifyParts";
            btnModifyParts.Size = new Size(75, 23);
            btnModifyParts.TabIndex = 27;
            btnModifyParts.Text = "Modify";
            btnModifyParts.UseVisualStyleBackColor = true;
            btnModifyParts.Click += btnModifyParts_Click;
            // 
            // btnDeleteParts
            // 
            btnDeleteParts.Location = new Point(383, 368);
            btnDeleteParts.Name = "btnDeleteParts";
            btnDeleteParts.Size = new Size(75, 23);
            btnDeleteParts.TabIndex = 26;
            btnDeleteParts.Text = "Delete";
            btnDeleteParts.UseVisualStyleBackColor = true;
            btnDeleteParts.Click += btnDeleteParts_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(880, 437);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 25;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnPartsSearch
            // 
            btnPartsSearch.Location = new Point(211, 100);
            btnPartsSearch.Name = "btnPartsSearch";
            btnPartsSearch.Size = new Size(75, 25);
            btnPartsSearch.TabIndex = 24;
            btnPartsSearch.Text = "Search";
            btnPartsSearch.UseVisualStyleBackColor = true;
            btnPartsSearch.Click += btnPartsSearch_Click;
            // 
            // productsGridView
            // 
            productsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            productsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsGridView.Location = new Point(503, 131);
            productsGridView.MultiSelect = false;
            productsGridView.Name = "productsGridView";
            productsGridView.ReadOnly = true;
            productsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productsGridView.Size = new Size(452, 231);
            productsGridView.TabIndex = 23;
            productsGridView.DataBindingComplete += productsGVDataBindingComplete;
            // 
            // partsGridView
            // 
            partsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            partsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            partsGridView.Location = new Point(30, 131);
            partsGridView.MultiSelect = false;
            partsGridView.Name = "partsGridView";
            partsGridView.ReadOnly = true;
            partsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            partsGridView.Size = new Size(428, 231);
            partsGridView.TabIndex = 22;
            partsGridView.DataBindingComplete += partsGVDataBindingComplete;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(30, 31);
            label1.Name = "label1";
            label1.Size = new Size(227, 21);
            label1.TabIndex = 21;
            label1.Text = "Inventory Management System";
            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 482);
            Controls.Add(btnAddProducts);
            Controls.Add(btnModifyProducts);
            Controls.Add(btnDeleteProducts);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtProductsSearch);
            Controls.Add(btnProductsSearch);
            Controls.Add(txtPartsSearch);
            Controls.Add(btnAddParts);
            Controls.Add(btnModifyParts);
            Controls.Add(btnDeleteParts);
            Controls.Add(btnExit);
            Controls.Add(btnPartsSearch);
            Controls.Add(productsGridView);
            Controls.Add(partsGridView);
            Controls.Add(label1);
            Name = "MainScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)productsGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)partsGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddProducts;
        private Button btnModifyProducts;
        private Button btnDeleteProducts;
        private Label label3;
        private Label label2;
        private TextBox txtProductsSearch;
        private TextBox txtPartsSearch;
        private Button btnAddParts;
        private Button btnModifyParts;
        private Button btnDeleteParts;
        private Button btnExit;
        private Button btnPartsSearch;
        private DataGridView productsGridView;
        private DataGridView partsGridView;
        private Label label1;
        private Button btnProductsSearch;
    }
}
