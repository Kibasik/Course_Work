﻿namespace Client
{
    partial class Workers
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
            this.label1 = new System.Windows.Forms.Label();
            this.workersDGV = new System.Windows.Forms.DataGridView();
            this.workerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerPostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workersList = new Client.WorkersList();
            this.dataTableTableAdapter = new Client.WorkersListTableAdapters.DataTableTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.workerNameTB = new System.Windows.Forms.TextBox();
            this.workerPostTB = new System.Windows.Forms.TextBox();
            this.workerPostButton = new System.Windows.Forms.Button();
            this.showAllWorkersButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.workersDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Список сотрудников:";
            // 
            // workersDGV
            // 
            this.workersDGV.AllowUserToAddRows = false;
            this.workersDGV.AllowUserToDeleteRows = false;
            this.workersDGV.AllowUserToResizeRows = false;
            this.workersDGV.AutoGenerateColumns = false;
            this.workersDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.workersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workersDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.workerNameDataGridViewTextBoxColumn,
            this.workerPostDataGridViewTextBoxColumn,
            this.workerIDDataGridViewTextBoxColumn});
            this.workersDGV.DataSource = this.dataTableBindingSource;
            this.workersDGV.Location = new System.Drawing.Point(15, 25);
            this.workersDGV.Name = "workersDGV";
            this.workersDGV.Size = new System.Drawing.Size(477, 150);
            this.workersDGV.TabIndex = 1;
            // 
            // workerNameDataGridViewTextBoxColumn
            // 
            this.workerNameDataGridViewTextBoxColumn.DataPropertyName = "WorkerName";
            this.workerNameDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.workerNameDataGridViewTextBoxColumn.Name = "workerNameDataGridViewTextBoxColumn";
            this.workerNameDataGridViewTextBoxColumn.Width = 250;
            // 
            // workerPostDataGridViewTextBoxColumn
            // 
            this.workerPostDataGridViewTextBoxColumn.DataPropertyName = "WorkerPost";
            this.workerPostDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.workerPostDataGridViewTextBoxColumn.Name = "workerPostDataGridViewTextBoxColumn";
            this.workerPostDataGridViewTextBoxColumn.Width = 180;
            // 
            // workerIDDataGridViewTextBoxColumn
            // 
            this.workerIDDataGridViewTextBoxColumn.DataPropertyName = "WorkerID";
            this.workerIDDataGridViewTextBoxColumn.HeaderText = "WorkerID";
            this.workerIDDataGridViewTextBoxColumn.Name = "workerIDDataGridViewTextBoxColumn";
            this.workerIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataTableBindingSource
            // 
            this.dataTableBindingSource.DataMember = "DataTable";
            this.dataTableBindingSource.DataSource = this.workersList;
            // 
            // workersList
            // 
            this.workersList.DataSetName = "WorkersList";
            this.workersList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTableTableAdapter
            // 
            this.dataTableTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ФИО:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Должность:";
            // 
            // workerNameTB
            // 
            this.workerNameTB.Location = new System.Drawing.Point(9, 31);
            this.workerNameTB.Name = "workerNameTB";
            this.workerNameTB.Size = new System.Drawing.Size(100, 20);
            this.workerNameTB.TabIndex = 4;
            this.workerNameTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // workerPostTB
            // 
            this.workerPostTB.Location = new System.Drawing.Point(9, 70);
            this.workerPostTB.Name = "workerPostTB";
            this.workerPostTB.Size = new System.Drawing.Size(100, 20);
            this.workerPostTB.TabIndex = 5;
            // 
            // workerPostButton
            // 
            this.workerPostButton.Location = new System.Drawing.Point(371, 16);
            this.workerPostButton.Name = "workerPostButton";
            this.workerPostButton.Size = new System.Drawing.Size(100, 35);
            this.workerPostButton.TabIndex = 6;
            this.workerPostButton.Text = "Отфильтровать";
            this.workerPostButton.UseVisualStyleBackColor = true;
            this.workerPostButton.Click += new System.EventHandler(this.workerPostButton_Click);
            // 
            // showAllWorkersButton
            // 
            this.showAllWorkersButton.Location = new System.Drawing.Point(371, 54);
            this.showAllWorkersButton.Name = "showAllWorkersButton";
            this.showAllWorkersButton.Size = new System.Drawing.Size(100, 36);
            this.showAllWorkersButton.TabIndex = 7;
            this.showAllWorkersButton.Text = "Показать весь список";
            this.showAllWorkersButton.UseVisualStyleBackColor = true;
            this.showAllWorkersButton.Click += new System.EventHandler(this.showAllWorkersButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.showAllWorkersButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.workerPostButton);
            this.groupBox1.Controls.Add(this.workerNameTB);
            this.groupBox1.Controls.Add(this.workerPostTB);
            this.groupBox1.Location = new System.Drawing.Point(15, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 98);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтрация";
            // 
            // Workers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 291);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.workersDGV);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(520, 330);
            this.Name = "Workers";
            this.ShowIcon = false;
            this.Text = "Сотрудники";
            this.Load += new System.EventHandler(this.Workers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.workersDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView workersDGV;
        private WorkersList workersList;
        private System.Windows.Forms.BindingSource dataTableBindingSource;
        private WorkersListTableAdapters.DataTableTableAdapter dataTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerPostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox workerNameTB;
        private System.Windows.Forms.TextBox workerPostTB;
        private System.Windows.Forms.Button workerPostButton;
        private System.Windows.Forms.Button showAllWorkersButton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}