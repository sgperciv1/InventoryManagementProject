namespace InventoryManagementApp
{
    partial class ModifyPart
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
            label7 = new Label();
            txtPartID = new TextBox();
            label8 = new Label();
            radioButtonOutsourced = new RadioButton();
            radioButtonInhouse = new RadioButton();
            btnModifyParts = new Button();
            btnCancel = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtPartMin
            // 
            txtPartMin.Location = new Point(363, 267);
            txtPartMin.Name = "txtPartMin";
            txtPartMin.Size = new Size(69, 23);
            txtPartMin.TabIndex = 86;
            // 
            // labelMachinIdCompanyName
            // 
            labelMachinIdCompanyName.AutoSize = true;
            labelMachinIdCompanyName.Font = new Font("Segoe UI", 12F);
            labelMachinIdCompanyName.Location = new Point(52, 307);
            labelMachinIdCompanyName.Name = "labelMachinIdCompanyName";
            labelMachinIdCompanyName.Size = new Size(88, 21);
            labelMachinIdCompanyName.TabIndex = 85;
            labelMachinIdCompanyName.Text = "Machine ID";
            // 
            // txtPartMachineIDCompanyName
            // 
            txtPartMachineIDCompanyName.Location = new Point(183, 307);
            txtPartMachineIDCompanyName.Name = "txtPartMachineIDCompanyName";
            txtPartMachineIDCompanyName.Size = new Size(166, 23);
            txtPartMachineIDCompanyName.TabIndex = 84;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(133, 265);
            label6.Name = "label6";
            label6.Size = new Size(39, 21);
            label6.TabIndex = 83;
            label6.Text = "Max";
            // 
            // txtPartMax
            // 
            txtPartMax.Location = new Point(183, 267);
            txtPartMax.Name = "txtPartMax";
            txtPartMax.Size = new Size(69, 23);
            txtPartMax.TabIndex = 82;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(83, 222);
            label4.Name = "label4";
            label4.Size = new Size(89, 21);
            label4.TabIndex = 81;
            label4.Text = "Price / Cost";
            // 
            // txtPartPriceCost
            // 
            txtPartPriceCost.Location = new Point(183, 224);
            txtPartPriceCost.Name = "txtPartPriceCost";
            txtPartPriceCost.Size = new Size(166, 23);
            txtPartPriceCost.TabIndex = 80;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(96, 184);
            label5.Name = "label5";
            label5.Size = new Size(76, 21);
            label5.TabIndex = 79;
            label5.Text = "Inventory";
            // 
            // txtPartInventory
            // 
            txtPartInventory.Location = new Point(183, 184);
            txtPartInventory.Name = "txtPartInventory";
            txtPartInventory.Size = new Size(166, 23);
            txtPartInventory.TabIndex = 78;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(120, 139);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 77;
            label3.Text = "Name";
            // 
            // txtPartName
            // 
            txtPartName.Location = new Point(183, 141);
            txtPartName.Name = "txtPartName";
            txtPartName.Size = new Size(166, 23);
            txtPartName.TabIndex = 76;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(147, 99);
            label7.Name = "label7";
            label7.Size = new Size(25, 21);
            label7.TabIndex = 75;
            label7.Text = "ID";
            // 
            // txtPartID
            // 
            txtPartID.Location = new Point(183, 101);
            txtPartID.Name = "txtPartID";
            txtPartID.ReadOnly = true;
            txtPartID.Size = new Size(166, 23);
            txtPartID.TabIndex = 74;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(312, 269);
            label8.Name = "label8";
            label8.Size = new Size(37, 21);
            label8.TabIndex = 73;
            label8.Text = "Min";
            // 
            // radioButtonOutsourced
            // 
            radioButtonOutsourced.AutoSize = true;
            radioButtonOutsourced.Location = new Point(259, 30);
            radioButtonOutsourced.Name = "radioButtonOutsourced";
            radioButtonOutsourced.Size = new Size(87, 19);
            radioButtonOutsourced.TabIndex = 72;
            radioButtonOutsourced.Text = "Outsourced";
            radioButtonOutsourced.UseVisualStyleBackColor = true;
            radioButtonOutsourced.CheckedChanged += radioButtonOutsourced_CheckedChanged;
            // 
            // radioButtonInhouse
            // 
            radioButtonInhouse.AutoSize = true;
            radioButtonInhouse.Checked = true;
            radioButtonInhouse.Location = new Point(165, 30);
            radioButtonInhouse.Name = "radioButtonInhouse";
            radioButtonInhouse.Size = new Size(74, 19);
            radioButtonInhouse.TabIndex = 71;
            radioButtonInhouse.TabStop = true;
            radioButtonInhouse.Text = "In-House";
            radioButtonInhouse.UseVisualStyleBackColor = true;
            radioButtonInhouse.CheckedChanged += radioButtonInhouse_CheckedChanged;
            // 
            // btnModifyParts
            // 
            btnModifyParts.Location = new Point(259, 358);
            btnModifyParts.Name = "btnModifyParts";
            btnModifyParts.Size = new Size(75, 23);
            btnModifyParts.TabIndex = 70;
            btnModifyParts.Text = "Save";
            btnModifyParts.UseVisualStyleBackColor = true;
            btnModifyParts.Click += btnModifyParts_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(355, 358);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 69;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(34, 27);
            label1.Name = "label1";
            label1.Size = new Size(94, 21);
            label1.TabIndex = 68;
            label1.Text = "Modify  Part";
            // 
            // ModifyPart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 450);
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
            Controls.Add(label7);
            Controls.Add(txtPartID);
            Controls.Add(label8);
            Controls.Add(radioButtonOutsourced);
            Controls.Add(radioButtonInhouse);
            Controls.Add(btnModifyParts);
            Controls.Add(btnCancel);
            Controls.Add(label1);
            Name = "ModifyPart";
            Text = "Modify Part";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private Label label7;
        private TextBox txtPartID;
        private Label label8;
        private RadioButton radioButtonOutsourced;
        private RadioButton radioButtonInhouse;
        private Button btnModifyParts;
        private Button btnCancel;
        private Label label1;
    }
}