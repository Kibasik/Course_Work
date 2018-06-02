namespace Client
{
    partial class Software
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Software));
            this.label1 = new System.Windows.Forms.Label();
            this.softwareTypeCB = new System.Windows.Forms.ComboBox();
            this.softwareDGV = new System.Windows.Forms.DataGridView();
            this.softwareTypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.softwareNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.softwareCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.softwareIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.softwareList = new Client.SoftwareList();
            this.showAllSoftwareButton = new System.Windows.Forms.Button();
            this.basketButton = new System.Windows.Forms.Button();
            this.dataTableTableAdapter = new Client.SoftwareListTableAdapters.DataTableTableAdapter();
            this.costButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.highPriceTB = new System.Windows.Forms.TextBox();
            this.lowPriceTB = new System.Windows.Forms.TextBox();
            this.softwareQuantityTB = new System.Windows.Forms.TextBox();
            this.softwareNameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.softwarePriceListReport = new FastReport.Report();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.softwareDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwareList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwarePriceListReport)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тип программного обеспечения:";
            // 
            // softwareTypeCB
            // 
            this.softwareTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.softwareTypeCB.FormattingEnabled = true;
            this.softwareTypeCB.Location = new System.Drawing.Point(9, 32);
            this.softwareTypeCB.Name = "softwareTypeCB";
            this.softwareTypeCB.Size = new System.Drawing.Size(166, 21);
            this.softwareTypeCB.TabIndex = 1;
            this.softwareTypeCB.SelectedIndexChanged += new System.EventHandler(this.softwareTypeCB_SelectedIndexChanged);
            // 
            // softwareDGV
            // 
            this.softwareDGV.AllowUserToAddRows = false;
            this.softwareDGV.AllowUserToDeleteRows = false;
            this.softwareDGV.AllowUserToResizeRows = false;
            this.softwareDGV.AutoGenerateColumns = false;
            this.softwareDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.softwareDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.softwareDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.softwareTypeNameDataGridViewTextBoxColumn,
            this.softwareNameDataGridViewTextBoxColumn,
            this.softwareCostDataGridViewTextBoxColumn,
            this.softwareIDDataGridViewTextBoxColumn});
            this.softwareDGV.DataSource = this.dataTableBindingSource;
            this.softwareDGV.Location = new System.Drawing.Point(6, 19);
            this.softwareDGV.Name = "softwareDGV";
            this.softwareDGV.ReadOnly = true;
            this.softwareDGV.Size = new System.Drawing.Size(456, 183);
            this.softwareDGV.TabIndex = 2;
            // 
            // softwareTypeNameDataGridViewTextBoxColumn
            // 
            this.softwareTypeNameDataGridViewTextBoxColumn.DataPropertyName = "SoftwareTypeName";
            this.softwareTypeNameDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.softwareTypeNameDataGridViewTextBoxColumn.Name = "softwareTypeNameDataGridViewTextBoxColumn";
            this.softwareTypeNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.softwareTypeNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // softwareNameDataGridViewTextBoxColumn
            // 
            this.softwareNameDataGridViewTextBoxColumn.DataPropertyName = "SoftwareName";
            this.softwareNameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.softwareNameDataGridViewTextBoxColumn.Name = "softwareNameDataGridViewTextBoxColumn";
            this.softwareNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.softwareNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // softwareCostDataGridViewTextBoxColumn
            // 
            this.softwareCostDataGridViewTextBoxColumn.DataPropertyName = "SoftwareCost";
            this.softwareCostDataGridViewTextBoxColumn.HeaderText = "Цена, руб.";
            this.softwareCostDataGridViewTextBoxColumn.Name = "softwareCostDataGridViewTextBoxColumn";
            this.softwareCostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // softwareIDDataGridViewTextBoxColumn
            // 
            this.softwareIDDataGridViewTextBoxColumn.DataPropertyName = "SoftwareID";
            this.softwareIDDataGridViewTextBoxColumn.HeaderText = "SoftwareID";
            this.softwareIDDataGridViewTextBoxColumn.Name = "softwareIDDataGridViewTextBoxColumn";
            this.softwareIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.softwareIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataTableBindingSource
            // 
            this.dataTableBindingSource.DataMember = "DataTable";
            this.dataTableBindingSource.DataSource = this.softwareList;
            // 
            // softwareList
            // 
            this.softwareList.DataSetName = "SoftwareList";
            this.softwareList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // showAllSoftwareButton
            // 
            this.showAllSoftwareButton.Location = new System.Drawing.Point(9, 211);
            this.showAllSoftwareButton.Name = "showAllSoftwareButton";
            this.showAllSoftwareButton.Size = new System.Drawing.Size(166, 33);
            this.showAllSoftwareButton.TabIndex = 3;
            this.showAllSoftwareButton.Text = "Показать весь список";
            this.showAllSoftwareButton.UseVisualStyleBackColor = true;
            this.showAllSoftwareButton.Click += new System.EventHandler(this.showAllSoftwareButton_Click);
            // 
            // basketButton
            // 
            this.basketButton.Location = new System.Drawing.Point(103, 223);
            this.basketButton.Name = "basketButton";
            this.basketButton.Size = new System.Drawing.Size(118, 36);
            this.basketButton.TabIndex = 5;
            this.basketButton.Text = "Добавить в корзину";
            this.basketButton.UseVisualStyleBackColor = true;
            this.basketButton.Click += new System.EventHandler(this.basketButton_Click);
            // 
            // dataTableTableAdapter
            // 
            this.dataTableTableAdapter.ClearBeforeFill = true;
            // 
            // costButton
            // 
            this.costButton.Location = new System.Drawing.Point(9, 124);
            this.costButton.Name = "costButton";
            this.costButton.Size = new System.Drawing.Size(106, 25);
            this.costButton.TabIndex = 23;
            this.costButton.Text = "Применить";
            this.costButton.UseVisualStyleBackColor = true;
            this.costButton.Click += new System.EventHandler(this.costButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "До:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "От:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Стоимость:";
            // 
            // highPriceTB
            // 
            this.highPriceTB.Location = new System.Drawing.Point(35, 98);
            this.highPriceTB.MaxLength = 10;
            this.highPriceTB.Name = "highPriceTB";
            this.highPriceTB.Size = new System.Drawing.Size(80, 20);
            this.highPriceTB.TabIndex = 19;
            this.highPriceTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.highPriceTB_KeyPress);
            // 
            // lowPriceTB
            // 
            this.lowPriceTB.Location = new System.Drawing.Point(35, 72);
            this.lowPriceTB.MaxLength = 10;
            this.lowPriceTB.Name = "lowPriceTB";
            this.lowPriceTB.Size = new System.Drawing.Size(80, 20);
            this.lowPriceTB.TabIndex = 18;
            this.lowPriceTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lowPriceTB_KeyPress);
            // 
            // softwareQuantityTB
            // 
            this.softwareQuantityTB.Location = new System.Drawing.Point(12, 239);
            this.softwareQuantityTB.MaxLength = 3;
            this.softwareQuantityTB.Name = "softwareQuantityTB";
            this.softwareQuantityTB.Size = new System.Drawing.Size(85, 20);
            this.softwareQuantityTB.TabIndex = 24;
            this.softwareQuantityTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.softwareQuantityTB_KeyPress);
            // 
            // softwareNameTB
            // 
            this.softwareNameTB.Location = new System.Drawing.Point(9, 168);
            this.softwareNameTB.Name = "softwareNameTB";
            this.softwareNameTB.Size = new System.Drawing.Size(166, 20);
            this.softwareNameTB.TabIndex = 25;
            this.softwareNameTB.TextChanged += new System.EventHandler(this.softwareNameTB_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Наименование ПО:";
            // 
            // softwarePriceListReport
            // 
            this.softwarePriceListReport.NeedRefresh = false;
            this.softwarePriceListReport.ReportResourceString = resources.GetString("softwarePriceListReport.ReportResourceString");
            this.softwarePriceListReport.RegisterData(this.softwareList, "softwareList");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Количество ПО:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.softwareTypeCB);
            this.groupBox1.Controls.Add(this.lowPriceTB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.highPriceTB);
            this.groupBox1.Controls.Add(this.showAllSoftwareButton);
            this.groupBox1.Controls.Add(this.softwareNameTB);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.costButton);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(486, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 250);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтрация";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.softwareDGV);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(468, 208);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Программное обеспечение";
            // 
            // Software
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 271);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.softwareQuantityTB);
            this.Controls.Add(this.basketButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(680, 310);
            this.Name = "Software";
            this.ShowIcon = false;
            this.Text = "Программное обеспечение";
            this.Load += new System.EventHandler(this.Software_Load);
            ((System.ComponentModel.ISupportInitialize)(this.softwareDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwareList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwarePriceListReport)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox softwareTypeCB;
        private System.Windows.Forms.DataGridView softwareDGV;
        private System.Windows.Forms.Button showAllSoftwareButton;
        private System.Windows.Forms.Button basketButton;
        private SoftwareList softwareList;
        private System.Windows.Forms.BindingSource dataTableBindingSource;
        private SoftwareListTableAdapters.DataTableTableAdapter dataTableTableAdapter;
        private System.Windows.Forms.Button costButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox highPriceTB;
        private System.Windows.Forms.TextBox lowPriceTB;
        private System.Windows.Forms.TextBox softwareQuantityTB;
        private System.Windows.Forms.TextBox softwareNameTB;
        private System.Windows.Forms.Label label2;
        private FastReport.Report softwarePriceListReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn softwareTypeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn softwareNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn softwareCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn softwareIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}