namespace Client
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.goodsListDGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goodsCatalogForClient = new Client.GoodsCatalogForClient();
            this.dataTableTableAdapter = new Client.GoodsCatalogForClientTableAdapters.DataTableTableAdapter();
            this.stationaryRB = new System.Windows.Forms.RadioButton();
            this.mobileRB = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.goodsCategoryCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.allGoodsListButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.goodsListDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsCatalogForClient)).BeginInit();
            this.SuspendLayout();
            // 
            // goodsListDGV
            // 
            this.goodsListDGV.AllowUserToAddRows = false;
            this.goodsListDGV.AllowUserToDeleteRows = false;
            this.goodsListDGV.AllowUserToResizeColumns = false;
            this.goodsListDGV.AllowUserToResizeRows = false;
            this.goodsListDGV.AutoGenerateColumns = false;
            this.goodsListDGV.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.goodsListDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.goodsListDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.goodsListDGV.DataSource = this.dataTableBindingSource;
            this.goodsListDGV.Location = new System.Drawing.Point(12, 82);
            this.goodsListDGV.Name = "goodsListDGV";
            this.goodsListDGV.ReadOnly = true;
            this.goodsListDGV.Size = new System.Drawing.Size(545, 246);
            this.goodsListDGV.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "GoodsName";
            this.dataGridViewTextBoxColumn1.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CategoryGoodsName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Категория";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "GoodsCost";
            this.dataGridViewTextBoxColumn3.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "GoodsManufacturerName";
            this.dataGridViewTextBoxColumn4.HeaderText = "Производитель";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TypeCategoryName";
            this.dataGridViewTextBoxColumn5.HeaderText = "Тип";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataTableBindingSource
            // 
            this.dataTableBindingSource.DataMember = "DataTable";
            this.dataTableBindingSource.DataSource = this.goodsCatalogForClient;
            // 
            // goodsCatalogForClient
            // 
            this.goodsCatalogForClient.DataSetName = "GoodsCatalogForClient";
            this.goodsCatalogForClient.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTableTableAdapter
            // 
            this.dataTableTableAdapter.ClearBeforeFill = true;
            // 
            // stationaryRB
            // 
            this.stationaryRB.AutoSize = true;
            this.stationaryRB.Location = new System.Drawing.Point(15, 34);
            this.stationaryRB.Name = "stationaryRB";
            this.stationaryRB.Size = new System.Drawing.Size(97, 17);
            this.stationaryRB.TabIndex = 3;
            this.stationaryRB.TabStop = true;
            this.stationaryRB.Text = "Стационарное";
            this.stationaryRB.UseVisualStyleBackColor = true;
            this.stationaryRB.CheckedChanged += new System.EventHandler(this.stationaryRB_CheckedChanged_1);
            // 
            // mobileRB
            // 
            this.mobileRB.AutoSize = true;
            this.mobileRB.Location = new System.Drawing.Point(118, 34);
            this.mobileRB.Name = "mobileRB";
            this.mobileRB.Size = new System.Drawing.Size(82, 17);
            this.mobileRB.TabIndex = 4;
            this.mobileRB.TabStop = true;
            this.mobileRB.Text = "Мобильное";
            this.mobileRB.UseVisualStyleBackColor = true;
            this.mobileRB.CheckedChanged += new System.EventHandler(this.mobileRB_CheckedChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Тип комплектующего:";
            // 
            // goodsCategoryCB
            // 
            this.goodsCategoryCB.FormattingEnabled = true;
            this.goodsCategoryCB.Location = new System.Drawing.Point(228, 34);
            this.goodsCategoryCB.Name = "goodsCategoryCB";
            this.goodsCategoryCB.Size = new System.Drawing.Size(188, 21);
            this.goodsCategoryCB.TabIndex = 6;
            this.goodsCategoryCB.SelectedIndexChanged += new System.EventHandler(this.goodsCategoryCB_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Категория комплектующего:";
            // 
            // allGoodsListButton
            // 
            this.allGoodsListButton.Location = new System.Drawing.Point(446, 22);
            this.allGoodsListButton.Name = "allGoodsListButton";
            this.allGoodsListButton.Size = new System.Drawing.Size(98, 42);
            this.allGoodsListButton.TabIndex = 9;
            this.allGoodsListButton.Text = "Показать весь список";
            this.allGoodsListButton.UseVisualStyleBackColor = true;
            this.allGoodsListButton.Click += new System.EventHandler(this.allGoodsListButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.allGoodsListButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.goodsCategoryCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mobileRB);
            this.Controls.Add(this.stationaryRB);
            this.Controls.Add(this.goodsListDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.goodsListDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsCatalogForClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryGoodsNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsManufacturerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeCategoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView goodsListDGV;
        private GoodsCatalogForClient goodsCatalogForClient;
        private System.Windows.Forms.BindingSource dataTableBindingSource;
        private GoodsCatalogForClientTableAdapters.DataTableTableAdapter dataTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.RadioButton stationaryRB;
        private System.Windows.Forms.RadioButton mobileRB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox goodsCategoryCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button allGoodsListButton;
    }
}

