namespace Client
{
    partial class Charts
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartsTC = new System.Windows.Forms.TabControl();
            this.goodsTP = new System.Windows.Forms.TabPage();
            this.goodsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.softwareTP = new System.Windows.Forms.TabPage();
            this.softwareChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.softwareQuantity = new Client.SoftwareQuantity();
            this.dataTableTableAdapter1 = new Client.SoftwareQuantityTableAdapters.DataTableTableAdapter();
            this.warehouseTB = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.goodsQuantity = new Client.GoodsQuantity();
            this.dataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTableTableAdapter = new Client.GoodsQuantityTableAdapters.DataTableTableAdapter();
            this.warehouseQuantity = new Client.WarehouseQuantity();
            this.dataTableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataTableTableAdapter2 = new Client.WarehouseQuantityTableAdapters.DataTableTableAdapter();
            this.chartsTC.SuspendLayout();
            this.goodsTP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goodsChart)).BeginInit();
            this.softwareTP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.softwareChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwareQuantity)).BeginInit();
            this.warehouseTB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // chartsTC
            // 
            this.chartsTC.Controls.Add(this.goodsTP);
            this.chartsTC.Controls.Add(this.softwareTP);
            this.chartsTC.Controls.Add(this.warehouseTB);
            this.chartsTC.Location = new System.Drawing.Point(12, 12);
            this.chartsTC.Name = "chartsTC";
            this.chartsTC.SelectedIndex = 0;
            this.chartsTC.Size = new System.Drawing.Size(600, 417);
            this.chartsTC.TabIndex = 0;
            // 
            // goodsTP
            // 
            this.goodsTP.BackColor = System.Drawing.SystemColors.Control;
            this.goodsTP.Controls.Add(this.goodsChart);
            this.goodsTP.Location = new System.Drawing.Point(4, 22);
            this.goodsTP.Name = "goodsTP";
            this.goodsTP.Padding = new System.Windows.Forms.Padding(3);
            this.goodsTP.Size = new System.Drawing.Size(592, 391);
            this.goodsTP.TabIndex = 0;
            this.goodsTP.Text = "Комплектующие";
            // 
            // goodsChart
            // 
            this.goodsChart.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.Title = "Категория комплектующего";
            chartArea1.AxisY.Title = "Количество";
            chartArea1.Name = "ChartArea1";
            this.goodsChart.ChartAreas.Add(chartArea1);
            this.goodsChart.DataSource = this.dataTableBindingSource;
            this.goodsChart.Location = new System.Drawing.Point(0, 0);
            this.goodsChart.Name = "goodsChart";
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.Name = "Series1";
            series1.XValueMember = "CategoryGoodsName";
            series1.YValueMembers = "Quantity";
            this.goodsChart.Series.Add(series1);
            this.goodsChart.Size = new System.Drawing.Size(592, 391);
            this.goodsChart.TabIndex = 0;
            this.goodsChart.Text = "chart1";
            // 
            // softwareTP
            // 
            this.softwareTP.BackColor = System.Drawing.SystemColors.Control;
            this.softwareTP.Controls.Add(this.softwareChart);
            this.softwareTP.Location = new System.Drawing.Point(4, 22);
            this.softwareTP.Name = "softwareTP";
            this.softwareTP.Padding = new System.Windows.Forms.Padding(3);
            this.softwareTP.Size = new System.Drawing.Size(592, 391);
            this.softwareTP.TabIndex = 1;
            this.softwareTP.Text = "Программное обеспечение";
            // 
            // softwareChart
            // 
            this.softwareChart.BackColor = System.Drawing.SystemColors.Control;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.Title = "Тип программного обеспечения";
            chartArea2.AxisY.Title = "Количество";
            chartArea2.Name = "ChartArea1";
            this.softwareChart.ChartAreas.Add(chartArea2);
            this.softwareChart.DataSource = this.dataTableBindingSource1;
            this.softwareChart.Location = new System.Drawing.Point(0, 0);
            this.softwareChart.Name = "softwareChart";
            series2.ChartArea = "ChartArea1";
            series2.IsValueShownAsLabel = true;
            series2.Name = "Series1";
            series2.XValueMember = "SoftwareTypeName";
            series2.YValueMembers = "Quantity";
            this.softwareChart.Series.Add(series2);
            this.softwareChart.Size = new System.Drawing.Size(592, 391);
            this.softwareChart.TabIndex = 0;
            this.softwareChart.Text = "chart1";
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
            // warehouseTB
            // 
            this.warehouseTB.BackColor = System.Drawing.SystemColors.Control;
            this.warehouseTB.Controls.Add(this.chart1);
            this.warehouseTB.Location = new System.Drawing.Point(4, 22);
            this.warehouseTB.Name = "warehouseTB";
            this.warehouseTB.Size = new System.Drawing.Size(592, 391);
            this.warehouseTB.TabIndex = 2;
            this.warehouseTB.Text = "Товары на складе";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.SystemColors.Control;
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisX.Title = "Категория комплектующего";
            chartArea3.AxisY.Title = "Количество";
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.DataSource = this.dataTableBindingSource2;
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.IsValueShownAsLabel = true;
            series3.Name = "Series1";
            series3.XValueMember = "CategoryGoodsName";
            series3.YValueMembers = "WarehouseGoodsAmount";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(592, 391);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // goodsQuantity
            // 
            this.goodsQuantity.DataSetName = "GoodsQuantity";
            this.goodsQuantity.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTableBindingSource
            // 
            this.dataTableBindingSource.DataMember = "DataTable";
            this.dataTableBindingSource.DataSource = this.goodsQuantity;
            // 
            // dataTableTableAdapter
            // 
            this.dataTableTableAdapter.ClearBeforeFill = true;
            // 
            // warehouseQuantity
            // 
            this.warehouseQuantity.DataSetName = "WarehouseQuantity";
            this.warehouseQuantity.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTableBindingSource2
            // 
            this.dataTableBindingSource2.DataMember = "DataTable";
            this.dataTableBindingSource2.DataSource = this.warehouseQuantity;
            // 
            // dataTableTableAdapter2
            // 
            this.dataTableTableAdapter2.ClearBeforeFill = true;
            // 
            // Charts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.chartsTC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "Charts";
            this.ShowIcon = false;
            this.Text = "Charts";
            this.Load += new System.EventHandler(this.Charts_Load);
            this.chartsTC.ResumeLayout(false);
            this.goodsTP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.goodsChart)).EndInit();
            this.softwareTP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.softwareChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwareQuantity)).EndInit();
            this.warehouseTB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl chartsTC;
        private System.Windows.Forms.TabPage goodsTP;
        private System.Windows.Forms.TabPage softwareTP;
        private System.Windows.Forms.DataVisualization.Charting.Chart goodsChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart softwareChart;
        private SoftwareQuantity softwareQuantity;
        private System.Windows.Forms.BindingSource dataTableBindingSource1;
        private SoftwareQuantityTableAdapters.DataTableTableAdapter dataTableTableAdapter1;
        private System.Windows.Forms.TabPage warehouseTB;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private GoodsQuantity goodsQuantity;
        private System.Windows.Forms.BindingSource dataTableBindingSource;
        private GoodsQuantityTableAdapters.DataTableTableAdapter dataTableTableAdapter;
        private WarehouseQuantity warehouseQuantity;
        private System.Windows.Forms.BindingSource dataTableBindingSource2;
        private WarehouseQuantityTableAdapters.DataTableTableAdapter dataTableTableAdapter2;
    }
}