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
            this.components = new System.ComponentModel.Container();
            this.basketDGV = new System.Windows.Forms.DataGridView();
            this.TypeCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryGoodsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodsManufacturerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodsCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodsQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.dataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.softwareDGV = new System.Windows.Forms.DataGridView();
            this.deleteGoodsButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.deleteSoftwareButton = new System.Windows.Forms.Button();
            this.SoftwareTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoftwareName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoftwareCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoftwareQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoftwareID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.basketDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwareDGV)).BeginInit();
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
            this.TypeCategoryName,
            this.CategoryGoodsName,
            this.GoodsName,
            this.GoodsManufacturerName,
            this.GoodsCost,
            this.GoodsQuantity,
            this.ID});
            this.basketDGV.Location = new System.Drawing.Point(12, 30);
            this.basketDGV.Name = "basketDGV";
            this.basketDGV.Size = new System.Drawing.Size(550, 324);
            this.basketDGV.TabIndex = 0;
            // 
            // TypeCategoryName
            // 
            this.TypeCategoryName.HeaderText = "Тип";
            this.TypeCategoryName.Name = "TypeCategoryName";
            // 
            // CategoryGoodsName
            // 
            this.CategoryGoodsName.HeaderText = "Категория";
            this.CategoryGoodsName.Name = "CategoryGoodsName";
            this.CategoryGoodsName.Width = 120;
            // 
            // GoodsName
            // 
            this.GoodsName.HeaderText = "Наименование";
            this.GoodsName.Name = "GoodsName";
            this.GoodsName.Width = 180;
            // 
            // GoodsManufacturerName
            // 
            this.GoodsManufacturerName.HeaderText = "Производитель";
            this.GoodsManufacturerName.Name = "GoodsManufacturerName";
            // 
            // GoodsCost
            // 
            this.GoodsCost.HeaderText = "Цена";
            this.GoodsCost.Name = "GoodsCost";
            // 
            // GoodsQuantity
            // 
            this.GoodsQuantity.HeaderText = "Количество";
            this.GoodsQuantity.Name = "GoodsQuantity";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(817, 704);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Общая стоимость:";
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Location = new System.Drawing.Point(925, 704);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(52, 13);
            this.totalCostLabel.TabIndex = 2;
            this.totalCostLabel.Text = "TotalCost";
            // 
            // dataTableBindingSource
            // 
            this.dataTableBindingSource.DataMember = "DataTable";
            // 
            // softwareDGV
            // 
            this.softwareDGV.AllowUserToAddRows = false;
            this.softwareDGV.AllowUserToDeleteRows = false;
            this.softwareDGV.AllowUserToResizeRows = false;
            this.softwareDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.softwareDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.softwareDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoftwareTypeName,
            this.SoftwareName,
            this.SoftwareCost,
            this.SoftwareQuantity,
            this.SoftwareID});
            this.softwareDGV.Location = new System.Drawing.Point(12, 394);
            this.softwareDGV.Name = "softwareDGV";
            this.softwareDGV.ReadOnly = true;
            this.softwareDGV.Size = new System.Drawing.Size(550, 323);
            this.softwareDGV.TabIndex = 3;
            // 
            // deleteGoodsButton
            // 
            this.deleteGoodsButton.Location = new System.Drawing.Point(579, 30);
            this.deleteGoodsButton.Name = "deleteGoodsButton";
            this.deleteGoodsButton.Size = new System.Drawing.Size(102, 48);
            this.deleteGoodsButton.TabIndex = 4;
            this.deleteGoodsButton.Text = "Удалить комплектующее";
            this.deleteGoodsButton.UseVisualStyleBackColor = true;
            this.deleteGoodsButton.Click += new System.EventHandler(this.deleteGoodsButton_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Список комплектующих:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Список программного обеспечения:";
            // 
            // deleteSoftwareButton
            // 
            this.deleteSoftwareButton.Location = new System.Drawing.Point(579, 394);
            this.deleteSoftwareButton.Name = "deleteSoftwareButton";
            this.deleteSoftwareButton.Size = new System.Drawing.Size(80, 33);
            this.deleteSoftwareButton.TabIndex = 7;
            this.deleteSoftwareButton.Text = "Удалить ПО";
            this.deleteSoftwareButton.UseVisualStyleBackColor = true;
            this.deleteSoftwareButton.Click += new System.EventHandler(this.deleteSoftwareButton_Click);
            // 
            // SoftwareTypeName
            // 
            this.SoftwareTypeName.HeaderText = "Тип";
            this.SoftwareTypeName.Name = "SoftwareTypeName";
            this.SoftwareTypeName.ReadOnly = true;
            this.SoftwareTypeName.Width = 200;
            // 
            // SoftwareName
            // 
            this.SoftwareName.HeaderText = "Наименование";
            this.SoftwareName.Name = "SoftwareName";
            this.SoftwareName.ReadOnly = true;
            this.SoftwareName.Width = 200;
            // 
            // SoftwareCost
            // 
            this.SoftwareCost.HeaderText = "Цена";
            this.SoftwareCost.Name = "SoftwareCost";
            this.SoftwareCost.ReadOnly = true;
            // 
            // SoftwareQuantity
            // 
            this.SoftwareQuantity.HeaderText = "Количество";
            this.SoftwareQuantity.Name = "SoftwareQuantity";
            this.SoftwareQuantity.ReadOnly = true;
            // 
            // SoftwareID
            // 
            this.SoftwareID.HeaderText = "ID";
            this.SoftwareID.Name = "SoftwareID";
            this.SoftwareID.ReadOnly = true;
            this.SoftwareID.Visible = false;
            // 
            // Basket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.deleteSoftwareButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deleteGoodsButton);
            this.Controls.Add(this.softwareDGV);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.basketDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 736);
            this.Name = "Basket";
            this.ShowIcon = false;
            this.Text = "Basket";
            this.Load += new System.EventHandler(this.Basket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.basketDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwareDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView basketDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.BindingSource dataTableBindingSource;
        private System.Windows.Forms.DataGridView softwareDGV;
        private System.Windows.Forms.Button deleteGoodsButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button deleteSoftwareButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryGoodsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsManufacturerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoftwareTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoftwareName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoftwareCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoftwareQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoftwareID;
    }
}