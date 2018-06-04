namespace Client
{
    partial class Suppliers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Suppliers));
            this.suppliersDGV = new System.Windows.Forms.DataGridView();
            this.suppliersIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suppliersNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suppliersAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suppliersEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suppliersPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suppliersList = new Client.SuppliersList();
            this.label1 = new System.Windows.Forms.Label();
            this.dataTableTableAdapter = new Client.SuppliersListTableAdapters.DataTableTableAdapter();
            this.reportButton = new System.Windows.Forms.Button();
            this.suppliersReport = new FastReport.Report();
            this.beginDTP = new System.Windows.Forms.DateTimePicker();
            this.endDTP = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersReport)).BeginInit();
            this.SuspendLayout();
            // 
            // suppliersDGV
            // 
            this.suppliersDGV.AllowUserToAddRows = false;
            this.suppliersDGV.AllowUserToDeleteRows = false;
            this.suppliersDGV.AllowUserToResizeRows = false;
            this.suppliersDGV.AutoGenerateColumns = false;
            this.suppliersDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.suppliersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suppliersDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.suppliersIDDataGridViewTextBoxColumn,
            this.suppliersNameDataGridViewTextBoxColumn,
            this.suppliersAddressDataGridViewTextBoxColumn,
            this.suppliersEmailDataGridViewTextBoxColumn,
            this.suppliersPhoneDataGridViewTextBoxColumn});
            this.suppliersDGV.DataSource = this.dataTableBindingSource;
            this.suppliersDGV.Location = new System.Drawing.Point(15, 25);
            this.suppliersDGV.Name = "suppliersDGV";
            this.suppliersDGV.ReadOnly = true;
            this.suppliersDGV.Size = new System.Drawing.Size(598, 154);
            this.suppliersDGV.TabIndex = 0;
            // 
            // suppliersIDDataGridViewTextBoxColumn
            // 
            this.suppliersIDDataGridViewTextBoxColumn.DataPropertyName = "SuppliersID";
            this.suppliersIDDataGridViewTextBoxColumn.HeaderText = "SuppliersID";
            this.suppliersIDDataGridViewTextBoxColumn.Name = "suppliersIDDataGridViewTextBoxColumn";
            this.suppliersIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.suppliersIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // suppliersNameDataGridViewTextBoxColumn
            // 
            this.suppliersNameDataGridViewTextBoxColumn.DataPropertyName = "SuppliersName";
            this.suppliersNameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.suppliersNameDataGridViewTextBoxColumn.Name = "suppliersNameDataGridViewTextBoxColumn";
            this.suppliersNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.suppliersNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // suppliersAddressDataGridViewTextBoxColumn
            // 
            this.suppliersAddressDataGridViewTextBoxColumn.DataPropertyName = "SuppliersAddress";
            this.suppliersAddressDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.suppliersAddressDataGridViewTextBoxColumn.Name = "suppliersAddressDataGridViewTextBoxColumn";
            this.suppliersAddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.suppliersAddressDataGridViewTextBoxColumn.Width = 150;
            // 
            // suppliersEmailDataGridViewTextBoxColumn
            // 
            this.suppliersEmailDataGridViewTextBoxColumn.DataPropertyName = "SuppliersEmail";
            this.suppliersEmailDataGridViewTextBoxColumn.HeaderText = "E-mail";
            this.suppliersEmailDataGridViewTextBoxColumn.Name = "suppliersEmailDataGridViewTextBoxColumn";
            this.suppliersEmailDataGridViewTextBoxColumn.ReadOnly = true;
            this.suppliersEmailDataGridViewTextBoxColumn.Width = 150;
            // 
            // suppliersPhoneDataGridViewTextBoxColumn
            // 
            this.suppliersPhoneDataGridViewTextBoxColumn.DataPropertyName = "SuppliersPhone";
            this.suppliersPhoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.suppliersPhoneDataGridViewTextBoxColumn.Name = "suppliersPhoneDataGridViewTextBoxColumn";
            this.suppliersPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataTableBindingSource
            // 
            this.dataTableBindingSource.DataMember = "DataTable";
            this.dataTableBindingSource.DataSource = this.suppliersList;
            // 
            // suppliersList
            // 
            this.suppliersList.DataSetName = "SuppliersList";
            this.suppliersList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Список поставщиков:";
            // 
            // dataTableTableAdapter
            // 
            this.dataTableTableAdapter.ClearBeforeFill = true;
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(15, 185);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(115, 40);
            this.reportButton.TabIndex = 2;
            this.reportButton.Text = "Отчет о поставках";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // suppliersReport
            // 
            this.suppliersReport.NeedRefresh = false;
            this.suppliersReport.ReportResourceString = resources.GetString("suppliersReport.ReportResourceString");
            this.suppliersReport.RegisterData(this.suppliersList, "suppliersList");
            // 
            // beginDTP
            // 
            this.beginDTP.Location = new System.Drawing.Point(329, 193);
            this.beginDTP.Name = "beginDTP";
            this.beginDTP.Size = new System.Drawing.Size(139, 20);
            this.beginDTP.TabIndex = 3;
            // 
            // endDTP
            // 
            this.endDTP.Location = new System.Drawing.Point(474, 193);
            this.endDTP.Name = "endDTP";
            this.endDTP.Size = new System.Drawing.Size(139, 20);
            this.endDTP.TabIndex = 4;
            // 
            // Suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 231);
            this.Controls.Add(this.endDTP);
            this.Controls.Add(this.beginDTP);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.suppliersDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 270);
            this.Name = "Suppliers";
            this.ShowIcon = false;
            this.Text = "Поставщики";
            this.Load += new System.EventHandler(this.Suppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.suppliersDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView suppliersDGV;
        private System.Windows.Forms.Label label1;
        private SuppliersList suppliersList;
        private System.Windows.Forms.BindingSource dataTableBindingSource;
        private SuppliersListTableAdapters.DataTableTableAdapter dataTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn suppliersIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suppliersNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suppliersAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suppliersEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suppliersPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button reportButton;
        private FastReport.Report suppliersReport;
        private System.Windows.Forms.DateTimePicker beginDTP;
        private System.Windows.Forms.DateTimePicker endDTP;
    }
}