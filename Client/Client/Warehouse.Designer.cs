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
            this.поставкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поставщикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.составПоставкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.товарыНаСкладеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.графикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новоеНаименованиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.программноеОбеспечениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.комплектующееToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shopGoodsTP = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.shopCategoryGoodsCB = new System.Windows.Forms.ComboBox();
            this.manufacturerFilterButton = new System.Windows.Forms.Button();
            this.shopShowAllButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.goodsManufacturerTB = new System.Windows.Forms.TextBox();
            this.changeDescriptionButton = new System.Windows.Forms.Button();
            this.changeCharacteristicsButton = new System.Windows.Forms.Button();
            this.goodsDGV = new System.Windows.Forms.DataGridView();
            this.typeCategoryNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryGoodsNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsManufacturerNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.warehouseGoods = new Client.WarehouseGoods();
            this.warehouseGoodsTP = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.goodsCategoryCB = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.manufacturerButton = new System.Windows.Forms.Button();
            this.showAllGoodsButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.goodsTypeCB = new System.Windows.Forms.ComboBox();
            this.manufacturerTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.goodsNameTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addGoodsButton = new System.Windows.Forms.Button();
            this.goodsQuantityTB = new System.Windows.Forms.TextBox();
            this.warehouseDGV = new System.Windows.Forms.DataGridView();
            this.typeCategoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryGoodsNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsManufacturerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouseGoodsAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouseTC = new System.Windows.Forms.TabControl();
            this.dataTableTableAdapter1 = new Client.WarehouseGoodsTableAdapters.DataTableTableAdapter();
            this.supplyStructureReport = new FastReport.Report();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseReport)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.shopGoodsTP.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goodsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseGoods)).BeginInit();
            this.warehouseGoodsTP.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDGV)).BeginInit();
            this.warehouseTC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplyStructureReport)).BeginInit();
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
            this.поставкиToolStripMenuItem,
            this.поставщикиToolStripMenuItem,
            this.отчетыToolStripMenuItem1,
            this.графикиToolStripMenuItem,
            this.новоеНаименованиеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(804, 24);
            this.menuStrip1.TabIndex = 45;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // поставкиToolStripMenuItem
            // 
            this.поставкиToolStripMenuItem.Name = "поставкиToolStripMenuItem";
            this.поставкиToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.поставкиToolStripMenuItem.Text = "&Поставки";
            this.поставкиToolStripMenuItem.Click += new System.EventHandler(this.поставкиToolStripMenuItem_Click);
            // 
            // поставщикиToolStripMenuItem
            // 
            this.поставщикиToolStripMenuItem.Name = "поставщикиToolStripMenuItem";
            this.поставщикиToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.поставщикиToolStripMenuItem.Text = "&Поставщики";
            this.поставщикиToolStripMenuItem.Click += new System.EventHandler(this.поставщикиToolStripMenuItem_Click);
            // 
            // отчетыToolStripMenuItem1
            // 
            this.отчетыToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.составПоставкиToolStripMenuItem,
            this.товарыНаСкладеToolStripMenuItem1});
            this.отчетыToolStripMenuItem1.Name = "отчетыToolStripMenuItem1";
            this.отчетыToolStripMenuItem1.Size = new System.Drawing.Size(60, 20);
            this.отчетыToolStripMenuItem1.Text = "&Отчеты";
            // 
            // составПоставкиToolStripMenuItem
            // 
            this.составПоставкиToolStripMenuItem.Name = "составПоставкиToolStripMenuItem";
            this.составПоставкиToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.составПоставкиToolStripMenuItem.Text = "&Состав поставки";
            this.составПоставкиToolStripMenuItem.Click += new System.EventHandler(this.составПоставкиToolStripMenuItem_Click);
            // 
            // товарыНаСкладеToolStripMenuItem1
            // 
            this.товарыНаСкладеToolStripMenuItem1.Name = "товарыНаСкладеToolStripMenuItem1";
            this.товарыНаСкладеToolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
            this.товарыНаСкладеToolStripMenuItem1.Text = "&Товары на складе";
            this.товарыНаСкладеToolStripMenuItem1.Click += new System.EventHandler(this.товарыНаСкладеToolStripMenuItem1_Click);
            // 
            // графикиToolStripMenuItem
            // 
            this.графикиToolStripMenuItem.Name = "графикиToolStripMenuItem";
            this.графикиToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.графикиToolStripMenuItem.Text = "&Графики";
            this.графикиToolStripMenuItem.Click += new System.EventHandler(this.графикиToolStripMenuItem_Click);
            // 
            // новоеНаименованиеToolStripMenuItem
            // 
            this.новоеНаименованиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.программноеОбеспечениеToolStripMenuItem,
            this.комплектующееToolStripMenuItem});
            this.новоеНаименованиеToolStripMenuItem.Name = "новоеНаименованиеToolStripMenuItem";
            this.новоеНаименованиеToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.новоеНаименованиеToolStripMenuItem.Text = "&Новое наименование";
            // 
            // программноеОбеспечениеToolStripMenuItem
            // 
            this.программноеОбеспечениеToolStripMenuItem.Name = "программноеОбеспечениеToolStripMenuItem";
            this.программноеОбеспечениеToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.программноеОбеспечениеToolStripMenuItem.Text = "&Программное обеспечение";
            this.программноеОбеспечениеToolStripMenuItem.Click += new System.EventHandler(this.программноеОбеспечениеToolStripMenuItem_Click);
            // 
            // комплектующееToolStripMenuItem
            // 
            this.комплектующееToolStripMenuItem.Name = "комплектующееToolStripMenuItem";
            this.комплектующееToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.комплектующееToolStripMenuItem.Text = "&Комплектующее";
            this.комплектующееToolStripMenuItem.Click += new System.EventHandler(this.комплектующееToolStripMenuItem_Click);
            // 
            // shopGoodsTP
            // 
            this.shopGoodsTP.BackColor = System.Drawing.SystemColors.Control;
            this.shopGoodsTP.Controls.Add(this.groupBox2);
            this.shopGoodsTP.Controls.Add(this.changeDescriptionButton);
            this.shopGoodsTP.Controls.Add(this.changeCharacteristicsButton);
            this.shopGoodsTP.Controls.Add(this.goodsDGV);
            this.shopGoodsTP.Location = new System.Drawing.Point(4, 22);
            this.shopGoodsTP.Name = "shopGoodsTP";
            this.shopGoodsTP.Padding = new System.Windows.Forms.Padding(3);
            this.shopGoodsTP.Size = new System.Drawing.Size(774, 277);
            this.shopGoodsTP.TabIndex = 1;
            this.shopGoodsTP.Text = "Товары в магазине";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.shopCategoryGoodsCB);
            this.groupBox2.Controls.Add(this.manufacturerFilterButton);
            this.groupBox2.Controls.Add(this.shopShowAllButton);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.goodsManufacturerTB);
            this.groupBox2.Location = new System.Drawing.Point(568, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 265);
            this.groupBox2.TabIndex = 58;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Фильтрация";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "Категория комплектующего:";
            // 
            // shopCategoryGoodsCB
            // 
            this.shopCategoryGoodsCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shopCategoryGoodsCB.FormattingEnabled = true;
            this.shopCategoryGoodsCB.Location = new System.Drawing.Point(9, 32);
            this.shopCategoryGoodsCB.Name = "shopCategoryGoodsCB";
            this.shopCategoryGoodsCB.Size = new System.Drawing.Size(185, 21);
            this.shopCategoryGoodsCB.TabIndex = 51;
            this.shopCategoryGoodsCB.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // manufacturerFilterButton
            // 
            this.manufacturerFilterButton.Location = new System.Drawing.Point(51, 98);
            this.manufacturerFilterButton.Name = "manufacturerFilterButton";
            this.manufacturerFilterButton.Size = new System.Drawing.Size(100, 26);
            this.manufacturerFilterButton.TabIndex = 54;
            this.manufacturerFilterButton.Text = "Отфильтровать";
            this.manufacturerFilterButton.UseVisualStyleBackColor = true;
            this.manufacturerFilterButton.Click += new System.EventHandler(this.manufacturerFilterButton_Click);
            // 
            // shopShowAllButton
            // 
            this.shopShowAllButton.Location = new System.Drawing.Point(9, 229);
            this.shopShowAllButton.Name = "shopShowAllButton";
            this.shopShowAllButton.Size = new System.Drawing.Size(185, 27);
            this.shopShowAllButton.TabIndex = 57;
            this.shopShowAllButton.Text = "Показать весь список";
            this.shopShowAllButton.UseVisualStyleBackColor = true;
            this.shopShowAllButton.Click += new System.EventHandler(this.shopShowAllButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "Фирма производитель:";
            // 
            // goodsManufacturerTB
            // 
            this.goodsManufacturerTB.Location = new System.Drawing.Point(9, 72);
            this.goodsManufacturerTB.Name = "goodsManufacturerTB";
            this.goodsManufacturerTB.Size = new System.Drawing.Size(185, 20);
            this.goodsManufacturerTB.TabIndex = 56;
            // 
            // changeDescriptionButton
            // 
            this.changeDescriptionButton.Location = new System.Drawing.Point(6, 235);
            this.changeDescriptionButton.Name = "changeDescriptionButton";
            this.changeDescriptionButton.Size = new System.Drawing.Size(122, 36);
            this.changeDescriptionButton.TabIndex = 48;
            this.changeDescriptionButton.Text = "Изменить описание";
            this.changeDescriptionButton.UseVisualStyleBackColor = true;
            this.changeDescriptionButton.Click += new System.EventHandler(this.changeDescriptionButton_Click);
            // 
            // changeCharacteristicsButton
            // 
            this.changeCharacteristicsButton.Location = new System.Drawing.Point(134, 235);
            this.changeCharacteristicsButton.Name = "changeCharacteristicsButton";
            this.changeCharacteristicsButton.Size = new System.Drawing.Size(150, 36);
            this.changeCharacteristicsButton.TabIndex = 49;
            this.changeCharacteristicsButton.Text = "Изменить характеристики";
            this.changeCharacteristicsButton.UseVisualStyleBackColor = true;
            this.changeCharacteristicsButton.Click += new System.EventHandler(this.changeCharacteristicsButton_Click);
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
            this.goodsDGV.Size = new System.Drawing.Size(556, 226);
            this.goodsDGV.TabIndex = 3;
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
            // dataTableBindingSource1
            // 
            this.dataTableBindingSource1.DataMember = "DataTable";
            this.dataTableBindingSource1.DataSource = this.warehouseGoods;
            // 
            // warehouseGoods
            // 
            this.warehouseGoods.DataSetName = "WarehouseGoods";
            this.warehouseGoods.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // warehouseGoodsTP
            // 
            this.warehouseGoodsTP.BackColor = System.Drawing.SystemColors.Control;
            this.warehouseGoodsTP.Controls.Add(this.groupBox1);
            this.warehouseGoodsTP.Controls.Add(this.label3);
            this.warehouseGoodsTP.Controls.Add(this.addGoodsButton);
            this.warehouseGoodsTP.Controls.Add(this.goodsQuantityTB);
            this.warehouseGoodsTP.Controls.Add(this.warehouseDGV);
            this.warehouseGoodsTP.Location = new System.Drawing.Point(4, 22);
            this.warehouseGoodsTP.Name = "warehouseGoodsTP";
            this.warehouseGoodsTP.Padding = new System.Windows.Forms.Padding(3);
            this.warehouseGoodsTP.Size = new System.Drawing.Size(774, 277);
            this.warehouseGoodsTP.TabIndex = 0;
            this.warehouseGoodsTP.Text = "Товары на складе";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.goodsCategoryCB);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.manufacturerButton);
            this.groupBox1.Controls.Add(this.showAllGoodsButton);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.goodsTypeCB);
            this.groupBox1.Controls.Add(this.manufacturerTB);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.goodsNameTB);
            this.groupBox1.Location = new System.Drawing.Point(568, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 265);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтрация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Тип комплектующего:";
            // 
            // goodsCategoryCB
            // 
            this.goodsCategoryCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.goodsCategoryCB.FormattingEnabled = true;
            this.goodsCategoryCB.Location = new System.Drawing.Point(9, 72);
            this.goodsCategoryCB.Name = "goodsCategoryCB";
            this.goodsCategoryCB.Size = new System.Drawing.Size(185, 21);
            this.goodsCategoryCB.TabIndex = 49;
            this.goodsCategoryCB.SelectedIndexChanged += new System.EventHandler(this.goodsCategoryCB_SelectedIndexChanged_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "Категория комплектующего:";
            // 
            // manufacturerButton
            // 
            this.manufacturerButton.Location = new System.Drawing.Point(50, 138);
            this.manufacturerButton.Name = "manufacturerButton";
            this.manufacturerButton.Size = new System.Drawing.Size(100, 26);
            this.manufacturerButton.TabIndex = 51;
            this.manufacturerButton.Text = "Отфильтровать";
            this.manufacturerButton.UseVisualStyleBackColor = true;
            this.manufacturerButton.Click += new System.EventHandler(this.manufacturerButton_Click_1);
            // 
            // showAllGoodsButton
            // 
            this.showAllGoodsButton.Location = new System.Drawing.Point(9, 229);
            this.showAllGoodsButton.Name = "showAllGoodsButton";
            this.showAllGoodsButton.Size = new System.Drawing.Size(185, 27);
            this.showAllGoodsButton.TabIndex = 58;
            this.showAllGoodsButton.Text = "Показать все товары";
            this.showAllGoodsButton.UseVisualStyleBackColor = true;
            this.showAllGoodsButton.Click += new System.EventHandler(this.showAllGoodsButton_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "Фирма производитель:";
            // 
            // goodsTypeCB
            // 
            this.goodsTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.goodsTypeCB.FormattingEnabled = true;
            this.goodsTypeCB.Location = new System.Drawing.Point(9, 32);
            this.goodsTypeCB.Name = "goodsTypeCB";
            this.goodsTypeCB.Size = new System.Drawing.Size(185, 21);
            this.goodsTypeCB.TabIndex = 57;
            this.goodsTypeCB.SelectedIndexChanged += new System.EventHandler(this.goodsTypeCB_SelectedIndexChanged_1);
            // 
            // manufacturerTB
            // 
            this.manufacturerTB.Location = new System.Drawing.Point(9, 112);
            this.manufacturerTB.Name = "manufacturerTB";
            this.manufacturerTB.Size = new System.Drawing.Size(185, 20);
            this.manufacturerTB.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 13);
            this.label7.TabIndex = 54;
            this.label7.Text = "Наименование товара:";
            // 
            // goodsNameTB
            // 
            this.goodsNameTB.Location = new System.Drawing.Point(9, 183);
            this.goodsNameTB.Name = "goodsNameTB";
            this.goodsNameTB.Size = new System.Drawing.Size(185, 20);
            this.goodsNameTB.TabIndex = 55;
            this.goodsNameTB.TextChanged += new System.EventHandler(this.goodsNameTB_TextChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Количество товаров:";
            // 
            // addGoodsButton
            // 
            this.addGoodsButton.Location = new System.Drawing.Point(122, 235);
            this.addGoodsButton.Name = "addGoodsButton";
            this.addGoodsButton.Size = new System.Drawing.Size(102, 36);
            this.addGoodsButton.TabIndex = 60;
            this.addGoodsButton.Text = "Добавить в магазин";
            this.addGoodsButton.UseVisualStyleBackColor = true;
            this.addGoodsButton.Click += new System.EventHandler(this.addGoodsButton_Click_1);
            // 
            // goodsQuantityTB
            // 
            this.goodsQuantityTB.Location = new System.Drawing.Point(6, 251);
            this.goodsQuantityTB.MaxLength = 4;
            this.goodsQuantityTB.Name = "goodsQuantityTB";
            this.goodsQuantityTB.Size = new System.Drawing.Size(110, 20);
            this.goodsQuantityTB.TabIndex = 59;
            this.goodsQuantityTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.goodsQuantityTB_KeyPress_1);
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
            this.warehouseDGV.Location = new System.Drawing.Point(6, 6);
            this.warehouseDGV.Name = "warehouseDGV";
            this.warehouseDGV.ReadOnly = true;
            this.warehouseDGV.Size = new System.Drawing.Size(556, 226);
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
            // warehouseTC
            // 
            this.warehouseTC.Controls.Add(this.warehouseGoodsTP);
            this.warehouseTC.Controls.Add(this.shopGoodsTP);
            this.warehouseTC.Location = new System.Drawing.Point(12, 27);
            this.warehouseTC.Name = "warehouseTC";
            this.warehouseTC.SelectedIndex = 0;
            this.warehouseTC.Size = new System.Drawing.Size(782, 303);
            this.warehouseTC.TabIndex = 47;
            // 
            // dataTableTableAdapter1
            // 
            this.dataTableTableAdapter1.ClearBeforeFill = true;
            // 
            // supplyStructureReport
            // 
            this.supplyStructureReport.NeedRefresh = false;
            this.supplyStructureReport.ReportResourceString = resources.GetString("supplyStructureReport.ReportResourceString");
            // 
            // Warehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 340);
            this.Controls.Add(this.warehouseTC);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Warehouse";
            this.ShowIcon = false;
            this.Text = "Склад";
            this.Load += new System.EventHandler(this.Warehouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseReport)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.shopGoodsTP.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goodsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseGoods)).EndInit();
            this.warehouseGoodsTP.ResumeLayout(false);
            this.warehouseGoodsTP.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDGV)).EndInit();
            this.warehouseTC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.supplyStructureReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private WarehouseTable warehouseTable;
        private System.Windows.Forms.BindingSource dataTableBindingSource;
        private WarehouseTableTableAdapters.DataTableTableAdapter dataTableTableAdapter;
        private FastReport.Report warehouseReport;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem поставкиToolStripMenuItem;
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
        private System.Windows.Forms.ToolStripMenuItem поставщикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem составПоставкиToolStripMenuItem;
        private FastReport.Report supplyStructureReport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox shopCategoryGoodsCB;
        private System.Windows.Forms.TextBox goodsManufacturerTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button manufacturerFilterButton;
        private System.Windows.Forms.Button shopShowAllButton;
        private System.Windows.Forms.ToolStripMenuItem графикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новоеНаименованиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem программноеОбеспечениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem комплектующееToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem товарыНаСкладеToolStripMenuItem1;
        private System.Windows.Forms.Button changeDescriptionButton;
        private System.Windows.Forms.Button changeCharacteristicsButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}