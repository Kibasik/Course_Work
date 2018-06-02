namespace Client
{
    partial class NewManufacturer
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
            this.newManufacturerTB = new System.Windows.Forms.TextBox();
            this.addNewManufacturerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя производителя:";
            // 
            // newManufacturerTB
            // 
            this.newManufacturerTB.Location = new System.Drawing.Point(15, 25);
            this.newManufacturerTB.Name = "newManufacturerTB";
            this.newManufacturerTB.Size = new System.Drawing.Size(207, 20);
            this.newManufacturerTB.TabIndex = 1;
            // 
            // addNewManufacturerButton
            // 
            this.addNewManufacturerButton.Location = new System.Drawing.Point(76, 51);
            this.addNewManufacturerButton.Name = "addNewManufacturerButton";
            this.addNewManufacturerButton.Size = new System.Drawing.Size(75, 23);
            this.addNewManufacturerButton.TabIndex = 2;
            this.addNewManufacturerButton.Text = "Добавить";
            this.addNewManufacturerButton.UseVisualStyleBackColor = true;
            this.addNewManufacturerButton.Click += new System.EventHandler(this.addNewManufacturerButton_Click);
            // 
            // NewManufacturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 81);
            this.Controls.Add(this.addNewManufacturerButton);
            this.Controls.Add(this.newManufacturerTB);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(250, 120);
            this.Name = "NewManufacturer";
            this.ShowIcon = false;
            this.Text = "Производитель";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newManufacturerTB;
        private System.Windows.Forms.Button addNewManufacturerButton;
    }
}