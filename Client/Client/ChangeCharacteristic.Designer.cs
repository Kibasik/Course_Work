namespace Client
{
    partial class ChangeCharacteristic
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
            this.characteristicValuesRTB = new System.Windows.Forms.RichTextBox();
            this.characteristicValueCB = new System.Windows.Forms.ComboBox();
            this.characteristicNameCB = new System.Windows.Forms.ComboBox();
            this.characteristicValueTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.acceptButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.warrantyPeriodCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // characteristicValuesRTB
            // 
            this.characteristicValuesRTB.BackColor = System.Drawing.SystemColors.Control;
            this.characteristicValuesRTB.Location = new System.Drawing.Point(12, 12);
            this.characteristicValuesRTB.Name = "characteristicValuesRTB";
            this.characteristicValuesRTB.ReadOnly = true;
            this.characteristicValuesRTB.Size = new System.Drawing.Size(500, 224);
            this.characteristicValuesRTB.TabIndex = 5;
            this.characteristicValuesRTB.Text = "";
            // 
            // characteristicValueCB
            // 
            this.characteristicValueCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.characteristicValueCB.FormattingEnabled = true;
            this.characteristicValueCB.Location = new System.Drawing.Point(185, 255);
            this.characteristicValueCB.Name = "characteristicValueCB";
            this.characteristicValueCB.Size = new System.Drawing.Size(166, 21);
            this.characteristicValueCB.TabIndex = 10;
            this.characteristicValueCB.SelectedIndexChanged += new System.EventHandler(this.characteristicValueCB_SelectedIndexChanged);
            // 
            // characteristicNameCB
            // 
            this.characteristicNameCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.characteristicNameCB.FormattingEnabled = true;
            this.characteristicNameCB.Location = new System.Drawing.Point(15, 255);
            this.characteristicNameCB.Name = "characteristicNameCB";
            this.characteristicNameCB.Size = new System.Drawing.Size(164, 21);
            this.characteristicNameCB.TabIndex = 9;
            this.characteristicNameCB.SelectedIndexChanged += new System.EventHandler(this.characteristicNameCB_SelectedIndexChanged);
            // 
            // characteristicValueTB
            // 
            this.characteristicValueTB.Location = new System.Drawing.Point(357, 256);
            this.characteristicValueTB.Name = "characteristicValueTB";
            this.characteristicValueTB.Size = new System.Drawing.Size(155, 20);
            this.characteristicValueTB.TabIndex = 8;
            this.characteristicValueTB.TextChanged += new System.EventHandler(this.characteristicValueTB_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Значение характеристики:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Характеристика:";
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(432, 279);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(80, 37);
            this.acceptButton.TabIndex = 11;
            this.acceptButton.Text = "Принять";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Срок гарантии, мес.:";
            // 
            // warrantyPeriodCB
            // 
            this.warrantyPeriodCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.warrantyPeriodCB.FormattingEnabled = true;
            this.warrantyPeriodCB.Location = new System.Drawing.Point(15, 295);
            this.warrantyPeriodCB.Name = "warrantyPeriodCB";
            this.warrantyPeriodCB.Size = new System.Drawing.Size(121, 21);
            this.warrantyPeriodCB.TabIndex = 13;
            this.warrantyPeriodCB.SelectedIndexChanged += new System.EventHandler(this.warrantyPeriodCB_SelectedIndexChanged);
            // 
            // ChangeCharacteristic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 328);
            this.Controls.Add(this.warrantyPeriodCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.characteristicValueCB);
            this.Controls.Add(this.characteristicNameCB);
            this.Controls.Add(this.characteristicValueTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.characteristicValuesRTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ChangeCharacteristic";
            this.ShowIcon = false;
            this.Text = "Изменить характеристики";
            this.Load += new System.EventHandler(this.ChangeCharacteristic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox characteristicValuesRTB;
        private System.Windows.Forms.ComboBox characteristicValueCB;
        private System.Windows.Forms.ComboBox characteristicNameCB;
        private System.Windows.Forms.TextBox characteristicValueTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox warrantyPeriodCB;
    }
}