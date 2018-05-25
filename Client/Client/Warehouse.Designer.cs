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
            this.dataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehouseTable = new Client.WarehouseTable();
            this.dataTableTableAdapter = new Client.WarehouseTableTableAdapters.DataTableTableAdapter();
            this.warehouseReport = new FastReport.Report();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.товарыНаСкладеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поставкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shopGoodsTP = new System.Windows.Forms.TabPage();
            this.warehouseGoodsTP = new System.Windows.Forms.TabPage();
            this.warehouseTC = new System.Windows.Forms.TabControl();
            this.label3 = new System.Windows.Forms.Label();
            this.addGoodsButton = new System.Windows.Forms.Button();
            this.goodsQuantityTB = new System.Windows.Forms.TextBox();
            this.showAllGoodsButton = new System.Windows.Forms.Button();
            this.goodsTypeCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.goodsNameTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.manufacturerTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.manufacturerButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.goodsCategoryCB = new System.Windows.Forms.ComboBox();
            this.warehouseDGV = new System.Windows.Forms.DataGridView();
            this.typeCategoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryGoodsNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsManufacturerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouseGoodsAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.goodsDGV = new System.Windows.Forms.DataGridView();
            this.warehouseGoods = new Client.WarehouseGoods();
            this.dataTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataTableTableAdapter1 = new Client.WarehouseGoodsTableAdapters.DataTableTableAdapter();
            this.typeCategoryNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryGoodsNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsManufacturerNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseReport)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.shopGoodsTP.SuspendLayout();
            this.warehouseGoodsTP.SuspendLayout();
            this.warehouseTC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseGoods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource1)).BeginInit();
            this.SuspendLayout();
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
            // warehouseReport
            // 
            this.warehouseReport.NeedRefresh = false;
            this.warehouseReport.ReportResourceString = resources.GetString("warehouseReport.ReportResourceString");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отчетыToolStripMenuItem,
            this.поставкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(804, 24);
            this.menuStrip1.TabIndex = 45;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.товарыНаСкладеToolStripMenuItem});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчетыToolStripMenuItem.Text = "&Отчеты";
            // 
            // товарыНаСкладеToolStripMenuItem
            // 
            this.товарыНаСкладеToolStripMenuItem.Name = "товарыНаСкладеToolStripMenuItem";
            this.товарыНаСкладеToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.товарыНаСкладеToolStripMenuItem.Text = "&Товары на складе";
            this.товарыНаСкладеToolStripMenuItem.Click += new System.EventHandler(this.товарыНаСкладеToolStripMenuItem_Click);
            // 
            // поставкиToolStripMenuItem
            // 
            this.поставкиToolStripMenuItem.Name = "поставкиToolStripMenuItem";
            this.поставкиToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.поставкиToolStripMenuItem.Text = "&Поставки";
            // 
            // shopGoodsTP
            // 
            this.shopGoodsTP.BackColor = System.Drawing.SystemColors.Control;
            this.shopGoodsTP.Controls.Add(this.goodsDGV);
            this.shopGoodsTP.Location = new System.Drawing.Point(4, 22);
            this.shopGoodsTP.Name = "shopGoodsTP";
            this.shopGoodsTP.Padding = new System.Windows.Forms.Padding(3);
            this.shopGoodsTP.Size = new System.Drawing.Size(774, 295);
            this.shopGoodsTP.TabIndex = 1;
            this.shopGoodsTP.Text = "Товары в магазине";
            // 
            // warehouseGoodsTP
            // 
            this.warehouseGoodsTP.BackColor = System.Drawing.SystemColors.Control;
            this.warehouseGoodsTP.Controls.Add(this.label3);
            this.warehouseGoodsTP.Controls.Add(this.addGoodsButton);
            this.warehouseGoodsTP.Controls.Add(this.goodsQuantityTB);
            this.warehouseGoodsTP.Controls.Add(this.showAllGoodsButton);
            this.warehouseGoodsTP.Controls.Add(this.goodsTypeCB);
            this.warehouseGoodsTP.Controls.Add(this.label2);
            this.warehouseGoodsTP.Controls.Add(this.goodsNameTB);
            this.warehouseGoodsTP.Controls.Add(this.label7);
            this.warehouseGoodsTP.Controls.Add(this.manufacturerTB);
            this.warehouseGoodsTP.Controls.Add(this.label6);
            this.warehouseGoodsTP.Controls.Add(this.manufacturerButton);
            this.warehouseGoodsTP.Controls.Add(this.label8);
            this.warehouseGoodsTP.Controls.Add(this.goodsCategoryCB);
            this.warehouseGoodsTP.Controls.Add(this.warehouseDGV);
            this.warehouseGoodsTP.Controls.Add(this.label1);
            this.warehouseGoodsTP.Location = new System.Drawing.Point(4, 22);
            this.warehouseGoodsTP.Name = "warehouseGoodsTP";
            this.warehouseGoodsTP.Padding = new System.Windows.Forms.Padding(3);
            this.warehouseGoodsTP.Size = new System.Drawing.Size(774, 295);
            this.warehouseGoodsTP.TabIndex = 0;
            this.warehouseGoodsTP.Text = "Товары на складе";
            // 
            // warehouseTC
            // 
            this.warehouseTC.Controls.Add(this.warehouseGoodsTP);
            this.warehouseTC.Controls.Add(this.shopGoodsTP);
            this.warehouseTC.Location = new System.Drawing.Point(12, 27);
            this.warehouseTC.Name = "warehouseTC";
            this.warehouseTC.SelectedIndex = 0;
            this.warehouseTC.Size = new System.Drawing.Size(782, 321);
            this.warehouseTC.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Количество товаров:";
            // 
            // addGoodsButton
            // 
            this.addGoodsButton.Location = new System.Drawing.Point(127, 236);
            this.addGoodsButton.Name = "addGoodsButton";
            this.addGoodsButton.Size = new System.Drawing.Size(80, 40);
            this.addGoodsButton.TabIndex = 60;
            this.addGoodsButton.Text = "Добавить в магазин";
            this.addGoodsButton.UseVisualStyleBackColor = true;
            this.addGoodsButton.Click += new System.EventHandler(this.addGoodsButton_Click_1);
            // 
            // goodsQuantityTB
            // 
            this.goodsQuantityTB.Location = new System.Drawing.Point(6, 256);
            this.goodsQuantityTB.Name = "goodsQuantityTB";
            this.goodsQuantityTB.Size = new System.Drawing.Size(100, 20);
            this.goodsQuantityTB.TabIndex = 59;
            // 
            // showAllGoodsButton
            // 
            this.showAllGoodsButton.Location = new System.Drawing.Point(465, 236);
            this.showAllGoodsButton.Name = "showAllGoodsButton";
            this.showAllGoodsButton.Size = new System.Drawing.Size(90, 40);
            this.showAllGoodsButton.TabIndex = 58;
            this.showAllGoodsButton.Text = "Показать все товары";
            this.showAllGoodsButton.UseVisualStyleBackColor = true;
            // 
            // goodsTypeCB
            // 
            this.goodsTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.goodsTypeCB.FormattingEnabled = true;
            this.goodsTypeCB.Location = new System.Drawing.Point(578, 36);
            this.goodsTypeCB.Name = "goodsTypeCB";
            this.goodsTypeCB.Size = new System.Drawing.Size(157, 21);
            this.goodsTypeCB.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(575, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Тип комплектующего:";
            // 
            // goodsNameTB
            // 
            this.goodsNameTB.Location = new System.Drawing.Point(581, 258);
            this.goodsNameTB.Name = "goodsNameTB";
            this.goodsNameTB.Size = new System.Drawing.Size(100, 20);
            this.goodsNameTB.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(578, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 13);
            this.label7.TabIndex = 54;
            this.label7.Text = "Наименование товара:";
            // 
            // manufacturerTB
            // 
            this.manufacturerTB.Location = new System.Drawing.Point(578, 145);
            this.manufacturerTB.Name = "manufacturerTB";
            this.manufacturerTB.Size = new System.Drawing.Size(100, 20);
            this.manufacturerTB.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(575, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "Фирма производитель:";
            // 
            // manufacturerButton
            // 
            this.manufacturerButton.Location = new System.Drawing.Point(578, 171);
            this.manufacturerButton.Name = "manufacturerButton";
            this.manufacturerButton.Size = new System.Drawing.Size(100, 40);
            this.manufacturerButton.TabIndex = 51;
            this.manufacturerButton.Text = "Отфильтровать";
            this.manufacturerButton.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(575, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "Категория комплектующего:";
            // 
            // goodsCategoryCB
            // 
            this.goodsCategoryCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.goodsCategoryCB.FormattingEnabled = true;
            this.goodsCategoryCB.Location = new System.Drawing.Point(578, 87);
            this.goodsCategoryCB.Name = "goodsCategoryCB";
            this.goodsCategoryCB.Size = new System.Drawing.Size(188, 21);
            this.goodsCategoryCB.TabIndex = 49;
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
            this.warehouseDGV.Location = new System.Drawing.Point(6, 20);
            this.warehouseDGV.Name = "warehouseDGV";
            this.warehouseDGV.ReadOnly = true;
            this.warehouseDGV.Size = new System.Drawing.Size(549, 212);
            this.warehouseDGV.TabIndex = 48;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Товары на складе:";
            // 
            // goodsDGV
            // 
            this.goodsDGV.AllowUserToAddRows = false;
            this.goodsDGV.AllowUserToDeleteRows = false;
            this.goodsDGV.AllowUserToResizeRows = false;
            this.goodsDGV.AutoGenerateColumns = false;
            this.goodsDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.goodsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.goodsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeCategoryNameDataGridViewTextBoxColumn1,
            this.categoryGoodsNameDataGridViewTextBoxColumn1,
            this.goodsManufacturerNameDataGridViewTextBoxColumn1,
            this.goodsNameDataGridViewTextBoxColumn1,
            this.goodsCostDataGridViewTextBoxColumn,
            this.goodsIDDataGridViewTextBoxColumn1,
            this.goodsAmountDataGridViewTextBoxColumn});
            this.goodsDGV.DataSource = this.dataTableBindingSource1;
            this.goodsDGV.Location = new System.Drawing.Point(6, 6);
            this.goodsDGV.Name = "goodsDGV";
            this.goodsDGV.ReadOnly = true;
            this.goodsDGV.Size = new System.Drawing.Size(762, 284);
            this.goodsDGV.TabIndex = 3;
            // 
            // warehouseGoods
            // 
            this.warehouseGoods.DataSetName = "WarehouseGoods";
            this.warehouseGoods.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTableBindingSource1
            // 
            this.dataTableBindingSource1.DataMember = "DataTable";
            this.dataTableBindingSource1.DataSource = this.warehouseGoods;
            // 
            // dataTableTableAdapter1
            // 
            this.dataTableTableAdapter1.ClearBeforeFill = true;
            // 
            // typeCategoryNameDataGridViewTextBoxColumn1
            // 
            this.typeCategoryNameDataGridViewTextBoxColumn1.DataPropertyName = "TypeCategoryName";
            this.typeCategoryNameDataGridViewTextBoxColumn1.HeaderText = "Тип";
            this.typeCategoryNameDataGridViewTextBoxColumn1.Name = "typeCategoryNameDataGridViewTextBoxColumn1";
            this.typeCategoryNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // categoryGoodsNameDataGridViewTextBoxColumn1
            // 
            this.categoryGoodsNameDataGridViewTextBoxColumn1.DataPropertyName = "CategoryGoodsName";
            this.categoryGoodsNameDataGridViewTextBoxColumn1.HeaderText = "Категория";
            this.categoryGoodsNameDataGridViewTextBoxColumn1.Name = "categoryGoodsNameDataGridViewTextBoxColumn1";
            this.categoryGoodsNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // goodsManufacturerNameDataGridViewTextBoxColumn1
            // 
            this.goodsManufacturerNameDataGridViewTextBoxColumn1.DataPropertyName = "GoodsManufacturerName";
            this.goodsManufacturerNameDataGridViewTextBoxColumn1.HeaderText = "Производитель";
            this.goodsManufacturerNameDataGridViewTextBoxColumn1.Name = "goodsManufacturerNameDataGridViewTextBoxColumn1";
            this.goodsManufacturerNameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.goodsManufacturerNameDataGridViewTextBoxColumn1.Width = 150;
            // 
            // goodsNameDataGridViewTextBoxColumn1
            // 
            this.goodsNameDataGridViewTextBoxColumn1.DataPropertyName = "GoodsName";
            this.goodsNameDataGridViewTextBoxColumn1.HeaderText = "Наименование";
            this.goodsNameDataGridViewTextBoxColumn1.Name = "goodsNameDataGridViewTextBoxColumn1";
            this.goodsNameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.goodsNameDataGridViewTextBoxColumn1.Width = 150;
            // 
            // goodsCostDataGridViewTextBoxColumn
            // 
            this.goodsCostDataGridViewTextBoxColumn.DataPropertyName = "GoodsCost";
            this.goodsCostDataGridViewTextBoxColumn.HeaderText = "Цена, руб.";
            this.goodsCostDataGridViewTextBoxColumn.Name = "goodsCostDataGridViewTextBoxColumn";
            this.goodsCostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // goodsIDDataGridViewTextBoxColumn1
            // 
            this.goodsIDDataGridViewTextBoxColumn1.DataPropertyName = "GoodsID";
            this.goodsIDDataGridViewTextBoxColumn1.HeaderText = "GoodsID";
            this.goodsIDDataGridViewTextBoxColumn1.Name = "goodsIDDataGridViewTextBoxColumn1";
            this.goodsIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.goodsIDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // goodsAmountDataGridViewTextBoxColumn
            // 
            this.goodsAmountDataGridViewTextBoxColumn.DataPropertyName = "GoodsAmount";
            this.goodsAmountDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.goodsAmountDataGridViewTextBoxColumn.Name = "goodsAmountDataGridViewTextBoxColumn";
            this.goodsAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Warehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 351);
            this.Controls.Add(this.warehouseTC);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(820, 390);
            this.Name = "Warehouse";
            this.ShowIcon = false;
            this.Text = "Warehouse";
            this.Load += new System.EventHandler(this.Warehouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseReport)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.shopGoodsTP.ResumeLayout(false);
            this.warehouseGoodsTP.ResumeLayout(false);
            this.warehouseGoodsTP.PerformLayout();
            this.warehouseTC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseGoods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private WarehouseTable warehouseTable;
        private System.Windows.Forms.BindingSource dataTableBindingSource;
        private WarehouseTableTableAdapters.DataTableTableAdapter dataTableTableAdapter;
        private FastReport.Report warehouseReport;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поставкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem товарыНаСкладеToolStripMenuItem;
        private System.Windows.Forms.TabPage shopGoodsTP;
        private System.Windows.Forms.TabPage warehouseGoodsTP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addGoodsButton;
        private System.Windows.Forms.TextBox goodsQuantityTB;
        private System.Windows.Forms.Button showAllGoodsButton;
        private System.Windows.Forms.ComboBox goodsTypeCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox goodsNameTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox manufacturerTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button manufacturerButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox goodsCategoryCB;
        private System.Windows.Forms.DataGridView warehouseDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeCategoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryGoodsNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsManufacturerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehouseGoodsAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl warehouseTC;
        private System.Windows.Forms.DataGridView goodsDGV;
        private WarehouseGoods warehouseGoods;
        private System.Windows.Forms.BindingSource dataTableBindingSource1;
        private WarehouseGoodsTableAdapters.DataTableTableAdapter dataTableTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeCategoryNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryGoodsNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsManufacturerNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsAmountDataGridViewTextBoxColumn;
    }
}