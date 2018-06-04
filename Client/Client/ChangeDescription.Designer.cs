namespace Client
{
    partial class ChangeDescription
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
            this.componentPB = new System.Windows.Forms.PictureBox();
            this.componentDescriptionRTB = new System.Windows.Forms.RichTextBox();
            this.componentNameLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.changeImageButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.componentPB)).BeginInit();
            this.SuspendLayout();
            // 
            // componentPB
            // 
            this.componentPB.Location = new System.Drawing.Point(12, 12);
            this.componentPB.Name = "componentPB";
            this.componentPB.Size = new System.Drawing.Size(233, 218);
            this.componentPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.componentPB.TabIndex = 0;
            this.componentPB.TabStop = false;
            // 
            // componentDescriptionRTB
            // 
            this.componentDescriptionRTB.BackColor = System.Drawing.SystemColors.Control;
            this.componentDescriptionRTB.Location = new System.Drawing.Point(261, 28);
            this.componentDescriptionRTB.Name = "componentDescriptionRTB";
            this.componentDescriptionRTB.Size = new System.Drawing.Size(351, 156);
            this.componentDescriptionRTB.TabIndex = 1;
            this.componentDescriptionRTB.Text = "";
            // 
            // componentNameLabel
            // 
            this.componentNameLabel.AutoSize = true;
            this.componentNameLabel.Location = new System.Drawing.Point(258, 12);
            this.componentNameLabel.Name = "componentNameLabel";
            this.componentNameLabel.Size = new System.Drawing.Size(83, 13);
            this.componentNameLabel.TabIndex = 2;
            this.componentNameLabel.Text = "Наименование";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(532, 190);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(80, 40);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // changeImageButton
            // 
            this.changeImageButton.Location = new System.Drawing.Point(261, 190);
            this.changeImageButton.Name = "changeImageButton";
            this.changeImageButton.Size = new System.Drawing.Size(90, 40);
            this.changeImageButton.TabIndex = 4;
            this.changeImageButton.Text = "Изменить изображение";
            this.changeImageButton.UseVisualStyleBackColor = true;
            this.changeImageButton.Click += new System.EventHandler(this.changeImageButton_Click);
            // 
            // ChangeDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 240);
            this.Controls.Add(this.changeImageButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.componentNameLabel);
            this.Controls.Add(this.componentDescriptionRTB);
            this.Controls.Add(this.componentPB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ChangeDescription";
            this.ShowIcon = false;
            this.Text = "Изменить описание";
            this.Load += new System.EventHandler(this.ChangeDescription_Load);
            ((System.ComponentModel.ISupportInitialize)(this.componentPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox componentPB;
        private System.Windows.Forms.RichTextBox componentDescriptionRTB;
        private System.Windows.Forms.Label componentNameLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button changeImageButton;
    }
}