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
            this.chartsTC = new System.Windows.Forms.TabControl();
            this.goodsTP = new System.Windows.Forms.TabPage();
            this.goodsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goodsQuantity = new Client.GoodsQuantity();
            this.softwareTP = new System.Windows.Forms.TabPage();
            this.softwareChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.softwareQuantity = new Client.SoftwareQuantity();
            this.dataTableTableAdapter = new Client.GoodsQuantityTableAdapters.DataTableTableAdapter();
            this.dataTableTableAdapter1 = new Client.SoftwareQuantityTableAdapters.DataTableTableAdapter();
            this.chartsTC.SuspendLayout();
            this.goodsTP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goodsChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsQuantity)).BeginInit();
            this.softwareTP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.softwareChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwareQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // chartsTC
            // 
            this.chartsTC.Controls.Add(this.goodsTP);
            this.chartsTC.Controls.Add(this.softwareTP);
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
            chartArea1.AxisX.Title = "Категория комплектующего";
            chartArea1.AxisY.Title = "Количество";
            chartArea1.Name = "ChartArea1";
            this.goodsChart.ChartAreas.Add(chartArea1);
            this.goodsChart.DataSource = this.dataTableBindingSource;
            this.goodsChart.Location = new System.Drawing.Point(0, 0);
            this.goodsChart.Name = "goodsChart";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            series1.XValueMember = "CategoryGoodsName";
            series1.YValueMembers = "Quantity";
            this.goodsChart.Series.Add(series1);
            this.goodsChart.Size = new System.Drawing.Size(592, 391);
            this.goodsChart.TabIndex = 0;
            this.goodsChart.Text = "chart1";
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
            chartArea2.AxisX.Title = "Тип программного обеспечения";
            chartArea2.AxisY.Title = "Количество";
            chartArea2.Name = "ChartArea1";
            this.softwareChart.ChartAreas.Add(chartArea2);
            this.softwareChart.DataSource = this.dataTableBindingSource1;
            this.softwareChart.Location = new System.Drawing.Point(0, 0);
            this.softwareChart.Name = "softwareChart";
            series2.ChartArea = "ChartArea1";
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
            // dataTableTableAdapter
            // 
            this.dataTableTableAdapter.ClearBeforeFill = true;
            // 
            // dataTableTableAdapter1
            // 
            this.dataTableTableAdapter1.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsQuantity)).EndInit();
            this.softwareTP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.softwareChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwareQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl chartsTC;
        private System.Windows.Forms.TabPage goodsTP;
        private System.Windows.Forms.TabPage softwareTP;
        private System.Windows.Forms.DataVisualization.Charting.Chart goodsChart;
        private GoodsQuantity goodsQuantity;
        private System.Windows.Forms.BindingSource dataTableBindingSource;
        private GoodsQuantityTableAdapters.DataTableTableAdapter dataTableTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart softwareChart;
        private SoftwareQuantity softwareQuantity;
        private System.Windows.Forms.BindingSource dataTableBindingSource1;
        private SoftwareQuantityTableAdapters.DataTableTableAdapter dataTableTableAdapter1;
    }
}