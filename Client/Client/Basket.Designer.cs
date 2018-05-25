namespace Client
{
    partial class Basket
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.goodsDGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.softwareDGV = new System.Windows.Forms.DataGridView();
            this.SoftwareTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoftwareName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoftwareCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoftwareQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoftwareID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteGoodsButton = new System.Windows.Forms.Button();
            this.deleteSoftwareButton = new System.Windows.Forms.Button();
            this.additionalServicesDGV = new System.Windows.Forms.DataGridView();
            this.AdditionalServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdditionalServiceCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdditionalServiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteAdditionalServiceButton = new System.Windows.Forms.Button();
            this.serviceMaintenanceDGV = new System.Windows.Forms.DataGridView();
            this.ServiceMaintenanceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceMaintenanceCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceMaintenancePeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceMaintenanceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteServiceMaintenanceButton = new System.Windows.Forms.Button();
            this.buyButton = new System.Windows.Forms.Button();
            this.basketTC = new System.Windows.Forms.TabControl();
            this.componentsTP = new System.Windows.Forms.TabPage();
            this.softwareTP = new System.Windows.Forms.TabPage();
            this.additionalServicesTP = new System.Windows.Forms.TabPage();
            this.serviceMaintenanceTP = new System.Windows.Forms.TabPage();
            this.TypeCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryGoodsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodsManufacturerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodsCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodsQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.goodsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwareDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.additionalServicesDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceMaintenanceDGV)).BeginInit();
            this.basketTC.SuspendLayout();
            this.componentsTP.SuspendLayout();
            this.softwareTP.SuspendLayout();
            this.additionalServicesTP.SuspendLayout();
            this.serviceMaintenanceTP.SuspendLayout();
            this.SuspendLayout();
            // 
            // goodsDGV
            // 
            this.goodsDGV.AllowUserToAddRows = false;
            this.goodsDGV.AllowUserToResizeColumns = false;
            this.goodsDGV.AllowUserToResizeRows = false;
            this.goodsDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.goodsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.goodsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TypeCategoryName,
            this.CategoryGoodsName,
            this.GoodsManufacturerName,
            this.GoodsName,
            this.GoodsCost,
            this.GoodsQuantity,
            this.ID});
            this.goodsDGV.Location = new System.Drawing.Point(6, 3);
            this.goodsDGV.Name = "goodsDGV";
            this.goodsDGV.Size = new System.Drawing.Size(535, 180);
            this.goodsDGV.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(403, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Общая стоимость:";
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Location = new System.Drawing.Point(511, 323);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(52, 13);
            this.totalCostLabel.TabIndex = 2;
            this.totalCostLabel.Text = "TotalCost";
            // 
            // softwareDGV
            // 
            this.softwareDGV.AllowUserToAddRows = false;
            this.softwareDGV.AllowUserToDeleteRows = false;
            this.softwareDGV.AllowUserToResizeRows = false;
            this.softwareDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.softwareDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.softwareDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoftwareTypeName,
            this.SoftwareName,
            this.SoftwareCost,
            this.SoftwareQuantity,
            this.SoftwareID});
            this.softwareDGV.Location = new System.Drawing.Point(3, 3);
            this.softwareDGV.Name = "softwareDGV";
            this.softwareDGV.ReadOnly = true;
            this.softwareDGV.Size = new System.Drawing.Size(538, 193);
            this.softwareDGV.TabIndex = 3;
            // 
            // SoftwareTypeName
            // 
            this.SoftwareTypeName.HeaderText = "Тип";
            this.SoftwareTypeName.Name = "SoftwareTypeName";
            this.SoftwareTypeName.ReadOnly = true;
            this.SoftwareTypeName.Width = 200;
            // 
            // SoftwareName
            // 
            this.SoftwareName.HeaderText = "Наименование";
            this.SoftwareName.Name = "SoftwareName";
            this.SoftwareName.ReadOnly = true;
            this.SoftwareName.Width = 200;
            // 
            // SoftwareCost
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.SoftwareCost.DefaultCellStyle = dataGridViewCellStyle2;
            this.SoftwareCost.HeaderText = "Цена, руб.";
            this.SoftwareCost.Name = "SoftwareCost";
            this.SoftwareCost.ReadOnly = true;
            // 
            // SoftwareQuantity
            // 
            this.SoftwareQuantity.HeaderText = "Количество";
            this.SoftwareQuantity.Name = "SoftwareQuantity";
            this.SoftwareQuantity.ReadOnly = true;
            // 
            // SoftwareID
            // 
            this.SoftwareID.HeaderText = "ID";
            this.SoftwareID.Name = "SoftwareID";
            this.SoftwareID.ReadOnly = true;
            this.SoftwareID.Visible = false;
            // 
            // deleteGoodsButton
            // 
            this.deleteGoodsButton.Location = new System.Drawing.Point(6, 189);
            this.deleteGoodsButton.Name = "deleteGoodsButton";
            this.deleteGoodsButton.Size = new System.Drawing.Size(80, 40);
            this.deleteGoodsButton.TabIndex = 4;
            this.deleteGoodsButton.Text = "Удалить";
            this.deleteGoodsButton.UseVisualStyleBackColor = true;
            this.deleteGoodsButton.Click += new System.EventHandler(this.deleteGoodsButton_Click_1);
            // 
            // deleteSoftwareButton
            // 
            this.deleteSoftwareButton.Location = new System.Drawing.Point(3, 202);
            this.deleteSoftwareButton.Name = "deleteSoftwareButton";
            this.deleteSoftwareButton.Size = new System.Drawing.Size(80, 40);
            this.deleteSoftwareButton.TabIndex = 7;
            this.deleteSoftwareButton.Text = "Удалить";
            this.deleteSoftwareButton.UseVisualStyleBackColor = true;
            this.deleteSoftwareButton.Click += new System.EventHandler(this.deleteSoftwareButton_Click);
            // 
            // additionalServicesDGV
            // 
            this.additionalServicesDGV.AllowUserToAddRows = false;
            this.additionalServicesDGV.AllowUserToDeleteRows = false;
            this.additionalServicesDGV.AllowUserToResizeRows = false;
            this.additionalServicesDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.additionalServicesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.additionalServicesDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AdditionalServiceName,
            this.AdditionalServiceCost,
            this.AdditionalServiceID});
            this.additionalServicesDGV.Location = new System.Drawing.Point(3, 3);
            this.additionalServicesDGV.Name = "additionalServicesDGV";
            this.additionalServicesDGV.ReadOnly = true;
            this.additionalServicesDGV.Size = new System.Drawing.Size(294, 180);
            this.additionalServicesDGV.TabIndex = 9;
            // 
            // AdditionalServiceName
            // 
            this.AdditionalServiceName.HeaderText = "Наименование";
            this.AdditionalServiceName.Name = "AdditionalServiceName";
            this.AdditionalServiceName.ReadOnly = true;
            this.AdditionalServiceName.Width = 135;
            // 
            // AdditionalServiceCost
            // 
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.AdditionalServiceCost.DefaultCellStyle = dataGridViewCellStyle3;
            this.AdditionalServiceCost.HeaderText = "Цена, руб.";
            this.AdditionalServiceCost.Name = "AdditionalServiceCost";
            this.AdditionalServiceCost.ReadOnly = true;
            // 
            // AdditionalServiceID
            // 
            this.AdditionalServiceID.HeaderText = "ID";
            this.AdditionalServiceID.Name = "AdditionalServiceID";
            this.AdditionalServiceID.ReadOnly = true;
            this.AdditionalServiceID.Visible = false;
            // 
            // deleteAdditionalServiceButton
            // 
            this.deleteAdditionalServiceButton.Location = new System.Drawing.Point(3, 189);
            this.deleteAdditionalServiceButton.Name = "deleteAdditionalServiceButton";
            this.deleteAdditionalServiceButton.Size = new System.Drawing.Size(80, 40);
            this.deleteAdditionalServiceButton.TabIndex = 10;
            this.deleteAdditionalServiceButton.Text = "Удалить";
            this.deleteAdditionalServiceButton.UseVisualStyleBackColor = true;
            this.deleteAdditionalServiceButton.Click += new System.EventHandler(this.deleteAdditionalServiceButton_Click);
            // 
            // serviceMaintenanceDGV
            // 
            this.serviceMaintenanceDGV.AllowUserToAddRows = false;
            this.serviceMaintenanceDGV.AllowUserToDeleteRows = false;
            this.serviceMaintenanceDGV.AllowUserToResizeRows = false;
            this.serviceMaintenanceDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.serviceMaintenanceDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serviceMaintenanceDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServiceMaintenanceName,
            this.ServiceMaintenanceCost,
            this.ServiceMaintenancePeriod,
            this.ServiceMaintenanceID});
            this.serviceMaintenanceDGV.Location = new System.Drawing.Point(3, 3);
            this.serviceMaintenanceDGV.Name = "serviceMaintenanceDGV";
            this.serviceMaintenanceDGV.ReadOnly = true;
            this.serviceMaintenanceDGV.Size = new System.Drawing.Size(400, 193);
            this.serviceMaintenanceDGV.TabIndex = 12;
            // 
            // ServiceMaintenanceName
            // 
            this.ServiceMaintenanceName.HeaderText = "Наименование";
            this.ServiceMaintenanceName.Name = "ServiceMaintenanceName";
            this.ServiceMaintenanceName.ReadOnly = true;
            this.ServiceMaintenanceName.Width = 150;
            // 
            // ServiceMaintenanceCost
            // 
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.ServiceMaintenanceCost.DefaultCellStyle = dataGridViewCellStyle4;
            this.ServiceMaintenanceCost.HeaderText = "Цена, руб.";
            this.ServiceMaintenanceCost.Name = "ServiceMaintenanceCost";
            this.ServiceMaintenanceCost.ReadOnly = true;
            // 
            // ServiceMaintenancePeriod
            // 
            this.ServiceMaintenancePeriod.HeaderText = "Срок, дней";
            this.ServiceMaintenancePeriod.Name = "ServiceMaintenancePeriod";
            this.ServiceMaintenancePeriod.ReadOnly = true;
            // 
            // ServiceMaintenanceID
            // 
            this.ServiceMaintenanceID.HeaderText = "ID";
            this.ServiceMaintenanceID.Name = "ServiceMaintenanceID";
            this.ServiceMaintenanceID.ReadOnly = true;
            this.ServiceMaintenanceID.Visible = false;
            // 
            // deleteServiceMaintenanceButton
            // 
            this.deleteServiceMaintenanceButton.Location = new System.Drawing.Point(3, 202);
            this.deleteServiceMaintenanceButton.Name = "deleteServiceMaintenanceButton";
            this.deleteServiceMaintenanceButton.Size = new System.Drawing.Size(80, 40);
            this.deleteServiceMaintenanceButton.TabIndex = 13;
            this.deleteServiceMaintenanceButton.Text = "Удалить";
            this.deleteServiceMaintenanceButton.UseVisualStyleBackColor = true;
            this.deleteServiceMaintenanceButton.Click += new System.EventHandler(this.deleteServiceMaintenanceButton_Click);
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(237, 296);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(80, 40);
            this.buyButton.TabIndex = 14;
            this.buyButton.Text = "Оплатить";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // basketTC
            // 
            this.basketTC.Controls.Add(this.componentsTP);
            this.basketTC.Controls.Add(this.softwareTP);
            this.basketTC.Controls.Add(this.additionalServicesTP);
            this.basketTC.Controls.Add(this.serviceMaintenanceTP);
            this.basketTC.Location = new System.Drawing.Point(12, 12);
            this.basketTC.Name = "basketTC";
            this.basketTC.SelectedIndex = 0;
            this.basketTC.Size = new System.Drawing.Size(555, 278);
            this.basketTC.TabIndex = 15;
            // 
            // componentsTP
            // 
            this.componentsTP.BackColor = System.Drawing.SystemColors.Control;
            this.componentsTP.Controls.Add(this.goodsDGV);
            this.componentsTP.Controls.Add(this.deleteGoodsButton);
            this.componentsTP.Location = new System.Drawing.Point(4, 22);
            this.componentsTP.Name = "componentsTP";
            this.componentsTP.Padding = new System.Windows.Forms.Padding(3);
            this.componentsTP.Size = new System.Drawing.Size(547, 252);
            this.componentsTP.TabIndex = 0;
            this.componentsTP.Text = "Комплектующие";
            // 
            // softwareTP
            // 
            this.softwareTP.BackColor = System.Drawing.SystemColors.Control;
            this.softwareTP.Controls.Add(this.softwareDGV);
            this.softwareTP.Controls.Add(this.deleteSoftwareButton);
            this.softwareTP.Location = new System.Drawing.Point(4, 22);
            this.softwareTP.Name = "softwareTP";
            this.softwareTP.Padding = new System.Windows.Forms.Padding(3);
            this.softwareTP.Size = new System.Drawing.Size(547, 252);
            this.softwareTP.TabIndex = 1;
            this.softwareTP.Text = "Программное обеспечение";
            // 
            // additionalServicesTP
            // 
            this.additionalServicesTP.BackColor = System.Drawing.SystemColors.Control;
            this.additionalServicesTP.Controls.Add(this.additionalServicesDGV);
            this.additionalServicesTP.Controls.Add(this.deleteAdditionalServiceButton);
            this.additionalServicesTP.Location = new System.Drawing.Point(4, 22);
            this.additionalServicesTP.Name = "additionalServicesTP";
            this.additionalServicesTP.Size = new System.Drawing.Size(547, 252);
            this.additionalServicesTP.TabIndex = 2;
            this.additionalServicesTP.Text = "Дополнительные услуги";
            // 
            // serviceMaintenanceTP
            // 
            this.serviceMaintenanceTP.BackColor = System.Drawing.SystemColors.Control;
            this.serviceMaintenanceTP.Controls.Add(this.serviceMaintenanceDGV);
            this.serviceMaintenanceTP.Controls.Add(this.deleteServiceMaintenanceButton);
            this.serviceMaintenanceTP.Location = new System.Drawing.Point(4, 22);
            this.serviceMaintenanceTP.Name = "serviceMaintenanceTP";
            this.serviceMaintenanceTP.Size = new System.Drawing.Size(547, 252);
            this.serviceMaintenanceTP.TabIndex = 3;
            this.serviceMaintenanceTP.Text = "Сервисное обслуживание";
            // 
            // TypeCategoryName
            // 
            this.TypeCategoryName.HeaderText = "Тип";
            this.TypeCategoryName.Name = "TypeCategoryName";
            // 
            // CategoryGoodsName
            // 
            this.CategoryGoodsName.HeaderText = "Категория";
            this.CategoryGoodsName.Name = "CategoryGoodsName";
            this.CategoryGoodsName.Width = 120;
            // 
            // GoodsManufacturerName
            // 
            this.GoodsManufacturerName.HeaderText = "Производитель";
            this.GoodsManufacturerName.Name = "GoodsManufacturerName";
            // 
            // GoodsName
            // 
            this.GoodsName.HeaderText = "Наименование";
            this.GoodsName.Name = "GoodsName";
            this.GoodsName.Width = 180;
            // 
            // GoodsCost
            // 
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.GoodsCost.DefaultCellStyle = dataGridViewCellStyle1;
            this.GoodsCost.HeaderText = "Цена, руб.";
            this.GoodsCost.Name = "GoodsCost";
            // 
            // GoodsQuantity
            // 
            this.GoodsQuantity.HeaderText = "Количество";
            this.GoodsQuantity.Name = "GoodsQuantity";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // Basket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.basketTC);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Basket";
            this.ShowIcon = false;
            this.Text = "Basket";
            this.Load += new System.EventHandler(this.Basket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.goodsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwareDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.additionalServicesDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceMaintenanceDGV)).EndInit();
            this.basketTC.ResumeLayout(false);
            this.componentsTP.ResumeLayout(false);
            this.softwareTP.ResumeLayout(false);
            this.additionalServicesTP.ResumeLayout(false);
            this.serviceMaintenanceTP.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView goodsDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.DataGridView softwareDGV;
        private System.Windows.Forms.Button deleteGoodsButton;
        private System.Windows.Forms.Button deleteSoftwareButton;
        private System.Windows.Forms.DataGridView additionalServicesDGV;
        private System.Windows.Forms.Button deleteAdditionalServiceButton;
        private System.Windows.Forms.DataGridView serviceMaintenanceDGV;
        private System.Windows.Forms.Button deleteServiceMaintenanceButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoftwareTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoftwareName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoftwareCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoftwareQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoftwareID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdditionalServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdditionalServiceCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdditionalServiceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceMaintenanceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceMaintenanceCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceMaintenancePeriod;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceMaintenanceID;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.TabControl basketTC;
        private System.Windows.Forms.TabPage componentsTP;
        private System.Windows.Forms.TabPage softwareTP;
        private System.Windows.Forms.TabPage additionalServicesTP;
        private System.Windows.Forms.TabPage serviceMaintenanceTP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryGoodsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsManufacturerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}