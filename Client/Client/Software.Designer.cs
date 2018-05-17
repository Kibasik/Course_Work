namespace Client
{
    partial class Software
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Software));
            this.label1 = new System.Windows.Forms.Label();
            this.softwareTypeCB = new System.Windows.Forms.ComboBox();
            this.softwareDGV = new System.Windows.Forms.DataGridView();
            this.softwareTypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.softwareNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.softwareCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.softwareIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.softwareList = new Client.SoftwareList();
            this.showAllSoftwareButton = new System.Windows.Forms.Button();
            this.softwareQuantityChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.softwareQuantity = new Client.SoftwareQuantity();
            this.dataTableTableAdapter1 = new Client.SoftwareQuantityTableAdapters.DataTableTableAdapter();
            this.basketButton = new System.Windows.Forms.Button();
            this.dataTableTableAdapter = new Client.SoftwareListTableAdapters.DataTableTableAdapter();
            this.costButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.highPriceTB = new System.Windows.Forms.TextBox();
            this.lowPriceTB = new System.Windows.Forms.TextBox();
            this.softwareQuantityTB = new System.Windows.Forms.TextBox();
            this.softwareNameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.softwarePriceListReport = new FastReport.Report();
            this.softwarePriceListButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.softwareDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwareList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwareQuantityChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwareQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwarePriceListReport)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тип программного боеспечения:";
            // 
            // softwareTypeCB
            // 
            this.softwareTypeCB.FormattingEnabled = true;
            this.softwareTypeCB.Location = new System.Drawing.Point(15, 25);
            this.softwareTypeCB.Name = "softwareTypeCB";
            this.softwareTypeCB.Size = new System.Drawing.Size(157, 21);
            this.softwareTypeCB.TabIndex = 1;
            this.softwareTypeCB.SelectedIndexChanged += new System.EventHandler(this.softwareTypeCB_SelectedIndexChanged);
            // 
            // softwareDGV
            // 
            this.softwareDGV.AllowUserToAddRows = false;
            this.softwareDGV.AllowUserToDeleteRows = false;
            this.softwareDGV.AllowUserToResizeRows = false;
            this.softwareDGV.AutoGenerateColumns = false;
            this.softwareDGV.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.softwareDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.softwareDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.softwareTypeNameDataGridViewTextBoxColumn,
            this.softwareNameDataGridViewTextBoxColumn,
            this.softwareCostDataGridViewTextBoxColumn,
            this.softwareIDDataGridViewTextBoxColumn});
            this.softwareDGV.DataSource = this.dataTableBindingSource;
            this.softwareDGV.Location = new System.Drawing.Point(12, 64);
            this.softwareDGV.Name = "softwareDGV";
            this.softwareDGV.ReadOnly = true;
            this.softwareDGV.Size = new System.Drawing.Size(600, 247);
            this.softwareDGV.TabIndex = 2;
            // 
            // softwareTypeNameDataGridViewTextBoxColumn
            // 
            this.softwareTypeNameDataGridViewTextBoxColumn.DataPropertyName = "SoftwareTypeName";
            this.softwareTypeNameDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.softwareTypeNameDataGridViewTextBoxColumn.Name = "softwareTypeNameDataGridViewTextBoxColumn";
            this.softwareTypeNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.softwareTypeNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // softwareNameDataGridViewTextBoxColumn
            // 
            this.softwareNameDataGridViewTextBoxColumn.DataPropertyName = "SoftwareName";
            this.softwareNameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.softwareNameDataGridViewTextBoxColumn.Name = "softwareNameDataGridViewTextBoxColumn";
            this.softwareNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.softwareNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // softwareCostDataGridViewTextBoxColumn
            // 
            this.softwareCostDataGridViewTextBoxColumn.DataPropertyName = "SoftwareCost";
            this.softwareCostDataGridViewTextBoxColumn.HeaderText = "Цена, руб.";
            this.softwareCostDataGridViewTextBoxColumn.Name = "softwareCostDataGridViewTextBoxColumn";
            this.softwareCostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // softwareIDDataGridViewTextBoxColumn
            // 
            this.softwareIDDataGridViewTextBoxColumn.DataPropertyName = "SoftwareID";
            this.softwareIDDataGridViewTextBoxColumn.HeaderText = "SoftwareID";
            this.softwareIDDataGridViewTextBoxColumn.Name = "softwareIDDataGridViewTextBoxColumn";
            this.softwareIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.softwareIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataTableBindingSource
            // 
            this.dataTableBindingSource.DataMember = "DataTable";
            this.dataTableBindingSource.DataSource = this.softwareList;
            this.dataTableBindingSource.Position = 0;
            // 
            // softwareList
            // 
            this.softwareList.DataSetName = "SoftwareList";
            this.softwareList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // showAllSoftwareButton
            // 
            this.showAllSoftwareButton.Location = new System.Drawing.Point(526, 17);
            this.showAllSoftwareButton.Name = "showAllSoftwareButton";
            this.showAllSoftwareButton.Size = new System.Drawing.Size(86, 35);
            this.showAllSoftwareButton.TabIndex = 3;
            this.showAllSoftwareButton.Text = "Показать весь список";
            this.showAllSoftwareButton.UseVisualStyleBackColor = true;
            this.showAllSoftwareButton.Click += new System.EventHandler(this.showAllSoftwareButton_Click);
            // 
            // softwareQuantityChart
            // 
            this.softwareQuantityChart.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.AxisX.Title = "Тип программного обеспечения";
            chartArea1.AxisY.Title = "Количество";
            chartArea1.Name = "ChartArea1";
            this.softwareQuantityChart.ChartAreas.Add(chartArea1);
            this.softwareQuantityChart.DataSource = this.dataTableBindingSource1;
            this.softwareQuantityChart.Location = new System.Drawing.Point(15, 349);
            this.softwareQuantityChart.Name = "softwareQuantityChart";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series0";
            series1.XValueMember = "SoftwareTypeName";
            series1.YValueMembers = "Quantity";
            this.softwareQuantityChart.Series.Add(series1);
            this.softwareQuantityChart.Size = new System.Drawing.Size(552, 368);
            this.softwareQuantityChart.TabIndex = 4;
            this.softwareQuantityChart.Text = "chart1";
            // 
            // dataTableBindingSource1
            // 
            this.dataTableBindingSource1.DataMember = "DataTable";
            this.dataTableBindingSource1.DataSource = this.softwareQuantity;
            // 
            // softwareQuantity
            // 
            this.softwareQuantity.DataSetName = "SoftwareQuantity";
            this.softwareQuantity.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTableTableAdapter1
            // 
            this.dataTableTableAdapter1.ClearBeforeFill = true;
            // 
            // basketButton
            // 
            this.basketButton.Location = new System.Drawing.Point(370, 17);
            this.basketButton.Name = "basketButton";
            this.basketButton.Size = new System.Drawing.Size(81, 35);
            this.basketButton.TabIndex = 5;
            this.basketButton.Text = "Добавить в корзину";
            this.basketButton.UseVisualStyleBackColor = true;
            this.basketButton.Click += new System.EventHandler(this.basketButton_Click);
            // 
            // dataTableTableAdapter
            // 
            this.dataTableTableAdapter.ClearBeforeFill = true;
            // 
            // costButton
            // 
            this.costButton.Location = new System.Drawing.Point(633, 142);
            this.costButton.Name = "costButton";
            this.costButton.Size = new System.Drawing.Size(75, 23);
            this.costButton.TabIndex = 23;
            this.costButton.Text = "Применить";
            this.costButton.UseVisualStyleBackColor = true;
            this.costButton.Click += new System.EventHandler(this.costButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(630, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "До:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(630, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "От:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(630, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Введите стоимость:";
            // 
            // highPriceTB
            // 
            this.highPriceTB.Location = new System.Drawing.Point(659, 116);
            this.highPriceTB.MaxLength = 10;
            this.highPriceTB.Name = "highPriceTB";
            this.highPriceTB.Size = new System.Drawing.Size(80, 20);
            this.highPriceTB.TabIndex = 19;
            this.highPriceTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.highPriceTB_KeyPress);
            // 
            // lowPriceTB
            // 
            this.lowPriceTB.Location = new System.Drawing.Point(659, 90);
            this.lowPriceTB.MaxLength = 10;
            this.lowPriceTB.Name = "lowPriceTB";
            this.lowPriceTB.Size = new System.Drawing.Size(80, 20);
            this.lowPriceTB.TabIndex = 18;
            this.lowPriceTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lowPriceTB_KeyPress);
            // 
            // softwareQuantityTB
            // 
            this.softwareQuantityTB.Location = new System.Drawing.Point(231, 25);
            this.softwareQuantityTB.MaxLength = 3;
            this.softwareQuantityTB.Name = "softwareQuantityTB";
            this.softwareQuantityTB.Size = new System.Drawing.Size(100, 20);
            this.softwareQuantityTB.TabIndex = 24;
            this.softwareQuantityTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.softwareQuantityTB_KeyPress);
            // 
            // softwareNameTB
            // 
            this.softwareNameTB.Location = new System.Drawing.Point(633, 219);
            this.softwareNameTB.Name = "softwareNameTB";
            this.softwareNameTB.Size = new System.Drawing.Size(100, 20);
            this.softwareNameTB.TabIndex = 25;
            this.softwareNameTB.TextChanged += new System.EventHandler(this.softwareNameTB_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(630, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Введите наименование ПО:";
            // 
            // softwarePriceListReport
            // 
            this.softwarePriceListReport.NeedRefresh = false;
            this.softwarePriceListReport.ReportResourceString = resources.GetString("softwarePriceListReport.ReportResourceString");
            this.softwarePriceListReport.RegisterData(this.softwareList, "softwareList");
            // 
            // softwarePriceListButton
            // 
            this.softwarePriceListButton.Location = new System.Drawing.Point(997, 17);
            this.softwarePriceListButton.Name = "softwarePriceListButton";
            this.softwarePriceListButton.Size = new System.Drawing.Size(82, 36);
            this.softwarePriceListButton.TabIndex = 28;
            this.softwarePriceListButton.Text = "Показать прайс-лист";
            this.softwarePriceListButton.UseVisualStyleBackColor = true;
            this.softwarePriceListButton.Click += new System.EventHandler(this.softwarePriceListButton_Click);
            // 
            // Software
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 729);
            this.Controls.Add(this.softwarePriceListButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.softwareNameTB);
            this.Controls.Add(this.softwareQuantityTB);
            this.Controls.Add(this.costButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.highPriceTB);
            this.Controls.Add(this.lowPriceTB);
            this.Controls.Add(this.basketButton);
            this.Controls.Add(this.softwareQuantityChart);
            this.Controls.Add(this.showAllSoftwareButton);
            this.Controls.Add(this.softwareDGV);
            this.Controls.Add(this.softwareTypeCB);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "Software";
            this.ShowIcon = false;
            this.Text = "Software";
            this.Load += new System.EventHandler(this.Software_Load);
            ((System.ComponentModel.ISupportInitialize)(this.softwareDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwareList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwareQuantityChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwareQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwarePriceListReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox softwareTypeCB;
        private System.Windows.Forms.DataGridView softwareDGV;
        private System.Windows.Forms.Button showAllSoftwareButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart softwareQuantityChart;
        private SoftwareQuantity softwareQuantity;
        private System.Windows.Forms.BindingSource dataTableBindingSource1;
        private SoftwareQuantityTableAdapters.DataTableTableAdapter dataTableTableAdapter1;
        private System.Windows.Forms.Button basketButton;
        private SoftwareList softwareList;
        private System.Windows.Forms.BindingSource dataTableBindingSource;
        private SoftwareListTableAdapters.DataTableTableAdapter dataTableTableAdapter;
        private System.Windows.Forms.Button costButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox highPriceTB;
        private System.Windows.Forms.TextBox lowPriceTB;
        private System.Windows.Forms.TextBox softwareQuantityTB;
        private System.Windows.Forms.TextBox softwareNameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn softwareTypeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn softwareNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn softwareCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn softwareIDDataGridViewTextBoxColumn;
        private FastReport.Report softwarePriceListReport;
        private System.Windows.Forms.Button softwarePriceListButton;
    }
}