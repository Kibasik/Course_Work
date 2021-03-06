﻿namespace Client
{
    partial class Assembly
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.assemblyNameCB = new System.Windows.Forms.ComboBox();
            this.basketButton = new System.Windows.Forms.Button();
            this.assemblyDGV = new System.Windows.Forms.DataGridView();
            this.TypeCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryGoodsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodsManufacturerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodsCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodsQauntity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssemblyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.assemblyDGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название сборки:";
            // 
            // assemblyNameCB
            // 
            this.assemblyNameCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.assemblyNameCB.FormattingEnabled = true;
            this.assemblyNameCB.Location = new System.Drawing.Point(9, 243);
            this.assemblyNameCB.Name = "assemblyNameCB";
            this.assemblyNameCB.Size = new System.Drawing.Size(121, 21);
            this.assemblyNameCB.TabIndex = 1;
            this.assemblyNameCB.SelectedIndexChanged += new System.EventHandler(this.assemblyNameCB_SelectedIndexChanged);
            // 
            // basketButton
            // 
            this.basketButton.Location = new System.Drawing.Point(245, 227);
            this.basketButton.Name = "basketButton";
            this.basketButton.Size = new System.Drawing.Size(126, 40);
            this.basketButton.TabIndex = 2;
            this.basketButton.Text = "Добавить в корзину";
            this.basketButton.UseVisualStyleBackColor = true;
            this.basketButton.Click += new System.EventHandler(this.basketButton_Click);
            // 
            // assemblyDGV
            // 
            this.assemblyDGV.AllowUserToAddRows = false;
            this.assemblyDGV.AllowUserToDeleteRows = false;
            this.assemblyDGV.AllowUserToResizeRows = false;
            this.assemblyDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.assemblyDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assemblyDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TypeCategoryName,
            this.CategoryGoodsName,
            this.GoodsManufacturerName,
            this.GoodsName,
            this.GoodsCost,
            this.GoodsQauntity,
            this.AssemblyID,
            this.GoodsID});
            this.assemblyDGV.Location = new System.Drawing.Point(9, 32);
            this.assemblyDGV.Name = "assemblyDGV";
            this.assemblyDGV.ReadOnly = true;
            this.assemblyDGV.Size = new System.Drawing.Size(645, 190);
            this.assemblyDGV.TabIndex = 3;
            // 
            // TypeCategoryName
            // 
            dataGridViewCellStyle3.NullValue = null;
            this.TypeCategoryName.DefaultCellStyle = dataGridViewCellStyle3;
            this.TypeCategoryName.HeaderText = "Тип";
            this.TypeCategoryName.Name = "TypeCategoryName";
            this.TypeCategoryName.ReadOnly = true;
            this.TypeCategoryName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // CategoryGoodsName
            // 
            this.CategoryGoodsName.HeaderText = "Категория";
            this.CategoryGoodsName.Name = "CategoryGoodsName";
            this.CategoryGoodsName.ReadOnly = true;
            // 
            // GoodsManufacturerName
            // 
            this.GoodsManufacturerName.HeaderText = "Производитель";
            this.GoodsManufacturerName.Name = "GoodsManufacturerName";
            this.GoodsManufacturerName.ReadOnly = true;
            // 
            // GoodsName
            // 
            this.GoodsName.HeaderText = "Наименование";
            this.GoodsName.Name = "GoodsName";
            this.GoodsName.ReadOnly = true;
            // 
            // GoodsCost
            // 
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.GoodsCost.DefaultCellStyle = dataGridViewCellStyle4;
            this.GoodsCost.HeaderText = "Цена, руб.";
            this.GoodsCost.Name = "GoodsCost";
            this.GoodsCost.ReadOnly = true;
            // 
            // GoodsQauntity
            // 
            this.GoodsQauntity.HeaderText = "Количество";
            this.GoodsQauntity.Name = "GoodsQauntity";
            this.GoodsQauntity.ReadOnly = true;
            // 
            // AssemblyID
            // 
            this.AssemblyID.HeaderText = "AssemblyID";
            this.AssemblyID.Name = "AssemblyID";
            this.AssemblyID.ReadOnly = true;
            this.AssemblyID.Visible = false;
            // 
            // GoodsID
            // 
            this.GoodsID.HeaderText = "GoodsID";
            this.GoodsID.Name = "GoodsID";
            this.GoodsID.ReadOnly = true;
            this.GoodsID.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(454, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Общая стоимость:";
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Location = new System.Drawing.Point(562, 241);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(13, 13);
            this.totalCostLabel.TabIndex = 5;
            this.totalCostLabel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Список комплектующих:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.totalCostLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.assemblyNameCB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.basketButton);
            this.groupBox1.Controls.Add(this.assemblyDGV);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(662, 276);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор сборки";
            // 
            // Assembly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 284);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(670, 320);
            this.Name = "Assembly";
            this.ShowIcon = false;
            this.Text = "Сборка";
            this.Load += new System.EventHandler(this.Assembly_Load);
            ((System.ComponentModel.ISupportInitialize)(this.assemblyDGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox assemblyNameCB;
        private System.Windows.Forms.Button basketButton;
        private System.Windows.Forms.DataGridView assemblyDGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryGoodsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsManufacturerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsQauntity;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssemblyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}