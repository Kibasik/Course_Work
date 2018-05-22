namespace Client
{
    partial class Warehouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Warehouse));
            this.label1 = new System.Windows.Forms.Label();
            this.warehouseDGV = new System.Windows.Forms.DataGridView();
            this.typeCategoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryGoodsNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsManufacturerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouseGoodsAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehouseTable = new Client.WarehouseTable();
            this.dataTableTableAdapter = new Client.WarehouseTableTableAdapters.DataTableTableAdapter();
            this.warehouserReportButton = new System.Windows.Forms.Button();
            this.warehouseReport = new FastReport.Report();
            this.goodsTypeCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.goodsNameTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.manufacturerTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.manufacturerButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.goodsCategoryCB = new System.Windows.Forms.ComboBox();
            this.showAllGoodsButton = new System.Windows.Forms.Button();
            this.goodsQuantityTB = new System.Windows.Forms.TextBox();
            this.addGoodsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseReport)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Товары на складе:";
            // 
            // warehouseDGV
            // 
            this.warehouseDGV.AllowUserToAddRows = false;
            this.warehouseDGV.AllowUserToDeleteRows = false;
            this.warehouseDGV.AllowUserToResizeRows = false;
            this.warehouseDGV.AutoGenerateColumns = false;
            this.warehouseDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.warehouseDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.warehouseDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeCategoryNameDataGridViewTextBoxColumn,
            this.categoryGoodsNameDataGridViewTextBoxColumn,
            this.goodsManufacturerNameDataGridViewTextBoxColumn,
            this.goodsNameDataGridViewTextBoxColumn,
            this.warehouseGoodsAmountDataGridViewTextBoxColumn,
            this.goodsIDDataGridViewTextBoxColumn});
            this.warehouseDGV.DataSource = this.dataTableBindingSource;
            this.warehouseDGV.Location = new System.Drawing.Point(15, 25);
            this.warehouseDGV.Name = "warehouseDGV";
            this.warehouseDGV.ReadOnly = true;
            this.warehouseDGV.Size = new System.Drawing.Size(549, 212);
            this.warehouseDGV.TabIndex = 1;
            // 
            // typeCategoryNameDataGridViewTextBoxColumn
            // 
            this.typeCategoryNameDataGridViewTextBoxColumn.DataPropertyName = "TypeCategoryName";
            this.typeCategoryNameDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.typeCategoryNameDataGridViewTextBoxColumn.Name = "typeCategoryNameDataGridViewTextBoxColumn";
            this.typeCategoryNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryGoodsNameDataGridViewTextBoxColumn
            // 
            this.categoryGoodsNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryGoodsName";
            this.categoryGoodsNameDataGridViewTextBoxColumn.HeaderText = "Категория";
            this.categoryGoodsNameDataGridViewTextBoxColumn.Name = "categoryGoodsNameDataGridViewTextBoxColumn";
            this.categoryGoodsNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // goodsManufacturerNameDataGridViewTextBoxColumn
            // 
            this.goodsManufacturerNameDataGridViewTextBoxColumn.DataPropertyName = "GoodsManufacturerName";
            this.goodsManufacturerNameDataGridViewTextBoxColumn.HeaderText = "Производитель";
            this.goodsManufacturerNameDataGridViewTextBoxColumn.Name = "goodsManufacturerNameDataGridViewTextBoxColumn";
            this.goodsManufacturerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // goodsNameDataGridViewTextBoxColumn
            // 
            this.goodsNameDataGridViewTextBoxColumn.DataPropertyName = "GoodsName";
            this.goodsNameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.goodsNameDataGridViewTextBoxColumn.Name = "goodsNameDataGridViewTextBoxColumn";
            this.goodsNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // warehouseGoodsAmountDataGridViewTextBoxColumn
            // 
            this.warehouseGoodsAmountDataGridViewTextBoxColumn.DataPropertyName = "WarehouseGoodsAmount";
            this.warehouseGoodsAmountDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.warehouseGoodsAmountDataGridViewTextBoxColumn.Name = "warehouseGoodsAmountDataGridViewTextBoxColumn";
            this.warehouseGoodsAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // goodsIDDataGridViewTextBoxColumn
            // 
            this.goodsIDDataGridViewTextBoxColumn.DataPropertyName = "GoodsID";
            this.goodsIDDataGridViewTextBoxColumn.HeaderText = "GoodsID";
            this.goodsIDDataGridViewTextBoxColumn.Name = "goodsIDDataGridViewTextBoxColumn";
            this.goodsIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.goodsIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataTableBindingSource
            // 
            this.dataTableBindingSource.DataMember = "DataTable";
            this.dataTableBindingSource.DataSource = this.warehouseTable;
            // 
            // warehouseTable
            // 
            this.warehouseTable.DataSetName = "WarehouseTable";
            this.warehouseTable.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTableTableAdapter
            // 
            this.dataTableTableAdapter.ClearBeforeFill = true;
            // 
            // warehouserReportButton
            // 
            this.warehouserReportButton.Location = new System.Drawing.Point(15, 243);
            this.warehouserReportButton.Name = "warehouserReportButton";
            this.warehouserReportButton.Size = new System.Drawing.Size(120, 40);
            this.warehouserReportButton.TabIndex = 2;
            this.warehouserReportButton.Text = "Отчет по товарам на складе";
            this.warehouserReportButton.UseVisualStyleBackColor = true;
            this.warehouserReportButton.Click += new System.EventHandler(this.warehouserReportButton_Click);
            // 
            // warehouseReport
            // 
            this.warehouseReport.NeedRefresh = false;
            this.warehouseReport.ReportResourceString = resources.GetString("warehouseReport.ReportResourceString");
            // 
            // goodsTypeCB
            // 
            this.goodsTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.goodsTypeCB.FormattingEnabled = true;
            this.goodsTypeCB.Location = new System.Drawing.Point(587, 41);
            this.goodsTypeCB.Name = "goodsTypeCB";
            this.goodsTypeCB.Size = new System.Drawing.Size(157, 21);
            this.goodsTypeCB.TabIndex = 41;
            this.goodsTypeCB.SelectedIndexChanged += new System.EventHandler(this.goodsTypeCB_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(584, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Тип комплектующего:";
            // 
            // goodsNameTB
            // 
            this.goodsNameTB.Location = new System.Drawing.Point(590, 263);
            this.goodsNameTB.Name = "goodsNameTB";
            this.goodsNameTB.Size = new System.Drawing.Size(100, 20);
            this.goodsNameTB.TabIndex = 39;
            this.goodsNameTB.TextChanged += new System.EventHandler(this.goodsNameTB_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(587, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Наименование товара:";
            // 
            // manufacturerTB
            // 
            this.manufacturerTB.Location = new System.Drawing.Point(587, 150);
            this.manufacturerTB.Name = "manufacturerTB";
            this.manufacturerTB.Size = new System.Drawing.Size(100, 20);
            this.manufacturerTB.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(584, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Фирма производитель:";
            // 
            // manufacturerButton
            // 
            this.manufacturerButton.Location = new System.Drawing.Point(587, 176);
            this.manufacturerButton.Name = "manufacturerButton";
            this.manufacturerButton.Size = new System.Drawing.Size(100, 40);
            this.manufacturerButton.TabIndex = 35;
            this.manufacturerButton.Text = "Отфильтровать";
            this.manufacturerButton.UseVisualStyleBackColor = true;
            this.manufacturerButton.Click += new System.EventHandler(this.manufacturerButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(584, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Категория комплектующего:";
            // 
            // goodsCategoryCB
            // 
            this.goodsCategoryCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.goodsCategoryCB.FormattingEnabled = true;
            this.goodsCategoryCB.Location = new System.Drawing.Point(587, 92);
            this.goodsCategoryCB.Name = "goodsCategoryCB";
            this.goodsCategoryCB.Size = new System.Drawing.Size(188, 21);
            this.goodsCategoryCB.TabIndex = 27;
            this.goodsCategoryCB.SelectedIndexChanged += new System.EventHandler(this.goodsCategoryCB_SelectedIndexChanged);
            // 
            // showAllGoodsButton
            // 
            this.showAllGoodsButton.Location = new System.Drawing.Point(158, 243);
            this.showAllGoodsButton.Name = "showAllGoodsButton";
            this.showAllGoodsButton.Size = new System.Drawing.Size(90, 40);
            this.showAllGoodsButton.TabIndex = 42;
            this.showAllGoodsButton.Text = "Показать все товары";
            this.showAllGoodsButton.UseVisualStyleBackColor = true;
            this.showAllGoodsButton.Click += new System.EventHandler(this.showAllGoodsButton_Click);
            // 
            // goodsQuantityTB
            // 
            this.goodsQuantityTB.Location = new System.Drawing.Point(273, 243);
            this.goodsQuantityTB.Name = "goodsQuantityTB";
            this.goodsQuantityTB.Size = new System.Drawing.Size(100, 20);
            this.goodsQuantityTB.TabIndex = 43;
            this.goodsQuantityTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.goodsQuantityTB_KeyPress);
            // 
            // addGoodsButton
            // 
            this.addGoodsButton.Location = new System.Drawing.Point(388, 243);
            this.addGoodsButton.Name = "addGoodsButton";
            this.addGoodsButton.Size = new System.Drawing.Size(80, 40);
            this.addGoodsButton.TabIndex = 44;
            this.addGoodsButton.Text = "Добавить в магазин";
            this.addGoodsButton.UseVisualStyleBackColor = true;
            this.addGoodsButton.Click += new System.EventHandler(this.addGoodsButton_Click);
            // 
            // Warehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 291);
            this.Controls.Add(this.addGoodsButton);
            this.Controls.Add(this.goodsQuantityTB);
            this.Controls.Add(this.showAllGoodsButton);
            this.Controls.Add(this.goodsTypeCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.goodsNameTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.manufacturerTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.manufacturerButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.goodsCategoryCB);
            this.Controls.Add(this.warehouserReportButton);
            this.Controls.Add(this.warehouseDGV);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 330);
            this.Name = "Warehouse";
            this.ShowIcon = false;
            this.Text = "Warehouse";
            this.Load += new System.EventHandler(this.Warehouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView warehouseDGV;
        private WarehouseTable warehouseTable;
        private System.Windows.Forms.BindingSource dataTableBindingSource;
        private WarehouseTableTableAdapters.DataTableTableAdapter dataTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeCategoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryGoodsNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsManufacturerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehouseGoodsAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button warehouserReportButton;
        private FastReport.Report warehouseReport;
        private System.Windows.Forms.ComboBox goodsTypeCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox goodsNameTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox manufacturerTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button manufacturerButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox goodsCategoryCB;
        private System.Windows.Forms.Button showAllGoodsButton;
        private System.Windows.Forms.TextBox goodsQuantityTB;
        private System.Windows.Forms.Button addGoodsButton;
    }
}