namespace Client
{
    partial class NewSoftware
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
            this.label2 = new System.Windows.Forms.Label();
            this.softwareTypeCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.softwareCostTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.softwareNameTB = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Тип:";
            // 
            // softwareTypeCB
            // 
            this.softwareTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.softwareTypeCB.FormattingEnabled = true;
            this.softwareTypeCB.Location = new System.Drawing.Point(12, 25);
            this.softwareTypeCB.Name = "softwareTypeCB";
            this.softwareTypeCB.Size = new System.Drawing.Size(201, 21);
            this.softwareTypeCB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Цена, руб.";
            // 
            // softwareCostTB
            // 
            this.softwareCostTB.Location = new System.Drawing.Point(12, 104);
            this.softwareCostTB.MaxLength = 5;
            this.softwareCostTB.Name = "softwareCostTB";
            this.softwareCostTB.Size = new System.Drawing.Size(100, 20);
            this.softwareCostTB.TabIndex = 5;
            this.softwareCostTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.softwareCostTB_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Наименование:";
            // 
            // softwareNameTB
            // 
            this.softwareNameTB.Location = new System.Drawing.Point(12, 65);
            this.softwareNameTB.MaxLength = 50;
            this.softwareNameTB.Name = "softwareNameTB";
            this.softwareNameTB.Size = new System.Drawing.Size(201, 20);
            this.softwareNameTB.TabIndex = 7;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 139);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(201, 33);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // NewSoftware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 184);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.softwareNameTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.softwareCostTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.softwareTypeCB);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NewSoftware";
            this.ShowIcon = false;
            this.Text = "Новое ПО";
            this.Load += new System.EventHandler(this.NewGoods_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox softwareTypeCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox softwareCostTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox softwareNameTB;
        private System.Windows.Forms.Button addButton;
    }
}