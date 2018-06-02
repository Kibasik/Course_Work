namespace Client
{
    partial class Supply
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Supply));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.suppliersCB = new System.Windows.Forms.ComboBox();
            this.supplyDGV = new System.Windows.Forms.DataGridView();
            this.typeCategoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryGoodsNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsManufacturerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goods = new Client.Goods();
            this.supplyDateDTP = new System.Windows.Forms.DateTimePicker();
            this.dataTableTableAdapter = new Client.GoodsTableAdapters.DataTableTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.workerNameCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.supplyQuantityTB = new System.Windows.Forms.TextBox();
            this.supplyButton = new System.Windows.Forms.Button();
            this.acceptSupplyButton = new System.Windows.Forms.Button();
            this.supplyReport = new FastReport.Report();
            this.supplyStructureButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.supplyDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyReport)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поставщик:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата поставки:";
            // 
            // suppliersCB
            // 
            this.suppliersCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.suppliersCB.FormattingEnabled = true;
            this.suppliersCB.Location = new System.Drawing.Point(15, 25);
            this.suppliersCB.Name = "suppliersCB";
            this.suppliersCB.Size = new System.Drawing.Size(164, 21);
            this.suppliersCB.TabIndex = 2;
            this.suppliersCB.SelectedIndexChanged += new System.EventHandler(this.suppliersCB_SelectedIndexChanged);
            // 
            // supplyDGV
            // 
            this.supplyDGV.AllowUserToAddRows = false;
            this.supplyDGV.AllowUserToDeleteRows = false;
            this.supplyDGV.AllowUserToResizeRows = false;
            this.supplyDGV.AutoGenerateColumns = false;
            this.supplyDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.supplyDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplyDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeCategoryNameDataGridViewTextBoxColumn,
            this.categoryGoodsNameDataGridViewTextBoxColumn,
            this.goodsManufacturerNameDataGridViewTextBoxColumn,
            this.goodsNameDataGridViewTextBoxColumn,
            this.goodsCostDataGridViewTextBoxColumn,
            this.goodsIDDataGridViewTextBoxColumn,
            this.goodsAmountDataGridViewTextBoxColumn});
            this.supplyDGV.DataSource = this.dataTableBindingSource;
            this.supplyDGV.Location = new System.Drawing.Point(15, 52);
            this.supplyDGV.Name = "supplyDGV";
            this.supplyDGV.ReadOnly = true;
            this.supplyDGV.Size = new System.Drawing.Size(646, 179);
            this.supplyDGV.TabIndex = 3;
            // 
            // typeCategoryNameDataGridViewTextBoxColumn
            // 
            this.typeCategoryNameDataGridViewTextBoxColumn.DataPropertyName = "TypeCategoryName";
            this.typeCategoryNameDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.typeCategoryNameDataGridViewTextBoxColumn.Name = "typeCategoryNameDataGridViewTextBoxColumn";
            this.typeCategoryNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryGoodsNameDataGridViewTextBoxColumn
            // 
            this.categoryGoodsNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryGoodsName";
            this.categoryGoodsNameDataGridViewTextBoxColumn.HeaderText = "Категория";
            this.categoryGoodsNameDataGridViewTextBoxColumn.Name = "categoryGoodsNameDataGridViewTextBoxColumn";
            this.categoryGoodsNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // goodsManufacturerNameDataGridViewTextBoxColumn
            // 
            this.goodsManufacturerNameDataGridViewTextBoxColumn.DataPropertyName = "GoodsManufacturerName";
            this.goodsManufacturerNameDataGridViewTextBoxColumn.HeaderText = "Производитель";
            this.goodsManufacturerNameDataGridViewTextBoxColumn.Name = "goodsManufacturerNameDataGridViewTextBoxColumn";
            this.goodsManufacturerNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.goodsManufacturerNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // goodsNameDataGridViewTextBoxColumn
            // 
            this.goodsNameDataGridViewTextBoxColumn.DataPropertyName = "GoodsName";
            this.goodsNameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.goodsNameDataGridViewTextBoxColumn.Name = "goodsNameDataGridViewTextBoxColumn";
            this.goodsNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.goodsNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // goodsCostDataGridViewTextBoxColumn
            // 
            this.goodsCostDataGridViewTextBoxColumn.DataPropertyName = "GoodsCost";
            this.goodsCostDataGridViewTextBoxColumn.HeaderText = "Цена, руб.";
            this.goodsCostDataGridViewTextBoxColumn.Name = "goodsCostDataGridViewTextBoxColumn";
            this.goodsCostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // goodsIDDataGridViewTextBoxColumn
            // 
            this.goodsIDDataGridViewTextBoxColumn.DataPropertyName = "GoodsID";
            this.goodsIDDataGridViewTextBoxColumn.HeaderText = "GoodsID";
            this.goodsIDDataGridViewTextBoxColumn.Name = "goodsIDDataGridViewTextBoxColumn";
            this.goodsIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.goodsIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // goodsAmountDataGridViewTextBoxColumn
            // 
            this.goodsAmountDataGridViewTextBoxColumn.DataPropertyName = "GoodsAmount";
            this.goodsAmountDataGridViewTextBoxColumn.HeaderText = "GoodsAmount";
            this.goodsAmountDataGridViewTextBoxColumn.Name = "goodsAmountDataGridViewTextBoxColumn";
            this.goodsAmountDataGridViewTextBoxColumn.ReadOnly = true;
            this.goodsAmountDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataTableBindingSource
            // 
            this.dataTableBindingSource.DataMember = "DataTable";
            this.dataTableBindingSource.DataSource = this.goods;
            // 
            // goods
            // 
            this.goods.DataSetName = "Goods";
            this.goods.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // supplyDateDTP
            // 
            this.supplyDateDTP.Location = new System.Drawing.Point(359, 26);
            this.supplyDateDTP.Name = "supplyDateDTP";
            this.supplyDateDTP.Size = new System.Drawing.Size(200, 20);
            this.supplyDateDTP.TabIndex = 4;
            // 
            // dataTableTableAdapter
            // 
            this.dataTableTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Сотрудник:";
            // 
            // workerNameCB
            // 
            this.workerNameCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workerNameCB.FormattingEnabled = true;
            this.workerNameCB.Location = new System.Drawing.Point(185, 25);
            this.workerNameCB.Name = "workerNameCB";
            this.workerNameCB.Size = new System.Drawing.Size(168, 21);
            this.workerNameCB.TabIndex = 6;
            this.workerNameCB.SelectedIndexChanged += new System.EventHandler(this.workerNameCB_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Количество товаров:";
            // 
            // supplyQuantityTB
            // 
            this.supplyQuantityTB.Location = new System.Drawing.Point(18, 250);
            this.supplyQuantityTB.Name = "supplyQuantityTB";
            this.supplyQuantityTB.Size = new System.Drawing.Size(110, 20);
            this.supplyQuantityTB.TabIndex = 8;
            this.supplyQuantityTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.supplyQuantityTB_KeyPress);
            // 
            // supplyButton
            // 
            this.supplyButton.Location = new System.Drawing.Point(134, 237);
            this.supplyButton.Name = "supplyButton";
            this.supplyButton.Size = new System.Drawing.Size(80, 33);
            this.supplyButton.TabIndex = 9;
            this.supplyButton.Text = "Добавить";
            this.supplyButton.UseVisualStyleBackColor = true;
            this.supplyButton.Click += new System.EventHandler(this.supplyButton_Click);
            // 
            // acceptSupplyButton
            // 
            this.acceptSupplyButton.Location = new System.Drawing.Point(220, 237);
            this.acceptSupplyButton.Name = "acceptSupplyButton";
            this.acceptSupplyButton.Size = new System.Drawing.Size(133, 33);
            this.acceptSupplyButton.TabIndex = 10;
            this.acceptSupplyButton.Text = "Подтвердить поставку";
            this.acceptSupplyButton.UseVisualStyleBackColor = true;
            this.acceptSupplyButton.Click += new System.EventHandler(this.acceptSupplyButton_Click);
            // 
            // supplyReport
            // 
            this.supplyReport.NeedRefresh = false;
            this.supplyReport.ReportResourceString = resources.GetString("supplyReport.ReportResourceString");
            // 
            // supplyStructureButton
            // 
            this.supplyStructureButton.Location = new System.Drawing.Point(359, 237);
            this.supplyStructureButton.Name = "supplyStructureButton";
            this.supplyStructureButton.Size = new System.Drawing.Size(118, 33);
            this.supplyStructureButton.TabIndex = 11;
            this.supplyStructureButton.Text = "Состав поставки";
            this.supplyStructureButton.UseVisualStyleBackColor = true;
            this.supplyStructureButton.Click += new System.EventHandler(this.supplyStructureButton_Click);
            // 
            // Supply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 276);
            this.Controls.Add(this.supplyStructureButton);
            this.Controls.Add(this.acceptSupplyButton);
            this.Controls.Add(this.supplyButton);
            this.Controls.Add(this.supplyQuantityTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.workerNameCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.supplyDateDTP);
            this.Controls.Add(this.supplyDGV);
            this.Controls.Add(this.suppliersCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "Supply";
            this.ShowIcon = false;
            this.Text = "Поставки";
            this.Load += new System.EventHandler(this.Supply_Load);
            ((System.ComponentModel.ISupportInitialize)(this.supplyDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox suppliersCB;
        private System.Windows.Forms.DataGridView supplyDGV;
        private System.Windows.Forms.DateTimePicker supplyDateDTP;
        private Goods goods;
        private System.Windows.Forms.BindingSource dataTableBindingSource;
        private GoodsTableAdapters.DataTableTableAdapter dataTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeCategoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryGoodsNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsManufacturerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox workerNameCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox supplyQuantityTB;
        private System.Windows.Forms.Button supplyButton;
        private System.Windows.Forms.Button acceptSupplyButton;
        private FastReport.Report supplyReport;
        private System.Windows.Forms.Button supplyStructureButton;
    }
}