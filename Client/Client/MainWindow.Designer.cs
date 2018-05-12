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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.stationaryGoodsDGV = new System.Windows.Forms.DataGridView();
            this.stationaryGoods = new Client.StationaryGoods();
            this.stationaryGoodsCategoryCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.showAllGoodsButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.опрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.корзинаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descriptionButton = new System.Windows.Forms.Button();
            this.stationaryLowPriceTB = new System.Windows.Forms.TextBox();
            this.stationaryHighPriceTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.costButton = new System.Windows.Forms.Button();
            this.ManufacturerButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.stationaryManufacturerTB = new System.Windows.Forms.TextBox();
            this.basketButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.stationaryGoodsNameTB = new System.Windows.Forms.TextBox();
            this.categoryGoodsQuantityChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.stationaryGoodsQuantity = new Client.StationaryGoodsQuantity();
            this.dataTableTableAdapter1 = new Client.StationaryGoodsQuantityTableAdapters.DataTableTableAdapter();
            this.dataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTableTableAdapter = new Client.StationaryGoodsTableAdapters.DataTableTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.stationaryGoodsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationaryGoods)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryGoodsQuantityChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationaryGoodsQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // stationaryGoodsDGV
            // 
            this.stationaryGoodsDGV.AllowUserToAddRows = false;
            this.stationaryGoodsDGV.AllowUserToDeleteRows = false;
            this.stationaryGoodsDGV.AllowUserToResizeColumns = false;
            this.stationaryGoodsDGV.AllowUserToResizeRows = false;
            this.stationaryGoodsDGV.AutoGenerateColumns = false;
            this.stationaryGoodsDGV.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.stationaryGoodsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stationaryGoodsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.goodsIDDataGridViewTextBoxColumn});
            this.stationaryGoodsDGV.DataSource = this.dataTableBindingSource;
            this.stationaryGoodsDGV.Location = new System.Drawing.Point(12, 76);
            this.stationaryGoodsDGV.Name = "stationaryGoodsDGV";
            this.stationaryGoodsDGV.ReadOnly = true;
            this.stationaryGoodsDGV.Size = new System.Drawing.Size(545, 246);
            this.stationaryGoodsDGV.TabIndex = 2;
            // 
            // stationaryGoods
            // 
            this.stationaryGoods.DataSetName = "StationaryGoods";
            this.stationaryGoods.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stationaryGoodsCategoryCB
            // 
            this.stationaryGoodsCategoryCB.FormattingEnabled = true;
            this.stationaryGoodsCategoryCB.Location = new System.Drawing.Point(12, 49);
            this.stationaryGoodsCategoryCB.Name = "stationaryGoodsCategoryCB";
            this.stationaryGoodsCategoryCB.Size = new System.Drawing.Size(188, 21);
            this.stationaryGoodsCategoryCB.TabIndex = 6;
            this.stationaryGoodsCategoryCB.SelectedIndexChanged += new System.EventHandler(this.goodsCategoryCB_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 33);
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
            this.showAllGoodsButton.Click += new System.EventHandler(this.allGoodsListButton_Click);
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
            // stationaryLowPriceTB
            // 
            this.stationaryLowPriceTB.Location = new System.Drawing.Point(603, 138);
            this.stationaryLowPriceTB.MaxLength = 10;
            this.stationaryLowPriceTB.Name = "stationaryLowPriceTB";
            this.stationaryLowPriceTB.Size = new System.Drawing.Size(80, 20);
            this.stationaryLowPriceTB.TabIndex = 12;
            this.stationaryLowPriceTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lowPriceTB_KeyPress);
            // 
            // stationaryHighPriceTB
            // 
            this.stationaryHighPriceTB.Location = new System.Drawing.Point(603, 164);
            this.stationaryHighPriceTB.MaxLength = 10;
            this.stationaryHighPriceTB.Name = "stationaryHighPriceTB";
            this.stationaryHighPriceTB.Size = new System.Drawing.Size(80, 20);
            this.stationaryHighPriceTB.TabIndex = 13;
            this.stationaryHighPriceTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.highPriceTB_KeyPress);
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
            // ManufacturerButton
            // 
            this.ManufacturerButton.Location = new System.Drawing.Point(577, 277);
            this.ManufacturerButton.Name = "ManufacturerButton";
            this.ManufacturerButton.Size = new System.Drawing.Size(100, 23);
            this.ManufacturerButton.TabIndex = 18;
            this.ManufacturerButton.Text = "Отфильтровать";
            this.ManufacturerButton.UseVisualStyleBackColor = true;
            this.ManufacturerButton.Click += new System.EventHandler(this.filterManufacturerButton_Click);
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
            // stationaryManufacturerTB
            // 
            this.stationaryManufacturerTB.Location = new System.Drawing.Point(577, 251);
            this.stationaryManufacturerTB.Name = "stationaryManufacturerTB";
            this.stationaryManufacturerTB.Size = new System.Drawing.Size(100, 20);
            this.stationaryManufacturerTB.TabIndex = 20;
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
            // stationaryGoodsNameTB
            // 
            this.stationaryGoodsNameTB.Location = new System.Drawing.Point(577, 343);
            this.stationaryGoodsNameTB.Name = "stationaryGoodsNameTB";
            this.stationaryGoodsNameTB.Size = new System.Drawing.Size(100, 20);
            this.stationaryGoodsNameTB.TabIndex = 23;
            this.stationaryGoodsNameTB.TextChanged += new System.EventHandler(this.goodsNameTB_TextChanged);
            // 
            // categoryGoodsQuantityChart
            // 
            this.categoryGoodsQuantityChart.BackColor = System.Drawing.SystemColors.Control;
            chartArea4.AxisX.Title = "Категория комплектующего";
            chartArea4.AxisY.Title = "Количество";
            chartArea4.Name = "ChartArea1";
            this.categoryGoodsQuantityChart.ChartAreas.Add(chartArea4);
            this.categoryGoodsQuantityChart.DataSource = this.dataTableBindingSource1;
            legend4.BackColor = System.Drawing.SystemColors.Control;
            legend4.Name = "Legend1";
            this.categoryGoodsQuantityChart.Legends.Add(legend4);
            this.categoryGoodsQuantityChart.Location = new System.Drawing.Point(21, 386);
            this.categoryGoodsQuantityChart.Name = "categoryGoodsQuantityChart";
            series4.ChartArea = "ChartArea1";
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            series4.XValueMember = "CategoryGoodsName";
            series4.YValueMembers = "Quantity";
            this.categoryGoodsQuantityChart.Series.Add(series4);
            this.categoryGoodsQuantityChart.Size = new System.Drawing.Size(586, 322);
            this.categoryGoodsQuantityChart.TabIndex = 24;
            this.categoryGoodsQuantityChart.Text = "Количество типов товаров";
            // 
            // dataTableBindingSource1
            // 
            this.dataTableBindingSource1.DataMember = "DataTable";
            this.dataTableBindingSource1.DataSource = this.stationaryGoodsQuantity;
            // 
            // stationaryGoodsQuantity
            // 
            this.stationaryGoodsQuantity.DataSetName = "StationaryGoodsQuantity";
            this.stationaryGoodsQuantity.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTableTableAdapter1
            // 
            this.dataTableTableAdapter1.ClearBeforeFill = true;
            // 
            // dataTableBindingSource
            // 
            this.dataTableBindingSource.DataMember = "DataTable";
            this.dataTableBindingSource.DataSource = this.stationaryGoods;
            // 
            // dataTableTableAdapter
            // 
            this.dataTableTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TypeCategoryName";
            this.dataGridViewTextBoxColumn1.HeaderText = "TypeCategoryName";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CategoryGoodsName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Тип";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "GoodsName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 180;
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
            this.dataGridViewTextBoxColumn5.DataPropertyName = "GoodsCost";
            this.dataGridViewTextBoxColumn5.HeaderText = "Цена";
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
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.categoryGoodsQuantityChart);
            this.Controls.Add(this.stationaryGoodsNameTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.basketButton);
            this.Controls.Add(this.stationaryManufacturerTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ManufacturerButton);
            this.Controls.Add(this.costButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.stationaryHighPriceTB);
            this.Controls.Add(this.stationaryLowPriceTB);
            this.Controls.Add(this.descriptionButton);
            this.Controls.Add(this.showAllGoodsButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stationaryGoodsCategoryCB);
            this.Controls.Add(this.stationaryGoodsDGV);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 736);
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.stationaryGoodsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationaryGoods)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryGoodsQuantityChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationaryGoodsQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryGoodsNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsManufacturerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeCategoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView stationaryGoodsDGV;
        private System.Windows.Forms.ComboBox stationaryGoodsCategoryCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button showAllGoodsButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem опрограммеToolStripMenuItem;
        private System.Windows.Forms.Button descriptionButton;
        private System.Windows.Forms.TextBox stationaryLowPriceTB;
        private System.Windows.Forms.TextBox stationaryHighPriceTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button costButton;
        private System.Windows.Forms.Button ManufacturerButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox stationaryManufacturerTB;
        private System.Windows.Forms.ToolStripMenuItem корзинаToolStripMenuItem;
        private System.Windows.Forms.Button basketButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox stationaryGoodsNameTB;
        private StationaryGoods stationaryGoods;
        private System.Windows.Forms.DataVisualization.Charting.Chart categoryGoodsQuantityChart;
        private StationaryGoodsQuantity stationaryGoodsQuantity;
        private System.Windows.Forms.BindingSource dataTableBindingSource1;
        private StationaryGoodsQuantityTableAdapters.DataTableTableAdapter dataTableTableAdapter1;
        private System.Windows.Forms.BindingSource dataTableBindingSource;
        private StationaryGoodsTableAdapters.DataTableTableAdapter dataTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsIDDataGridViewTextBoxColumn;
    }
}

