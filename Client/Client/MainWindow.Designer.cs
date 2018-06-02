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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.goodsDGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodsAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.goods = new Client.Goods();
            this.goodsCategoryCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.showAllGoodsButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.опрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.корзинаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дополнительноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.программноеОбеспечениеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.дополнительныеУслугиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сервисноеОбслуживаниеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сборкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.графикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.полныйПрайслистToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прайслистКомплектующихToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прайслистДопУслугToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прайслистСервисногоОбслуживанияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прайслистПОToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.количествоТовараВМагазинеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.dataTableTableAdapter1 = new Client.GoodsTableAdapters.DataTableTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.goodsTypeCB = new System.Windows.Forms.ComboBox();
            this.дополнительнвеУслугиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goodsQuantityTB = new System.Windows.Forms.TextBox();
            this.componentsPriceListReport = new FastReport.Report();
            this.fullPriceListReport = new FastReport.Report();
            this.label9 = new System.Windows.Forms.Label();
            this.goodsQuantityReport = new FastReport.Report();
            this.additionalServicesPriceListReport = new FastReport.Report();
            this.softwarePriceListReport = new FastReport.Report();
            this.serviceMaintenancePriceListReport = new FastReport.Report();
            this.label11 = new System.Windows.Forms.Label();
            this.basketQuantityLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.goodsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goods)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.componentsPriceListReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullPriceListReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsQuantityReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.additionalServicesPriceListReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwarePriceListReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceMaintenancePriceListReport)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
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
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.goodsIDDataGridViewTextBoxColumn,
            this.GoodsAmount});
            this.goodsDGV.DataSource = this.dataTableBindingSource1;
            this.goodsDGV.Location = new System.Drawing.Point(6, 19);
            this.goodsDGV.Name = "goodsDGV";
            this.goodsDGV.ReadOnly = true;
            this.goodsDGV.Size = new System.Drawing.Size(644, 208);
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
            // GoodsAmount
            // 
            this.GoodsAmount.DataPropertyName = "GoodsAmount";
            this.GoodsAmount.HeaderText = "Количество";
            this.GoodsAmount.Name = "GoodsAmount";
            this.GoodsAmount.ReadOnly = true;
            // 
            // dataTableBindingSource1
            // 
            this.dataTableBindingSource1.DataMember = "DataTable";
            this.dataTableBindingSource1.DataSource = this.goods;
            // 
            // goods
            // 
            this.goods.DataSetName = "Goods";
            this.goods.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // goodsCategoryCB
            // 
            this.goodsCategoryCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.goodsCategoryCB.FormattingEnabled = true;
            this.goodsCategoryCB.Location = new System.Drawing.Point(9, 81);
            this.goodsCategoryCB.Name = "goodsCategoryCB";
            this.goodsCategoryCB.Size = new System.Drawing.Size(188, 21);
            this.goodsCategoryCB.TabIndex = 6;
            this.goodsCategoryCB.SelectedIndexChanged += new System.EventHandler(this.goodsCategoryCB_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Категория комплектующего:";
            // 
            // showAllGoodsButton
            // 
            this.showAllGoodsButton.Location = new System.Drawing.Point(9, 256);
            this.showAllGoodsButton.Name = "showAllGoodsButton";
            this.showAllGoodsButton.Size = new System.Drawing.Size(201, 25);
            this.showAllGoodsButton.TabIndex = 9;
            this.showAllGoodsButton.Text = "Показать весь список";
            this.showAllGoodsButton.UseVisualStyleBackColor = true;
            this.showAllGoodsButton.Click += new System.EventHandler(this.showAllGoodsButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem,
            this.корзинаToolStripMenuItem,
            this.дополнительноToolStripMenuItem,
            this.сборкаToolStripMenuItem,
            this.графикиToolStripMenuItem,
            this.сотрудникиToolStripMenuItem,
            this.отчетыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(904, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
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
            // сборкаToolStripMenuItem
            // 
            this.сборкаToolStripMenuItem.Name = "сборкаToolStripMenuItem";
            this.сборкаToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.сборкаToolStripMenuItem.Text = "&Сборка";
            this.сборкаToolStripMenuItem.Click += new System.EventHandler(this.сборкаToolStripMenuItem_Click);
            // 
            // графикиToolStripMenuItem
            // 
            this.графикиToolStripMenuItem.Name = "графикиToolStripMenuItem";
            this.графикиToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.графикиToolStripMenuItem.Text = "&Графики";
            this.графикиToolStripMenuItem.Click += new System.EventHandler(this.графикиToolStripMenuItem_Click);
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.сотрудникиToolStripMenuItem.Text = "&Сотрудники";
            this.сотрудникиToolStripMenuItem.Click += new System.EventHandler(this.сотрудникиToolStripMenuItem_Click_1);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.полныйПрайслистToolStripMenuItem,
            this.прайслистКомплектующихToolStripMenuItem,
            this.прайслистДопУслугToolStripMenuItem,
            this.прайслистСервисногоОбслуживанияToolStripMenuItem,
            this.прайслистПОToolStripMenuItem,
            this.количествоТовараВМагазинеToolStripMenuItem});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчетыToolStripMenuItem.Text = "&Отчеты";
            // 
            // полныйПрайслистToolStripMenuItem
            // 
            this.полныйПрайслистToolStripMenuItem.Name = "полныйПрайслистToolStripMenuItem";
            this.полныйПрайслистToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.полныйПрайслистToolStripMenuItem.Text = "&Полный прайс-лист";
            this.полныйПрайслистToolStripMenuItem.Click += new System.EventHandler(this.полныйПрайслистToolStripMenuItem_Click);
            // 
            // прайслистКомплектующихToolStripMenuItem
            // 
            this.прайслистКомплектующихToolStripMenuItem.Name = "прайслистКомплектующихToolStripMenuItem";
            this.прайслистКомплектующихToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.прайслистКомплектующихToolStripMenuItem.Text = "&Прайс-лист комплектующих";
            this.прайслистКомплектующихToolStripMenuItem.Click += new System.EventHandler(this.прайслистКомплектующихToolStripMenuItem_Click);
            // 
            // прайслистДопУслугToolStripMenuItem
            // 
            this.прайслистДопУслугToolStripMenuItem.Name = "прайслистДопУслугToolStripMenuItem";
            this.прайслистДопУслугToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.прайслистДопУслугToolStripMenuItem.Text = "&Прайс-лист доп. услуг";
            this.прайслистДопУслугToolStripMenuItem.Click += new System.EventHandler(this.прайслистДопУслугToolStripMenuItem_Click);
            // 
            // прайслистСервисногоОбслуживанияToolStripMenuItem
            // 
            this.прайслистСервисногоОбслуживанияToolStripMenuItem.Name = "прайслистСервисногоОбслуживанияToolStripMenuItem";
            this.прайслистСервисногоОбслуживанияToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.прайслистСервисногоОбслуживанияToolStripMenuItem.Text = "&Прайс-лист сервисного обслуживания";
            this.прайслистСервисногоОбслуживанияToolStripMenuItem.Click += new System.EventHandler(this.прайслистСервисногоОбслуживанияToolStripMenuItem_Click);
            // 
            // прайслистПОToolStripMenuItem
            // 
            this.прайслистПОToolStripMenuItem.Name = "прайслистПОToolStripMenuItem";
            this.прайслистПОToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.прайслистПОToolStripMenuItem.Text = "&Прайс-лист ПО";
            this.прайслистПОToolStripMenuItem.Click += new System.EventHandler(this.прайслистПОToolStripMenuItem_Click);
            // 
            // количествоТовараВМагазинеToolStripMenuItem
            // 
            this.количествоТовараВМагазинеToolStripMenuItem.Name = "количествоТовараВМагазинеToolStripMenuItem";
            this.количествоТовараВМагазинеToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.количествоТовараВМагазинеToolStripMenuItem.Text = "&Количество товара в магазине";
            this.количествоТовараВМагазинеToolStripMenuItem.Click += new System.EventHandler(this.количествоТовараВМагазинеToolStripMenuItem_Click);
            // 
            // descriptionButton
            // 
            this.descriptionButton.Location = new System.Drawing.Point(540, 10);
            this.descriptionButton.Name = "descriptionButton";
            this.descriptionButton.Size = new System.Drawing.Size(110, 25);
            this.descriptionButton.TabIndex = 11;
            this.descriptionButton.Text = "Описание товара";
            this.descriptionButton.UseVisualStyleBackColor = true;
            this.descriptionButton.Click += new System.EventHandler(this.descriptionButton_Click);
            // 
            // lowPriceTB
            // 
            this.lowPriceTB.Location = new System.Drawing.Point(29, 163);
            this.lowPriceTB.MaxLength = 10;
            this.lowPriceTB.Name = "lowPriceTB";
            this.lowPriceTB.Size = new System.Drawing.Size(80, 20);
            this.lowPriceTB.TabIndex = 12;
            this.lowPriceTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lowPriceTB_KeyPress);
            // 
            // highPriceTB
            // 
            this.highPriceTB.Location = new System.Drawing.Point(29, 189);
            this.highPriceTB.MaxLength = 10;
            this.highPriceTB.Name = "highPriceTB";
            this.highPriceTB.Size = new System.Drawing.Size(80, 20);
            this.highPriceTB.TabIndex = 13;
            this.highPriceTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.highPriceTB_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Стоимость:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "От:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "До:";
            // 
            // costButton
            // 
            this.costButton.Location = new System.Drawing.Point(115, 186);
            this.costButton.Name = "costButton";
            this.costButton.Size = new System.Drawing.Size(95, 25);
            this.costButton.TabIndex = 17;
            this.costButton.Text = "Применить";
            this.costButton.UseVisualStyleBackColor = true;
            this.costButton.Click += new System.EventHandler(this.costButton_Click);
            // 
            // manufacturerButton
            // 
            this.manufacturerButton.Location = new System.Drawing.Point(115, 118);
            this.manufacturerButton.Name = "manufacturerButton";
            this.manufacturerButton.Size = new System.Drawing.Size(95, 25);
            this.manufacturerButton.TabIndex = 18;
            this.manufacturerButton.Text = "Отфильтровать";
            this.manufacturerButton.UseVisualStyleBackColor = true;
            this.manufacturerButton.Click += new System.EventHandler(this.manufacturerButton_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Фирма производитель:";
            // 
            // manufacturerTB
            // 
            this.manufacturerTB.Location = new System.Drawing.Point(9, 121);
            this.manufacturerTB.Name = "manufacturerTB";
            this.manufacturerTB.Size = new System.Drawing.Size(100, 20);
            this.manufacturerTB.TabIndex = 20;
            // 
            // basketButton
            // 
            this.basketButton.Location = new System.Drawing.Point(334, 10);
            this.basketButton.Name = "basketButton";
            this.basketButton.Size = new System.Drawing.Size(124, 25);
            this.basketButton.TabIndex = 21;
            this.basketButton.Text = "Добавить в корзину";
            this.basketButton.UseVisualStyleBackColor = true;
            this.basketButton.Click += new System.EventHandler(this.basketButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Наименование товара:";
            // 
            // goodsNameTB
            // 
            this.goodsNameTB.Location = new System.Drawing.Point(9, 230);
            this.goodsNameTB.Name = "goodsNameTB";
            this.goodsNameTB.Size = new System.Drawing.Size(201, 20);
            this.goodsNameTB.TabIndex = 23;
            this.goodsNameTB.TextChanged += new System.EventHandler(this.goodsNameTB_TextChanged_1);
            // 
            // dataTableTableAdapter1
            // 
            this.dataTableTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Тип комплектующего:";
            // 
            // goodsTypeCB
            // 
            this.goodsTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.goodsTypeCB.FormattingEnabled = true;
            this.goodsTypeCB.Location = new System.Drawing.Point(9, 41);
            this.goodsTypeCB.Name = "goodsTypeCB";
            this.goodsTypeCB.Size = new System.Drawing.Size(188, 21);
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
            this.goodsQuantityTB.Location = new System.Drawing.Point(166, 13);
            this.goodsQuantityTB.MaxLength = 3;
            this.goodsQuantityTB.Name = "goodsQuantityTB";
            this.goodsQuantityTB.Size = new System.Drawing.Size(151, 20);
            this.goodsQuantityTB.TabIndex = 27;
            this.goodsQuantityTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.goodsQuantityTB_KeyPress);
            // 
            // componentsPriceListReport
            // 
            this.componentsPriceListReport.NeedRefresh = false;
            this.componentsPriceListReport.ReportResourceString = resources.GetString("componentsPriceListReport.ReportResourceString");
            this.componentsPriceListReport.RegisterData(this.goods, "goods");
            // 
            // fullPriceListReport
            // 
            this.fullPriceListReport.NeedRefresh = false;
            this.fullPriceListReport.ReportResourceString = resources.GetString("fullPriceListReport.ReportResourceString");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Количество комплектующих:";
            // 
            // goodsQuantityReport
            // 
            this.goodsQuantityReport.NeedRefresh = false;
            this.goodsQuantityReport.ReportResourceString = resources.GetString("goodsQuantityReport.ReportResourceString");
            // 
            // additionalServicesPriceListReport
            // 
            this.additionalServicesPriceListReport.NeedRefresh = false;
            this.additionalServicesPriceListReport.ReportResourceString = resources.GetString("additionalServicesPriceListReport.ReportResourceString");
            // 
            // softwarePriceListReport
            // 
            this.softwarePriceListReport.NeedRefresh = false;
            this.softwarePriceListReport.ReportResourceString = resources.GetString("softwarePriceListReport.ReportResourceString");
            // 
            // serviceMaintenancePriceListReport
            // 
            this.serviceMaintenancePriceListReport.NeedRefresh = false;
            this.serviceMaintenancePriceListReport.ReportResourceString = resources.GetString("serviceMaintenancePriceListReport.ReportResourceString");
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(167, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Количество товаров в корзине:";
            // 
            // basketQuantityLabel
            // 
            this.basketQuantityLabel.AutoSize = true;
            this.basketQuantityLabel.Location = new System.Drawing.Point(179, 39);
            this.basketQuantityLabel.Name = "basketQuantityLabel";
            this.basketQuantityLabel.Size = new System.Drawing.Size(41, 13);
            this.basketQuantityLabel.TabIndex = 34;
            this.basketQuantityLabel.Text = "label10";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.goodsCategoryCB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.manufacturerButton);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.showAllGoodsButton);
            this.groupBox1.Controls.Add(this.manufacturerTB);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.goodsNameTB);
            this.groupBox1.Controls.Add(this.goodsTypeCB);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lowPriceTB);
            this.groupBox1.Controls.Add(this.costButton);
            this.groupBox1.Controls.Add(this.highPriceTB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(678, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 317);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтрация";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.goodsDGV);
            this.groupBox2.Location = new System.Drawing.Point(12, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(660, 250);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Список комплектующих";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.goodsQuantityTB);
            this.groupBox3.Controls.Add(this.basketQuantityLabel);
            this.groupBox3.Controls.Add(this.descriptionButton);
            this.groupBox3.Controls.Add(this.basketButton);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(12, 283);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(660, 61);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(904, 350);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.Text = "Магазин";
            this.Load += new System.EventHandler(this.MainWindow_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.goodsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goods)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.componentsPriceListReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullPriceListReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsQuantityReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.additionalServicesPriceListReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwarePriceListReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceMaintenancePriceListReport)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView goodsDGV;
        private System.Windows.Forms.ComboBox goodsCategoryCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button showAllGoodsButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
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
        private Goods goods;
        private System.Windows.Forms.BindingSource dataTableBindingSource1;
        private GoodsTableAdapters.DataTableTableAdapter dataTableTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox goodsTypeCB;
        private System.Windows.Forms.ToolStripMenuItem дополнительнвеУслугиToolStripMenuItem;
        private System.Windows.Forms.TextBox goodsQuantityTB;
        private System.Windows.Forms.ToolStripMenuItem дополнительноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem программноеОбеспечениеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem дополнительныеУслугиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сервисноеОбслуживаниеToolStripMenuItem1;
        private FastReport.Report componentsPriceListReport;
        private System.Windows.Forms.ToolStripMenuItem сборкаToolStripMenuItem;
        private FastReport.Report fullPriceListReport;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripMenuItem графикиToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsAmount;
        private FastReport.Report goodsQuantityReport;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem полныйПрайслистToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прайслистКомплектующихToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прайслистДопУслугToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прайслистСервисногоОбслуживанияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прайслистПОToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem количествоТовараВМагазинеToolStripMenuItem;
        private FastReport.Report additionalServicesPriceListReport;
        private FastReport.Report softwarePriceListReport;
        private FastReport.Report serviceMaintenancePriceListReport;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label basketQuantityLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

