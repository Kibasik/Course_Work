namespace Client
{
    partial class Description
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
            this.goodsImagePB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.goodsImagePB)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionRTB
            // 
            this.descriptionRTB.Location = new System.Drawing.Point(295, 235);
            this.descriptionRTB.Name = "descriptionRTB";
            this.descriptionRTB.ReadOnly = true;
            this.descriptionRTB.Size = new System.Drawing.Size(537, 354);
            this.descriptionRTB.TabIndex = 1;
            this.descriptionRTB.Text = "";
            // 
            // goodsNameLabel
            // 
            this.goodsNameLabel.AutoSize = true;
            this.goodsNameLabel.Location = new System.Drawing.Point(229, 9);
            this.goodsNameLabel.Name = "goodsNameLabel";
            this.goodsNameLabel.Size = new System.Drawing.Size(170, 13);
            this.goodsNameLabel.TabIndex = 2;
            this.goodsNameLabel.Text = "Тут будет наименование товара";
            // 
            // goodsImagePB
            // 
            this.goodsImagePB.Location = new System.Drawing.Point(12, 33);
            this.goodsImagePB.Name = "goodsImagePB";
            this.goodsImagePB.Size = new System.Drawing.Size(277, 202);
            this.goodsImagePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.goodsImagePB.TabIndex = 3;
            this.goodsImagePB.TabStop = false;
            // 
            // Description
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 601);
            this.Controls.Add(this.goodsImagePB);
            this.Controls.Add(this.goodsNameLabel);
            this.Controls.Add(this.descriptionRTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(860, 640);
            this.Name = "Description";
            this.ShowIcon = false;
            this.Text = "Description";
            this.Load += new System.EventHandler(this.DescriptionWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.goodsImagePB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox descriptionRTB;
        private System.Windows.Forms.Label goodsNameLabel;
        private System.Windows.Forms.PictureBox goodsImagePB;
    }
}