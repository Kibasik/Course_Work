namespace Client
{
    partial class WarehouseCharts
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.suppliersSupplyTP = new System.Windows.Forms.TabPage();
            this.deleteSuppliersFilterButton = new System.Windows.Forms.Button();
            this.suppliersCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.suppliersSupplyChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suppliersChart = new Client.SuppliersChart();
            this.warehouseChartsTC = new System.Windows.Forms.TabControl();
            this.workersSupplyTP = new System.Windows.Forms.TabPage();
            this.deleteWorkerFilterButton = new System.Windows.Forms.Button();
            this.workerNameCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.workersSupplyChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.workersChart = new Client.WorkersChart();
            this.dateSupplyTP = new System.Windows.Forms.TabPage();
            this.dateSupplyChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataTableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dateSupplyChart1 = new Client.DateSupplyChart();
            this.endDTP = new System.Windows.Forms.DateTimePicker();
            this.beginDTP = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.warehouseGoodsAmountTP = new System.Windows.Forms.TabPage();
            this.deleteComponentsTypeFilterButton = new System.Windows.Forms.Button();
            this.componentsTypeCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.warehouseComponentsAmountChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataTableBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.warehouseComponentsAmount = new Client.WarehouseComponentsAmount();
            this.dataTableTableAdapter = new Client.SuppliersChartTableAdapters.DataTableTableAdapter();
            this.dataTableTableAdapter1 = new Client.WorkersChartTableAdapters.DataTableTableAdapter();
            this.dataTableTableAdapter2 = new Client.DateSupplyChartTableAdapters.DataTableTableAdapter();
            this.dataTableTableAdapter3 = new Client.WarehouseComponentsAmountTableAdapters.DataTableTableAdapter();
            this.suppliersSupplyTP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersSupplyChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersChart)).BeginInit();
            this.warehouseChartsTC.SuspendLayout();
            this.workersSupplyTP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workersSupplyChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersChart)).BeginInit();
            this.dateSupplyTP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateSupplyChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSupplyChart1)).BeginInit();
            this.warehouseGoodsAmountTP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseComponentsAmountChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseComponentsAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // suppliersSupplyTP
            // 
            this.suppliersSupplyTP.BackColor = System.Drawing.SystemColors.Control;
            this.suppliersSupplyTP.Controls.Add(this.deleteSuppliersFilterButton);
            this.suppliersSupplyTP.Controls.Add(this.suppliersCB);
            this.suppliersSupplyTP.Controls.Add(this.label1);
            this.suppliersSupplyTP.Controls.Add(this.suppliersSupplyChart);
            this.suppliersSupplyTP.Location = new System.Drawing.Point(4, 22);
            this.suppliersSupplyTP.Name = "suppliersSupplyTP";
            this.suppliersSupplyTP.Padding = new System.Windows.Forms.Padding(3);
            this.suppliersSupplyTP.Size = new System.Drawing.Size(601, 431);
            this.suppliersSupplyTP.TabIndex = 0;
            this.suppliersSupplyTP.Text = "Поставки по поставщикам";
            // 
            // deleteSuppliersFilterButton
            // 
            this.deleteSuppliersFilterButton.Location = new System.Drawing.Point(186, 17);
            this.deleteSuppliersFilterButton.Name = "deleteSuppliersFilterButton";
            this.deleteSuppliersFilterButton.Size = new System.Drawing.Size(75, 23);
            this.deleteSuppliersFilterButton.TabIndex = 3;
            this.deleteSuppliersFilterButton.Text = "Сбросить";
            this.deleteSuppliersFilterButton.UseVisualStyleBackColor = true;
            this.deleteSuppliersFilterButton.Click += new System.EventHandler(this.deleteSuppliersFilterButton_Click);
            // 
            // suppliersCB
            // 
            this.suppliersCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.suppliersCB.FormattingEnabled = true;
            this.suppliersCB.Location = new System.Drawing.Point(9, 19);
            this.suppliersCB.Name = "suppliersCB";
            this.suppliersCB.Size = new System.Drawing.Size(171, 21);
            this.suppliersCB.TabIndex = 2;
            this.suppliersCB.SelectedIndexChanged += new System.EventHandler(this.suppliersCB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Поставщик:";
            // 
            // suppliersSupplyChart
            // 
            this.suppliersSupplyChart.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.Title = "Дата поставки";
            chartArea1.AxisY.Title = "Число товаров";
            chartArea1.Name = "ChartArea1";
            this.suppliersSupplyChart.ChartAreas.Add(chartArea1);
            this.suppliersSupplyChart.DataSource = this.dataTableBindingSource;
            this.suppliersSupplyChart.Location = new System.Drawing.Point(0, 51);
            this.suppliersSupplyChart.Name = "suppliersSupplyChart";
            this.suppliersSupplyChart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.Label = "#VALX, #VALY";
            series1.Name = "Series1";
            series1.XValueMember = "SupplyDate";
            series1.YValueMembers = "GoodsAmount";
            this.suppliersSupplyChart.Series.Add(series1);
            this.suppliersSupplyChart.Size = new System.Drawing.Size(592, 380);
            this.suppliersSupplyChart.TabIndex = 0;
            this.suppliersSupplyChart.Text = "chart1";
            // 
            // dataTableBindingSource
            // 
            this.dataTableBindingSource.DataMember = "DataTable";
            this.dataTableBindingSource.DataSource = this.suppliersChart;
            // 
            // suppliersChart
            // 
            this.suppliersChart.DataSetName = "SuppliersChart";
            this.suppliersChart.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // warehouseChartsTC
            // 
            this.warehouseChartsTC.Controls.Add(this.suppliersSupplyTP);
            this.warehouseChartsTC.Controls.Add(this.workersSupplyTP);
            this.warehouseChartsTC.Controls.Add(this.dateSupplyTP);
            this.warehouseChartsTC.Controls.Add(this.warehouseGoodsAmountTP);
            this.warehouseChartsTC.Location = new System.Drawing.Point(12, 12);
            this.warehouseChartsTC.Name = "warehouseChartsTC";
            this.warehouseChartsTC.SelectedIndex = 0;
            this.warehouseChartsTC.Size = new System.Drawing.Size(609, 457);
            this.warehouseChartsTC.TabIndex = 0;
            // 
            // workersSupplyTP
            // 
            this.workersSupplyTP.BackColor = System.Drawing.SystemColors.Control;
            this.workersSupplyTP.Controls.Add(this.deleteWorkerFilterButton);
            this.workersSupplyTP.Controls.Add(this.workerNameCB);
            this.workersSupplyTP.Controls.Add(this.label3);
            this.workersSupplyTP.Controls.Add(this.workersSupplyChart);
            this.workersSupplyTP.Location = new System.Drawing.Point(4, 22);
            this.workersSupplyTP.Name = "workersSupplyTP";
            this.workersSupplyTP.Size = new System.Drawing.Size(601, 431);
            this.workersSupplyTP.TabIndex = 1;
            this.workersSupplyTP.Text = "Поставки по сотрудникам";
            // 
            // deleteWorkerFilterButton
            // 
            this.deleteWorkerFilterButton.Location = new System.Drawing.Point(186, 17);
            this.deleteWorkerFilterButton.Name = "deleteWorkerFilterButton";
            this.deleteWorkerFilterButton.Size = new System.Drawing.Size(75, 23);
            this.deleteWorkerFilterButton.TabIndex = 6;
            this.deleteWorkerFilterButton.Text = "Сбросить";
            this.deleteWorkerFilterButton.UseVisualStyleBackColor = true;
            this.deleteWorkerFilterButton.Click += new System.EventHandler(this.deleteWorkerFilterButton_Click);
            // 
            // workerNameCB
            // 
            this.workerNameCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workerNameCB.FormattingEnabled = true;
            this.workerNameCB.Location = new System.Drawing.Point(9, 19);
            this.workerNameCB.Name = "workerNameCB";
            this.workerNameCB.Size = new System.Drawing.Size(171, 21);
            this.workerNameCB.TabIndex = 3;
            this.workerNameCB.SelectedIndexChanged += new System.EventHandler(this.workerNameCB_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Сотрудник:";
            // 
            // workersSupplyChart
            // 
            this.workersSupplyChart.BackColor = System.Drawing.SystemColors.Control;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.Title = "Дата поставки";
            chartArea2.AxisY.Title = "Число товаров";
            chartArea2.Name = "ChartArea1";
            this.workersSupplyChart.ChartAreas.Add(chartArea2);
            this.workersSupplyChart.DataSource = this.dataTableBindingSource1;
            this.workersSupplyChart.Location = new System.Drawing.Point(0, 51);
            this.workersSupplyChart.Name = "workersSupplyChart";
            series2.ChartArea = "ChartArea1";
            series2.Label = "#VALX, #VAL";
            series2.Name = "Series1";
            series2.XValueMember = "SupplyDate";
            series2.YValueMembers = "GoodsAmount";
            this.workersSupplyChart.Series.Add(series2);
            this.workersSupplyChart.Size = new System.Drawing.Size(592, 380);
            this.workersSupplyChart.TabIndex = 0;
            this.workersSupplyChart.Text = "chart1";
            // 
            // dataTableBindingSource1
            // 
            this.dataTableBindingSource1.DataMember = "DataTable";
            this.dataTableBindingSource1.DataSource = this.workersChart;
            // 
            // workersChart
            // 
            this.workersChart.DataSetName = "WorkersChart";
            this.workersChart.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateSupplyTP
            // 
            this.dateSupplyTP.BackColor = System.Drawing.SystemColors.Control;
            this.dateSupplyTP.Controls.Add(this.dateSupplyChart);
            this.dateSupplyTP.Controls.Add(this.endDTP);
            this.dateSupplyTP.Controls.Add(this.beginDTP);
            this.dateSupplyTP.Controls.Add(this.label4);
            this.dateSupplyTP.Location = new System.Drawing.Point(4, 22);
            this.dateSupplyTP.Name = "dateSupplyTP";
            this.dateSupplyTP.Size = new System.Drawing.Size(601, 431);
            this.dateSupplyTP.TabIndex = 2;
            this.dateSupplyTP.Text = "Поставки по дате";
            // 
            // dateSupplyChart
            // 
            this.dateSupplyChart.BackColor = System.Drawing.SystemColors.Control;
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisX.Title = "Дата поставки";
            chartArea3.AxisY.Title = "Число товаров";
            chartArea3.Name = "ChartArea1";
            this.dateSupplyChart.ChartAreas.Add(chartArea3);
            this.dateSupplyChart.DataSource = this.dataTableBindingSource2;
            this.dateSupplyChart.Location = new System.Drawing.Point(0, 51);
            this.dateSupplyChart.Name = "dateSupplyChart";
            series3.ChartArea = "ChartArea1";
            series3.Label = "#VALX, #VAL";
            series3.Name = "Series1";
            series3.XValueMember = "SupplyDate";
            series3.YValueMembers = "GoodsAmount";
            this.dateSupplyChart.Series.Add(series3);
            this.dateSupplyChart.Size = new System.Drawing.Size(592, 380);
            this.dateSupplyChart.TabIndex = 9;
            this.dateSupplyChart.Text = "chart1";
            // 
            // dataTableBindingSource2
            // 
            this.dataTableBindingSource2.DataMember = "DataTable";
            this.dataTableBindingSource2.DataSource = this.dateSupplyChart1;
            // 
            // dateSupplyChart1
            // 
            this.dateSupplyChart1.DataSetName = "DateSupplyChart";
            this.dateSupplyChart1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // endDTP
            // 
            this.endDTP.Location = new System.Drawing.Point(152, 25);
            this.endDTP.Name = "endDTP";
            this.endDTP.Size = new System.Drawing.Size(140, 20);
            this.endDTP.TabIndex = 8;
            this.endDTP.ValueChanged += new System.EventHandler(this.endDTP_ValueChanged);
            // 
            // beginDTP
            // 
            this.beginDTP.Location = new System.Drawing.Point(6, 25);
            this.beginDTP.Name = "beginDTP";
            this.beginDTP.Size = new System.Drawing.Size(140, 20);
            this.beginDTP.TabIndex = 7;
            this.beginDTP.ValueChanged += new System.EventHandler(this.beginDTP_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Дата поставки:";
            // 
            // warehouseGoodsAmountTP
            // 
            this.warehouseGoodsAmountTP.BackColor = System.Drawing.SystemColors.Control;
            this.warehouseGoodsAmountTP.Controls.Add(this.deleteComponentsTypeFilterButton);
            this.warehouseGoodsAmountTP.Controls.Add(this.componentsTypeCB);
            this.warehouseGoodsAmountTP.Controls.Add(this.label2);
            this.warehouseGoodsAmountTP.Controls.Add(this.warehouseComponentsAmountChart);
            this.warehouseGoodsAmountTP.Location = new System.Drawing.Point(4, 22);
            this.warehouseGoodsAmountTP.Name = "warehouseGoodsAmountTP";
            this.warehouseGoodsAmountTP.Size = new System.Drawing.Size(601, 431);
            this.warehouseGoodsAmountTP.TabIndex = 3;
            this.warehouseGoodsAmountTP.Text = "Количество комплектующих на складе";
            // 
            // deleteComponentsTypeFilterButton
            // 
            this.deleteComponentsTypeFilterButton.Location = new System.Drawing.Point(186, 17);
            this.deleteComponentsTypeFilterButton.Name = "deleteComponentsTypeFilterButton";
            this.deleteComponentsTypeFilterButton.Size = new System.Drawing.Size(75, 23);
            this.deleteComponentsTypeFilterButton.TabIndex = 3;
            this.deleteComponentsTypeFilterButton.Text = "Сбросить";
            this.deleteComponentsTypeFilterButton.UseVisualStyleBackColor = true;
            this.deleteComponentsTypeFilterButton.Click += new System.EventHandler(this.deleteComponentsTypeFilterButton_Click);
            // 
            // componentsTypeCB
            // 
            this.componentsTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.componentsTypeCB.FormattingEnabled = true;
            this.componentsTypeCB.Location = new System.Drawing.Point(9, 19);
            this.componentsTypeCB.Name = "componentsTypeCB";
            this.componentsTypeCB.Size = new System.Drawing.Size(171, 21);
            this.componentsTypeCB.TabIndex = 2;
            this.componentsTypeCB.SelectedIndexChanged += new System.EventHandler(this.componentsTypeCB_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Тип комплектующего:";
            // 
            // warehouseComponentsAmountChart
            // 
            this.warehouseComponentsAmountChart.BackColor = System.Drawing.SystemColors.Control;
            chartArea4.AxisX.MajorGrid.Enabled = false;
            chartArea4.AxisX.Title = "Категория комплектующего";
            chartArea4.AxisY.Title = "Количество комплектующих";
            chartArea4.Name = "ChartArea1";
            this.warehouseComponentsAmountChart.ChartAreas.Add(chartArea4);
            this.warehouseComponentsAmountChart.DataSource = this.dataTableBindingSource3;
            this.warehouseComponentsAmountChart.Location = new System.Drawing.Point(0, 51);
            this.warehouseComponentsAmountChart.Name = "warehouseComponentsAmountChart";
            series4.ChartArea = "ChartArea1";
            series4.Label = "#VAL";
            series4.Name = "Series1";
            series4.XValueMember = "CategoryGoodsName";
            series4.YValueMembers = "WarehouseGoodsAmount";
            this.warehouseComponentsAmountChart.Series.Add(series4);
            this.warehouseComponentsAmountChart.Size = new System.Drawing.Size(592, 380);
            this.warehouseComponentsAmountChart.TabIndex = 0;
            this.warehouseComponentsAmountChart.Text = "chart1";
            // 
            // dataTableBindingSource3
            // 
            this.dataTableBindingSource3.DataMember = "DataTable";
            this.dataTableBindingSource3.DataSource = this.warehouseComponentsAmount;
            // 
            // warehouseComponentsAmount
            // 
            this.warehouseComponentsAmount.DataSetName = "WarehouseComponentsAmount";
            this.warehouseComponentsAmount.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTableTableAdapter
            // 
            this.dataTableTableAdapter.ClearBeforeFill = true;
            // 
            // dataTableTableAdapter1
            // 
            this.dataTableTableAdapter1.ClearBeforeFill = true;
            // 
            // dataTableTableAdapter2
            // 
            this.dataTableTableAdapter2.ClearBeforeFill = true;
            // 
            // dataTableTableAdapter3
            // 
            this.dataTableTableAdapter3.ClearBeforeFill = true;
            // 
            // WarehouseCharts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 481);
            this.Controls.Add(this.warehouseChartsTC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "WarehouseCharts";
            this.ShowIcon = false;
            this.Text = "Графики";
            this.Load += new System.EventHandler(this.WarehouseCharts_Load);
            this.suppliersSupplyTP.ResumeLayout(false);
            this.suppliersSupplyTP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersSupplyChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersChart)).EndInit();
            this.warehouseChartsTC.ResumeLayout(false);
            this.workersSupplyTP.ResumeLayout(false);
            this.workersSupplyTP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workersSupplyChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersChart)).EndInit();
            this.dateSupplyTP.ResumeLayout(false);
            this.dateSupplyTP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateSupplyChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSupplyChart1)).EndInit();
            this.warehouseGoodsAmountTP.ResumeLayout(false);
            this.warehouseGoodsAmountTP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseComponentsAmountChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseComponentsAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage suppliersSupplyTP;
        private System.Windows.Forms.TabControl warehouseChartsTC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox suppliersCB;
        private System.Windows.Forms.DataVisualization.Charting.Chart suppliersSupplyChart;
        private System.Windows.Forms.TabPage workersSupplyTP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox workerNameCB;
        private SuppliersChart suppliersChart;
        private System.Windows.Forms.BindingSource dataTableBindingSource;
        private SuppliersChartTableAdapters.DataTableTableAdapter dataTableTableAdapter;
        private WorkersChart workersChart;
        private System.Windows.Forms.BindingSource dataTableBindingSource1;
        private WorkersChartTableAdapters.DataTableTableAdapter dataTableTableAdapter1;
        private System.Windows.Forms.Button deleteSuppliersFilterButton;
        private System.Windows.Forms.Button deleteWorkerFilterButton;
        private System.Windows.Forms.TabPage dateSupplyTP;
        private System.Windows.Forms.DataVisualization.Charting.Chart workersSupplyChart;
        private System.Windows.Forms.DateTimePicker endDTP;
        private System.Windows.Forms.DateTimePicker beginDTP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart dateSupplyChart;
        private DateSupplyChart dateSupplyChart1;
        private System.Windows.Forms.BindingSource dataTableBindingSource2;
        private DateSupplyChartTableAdapters.DataTableTableAdapter dataTableTableAdapter2;
        private System.Windows.Forms.TabPage warehouseGoodsAmountTP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart warehouseComponentsAmountChart;
        private System.Windows.Forms.ComboBox componentsTypeCB;
        private System.Windows.Forms.Button deleteComponentsTypeFilterButton;
        private WarehouseComponentsAmount warehouseComponentsAmount;
        private System.Windows.Forms.BindingSource dataTableBindingSource3;
        private WarehouseComponentsAmountTableAdapters.DataTableTableAdapter dataTableTableAdapter3;
    }
}