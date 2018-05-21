namespace Client
{
    partial class ServiceMaintenance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceMaintenance));
            this.label1 = new System.Windows.Forms.Label();
            this.serviceMaintenanceDGV = new System.Windows.Forms.DataGridView();
            this.serviceMaintenanceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceMaintenanceNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceMaintenancePeriodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceMaintenanceCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceMaintenanceList = new Client.ServiceMaintenanceList();
            this.basketButton = new System.Windows.Forms.Button();
            this.costButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.highPriceTB = new System.Windows.Forms.TextBox();
            this.lowPriceTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.serviceMaintenanceNameTB = new System.Windows.Forms.TextBox();
            this.showAllServiceMaintenanceButton = new System.Windows.Forms.Button();
            this.serviceMaintenancePriceListReport = new FastReport.Report();
            this.serviceMaintenancePriceListButton = new System.Windows.Forms.Button();
            this.dataTableTableAdapter = new Client.ServiceMaintenanceListTableAdapters.DataTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.serviceMaintenanceDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceMaintenanceList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceMaintenancePriceListReport)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Список сервисного обслуживания:\r\n";
            // 
            // serviceMaintenanceDGV
            // 
            this.serviceMaintenanceDGV.AllowUserToAddRows = false;
            this.serviceMaintenanceDGV.AllowUserToDeleteRows = false;
            this.serviceMaintenanceDGV.AllowUserToResizeRows = false;
            this.serviceMaintenanceDGV.AutoGenerateColumns = false;
            this.serviceMaintenanceDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.serviceMaintenanceDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serviceMaintenanceDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serviceMaintenanceIDDataGridViewTextBoxColumn,
            this.serviceMaintenanceNameDataGridViewTextBoxColumn,
            this.serviceMaintenancePeriodDataGridViewTextBoxColumn,
            this.serviceMaintenanceCostDataGridViewTextBoxColumn});
            this.serviceMaintenanceDGV.DataSource = this.dataTableBindingSource;
            this.serviceMaintenanceDGV.Location = new System.Drawing.Point(15, 25);
            this.serviceMaintenanceDGV.Name = "serviceMaintenanceDGV";
            this.serviceMaintenanceDGV.ReadOnly = true;
            this.serviceMaintenanceDGV.Size = new System.Drawing.Size(435, 216);
            this.serviceMaintenanceDGV.TabIndex = 1;
            // 
            // serviceMaintenanceIDDataGridViewTextBoxColumn
            // 
            this.serviceMaintenanceIDDataGridViewTextBoxColumn.DataPropertyName = "ServiceMaintenanceID";
            this.serviceMaintenanceIDDataGridViewTextBoxColumn.HeaderText = "ServiceMaintenanceID";
            this.serviceMaintenanceIDDataGridViewTextBoxColumn.Name = "serviceMaintenanceIDDataGridViewTextBoxColumn";
            this.serviceMaintenanceIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.serviceMaintenanceIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // serviceMaintenanceNameDataGridViewTextBoxColumn
            // 
            this.serviceMaintenanceNameDataGridViewTextBoxColumn.DataPropertyName = "ServiceMaintenanceName";
            this.serviceMaintenanceNameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.serviceMaintenanceNameDataGridViewTextBoxColumn.Name = "serviceMaintenanceNameDataGridViewTextBoxColumn";
            this.serviceMaintenanceNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.serviceMaintenanceNameDataGridViewTextBoxColumn.Width = 180;
            // 
            // serviceMaintenancePeriodDataGridViewTextBoxColumn
            // 
            this.serviceMaintenancePeriodDataGridViewTextBoxColumn.DataPropertyName = "ServiceMaintenancePeriod";
            this.serviceMaintenancePeriodDataGridViewTextBoxColumn.HeaderText = "Срок, дней";
            this.serviceMaintenancePeriodDataGridViewTextBoxColumn.Name = "serviceMaintenancePeriodDataGridViewTextBoxColumn";
            this.serviceMaintenancePeriodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serviceMaintenanceCostDataGridViewTextBoxColumn
            // 
            this.serviceMaintenanceCostDataGridViewTextBoxColumn.DataPropertyName = "ServiceMaintenanceCost";
            this.serviceMaintenanceCostDataGridViewTextBoxColumn.HeaderText = "Цена, руб.";
            this.serviceMaintenanceCostDataGridViewTextBoxColumn.Name = "serviceMaintenanceCostDataGridViewTextBoxColumn";
            this.serviceMaintenanceCostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataTableBindingSource
            // 
            this.dataTableBindingSource.DataMember = "DataTable";
            this.dataTableBindingSource.DataSource = this.serviceMaintenanceList;
            // 
            // serviceMaintenanceList
            // 
            this.serviceMaintenanceList.DataSetName = "ServiceMaintenanceList";
            this.serviceMaintenanceList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // basketButton
            // 
            this.basketButton.Location = new System.Drawing.Point(15, 247);
            this.basketButton.Name = "basketButton";
            this.basketButton.Size = new System.Drawing.Size(80, 40);
            this.basketButton.TabIndex = 2;
            this.basketButton.Text = "Добавить в корзину";
            this.basketButton.UseVisualStyleBackColor = true;
            this.basketButton.Click += new System.EventHandler(this.basketButton_Click);
            // 
            // costButton
            // 
            this.costButton.Location = new System.Drawing.Point(461, 159);
            this.costButton.Name = "costButton";
            this.costButton.Size = new System.Drawing.Size(80, 40);
            this.costButton.TabIndex = 29;
            this.costButton.Text = "Применить";
            this.costButton.UseVisualStyleBackColor = true;
            this.costButton.Click += new System.EventHandler(this.costButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(458, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "До:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(458, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "От:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(458, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Стоимость:";
            // 
            // highPriceTB
            // 
            this.highPriceTB.Location = new System.Drawing.Point(487, 133);
            this.highPriceTB.MaxLength = 10;
            this.highPriceTB.Name = "highPriceTB";
            this.highPriceTB.Size = new System.Drawing.Size(80, 20);
            this.highPriceTB.TabIndex = 25;
            // 
            // lowPriceTB
            // 
            this.lowPriceTB.Location = new System.Drawing.Point(487, 107);
            this.lowPriceTB.MaxLength = 10;
            this.lowPriceTB.Name = "lowPriceTB";
            this.lowPriceTB.Size = new System.Drawing.Size(80, 20);
            this.lowPriceTB.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(456, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 26);
            this.label2.TabIndex = 30;
            this.label2.Text = "Наименование сервисного \r\nобслуживания:";
            // 
            // serviceMaintenanceNameTB
            // 
            this.serviceMaintenanceNameTB.Location = new System.Drawing.Point(459, 54);
            this.serviceMaintenanceNameTB.Name = "serviceMaintenanceNameTB";
            this.serviceMaintenanceNameTB.Size = new System.Drawing.Size(120, 20);
            this.serviceMaintenanceNameTB.TabIndex = 31;
            this.serviceMaintenanceNameTB.TextChanged += new System.EventHandler(this.serviceMaintenanceNameTB_TextChanged);
            // 
            // showAllServiceMaintenanceButton
            // 
            this.showAllServiceMaintenanceButton.Location = new System.Drawing.Point(161, 247);
            this.showAllServiceMaintenanceButton.Name = "showAllServiceMaintenanceButton";
            this.showAllServiceMaintenanceButton.Size = new System.Drawing.Size(90, 40);
            this.showAllServiceMaintenanceButton.TabIndex = 32;
            this.showAllServiceMaintenanceButton.Text = "Показать весь список";
            this.showAllServiceMaintenanceButton.UseVisualStyleBackColor = true;
            this.showAllServiceMaintenanceButton.Click += new System.EventHandler(this.showAllServiceMaintenanceButton_Click);
            // 
            // serviceMaintenancePriceListReport
            // 
            this.serviceMaintenancePriceListReport.NeedRefresh = false;
            this.serviceMaintenancePriceListReport.ReportResourceString = resources.GetString("serviceMaintenancePriceListReport.ReportResourceString");
            this.serviceMaintenancePriceListReport.RegisterData(this.serviceMaintenanceList, "serviceMaintenanceList");
            // 
            // serviceMaintenancePriceListButton
            // 
            this.serviceMaintenancePriceListButton.Location = new System.Drawing.Point(310, 247);
            this.serviceMaintenancePriceListButton.Name = "serviceMaintenancePriceListButton";
            this.serviceMaintenancePriceListButton.Size = new System.Drawing.Size(140, 40);
            this.serviceMaintenancePriceListButton.TabIndex = 33;
            this.serviceMaintenancePriceListButton.Text = "Прайс-лист сервисного обслуживания";
            this.serviceMaintenancePriceListButton.UseVisualStyleBackColor = true;
            this.serviceMaintenancePriceListButton.Click += new System.EventHandler(this.serviceMaintenancePriceListButton_Click_1);
            // 
            // dataTableTableAdapter
            // 
            this.dataTableTableAdapter.ClearBeforeFill = true;
            // 
            // ServiceMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 301);
            this.Controls.Add(this.serviceMaintenancePriceListButton);
            this.Controls.Add(this.showAllServiceMaintenanceButton);
            this.Controls.Add(this.serviceMaintenanceNameTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.costButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.highPriceTB);
            this.Controls.Add(this.lowPriceTB);
            this.Controls.Add(this.basketButton);
            this.Controls.Add(this.serviceMaintenanceDGV);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(640, 340);
            this.Name = "ServiceMaintenance";
            this.ShowIcon = false;
            this.Text = "ServiceMaintenance";
            this.Load += new System.EventHandler(this.ServiceMaintenance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.serviceMaintenanceDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceMaintenanceList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceMaintenancePriceListReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView serviceMaintenanceDGV;
        private ServiceMaintenanceList serviceMaintenanceList;
        private System.Windows.Forms.Button basketButton;
        private System.Windows.Forms.Button costButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox highPriceTB;
        private System.Windows.Forms.TextBox lowPriceTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox serviceMaintenanceNameTB;
        private System.Windows.Forms.Button showAllServiceMaintenanceButton;
        private FastReport.Report serviceMaintenancePriceListReport;
        private System.Windows.Forms.Button serviceMaintenancePriceListButton;
        private System.Windows.Forms.BindingSource dataTableBindingSource;
        private ServiceMaintenanceListTableAdapters.DataTableTableAdapter dataTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceMaintenanceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceMaintenanceNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceMaintenancePeriodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceMaintenanceCostDataGridViewTextBoxColumn;
    }
}