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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.goodsDGV = new System.Windows.Forms.DataGridView();
            this.TypeCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryGoodsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodsManufacturerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodsCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodsQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.dataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.softwareDGV = new System.Windows.Forms.DataGridView();
            this.SoftwareTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoftwareName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoftwareCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoftwareQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoftwareID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteGoodsButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.deleteSoftwareButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.additionalServicesDGV = new System.Windows.Forms.DataGridView();
            this.AdditionalServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdditionalServiceCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdditionalServiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteAdditionalServiceButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.serviceMaintenanceDGV = new System.Windows.Forms.DataGridView();
            this.ServiceMaintenanceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceMaintenanceCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceMaintenancePeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceMaintenanceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteServiceMaintenanceButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.goodsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwareDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.additionalServicesDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceMaintenanceDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // goodsDGV
            // 
            this.goodsDGV.AllowUserToAddRows = false;
            this.goodsDGV.AllowUserToResizeColumns = false;
            this.goodsDGV.AllowUserToResizeRows = false;
            this.goodsDGV.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.goodsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.goodsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TypeCategoryName,
            this.CategoryGoodsName,
            this.GoodsName,
            this.GoodsManufacturerName,
            this.GoodsCost,
            this.GoodsQuantity,
            this.ID});
            this.goodsDGV.Location = new System.Drawing.Point(15, 25);
            this.goodsDGV.Name = "goodsDGV";
            this.goodsDGV.Size = new System.Drawing.Size(523, 180);
            this.goodsDGV.TabIndex = 0;
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
            // GoodsName
            // 
            this.GoodsName.HeaderText = "Наименование";
            this.GoodsName.Name = "GoodsName";
            this.GoodsName.Width = 180;
            // 
            // GoodsManufacturerName
            // 
            this.GoodsManufacturerName.HeaderText = "Производитель";
            this.GoodsManufacturerName.Name = "GoodsManufacturerName";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(805, 559);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Общая стоимость:";
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Location = new System.Drawing.Point(913, 559);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(52, 13);
            this.totalCostLabel.TabIndex = 2;
            this.totalCostLabel.Text = "TotalCost";
            // 
            // dataTableBindingSource
            // 
            this.dataTableBindingSource.DataMember = "DataTable";
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
            this.softwareDGV.Location = new System.Drawing.Point(15, 298);
            this.softwareDGV.Name = "softwareDGV";
            this.softwareDGV.ReadOnly = true;
            this.softwareDGV.Size = new System.Drawing.Size(523, 193);
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
            this.deleteGoodsButton.Location = new System.Drawing.Point(15, 211);
            this.deleteGoodsButton.Name = "deleteGoodsButton";
            this.deleteGoodsButton.Size = new System.Drawing.Size(102, 48);
            this.deleteGoodsButton.TabIndex = 4;
            this.deleteGoodsButton.Text = "Удалить комплектующее";
            this.deleteGoodsButton.UseVisualStyleBackColor = true;
            this.deleteGoodsButton.Click += new System.EventHandler(this.deleteGoodsButton_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Список комплектующих:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Список программного обеспечения:";
            // 
            // deleteSoftwareButton
            // 
            this.deleteSoftwareButton.Location = new System.Drawing.Point(15, 497);
            this.deleteSoftwareButton.Name = "deleteSoftwareButton";
            this.deleteSoftwareButton.Size = new System.Drawing.Size(80, 33);
            this.deleteSoftwareButton.TabIndex = 7;
            this.deleteSoftwareButton.Text = "Удалить ПО";
            this.deleteSoftwareButton.UseVisualStyleBackColor = true;
            this.deleteSoftwareButton.Click += new System.EventHandler(this.deleteSoftwareButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(572, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Список дополнительных услгуг:";
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
            this.additionalServicesDGV.Location = new System.Drawing.Point(575, 25);
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
            this.deleteAdditionalServiceButton.Location = new System.Drawing.Point(575, 211);
            this.deleteAdditionalServiceButton.Name = "deleteAdditionalServiceButton";
            this.deleteAdditionalServiceButton.Size = new System.Drawing.Size(75, 48);
            this.deleteAdditionalServiceButton.TabIndex = 10;
            this.deleteAdditionalServiceButton.Text = "Удалить доп. услугу";
            this.deleteAdditionalServiceButton.UseVisualStyleBackColor = true;
            this.deleteAdditionalServiceButton.Click += new System.EventHandler(this.deleteAdditionalServiceButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(572, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Список сервисного обслуживания:";
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
            this.serviceMaintenanceDGV.Location = new System.Drawing.Point(575, 298);
            this.serviceMaintenanceDGV.Name = "serviceMaintenanceDGV";
            this.serviceMaintenanceDGV.ReadOnly = true;
            this.serviceMaintenanceDGV.Size = new System.Drawing.Size(390, 193);
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
            this.deleteServiceMaintenanceButton.Location = new System.Drawing.Point(575, 497);
            this.deleteServiceMaintenanceButton.Name = "deleteServiceMaintenanceButton";
            this.deleteServiceMaintenanceButton.Size = new System.Drawing.Size(121, 40);
            this.deleteServiceMaintenanceButton.TabIndex = 13;
            this.deleteServiceMaintenanceButton.Text = "Удалить сервисное обслуживание";
            this.deleteServiceMaintenanceButton.UseVisualStyleBackColor = true;
            this.deleteServiceMaintenanceButton.Click += new System.EventHandler(this.deleteServiceMaintenanceButton_Click);
            // 
            // Basket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 581);
            this.Controls.Add(this.deleteServiceMaintenanceButton);
            this.Controls.Add(this.serviceMaintenanceDGV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.deleteAdditionalServiceButton);
            this.Controls.Add(this.additionalServicesDGV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.deleteSoftwareButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deleteGoodsButton);
            this.Controls.Add(this.softwareDGV);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.goodsDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 620);
            this.Name = "Basket";
            this.ShowIcon = false;
            this.Text = "Basket";
            this.Load += new System.EventHandler(this.Basket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.goodsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwareDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.additionalServicesDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceMaintenanceDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView goodsDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.BindingSource dataTableBindingSource;
        private System.Windows.Forms.DataGridView softwareDGV;
        private System.Windows.Forms.Button deleteGoodsButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button deleteSoftwareButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView additionalServicesDGV;
        private System.Windows.Forms.Button deleteAdditionalServiceButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView serviceMaintenanceDGV;
        private System.Windows.Forms.Button deleteServiceMaintenanceButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryGoodsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsManufacturerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
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
    }
}