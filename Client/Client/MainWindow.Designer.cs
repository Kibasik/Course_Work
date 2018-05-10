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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.goodsListDGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goodsCatalogForClient = new Client.GoodsCatalogForClient();
            this.stationaryRB = new System.Windows.Forms.RadioButton();
            this.mobileRB = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.goodsCategoryCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.allGoodsListButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.опрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.корзинаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descriptionButton = new System.Windows.Forms.Button();
            this.lowPriceTB = new System.Windows.Forms.TextBox();
            this.highPriceTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.costButton = new System.Windows.Forms.Button();
            this.filterManufacturerButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.manufacturerTB = new System.Windows.Forms.TextBox();
            this.basketButton = new System.Windows.Forms.Button();
            this.dataTableTableAdapter = new Client.GoodsCatalogForClientTableAdapters.DataTableTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.goodsNameTB = new System.Windows.Forms.TextBox();
            this.categoryGoodsQuantityChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.categoryGoodsQuantity = new Client.CategoryGoodsQuantity();
            this.dataTableTableAdapter1 = new Client.CategoryGoodsQuantityTableAdapters.DataTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.goodsListDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsCatalogForClient)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryGoodsQuantityChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryGoodsQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // goodsListDGV
            // 
            this.goodsListDGV.AllowUserToAddRows = false;
            this.goodsListDGV.AllowUserToDeleteRows = false;
            this.goodsListDGV.AllowUserToResizeColumns = false;
            this.goodsListDGV.AllowUserToResizeRows = false;
            this.goodsListDGV.AutoGenerateColumns = false;
            this.goodsListDGV.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.goodsListDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.goodsListDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.goodsIDDataGridViewTextBoxColumn});
            this.goodsListDGV.DataSource = this.dataTableBindingSource;
            this.goodsListDGV.Location = new System.Drawing.Point(12, 73);
            this.goodsListDGV.Name = "goodsListDGV";
            this.goodsListDGV.ReadOnly = true;
            this.goodsListDGV.Size = new System.Drawing.Size(545, 246);
            this.goodsListDGV.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "GoodsName";
            this.dataGridViewTextBoxColumn1.HeaderText = "Наименование";
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "GoodsCost";
            this.dataGridViewTextBoxColumn3.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "GoodsManufacturerName";
            this.dataGridViewTextBoxColumn4.HeaderText = "Производитель";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TypeCategoryName";
            this.dataGridViewTextBoxColumn5.HeaderText = "Тип";
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
            // dataTableBindingSource
            // 
            this.dataTableBindingSource.DataMember = "DataTable";
            this.dataTableBindingSource.DataSource = this.goodsCatalogForClient;
            // 
            // goodsCatalogForClient
            // 
            this.goodsCatalogForClient.DataSetName = "GoodsCatalogForClient";
            this.goodsCatalogForClient.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stationaryRB
            // 
            this.stationaryRB.AutoSize = true;
            this.stationaryRB.Location = new System.Drawing.Point(12, 50);
            this.stationaryRB.Name = "stationaryRB";
            this.stationaryRB.Size = new System.Drawing.Size(97, 17);
            this.stationaryRB.TabIndex = 3;
            this.stationaryRB.TabStop = true;
            this.stationaryRB.Text = "Стационарное";
            this.stationaryRB.UseVisualStyleBackColor = true;
            this.stationaryRB.CheckedChanged += new System.EventHandler(this.stationaryRB_CheckedChanged_1);
            // 
            // mobileRB
            // 
            this.mobileRB.AutoSize = true;
            this.mobileRB.Location = new System.Drawing.Point(118, 50);
            this.mobileRB.Name = "mobileRB";
            this.mobileRB.Size = new System.Drawing.Size(82, 17);
            this.mobileRB.TabIndex = 4;
            this.mobileRB.TabStop = true;
            this.mobileRB.Text = "Мобильное";
            this.mobileRB.UseVisualStyleBackColor = true;
            this.mobileRB.CheckedChanged += new System.EventHandler(this.mobileRB_CheckedChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Тип комплектующего:";
            // 
            // goodsCategoryCB
            // 
            this.goodsCategoryCB.FormattingEnabled = true;
            this.goodsCategoryCB.Location = new System.Drawing.Point(231, 49);
            this.goodsCategoryCB.Name = "goodsCategoryCB";
            this.goodsCategoryCB.Size = new System.Drawing.Size(188, 21);
            this.goodsCategoryCB.TabIndex = 6;
            this.goodsCategoryCB.SelectedIndexChanged += new System.EventHandler(this.goodsCategoryCB_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Категория комплектующего:";
            // 
            // allGoodsListButton
            // 
            this.allGoodsListButton.Location = new System.Drawing.Point(449, 28);
            this.allGoodsListButton.Name = "allGoodsListButton";
            this.allGoodsListButton.Size = new System.Drawing.Size(98, 42);
            this.allGoodsListButton.TabIndex = 9;
            this.allGoodsListButton.Text = "Показать весь список";
            this.allGoodsListButton.UseVisualStyleBackColor = true;
            this.allGoodsListButton.Click += new System.EventHandler(this.allGoodsListButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.корзинаToolStripMenuItem});
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
            this.costButton.Click += new System.EventHandler(this.costButton_Click_1);
            // 
            // filterManufacturerButton
            // 
            this.filterManufacturerButton.Location = new System.Drawing.Point(577, 277);
            this.filterManufacturerButton.Name = "filterManufacturerButton";
            this.filterManufacturerButton.Size = new System.Drawing.Size(100, 23);
            this.filterManufacturerButton.TabIndex = 18;
            this.filterManufacturerButton.Text = "Отфильтровать";
            this.filterManufacturerButton.UseVisualStyleBackColor = true;
            this.filterManufacturerButton.Click += new System.EventHandler(this.filterManufacturerButton_Click);
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
            // dataTableTableAdapter
            // 
            this.dataTableTableAdapter.ClearBeforeFill = true;
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
            this.goodsNameTB.TextChanged += new System.EventHandler(this.goodsNameTB_TextChanged);
            this.goodsNameTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.goodsNameTB_KeyPress);
            // 
            // categoryGoodsQuantityChart
            // 
            chartArea1.AxisX.Title = "Категория комплектующего";
            chartArea1.AxisY.Title = "Количество";
            chartArea1.Name = "ChartArea1";
            this.categoryGoodsQuantityChart.ChartAreas.Add(chartArea1);
            this.categoryGoodsQuantityChart.DataSource = this.dataTableBindingSource1;
            legend1.Name = "Legend1";
            this.categoryGoodsQuantityChart.Legends.Add(legend1);
            this.categoryGoodsQuantityChart.Location = new System.Drawing.Point(21, 386);
            this.categoryGoodsQuantityChart.Name = "categoryGoodsQuantityChart";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueMember = "CategoryGoodsName";
            series1.YValueMembers = "Quantity";
            this.categoryGoodsQuantityChart.Series.Add(series1);
            this.categoryGoodsQuantityChart.Size = new System.Drawing.Size(586, 322);
            this.categoryGoodsQuantityChart.TabIndex = 24;
            this.categoryGoodsQuantityChart.Text = "Количество типов товаров";
            // 
            // dataTableBindingSource1
            // 
            this.dataTableBindingSource1.DataMember = "DataTable";
            this.dataTableBindingSource1.DataSource = this.categoryGoodsQuantity;
            // 
            // categoryGoodsQuantity
            // 
            this.categoryGoodsQuantity.DataSetName = "CategoryGoodsQuantity";
            this.categoryGoodsQuantity.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTableTableAdapter1
            // 
            this.dataTableTableAdapter1.ClearBeforeFill = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.categoryGoodsQuantityChart);
            this.Controls.Add(this.goodsNameTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.basketButton);
            this.Controls.Add(this.manufacturerTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.filterManufacturerButton);
            this.Controls.Add(this.costButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.highPriceTB);
            this.Controls.Add(this.lowPriceTB);
            this.Controls.Add(this.descriptionButton);
            this.Controls.Add(this.allGoodsListButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.goodsCategoryCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mobileRB);
            this.Controls.Add(this.stationaryRB);
            this.Controls.Add(this.goodsListDGV);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.goodsListDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsCatalogForClient)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryGoodsQuantityChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryGoodsQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryGoodsNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsManufacturerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeCategoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView goodsListDGV;
        private GoodsCatalogForClient goodsCatalogForClient;
        private System.Windows.Forms.BindingSource dataTableBindingSource;
        private GoodsCatalogForClientTableAdapters.DataTableTableAdapter dataTableTableAdapter;
        private System.Windows.Forms.RadioButton stationaryRB;
        private System.Windows.Forms.RadioButton mobileRB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox goodsCategoryCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button allGoodsListButton;
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
        private System.Windows.Forms.Button filterManufacturerButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox manufacturerTB;
        private System.Windows.Forms.ToolStripMenuItem корзинаToolStripMenuItem;
        private System.Windows.Forms.Button basketButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox goodsNameTB;
        private System.Windows.Forms.DataVisualization.Charting.Chart categoryGoodsQuantityChart;
        private CategoryGoodsQuantity categoryGoodsQuantity;
        private System.Windows.Forms.BindingSource dataTableBindingSource1;
        private CategoryGoodsQuantityTableAdapters.DataTableTableAdapter dataTableTableAdapter1;
    }
}

