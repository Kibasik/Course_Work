namespace Client
{
    partial class Basket
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
            this.basketDGV = new System.Windows.Forms.DataGridView();
            this.GoodsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryGoodsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodsCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodsManufacturerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.basketDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // basketDGV
            // 
            this.basketDGV.AllowUserToAddRows = false;
            this.basketDGV.AllowUserToResizeColumns = false;
            this.basketDGV.AllowUserToResizeRows = false;
            this.basketDGV.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.basketDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.basketDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GoodsName,
            this.CategoryGoodsName,
            this.GoodsCost,
            this.GoodsManufacturerName,
            this.TypeCategoryName});
            this.basketDGV.Location = new System.Drawing.Point(12, 12);
            this.basketDGV.Name = "basketDGV";
            this.basketDGV.Size = new System.Drawing.Size(600, 342);
            this.basketDGV.TabIndex = 0;
            // 
            // GoodsName
            // 
            this.GoodsName.HeaderText = "Наименование";
            this.GoodsName.Name = "GoodsName";
            this.GoodsName.Width = 155;
            // 
            // CategoryGoodsName
            // 
            this.CategoryGoodsName.HeaderText = "Категория";
            this.CategoryGoodsName.Name = "CategoryGoodsName";
            // 
            // GoodsCost
            // 
            this.GoodsCost.HeaderText = "Цена";
            this.GoodsCost.Name = "GoodsCost";
            // 
            // GoodsManufacturerName
            // 
            this.GoodsManufacturerName.HeaderText = "Производитель";
            this.GoodsManufacturerName.Name = "GoodsManufacturerName";
            // 
            // TypeCategoryName
            // 
            this.TypeCategoryName.HeaderText = "Тип";
            this.TypeCategoryName.Name = "TypeCategoryName";
            // 
            // Basket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.basketDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "Basket";
            this.ShowIcon = false;
            this.Text = "Basket";
            ((System.ComponentModel.ISupportInitialize)(this.basketDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView basketDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryGoodsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsManufacturerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeCategoryName;
    }
}