namespace InventoryManagementApp
{
    partial class AddPart
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
            radioButtonOutsourced = new RadioButton();
            radioButtonInhouse = new RadioButton();
            label8 = new Label();
            txtPartMin = new TextBox();
            labelMachinIdCompanyName = new Label();
            txtPartMachineIDCompanyName = new TextBox();
            label6 = new Label();
            txtPartMax = new TextBox();
            label4 = new Label();
            txtPartPriceCost = new TextBox();
            label5 = new Label();
            txtPartInventory = new TextBox();
            label3 = new Label();
            txtPartName = new TextBox();
            label2 = new Label();
            txtPartID = new TextBox();
            btnSaveParts = new Button();
            btnCancel = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // radioButtonOutsourced
            // 
            radioButtonOutsourced.AutoSize = true;
            radioButtonOutsourced.Location = new Point(275, 41);
            radioButtonOutsourced.Name = "radioButtonOutsourced";
            radioButtonOutsourced.Size = new Size(87, 19);
            radioButtonOutsourced.TabIndex = 54;
            radioButtonOutsourced.Text = "Outsourced";
            radioButtonOutsourced.UseVisualStyleBackColor = true;
            radioButtonOutsourced.CheckedChanged += radioButtonOutsourced_CheckedChanged;
            // 
            // radioButtonInhouse
            // 
            radioButtonInhouse.AutoSize = true;
            radioButtonInhouse.Checked = true;
            radioButtonInhouse.Location = new Point(161, 41);
            radioButtonInhouse.Name = "radioButtonInhouse";
            radioButtonInhouse.Size = new Size(74, 19);
            radioButtonInhouse.TabIndex = 53;
            radioButtonInhouse.TabStop = true;
            radioButtonInhouse.Text = "In-House";
            radioButtonInhouse.UseVisualStyleBackColor = true;
            radioButtonInhouse.CheckedChanged += radioButtonInhouse_CheckedChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(327, 273);
            label8.Name = "label8";
            label8.Size = new Size(37, 21);
            label8.TabIndex = 52;
            label8.Text = "Min";
            // 
            // txtPartMin
            // 
            txtPartMin.Location = new Point(377, 275);
            txtPartMin.Name = "txtPartMin";
            txtPartMin.Size = new Size(69, 23);
            txtPartMin.TabIndex = 51;
            // 
            // labelMachinIdCompanyName
            // 
            labelMachinIdCompanyName.AutoSize = true;
            labelMachinIdCompanyName.Font = new Font("Segoe UI", 12F);
            labelMachinIdCompanyName.Location = new Point(66, 315);
            labelMachinIdCompanyName.Name = "labelMachinIdCompanyName";
            labelMachinIdCompanyName.Size = new Size(88, 21);
            labelMachinIdCompanyName.TabIndex = 50;
            labelMachinIdCompanyName.Text = "Machine ID";
            // 
            // txtPartMachineIDCompanyName
            // 
            txtPartMachineIDCompanyName.Location = new Point(197, 315);
            txtPartMachineIDCompanyName.Name = "txtPartMachineIDCompanyName";
            txtPartMachineIDCompanyName.Size = new Size(166, 23);
            txtPartMachineIDCompanyName.TabIndex = 49;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(147, 273);
            label6.Name = "label6";
            label6.Size = new Size(39, 21);
            label6.TabIndex = 48;
            label6.Text = "Max";
            // 
            // txtPartMax
            // 
            txtPartMax.Location = new Point(197, 275);
            txtPartMax.Name = "txtPartMax";
            txtPartMax.Size = new Size(69, 23);
            txtPartMax.TabIndex = 47;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(97, 230);
            label4.Name = "label4";
            label4.Size = new Size(89, 21);
            label4.TabIndex = 46;
            label4.Text = "Price / Cost";
            // 
            // txtPartPriceCost
            // 
            txtPartPriceCost.Location = new Point(197, 232);
            txtPartPriceCost.Name = "txtPartPriceCost";
            txtPartPriceCost.Size = new Size(166, 23);
            txtPartPriceCost.TabIndex = 45;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(110, 192);
            label5.Name = "label5";
            label5.Size = new Size(76, 21);
            label5.TabIndex = 44;
            label5.Text = "Inventory";
            // 
            // txtPartInventory
            // 
            txtPartInventory.Location = new Point(197, 192);
            txtPartInventory.Name = "txtPartInventory";
            txtPartInventory.Size = new Size(166, 23);
            txtPartInventory.TabIndex = 43;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(134, 147);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 42;
            label3.Text = "Name";
            // 
            // txtPartName
            // 
            txtPartName.Location = new Point(197, 149);
            txtPartName.Name = "txtPartName";
            txtPartName.Size = new Size(166, 23);
            txtPartName.TabIndex = 41;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(161, 107);
            label2.Name = "label2";
            label2.Size = new Size(25, 21);
            label2.TabIndex = 40;
            label2.Text = "ID";
            // 
            // txtPartID
            // 
            txtPartID.Location = new Point(197, 109);
            txtPartID.Name = "txtPartID";
            txtPartID.ReadOnly = true;
            txtPartID.Size = new Size(166, 23);
            txtPartID.TabIndex = 39;
            // 
            // btnSaveParts
            // 
            btnSaveParts.Location = new Point(275, 369);
            btnSaveParts.Name = "btnSaveParts";
            btnSaveParts.Size = new Size(75, 23);
            btnSaveParts.TabIndex = 38;
            btnSaveParts.Text = "Save";
            btnSaveParts.UseVisualStyleBackColor = true;
            btnSaveParts.Click += btnSaveParts_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(371, 369);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 37;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(50, 38);
            label1.Name = "label1";
            label1.Size = new Size(69, 21);
            label1.TabIndex = 36;
            label1.Text = "Add Part";
            // 
            // AddPart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 450);
            Controls.Add(radioButtonOutsourced);
            Controls.Add(radioButtonInhouse);
            Controls.Add(label8);
            Controls.Add(txtPartMin);
            Controls.Add(labelMachinIdCompanyName);
            Controls.Add(txtPartMachineIDCompanyName);
            Controls.Add(label6);
            Controls.Add(txtPartMax);
            Controls.Add(label4);
            Controls.Add(txtPartPriceCost);
            Controls.Add(label5);
            Controls.Add(txtPartInventory);
            Controls.Add(label3);
            Controls.Add(txtPartName);
            Controls.Add(label2);
            Controls.Add(txtPartID);
            Controls.Add(btnSaveParts);
            Controls.Add(btnCancel);
            Controls.Add(label1);
            Name = "AddPart";
            Text = "Add Part";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButtonOutsourced;
        private RadioButton radioButtonInhouse;
        private Label label8;
        private TextBox txtPartMin;
        private Label labelMachinIdCompanyName;
        private TextBox txtPartMachineIDCompanyName;
        private Label label6;
        private TextBox txtPartMax;
        private Label label4;
        private TextBox txtPartPriceCost;
        private Label label5;
        private TextBox txtPartInventory;
        private Label label3;
        private TextBox txtPartName;
        private Label label2;
        private TextBox txtPartID;
        private Button btnSaveParts;
        private Button btnCancel;
        private Label label1;
    }
}