﻿
namespace AdoNetDemo
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
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.UnitPrice = new System.Windows.Forms.Label();
            this.lblStockAmount = new System.Windows.Forms.Label();
            this.tbxUnitPrice = new System.Windows.Forms.TextBox();
            this.tbxStockAmount = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxUnitPriceUpdate = new System.Windows.Forms.TextBox();
            this.tbxNameUpdate = new System.Windows.Forms.TextBox();
            this.lblNameUpdate = new System.Windows.Forms.Label();
            this.tbxStockAmountUpdate = new System.Windows.Forms.TextBox();
            this.lblUnitPriceUpdate = new System.Windows.Forms.Label();
            this.lblStockAmountUpdate = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.gbxAdd.SuspendLayout();
            this.gbxUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProducts
            // 
            this.dgwProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(13, 12);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.RowHeadersWidth = 51;
            this.dgwProducts.RowTemplate.Height = 29;
            this.dgwProducts.Size = new System.Drawing.Size(838, 217);
            this.dgwProducts.TabIndex = 0;
            this.dgwProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellClick);
            this.dgwProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellContentClick);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(51, 31);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(50, 21);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // UnitPrice
            // 
            this.UnitPrice.AutoSize = true;
            this.UnitPrice.Location = new System.Drawing.Point(51, 73);
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.Size = new System.Drawing.Size(81, 21);
            this.UnitPrice.TabIndex = 2;
            this.UnitPrice.Text = "Unit Price";
            // 
            // lblStockAmount
            // 
            this.lblStockAmount.AutoSize = true;
            this.lblStockAmount.Location = new System.Drawing.Point(51, 118);
            this.lblStockAmount.Name = "lblStockAmount";
            this.lblStockAmount.Size = new System.Drawing.Size(106, 21);
            this.lblStockAmount.TabIndex = 3;
            this.lblStockAmount.Text = "Stock Amount";
            // 
            // tbxUnitPrice
            // 
            this.tbxUnitPrice.Location = new System.Drawing.Point(163, 73);
            this.tbxUnitPrice.Name = "tbxUnitPrice";
            this.tbxUnitPrice.Size = new System.Drawing.Size(125, 26);
            this.tbxUnitPrice.TabIndex = 4;
            // 
            // tbxStockAmount
            // 
            this.tbxStockAmount.Location = new System.Drawing.Point(163, 115);
            this.tbxStockAmount.Name = "tbxStockAmount";
            this.tbxStockAmount.Size = new System.Drawing.Size(125, 26);
            this.tbxStockAmount.TabIndex = 5;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(163, 31);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(125, 26);
            this.tbxName.TabIndex = 6;
            // 
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.btnAdd);
            this.gbxAdd.Controls.Add(this.tbxUnitPrice);
            this.gbxAdd.Controls.Add(this.tbxName);
            this.gbxAdd.Controls.Add(this.lblName);
            this.gbxAdd.Controls.Add(this.tbxStockAmount);
            this.gbxAdd.Controls.Add(this.UnitPrice);
            this.gbxAdd.Controls.Add(this.lblStockAmount);
            this.gbxAdd.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbxAdd.Location = new System.Drawing.Point(13, 235);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(366, 272);
            this.gbxAdd.TabIndex = 7;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Add a product";
            this.gbxAdd.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(163, 165);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(125, 68);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.btnRemove);
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Controls.Add(this.tbxUnitPriceUpdate);
            this.gbxUpdate.Controls.Add(this.tbxNameUpdate);
            this.gbxUpdate.Controls.Add(this.lblNameUpdate);
            this.gbxUpdate.Controls.Add(this.tbxStockAmountUpdate);
            this.gbxUpdate.Controls.Add(this.lblUnitPriceUpdate);
            this.gbxUpdate.Controls.Add(this.lblStockAmountUpdate);
            this.gbxUpdate.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbxUpdate.Location = new System.Drawing.Point(501, 235);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(350, 272);
            this.gbxUpdate.TabIndex = 8;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Update a product";
            this.gbxUpdate.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(163, 147);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(125, 68);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tbxUnitPriceUpdate
            // 
            this.tbxUnitPriceUpdate.Location = new System.Drawing.Point(163, 73);
            this.tbxUnitPriceUpdate.Name = "tbxUnitPriceUpdate";
            this.tbxUnitPriceUpdate.Size = new System.Drawing.Size(125, 26);
            this.tbxUnitPriceUpdate.TabIndex = 4;
            // 
            // tbxNameUpdate
            // 
            this.tbxNameUpdate.Location = new System.Drawing.Point(163, 31);
            this.tbxNameUpdate.Name = "tbxNameUpdate";
            this.tbxNameUpdate.Size = new System.Drawing.Size(125, 26);
            this.tbxNameUpdate.TabIndex = 6;
            // 
            // lblNameUpdate
            // 
            this.lblNameUpdate.AutoSize = true;
            this.lblNameUpdate.Location = new System.Drawing.Point(51, 31);
            this.lblNameUpdate.Name = "lblNameUpdate";
            this.lblNameUpdate.Size = new System.Drawing.Size(50, 21);
            this.lblNameUpdate.TabIndex = 1;
            this.lblNameUpdate.Text = "Name";
            // 
            // tbxStockAmountUpdate
            // 
            this.tbxStockAmountUpdate.Location = new System.Drawing.Point(163, 115);
            this.tbxStockAmountUpdate.Name = "tbxStockAmountUpdate";
            this.tbxStockAmountUpdate.Size = new System.Drawing.Size(125, 26);
            this.tbxStockAmountUpdate.TabIndex = 5;
            // 
            // lblUnitPriceUpdate
            // 
            this.lblUnitPriceUpdate.AutoSize = true;
            this.lblUnitPriceUpdate.Location = new System.Drawing.Point(51, 73);
            this.lblUnitPriceUpdate.Name = "lblUnitPriceUpdate";
            this.lblUnitPriceUpdate.Size = new System.Drawing.Size(81, 21);
            this.lblUnitPriceUpdate.TabIndex = 2;
            this.lblUnitPriceUpdate.Text = "Unit Price";
            // 
            // lblStockAmountUpdate
            // 
            this.lblStockAmountUpdate.AutoSize = true;
            this.lblStockAmountUpdate.Location = new System.Drawing.Point(51, 118);
            this.lblStockAmountUpdate.Name = "lblStockAmountUpdate";
            this.lblStockAmountUpdate.Size = new System.Drawing.Size(106, 21);
            this.lblStockAmountUpdate.TabIndex = 3;
            this.lblStockAmountUpdate.Text = "Stock Amount";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(163, 239);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(125, 29);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 556);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.gbxAdd);
            this.Controls.Add(this.dgwProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProducts;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label UnitPrice;
        private System.Windows.Forms.Label lblStockAmount;
        private System.Windows.Forms.TextBox tbxUnitPrice;
        private System.Windows.Forms.TextBox tbxStockAmount;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxUnitPriceUpdate;
        private System.Windows.Forms.TextBox tbxNameUpdate;
        private System.Windows.Forms.Label lblNameUpdate;
        private System.Windows.Forms.TextBox tbxStockAmountUpdate;
        private System.Windows.Forms.Label lblUnitPriceUpdate;
        private System.Windows.Forms.Label lblStockAmountUpdate;
        private System.Windows.Forms.Button btnRemove;
    }
}

