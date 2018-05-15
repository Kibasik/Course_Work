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
            this.label1 = new System.Windows.Forms.Label();
            this.additionalServicesDGV = new System.Windows.Forms.DataGridView();
            this.basketButton = new System.Windows.Forms.Button();
            this.AdditionalServiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdditionalServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdditionalServiceCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.additionalServicesDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите дополнительную услугу:";
            // 
            // additionalServicesDGV
            // 
            this.additionalServicesDGV.AllowUserToAddRows = false;
            this.additionalServicesDGV.AllowUserToDeleteRows = false;
            this.additionalServicesDGV.AllowUserToResizeRows = false;
            this.additionalServicesDGV.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.additionalServicesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.additionalServicesDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AdditionalServiceID,
            this.AdditionalServiceName,
            this.AdditionalServiceCost});
            this.additionalServicesDGV.Location = new System.Drawing.Point(12, 25);
            this.additionalServicesDGV.Name = "additionalServicesDGV";
            this.additionalServicesDGV.ReadOnly = true;
            this.additionalServicesDGV.Size = new System.Drawing.Size(301, 176);
            this.additionalServicesDGV.TabIndex = 1;
            // 
            // basketButton
            // 
            this.basketButton.Location = new System.Drawing.Point(12, 207);
            this.basketButton.Name = "basketButton";
            this.basketButton.Size = new System.Drawing.Size(75, 36);
            this.basketButton.TabIndex = 2;
            this.basketButton.Text = "Добавить в корзину";
            this.basketButton.UseVisualStyleBackColor = true;
            this.basketButton.Click += new System.EventHandler(this.basketButton_Click);
            // 
            // AdditionalServiceID
            // 
            this.AdditionalServiceID.HeaderText = "ID";
            this.AdditionalServiceID.Name = "AdditionalServiceID";
            this.AdditionalServiceID.ReadOnly = true;
            this.AdditionalServiceID.Visible = false;
            // 
            // AdditionalServiceName
            // 
            this.AdditionalServiceName.HeaderText = "Наименование";
            this.AdditionalServiceName.Name = "AdditionalServiceName";
            this.AdditionalServiceName.ReadOnly = true;
            this.AdditionalServiceName.Width = 150;
            // 
            // AdditionalServiceCost
            // 
            this.AdditionalServiceCost.HeaderText = "Цена";
            this.AdditionalServiceCost.Name = "AdditionalServiceCost";
            this.AdditionalServiceCost.ReadOnly = true;
            // 
            // AdditionalServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 281);
            this.Controls.Add(this.basketButton);
            this.Controls.Add(this.additionalServicesDGV);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(480, 320);
            this.Name = "AdditionalServices";
            this.ShowIcon = false;
            this.Text = "AdditionalServices";
            this.Load += new System.EventHandler(this.AdditionalServices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.additionalServicesDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView additionalServicesDGV;
        private System.Windows.Forms.Button basketButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdditionalServiceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdditionalServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdditionalServiceCost;
    }
}