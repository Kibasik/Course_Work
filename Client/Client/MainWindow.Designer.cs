namespace Client
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.goodsDGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.goods = new Client.Goods();
            this.goodsCategoryCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.showAllGoodsButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.опрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.корзинаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дополнительноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.программноеОбеспечениеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.дополнительныеУслугиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сервисноеОбслуживаниеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.доставкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descriptionButton = new System.Windows.Forms.Button();
            this.lowPriceTB = new System.Windows.Forms.TextBox();
            this.highPriceTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.costButton = new System.Windows.Forms.Button();
            this.manufacturerButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.manufacturerTB = new System.Windows.Forms.TextBox();
            this.basketButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.goodsNameTB = new System.Windows.Forms.TextBox();
            this.goodsQuantityChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goodsQuantity = new Client.GoodsQuantity();
            this.dataTableTableAdapter = new Client.GoodsQuantityTableAdapters.DataTableTableAdapter();
            this.dataTableTableAdapter1 = new Client.GoodsTableAdapters.DataTableTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.goodsTypeCB = new System.Windows.Forms.ComboBox();
            this.дополнительнвеУслугиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goodsQuantityTB = new System.Windows.Forms.TextBox();
            this.goodsPriceListButton = new System.Windows.Forms.Button();
            this.goodsPriceListReport = new FastReport.Report();
            ((System.ComponentModel.ISupportInitialize)(this.goodsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goods)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goodsQuantityChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsPriceListReport)).BeginInit();
            this.SuspendLayout();
            // 
            // goodsDGV
            // 
            this.goodsDGV.AllowUserToAddRows = false;
            this.goodsDGV.AllowUserToDeleteRows = false;
            this.goodsDGV.AllowUserToResizeRows = false;
            this.goodsDGV.AutoGenerateColumns = false;
            this.goodsDGV.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.goodsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.goodsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.goodsIDDataGridViewTextBoxColumn});
            this.goodsDGV.DataSource = this.dataTableBindingSource1;
            this.goodsDGV.Location = new System.Drawing.Point(12, 76);
            this.goodsDGV.Name = "goodsDGV";
            this.goodsDGV.ReadOnly = true;
            this.goodsDGV.Size = new System.Drawing.Size(545, 246);
            this.goodsDGV.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TypeCategoryName";
            this.dataGridViewTextBoxColumn1.HeaderText = "Тип";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CategoryGoodsName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Категория";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "GoodsManufacturerName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Производитель";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "GoodsName";
            this.dataGridViewTextBoxColumn4.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "GoodsCost";
            this.dataGridViewTextBoxColumn5.HeaderText = "Цена, руб.";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // goodsIDDataGridViewTextBoxColumn
            // 
            this.goodsIDDataGridViewTextBoxColumn.DataPropertyName = "GoodsID";
            this.goodsIDDataGridViewTextBoxColumn.HeaderText = "GoodsID";
            this.goodsIDDataGridViewTextBoxColumn.Name = "goodsIDDataGridViewTextBoxColumn";
            this.goodsIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.goodsIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataTableBindingSource1
            // 
            this.dataTableBindingSource1.DataMember = "DataTable";
            this.dataTableBindingSource1.DataSource = this.goods;
            this.dataTableBindingSource1.Position = 0;
            // 
            // goods
            // 
            this.goods.DataSetName = "Goods";
            this.goods.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // goodsCategoryCB
            // 
            this.goodsCategoryCB.FormattingEnabled = true;
            this.goodsCategoryCB.Location = new System.Drawing.Point(224, 49);
            this.goodsCategoryCB.Name = "goodsCategoryCB";
            this.goodsCategoryCB.Size = new System.Drawing.Size(188, 21);
            this.goodsCategoryCB.TabIndex = 6;
            this.goodsCategoryCB.SelectedIndexChanged += new System.EventHandler(this.goodsCategoryCB_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Категория комплектующего:";
            // 
            // showAllGoodsButton
            // 
            this.showAllGoodsButton.Location = new System.Drawing.Point(459, 25);
            this.showAllGoodsButton.Name = "showAllGoodsButton";
            this.showAllGoodsButton.Size = new System.Drawing.Size(98, 42);
            this.showAllGoodsButton.TabIndex = 9;
            this.showAllGoodsButton.Text = "Показать весь список";
            this.showAllGoodsButton.UseVisualStyleBackColor = true;
            this.showAllGoodsButton.Click += new System.EventHandler(this.showAllGoodsButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.корзинаToolStripMenuItem,
            this.дополнительноToolStripMenuItem,
            this.доставкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "&Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.выходToolStripMenuItem.Text = "Вы&ход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.опрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Спра&вка";
            // 
            // опрограммеToolStripMenuItem
            // 
            this.опрограммеToolStripMenuItem.Name = "опрограммеToolStripMenuItem";
            this.опрограммеToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.опрограммеToolStripMenuItem.Text = "&О программе...";
            this.опрограммеToolStripMenuItem.Click += new System.EventHandler(this.опрограммеToolStripMenuItem_Click);
            // 
            // корзинаToolStripMenuItem
            // 
            this.корзинаToolStripMenuItem.Name = "корзинаToolStripMenuItem";
            this.корзинаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.корзинаToolStripMenuItem.Text = "&Корзина";
            this.корзинаToolStripMenuItem.Click += new System.EventHandler(this.корзинаToolStripMenuItem_Click);
            // 
            // дополнительноToolStripMenuItem
            // 
            this.дополнительноToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.программноеОбеспечениеToolStripMenuItem1,
            this.дополнительныеУслугиToolStripMenuItem1,
            this.сервисноеОбслуживаниеToolStripMenuItem1});
            this.дополнительноToolStripMenuItem.Name = "дополнительноToolStripMenuItem";
            this.дополнительноToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.дополнительноToolStripMenuItem.Text = "&Дополнительно";
            // 
            // программноеОбеспечениеToolStripMenuItem1
            // 
            this.программноеОбеспечениеToolStripMenuItem1.Name = "программноеОбеспечениеToolStripMenuItem1";
            this.программноеОбеспечениеToolStripMenuItem1.Size = new System.Drawing.Size(228, 22);
            this.программноеОбеспечениеToolStripMenuItem1.Text = "&Программное обеспечение";
            this.программноеОбеспечениеToolStripMenuItem1.Click += new System.EventHandler(this.программноеОбеспечениеToolStripMenuItem1_Click);
            // 
            // дополнительныеУслугиToolStripMenuItem1
            // 
            this.дополнительныеУслугиToolStripMenuItem1.Name = "дополнительныеУслугиToolStripMenuItem1";
            this.дополнительныеУслугиToolStripMenuItem1.Size = new System.Drawing.Size(228, 22);
            this.дополнительныеУслугиToolStripMenuItem1.Text = "&Дополнительные услуги";
            this.дополнительныеУслугиToolStripMenuItem1.Click += new System.EventHandler(this.дополнительныеУслугиToolStripMenuItem1_Click);
            // 
            // сервисноеОбслуживаниеToolStripMenuItem1
            // 
            this.сервисноеОбслуживаниеToolStripMenuItem1.Name = "сервисноеОбслуживаниеToolStripMenuItem1";
            this.сервисноеОбслуживаниеToolStripMenuItem1.Size = new System.Drawing.Size(228, 22);
            this.сервисноеОбслуживаниеToolStripMenuItem1.Text = "&Сервисное обслуживание";
            this.сервисноеОбслуживаниеToolStripMenuItem1.Click += new System.EventHandler(this.сервисноеОбслуживаниеToolStripMenuItem1_Click);
            // 
            // доставкаToolStripMenuItem
            // 
            this.доставкаToolStripMenuItem.Name = "доставкаToolStripMenuItem";
            this.доставкаToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.доставкаToolStripMenuItem.Text = "&Доставка";
            this.доставкаToolStripMenuItem.Click += new System.EventHandler(this.доставкаToolStripMenuItem_Click);
            // 
            // descriptionButton
            // 
            this.descriptionButton.Location = new System.Drawing.Point(577, 76);
            this.descriptionButton.Name = "descriptionButton";
            this.descriptionButton.Size = new System.Drawing.Size(75, 23);
            this.descriptionButton.TabIndex = 11;
            this.descriptionButton.Text = "Описание";
            this.descriptionButton.UseVisualStyleBackColor = true;
            this.descriptionButton.Click += new System.EventHandler(this.descriptionButton_Click);
            // 
            // lowPriceTB
            // 
            this.lowPriceTB.Location = new System.Drawing.Point(603, 138);
            this.lowPriceTB.MaxLength = 10;
            this.lowPriceTB.Name = "lowPriceTB";
            this.lowPriceTB.Size = new System.Drawing.Size(80, 20);
            this.lowPriceTB.TabIndex = 12;
            this.lowPriceTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lowPriceTB_KeyPress);
            // 
            // highPriceTB
            // 
            this.highPriceTB.Location = new System.Drawing.Point(603, 164);
            this.highPriceTB.MaxLength = 10;
            this.highPriceTB.Name = "highPriceTB";
            this.highPriceTB.Size = new System.Drawing.Size(80, 20);
            this.highPriceTB.TabIndex = 13;
            this.highPriceTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.highPriceTB_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(574, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Введите стоимость:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(574, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "От:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(574, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "До:";
            // 
            // costButton
            // 
            this.costButton.Location = new System.Drawing.Point(577, 190);
            this.costButton.Name = "costButton";
            this.costButton.Size = new System.Drawing.Size(75, 23);
            this.costButton.TabIndex = 17;
            this.costButton.Text = "Применить";
            this.costButton.UseVisualStyleBackColor = true;
            this.costButton.Click += new System.EventHandler(this.costButton_Click);
            // 
            // manufacturerButton
            // 
            this.manufacturerButton.Location = new System.Drawing.Point(577, 277);
            this.manufacturerButton.Name = "manufacturerButton";
            this.manufacturerButton.Size = new System.Drawing.Size(100, 23);
            this.manufacturerButton.TabIndex = 18;
            this.manufacturerButton.Text = "Отфильтровать";
            this.manufacturerButton.UseVisualStyleBackColor = true;
            this.manufacturerButton.Click += new System.EventHandler(this.manufacturerButton_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(574, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Введите фирму производитель:";
            // 
            // manufacturerTB
            // 
            this.manufacturerTB.Location = new System.Drawing.Point(577, 251);
            this.manufacturerTB.Name = "manufacturerTB";
            this.manufacturerTB.Size = new System.Drawing.Size(100, 20);
            this.manufacturerTB.TabIndex = 20;
            // 
            // basketButton
            // 
            this.basketButton.Location = new System.Drawing.Point(12, 343);
            this.basketButton.Name = "basketButton";
            this.basketButton.Size = new System.Drawing.Size(75, 37);
            this.basketButton.TabIndex = 21;
            this.basketButton.Text = "Добавить в корзину";
            this.basketButton.UseVisualStyleBackColor = true;
            this.basketButton.Click += new System.EventHandler(this.basketButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(574, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Введите наименование товара:";
            // 
            // goodsNameTB
            // 
            this.goodsNameTB.Location = new System.Drawing.Point(577, 343);
            this.goodsNameTB.Name = "goodsNameTB";
            this.goodsNameTB.Size = new System.Drawing.Size(100, 20);
            this.goodsNameTB.TabIndex = 23;
            this.goodsNameTB.TextChanged += new System.EventHandler(this.goodsNameTB_TextChanged_1);
            // 
            // goodsQuantityChart
            // 
            this.goodsQuantityChart.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.AxisX.Title = "Категория комплектующего";
            chartArea1.AxisY.Title = "Количество";
            chartArea1.Name = "ChartArea1";
            this.goodsQuantityChart.ChartAreas.Add(chartArea1);
            this.goodsQuantityChart.DataSource = this.dataTableBindingSource;
            this.goodsQuantityChart.Location = new System.Drawing.Point(21, 386);
            this.goodsQuantityChart.Name = "goodsQuantityChart";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Name = "Series1";
            series1.XValueMember = "CategoryGoodsName";
            series1.YValueMembers = "Quantity";
            this.goodsQuantityChart.Series.Add(series1);
            this.goodsQuantityChart.Size = new System.Drawing.Size(586, 322);
            this.goodsQuantityChart.TabIndex = 24;
            this.goodsQuantityChart.Text = "Количество товаров";
            // 
            // dataTableBindingSource
            // 
            this.dataTableBindingSource.DataMember = "DataTable";
            this.dataTableBindingSource.DataSource = this.goodsQuantity;
            // 
            // goodsQuantity
            // 
            this.goodsQuantity.DataSetName = "GoodsQuantity";
            this.goodsQuantity.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTableTableAdapter
            // 
            this.dataTableTableAdapter.ClearBeforeFill = true;
            // 
            // dataTableTableAdapter1
            // 
            this.dataTableTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Тип комплектующего:";
            // 
            // goodsTypeCB
            // 
            this.goodsTypeCB.FormattingEnabled = true;
            this.goodsTypeCB.Location = new System.Drawing.Point(12, 49);
            this.goodsTypeCB.Name = "goodsTypeCB";
            this.goodsTypeCB.Size = new System.Drawing.Size(157, 21);
            this.goodsTypeCB.TabIndex = 26;
            this.goodsTypeCB.SelectedIndexChanged += new System.EventHandler(this.goodsTypeCB_SelectedIndexChanged);
            // 
            // дополнительнвеУслугиToolStripMenuItem
            // 
            this.дополнительнвеУслугиToolStripMenuItem.Name = "дополнительнвеУслугиToolStripMenuItem";
            this.дополнительнвеУслугиToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.дополнительнвеУслугиToolStripMenuItem.Text = "Дополнительные услуги";
            // 
            // goodsQuantityTB
            // 
            this.goodsQuantityTB.Location = new System.Drawing.Point(102, 360);
            this.goodsQuantityTB.MaxLength = 3;
            this.goodsQuantityTB.Name = "goodsQuantityTB";
            this.goodsQuantityTB.Size = new System.Drawing.Size(100, 20);
            this.goodsQuantityTB.TabIndex = 27;
            this.goodsQuantityTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.goodsQuantityTB_KeyPress);
            // 
            // goodsPriceListButton
            // 
            this.goodsPriceListButton.Location = new System.Drawing.Point(907, 27);
            this.goodsPriceListButton.Name = "goodsPriceListButton";
            this.goodsPriceListButton.Size = new System.Drawing.Size(89, 34);
            this.goodsPriceListButton.TabIndex = 28;
            this.goodsPriceListButton.Text = "Показать прайс-лист";
            this.goodsPriceListButton.UseVisualStyleBackColor = true;
            this.goodsPriceListButton.Click += new System.EventHandler(this.goodsPriceListButton_Click);
            // 
            // goodsPriceListReport
            // 
            this.goodsPriceListReport.NeedRefresh = false;
            this.goodsPriceListReport.ReportResourceString = resources.GetString("goodsPriceListReport.ReportResourceString");
            this.goodsPriceListReport.RegisterData(this.goods, "goods");
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.goodsPriceListButton);
            this.Controls.Add(this.goodsQuantityTB);
            this.Controls.Add(this.goodsTypeCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.goodsQuantityChart);
            this.Controls.Add(this.goodsNameTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.basketButton);
            this.Controls.Add(this.manufacturerTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.manufacturerButton);
            this.Controls.Add(this.costButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.highPriceTB);
            this.Controls.Add(this.lowPriceTB);
            this.Controls.Add(this.descriptionButton);
            this.Controls.Add(this.showAllGoodsButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.goodsCategoryCB);
            this.Controls.Add(this.goodsDGV);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 736);
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.Text = "MainWIndow";
            this.Load += new System.EventHandler(this.MainWindow_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.goodsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goods)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goodsQuantityChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsPriceListReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryGoodsNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsManufacturerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeCategoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView goodsDGV;
        private System.Windows.Forms.ComboBox goodsCategoryCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button showAllGoodsButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem опрограммеToolStripMenuItem;
        private System.Windows.Forms.Button descriptionButton;
        private System.Windows.Forms.TextBox lowPriceTB;
        private System.Windows.Forms.TextBox highPriceTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button costButton;
        private System.Windows.Forms.Button manufacturerButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox manufacturerTB;
        private System.Windows.Forms.ToolStripMenuItem корзинаToolStripMenuItem;
        private System.Windows.Forms.Button basketButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox goodsNameTB;
        private System.Windows.Forms.DataVisualization.Charting.Chart goodsQuantityChart;
        private GoodsQuantity goodsQuantity;
        private System.Windows.Forms.BindingSource dataTableBindingSource;
        private GoodsQuantityTableAdapters.DataTableTableAdapter dataTableTableAdapter;
        private Goods goods;
        private System.Windows.Forms.BindingSource dataTableBindingSource1;
        private GoodsTableAdapters.DataTableTableAdapter dataTableTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox goodsTypeCB;
        private System.Windows.Forms.ToolStripMenuItem доставкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дополнительнвеУслугиToolStripMenuItem;
        private System.Windows.Forms.TextBox goodsQuantityTB;
        private System.Windows.Forms.ToolStripMenuItem дополнительноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem программноеОбеспечениеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem дополнительныеУслугиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сервисноеОбслуживаниеToolStripMenuItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button goodsPriceListButton;
        private FastReport.Report goodsPriceListReport;
    }
}

