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
            this.descriptionPB = new System.Windows.Forms.PictureBox();
            this.descriptionRTB = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionPB)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionPB
            // 
            this.descriptionPB.Location = new System.Drawing.Point(12, 12);
            this.descriptionPB.Name = "descriptionPB";
            this.descriptionPB.Size = new System.Drawing.Size(311, 229);
            this.descriptionPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.descriptionPB.TabIndex = 0;
            this.descriptionPB.TabStop = false;
            // 
            // descriptionRTB
            // 
            this.descriptionRTB.Location = new System.Drawing.Point(329, 237);
            this.descriptionRTB.Name = "descriptionRTB";
            this.descriptionRTB.ReadOnly = true;
            this.descriptionRTB.Size = new System.Drawing.Size(503, 352);
            this.descriptionRTB.TabIndex = 1;
            this.descriptionRTB.Text = "";
            // 
            // DescriptionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 601);
            this.Controls.Add(this.descriptionRTB);
            this.Controls.Add(this.descriptionPB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(860, 640);
            this.Name = "DescriptionWindow";
            this.ShowIcon = false;
            this.Text = "Описание товара";
            this.Load += new System.EventHandler(this.DescriptionWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.descriptionPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox descriptionPB;
        private System.Windows.Forms.RichTextBox descriptionRTB;
    }
}