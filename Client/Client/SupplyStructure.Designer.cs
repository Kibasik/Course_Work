namespace Client
{
    partial class SupplyStructure
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.supplyStructureDGV = new System.Windows.Forms.DataGridView();
            this.GoodsTypeCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryGoodsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodsManufacturerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodsCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodsAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.supplyStructureDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // supplyStructureDGV
            // 
            this.supplyStructureDGV.AllowUserToAddRows = false;
            this.supplyStructureDGV.AllowUserToDeleteRows = false;
            this.supplyStructureDGV.AllowUserToResizeRows = false;
            this.supplyStructureDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.supplyStructureDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplyStructureDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GoodsTypeCategoryName,
            this.CategoryGoodsName,
            this.GoodsManufacturerName,
            this.GoodsName,
            this.GoodsCost,
            this.GoodsAmount,
            this.GoodsID});
            this.supplyStructureDGV.Location = new System.Drawing.Point(15, 25);
            this.supplyStructureDGV.Name = "supplyStructureDGV";
            this.supplyStructureDGV.ReadOnly = true;
            this.supplyStructureDGV.Size = new System.Drawing.Size(645, 183);
            this.supplyStructureDGV.TabIndex = 0;
            // 
            // GoodsTypeCategoryName
            // 
            this.GoodsTypeCategoryName.HeaderText = "Тип";
            this.GoodsTypeCategoryName.Name = "GoodsTypeCategoryName";
            this.GoodsTypeCategoryName.ReadOnly = true;
            // 
            // CategoryGoodsName
            // 
            this.CategoryGoodsName.HeaderText = "Категория";
            this.CategoryGoodsName.Name = "CategoryGoodsName";
            this.CategoryGoodsName.ReadOnly = true;
            // 
            // GoodsManufacturerName
            // 
            this.GoodsManufacturerName.HeaderText = "Производитель";
            this.GoodsManufacturerName.Name = "GoodsManufacturerName";
            this.GoodsManufacturerName.ReadOnly = true;
            // 
            // GoodsName
            // 
            this.GoodsName.HeaderText = "Наименование";
            this.GoodsName.Name = "GoodsName";
            this.GoodsName.ReadOnly = true;
            // 
            // GoodsCost
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.GoodsCost.DefaultCellStyle = dataGridViewCellStyle2;
            this.GoodsCost.HeaderText = "Цена, руб.";
            this.GoodsCost.Name = "GoodsCost";
            this.GoodsCost.ReadOnly = true;
            // 
            // GoodsAmount
            // 
            this.GoodsAmount.HeaderText = "Количество";
            this.GoodsAmount.Name = "GoodsAmount";
            this.GoodsAmount.ReadOnly = true;
            // 
            // GoodsID
            // 
            this.GoodsID.HeaderText = "GoodsID";
            this.GoodsID.Name = "GoodsID";
            this.GoodsID.ReadOnly = true;
            this.GoodsID.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Состав поставки:";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(15, 214);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(80, 40);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // SupplyStructure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 261);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.supplyStructureDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "SupplyStructure";
            this.ShowIcon = false;
            this.Text = "Состав поставки";
            this.Load += new System.EventHandler(this.SupplyStructure_Load);
            ((System.ComponentModel.ISupportInitialize)(this.supplyStructureDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView supplyStructureDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsTypeCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryGoodsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsManufacturerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsID;
    }
}