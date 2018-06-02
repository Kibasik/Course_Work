namespace Client
{
    partial class AdditionalServices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdditionalServices));
            this.additionalServicesDGV = new System.Windows.Forms.DataGridView();
            this.additionalServiceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.additionalServiceNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.additionalServiceCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.additionalServicesList = new Client.AdditionalServicesList();
            this.basketButton = new System.Windows.Forms.Button();
            this.additionalServiceNameTB = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.costButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.highPriceTB = new System.Windows.Forms.TextBox();
            this.lowPriceTB = new System.Windows.Forms.TextBox();
            this.dataTableTableAdapter = new Client.AdditionalServicesListTableAdapters.DataTableTableAdapter();
            this.showAllAdditionalServicesButton = new System.Windows.Forms.Button();
            this.additionalServicesPriceListReport = new FastReport.Report();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.additionalServicesDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.additionalServicesList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.additionalServicesPriceListReport)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // additionalServicesDGV
            // 
            this.additionalServicesDGV.AllowUserToAddRows = false;
            this.additionalServicesDGV.AllowUserToDeleteRows = false;
            this.additionalServicesDGV.AllowUserToResizeRows = false;
            this.additionalServicesDGV.AutoGenerateColumns = false;
            this.additionalServicesDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.additionalServicesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.additionalServicesDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.additionalServiceIDDataGridViewTextBoxColumn,
            this.additionalServiceNameDataGridViewTextBoxColumn,
            this.additionalServiceCostDataGridViewTextBoxColumn});
            this.additionalServicesDGV.DataSource = this.dataTableBindingSource;
            this.additionalServicesDGV.Location = new System.Drawing.Point(6, 16);
            this.additionalServicesDGV.Name = "additionalServicesDGV";
            this.additionalServicesDGV.ReadOnly = true;
            this.additionalServicesDGV.Size = new System.Drawing.Size(301, 170);
            this.additionalServicesDGV.TabIndex = 1;
            // 
            // additionalServiceIDDataGridViewTextBoxColumn
            // 
            this.additionalServiceIDDataGridViewTextBoxColumn.DataPropertyName = "AdditionalServiceID";
            this.additionalServiceIDDataGridViewTextBoxColumn.HeaderText = "AdditionalServiceID";
            this.additionalServiceIDDataGridViewTextBoxColumn.Name = "additionalServiceIDDataGridViewTextBoxColumn";
            this.additionalServiceIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.additionalServiceIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // additionalServiceNameDataGridViewTextBoxColumn
            // 
            this.additionalServiceNameDataGridViewTextBoxColumn.DataPropertyName = "AdditionalServiceName";
            this.additionalServiceNameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.additionalServiceNameDataGridViewTextBoxColumn.Name = "additionalServiceNameDataGridViewTextBoxColumn";
            this.additionalServiceNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.additionalServiceNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // additionalServiceCostDataGridViewTextBoxColumn
            // 
            this.additionalServiceCostDataGridViewTextBoxColumn.DataPropertyName = "AdditionalServiceCost";
            this.additionalServiceCostDataGridViewTextBoxColumn.HeaderText = "Цена, руб.";
            this.additionalServiceCostDataGridViewTextBoxColumn.Name = "additionalServiceCostDataGridViewTextBoxColumn";
            this.additionalServiceCostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataTableBindingSource
            // 
            this.dataTableBindingSource.DataMember = "DataTable";
            this.dataTableBindingSource.DataSource = this.additionalServicesList;
            // 
            // additionalServicesList
            // 
            this.additionalServicesList.DataSetName = "AdditionalServicesList";
            this.additionalServicesList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // basketButton
            // 
            this.basketButton.Location = new System.Drawing.Point(102, 207);
            this.basketButton.Name = "basketButton";
            this.basketButton.Size = new System.Drawing.Size(128, 40);
            this.basketButton.TabIndex = 2;
            this.basketButton.Text = "Добавить в корзину";
            this.basketButton.UseVisualStyleBackColor = true;
            this.basketButton.Click += new System.EventHandler(this.basketButton_Click);
            // 
            // additionalServiceNameTB
            // 
            this.additionalServiceNameTB.Location = new System.Drawing.Point(9, 45);
            this.additionalServiceNameTB.Name = "additionalServiceNameTB";
            this.additionalServiceNameTB.Size = new System.Drawing.Size(118, 20);
            this.additionalServiceNameTB.TabIndex = 3;
            this.additionalServiceNameTB.TextChanged += new System.EventHandler(this.additionalServiceNameTB_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Наименование доп. \r\nуслуги:";
            // 
            // costButton
            // 
            this.costButton.Location = new System.Drawing.Point(10, 149);
            this.costButton.Name = "costButton";
            this.costButton.Size = new System.Drawing.Size(117, 27);
            this.costButton.TabIndex = 23;
            this.costButton.Text = "Применить";
            this.costButton.UseVisualStyleBackColor = true;
            this.costButton.Click += new System.EventHandler(this.costButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "До:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "От:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Cтоимость:";
            // 
            // highPriceTB
            // 
            this.highPriceTB.Location = new System.Drawing.Point(36, 123);
            this.highPriceTB.MaxLength = 10;
            this.highPriceTB.Name = "highPriceTB";
            this.highPriceTB.Size = new System.Drawing.Size(91, 20);
            this.highPriceTB.TabIndex = 19;
            // 
            // lowPriceTB
            // 
            this.lowPriceTB.Location = new System.Drawing.Point(36, 97);
            this.lowPriceTB.MaxLength = 10;
            this.lowPriceTB.Name = "lowPriceTB";
            this.lowPriceTB.Size = new System.Drawing.Size(91, 20);
            this.lowPriceTB.TabIndex = 18;
            // 
            // dataTableTableAdapter
            // 
            this.dataTableTableAdapter.ClearBeforeFill = true;
            // 
            // showAllAdditionalServicesButton
            // 
            this.showAllAdditionalServicesButton.Location = new System.Drawing.Point(9, 198);
            this.showAllAdditionalServicesButton.Name = "showAllAdditionalServicesButton";
            this.showAllAdditionalServicesButton.Size = new System.Drawing.Size(118, 40);
            this.showAllAdditionalServicesButton.TabIndex = 24;
            this.showAllAdditionalServicesButton.Text = "Показать весь список";
            this.showAllAdditionalServicesButton.UseVisualStyleBackColor = true;
            this.showAllAdditionalServicesButton.Click += new System.EventHandler(this.showAllAdditionalServicesButton_Click);
            // 
            // additionalServicesPriceListReport
            // 
            this.additionalServicesPriceListReport.NeedRefresh = false;
            this.additionalServicesPriceListReport.ReportResourceString = resources.GetString("additionalServicesPriceListReport.ReportResourceString");
            this.additionalServicesPriceListReport.RegisterData(this.additionalServicesList, "additionalServicesList");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.additionalServiceNameTB);
            this.groupBox1.Controls.Add(this.showAllAdditionalServicesButton);
            this.groupBox1.Controls.Add(this.lowPriceTB);
            this.groupBox1.Controls.Add(this.costButton);
            this.groupBox1.Controls.Add(this.highPriceTB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(322, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 246);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтрация";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.additionalServicesDGV);
            this.groupBox2.Location = new System.Drawing.Point(2, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 192);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Дополнительные услуги";
            // 
            // AdditionalServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 259);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.basketButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(480, 280);
            this.Name = "AdditionalServices";
            this.ShowIcon = false;
            this.Text = "Дополнительные услуги";
            this.Load += new System.EventHandler(this.AdditionalServices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.additionalServicesDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.additionalServicesList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.additionalServicesPriceListReport)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView additionalServicesDGV;
        private System.Windows.Forms.Button basketButton;
        private System.Windows.Forms.TextBox additionalServiceNameTB;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button costButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox highPriceTB;
        private System.Windows.Forms.TextBox lowPriceTB;
        private AdditionalServicesList additionalServicesList;
        private System.Windows.Forms.BindingSource dataTableBindingSource;
        private AdditionalServicesListTableAdapters.DataTableTableAdapter dataTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn additionalServiceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn additionalServiceNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn additionalServiceCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button showAllAdditionalServicesButton;
        private FastReport.Report additionalServicesPriceListReport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}