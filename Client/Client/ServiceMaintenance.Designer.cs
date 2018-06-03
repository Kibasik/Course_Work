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
            this.dataTableTableAdapter = new Client.ServiceMaintenanceListTableAdapters.DataTableTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.serviceMaintenanceDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceMaintenanceList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceMaintenancePriceListReport)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            this.serviceMaintenanceDGV.Location = new System.Drawing.Point(6, 19);
            this.serviceMaintenanceDGV.Name = "serviceMaintenanceDGV";
            this.serviceMaintenanceDGV.ReadOnly = true;
            this.serviceMaintenanceDGV.Size = new System.Drawing.Size(437, 223);
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
            this.basketButton.Location = new System.Drawing.Point(18, 266);
            this.basketButton.Name = "basketButton";
            this.basketButton.Size = new System.Drawing.Size(128, 34);
            this.basketButton.TabIndex = 2;
            this.basketButton.Text = "Добавить в корзину";
            this.basketButton.UseVisualStyleBackColor = true;
            this.basketButton.Click += new System.EventHandler(this.basketButton_Click);
            // 
            // costButton
            // 
            this.costButton.Location = new System.Drawing.Point(11, 138);
            this.costButton.Name = "costButton";
            this.costButton.Size = new System.Drawing.Size(106, 25);
            this.costButton.TabIndex = 29;
            this.costButton.Text = "Применить";
            this.costButton.UseVisualStyleBackColor = true;
            this.costButton.Click += new System.EventHandler(this.costButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "До:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "От:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Стоимость:";
            // 
            // highPriceTB
            // 
            this.highPriceTB.Location = new System.Drawing.Point(37, 112);
            this.highPriceTB.MaxLength = 10;
            this.highPriceTB.Name = "highPriceTB";
            this.highPriceTB.Size = new System.Drawing.Size(80, 20);
            this.highPriceTB.TabIndex = 25;
            this.highPriceTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.highPriceTB_KeyPress);
            // 
            // lowPriceTB
            // 
            this.lowPriceTB.Location = new System.Drawing.Point(37, 86);
            this.lowPriceTB.MaxLength = 10;
            this.lowPriceTB.Name = "lowPriceTB";
            this.lowPriceTB.Size = new System.Drawing.Size(80, 20);
            this.lowPriceTB.TabIndex = 24;
            this.lowPriceTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lowPriceTB_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 26);
            this.label2.TabIndex = 30;
            this.label2.Text = "Наименование сервисного \r\nобслуживания:";
            // 
            // serviceMaintenanceNameTB
            // 
            this.serviceMaintenanceNameTB.Location = new System.Drawing.Point(9, 47);
            this.serviceMaintenanceNameTB.Name = "serviceMaintenanceNameTB";
            this.serviceMaintenanceNameTB.Size = new System.Drawing.Size(145, 20);
            this.serviceMaintenanceNameTB.TabIndex = 31;
            this.serviceMaintenanceNameTB.TextChanged += new System.EventHandler(this.serviceMaintenanceNameTB_TextChanged);
            // 
            // showAllServiceMaintenanceButton
            // 
            this.showAllServiceMaintenanceButton.Location = new System.Drawing.Point(11, 215);
            this.showAllServiceMaintenanceButton.Name = "showAllServiceMaintenanceButton";
            this.showAllServiceMaintenanceButton.Size = new System.Drawing.Size(143, 27);
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
            // dataTableTableAdapter
            // 
            this.dataTableTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.showAllServiceMaintenanceButton);
            this.groupBox1.Controls.Add(this.lowPriceTB);
            this.groupBox1.Controls.Add(this.serviceMaintenanceNameTB);
            this.groupBox1.Controls.Add(this.highPriceTB);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.costButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(467, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 248);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтрация";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.serviceMaintenanceDGV);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(449, 248);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Список сервисного обслуживания";
            // 
            // ServiceMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 306);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.basketButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(640, 340);
            this.Name = "ServiceMaintenance";
            this.ShowIcon = false;
            this.Text = "Сервисное обслуживание";
            this.Load += new System.EventHandler(this.ServiceMaintenance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.serviceMaintenanceDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceMaintenanceList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceMaintenancePriceListReport)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.BindingSource dataTableBindingSource;
        private ServiceMaintenanceListTableAdapters.DataTableTableAdapter dataTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceMaintenanceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceMaintenanceNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceMaintenancePeriodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceMaintenanceCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}