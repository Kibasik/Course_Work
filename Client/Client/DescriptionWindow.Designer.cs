namespace Client
{
    partial class DescriptionWindow
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
            this.descriptionRTB = new System.Windows.Forms.RichTextBox();
            this.goodsNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // descriptionRTB
            // 
            this.descriptionRTB.Location = new System.Drawing.Point(12, 25);
            this.descriptionRTB.Name = "descriptionRTB";
            this.descriptionRTB.ReadOnly = true;
            this.descriptionRTB.Size = new System.Drawing.Size(600, 404);
            this.descriptionRTB.TabIndex = 1;
            this.descriptionRTB.Text = "";
            // 
            // goodsNameLabel
            // 
            this.goodsNameLabel.AutoSize = true;
            this.goodsNameLabel.Location = new System.Drawing.Point(207, 9);
            this.goodsNameLabel.Name = "goodsNameLabel";
            this.goodsNameLabel.Size = new System.Drawing.Size(170, 13);
            this.goodsNameLabel.TabIndex = 2;
            this.goodsNameLabel.Text = "Тут будет наименование товара";
            // 
            // DescriptionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.goodsNameLabel);
            this.Controls.Add(this.descriptionRTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "DescriptionWindow";
            this.ShowIcon = false;
            this.Text = "Описание товара";
            this.Load += new System.EventHandler(this.DescriptionWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox descriptionRTB;
        private System.Windows.Forms.Label goodsNameLabel;
    }
}