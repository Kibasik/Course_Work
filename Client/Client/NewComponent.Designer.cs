namespace Client
{
    partial class NewComponent
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
            this.label2 = new System.Windows.Forms.Label();
            this.componentTypeCB = new System.Windows.Forms.ComboBox();
            this.componentCategoryCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.componentNameTB = new System.Windows.Forms.TextBox();
            this.componentCostTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.warrantyPeriodCB = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.chooseImageButton = new System.Windows.Forms.Button();
            this.manufactureCountryNameCB = new System.Windows.Forms.ComboBox();
            this.manufacturerNameCB = new System.Windows.Forms.ComboBox();
            this.componentDescriptionRTB = new System.Windows.Forms.RichTextBox();
            this.newManufacturerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тип:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Категория:";
            // 
            // componentTypeCB
            // 
            this.componentTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.componentTypeCB.FormattingEnabled = true;
            this.componentTypeCB.Location = new System.Drawing.Point(15, 25);
            this.componentTypeCB.Name = "componentTypeCB";
            this.componentTypeCB.Size = new System.Drawing.Size(179, 21);
            this.componentTypeCB.TabIndex = 2;
            this.componentTypeCB.SelectedIndexChanged += new System.EventHandler(this.componentTypeCB_SelectedIndexChanged);
            // 
            // componentCategoryCB
            // 
            this.componentCategoryCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.componentCategoryCB.FormattingEnabled = true;
            this.componentCategoryCB.Location = new System.Drawing.Point(209, 25);
            this.componentCategoryCB.Name = "componentCategoryCB";
            this.componentCategoryCB.Size = new System.Drawing.Size(166, 21);
            this.componentCategoryCB.TabIndex = 3;
            this.componentCategoryCB.SelectedIndexChanged += new System.EventHandler(this.componentCategoryCB_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Страна производства:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Производитель:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Наименование:";
            // 
            // componentNameTB
            // 
            this.componentNameTB.Location = new System.Drawing.Point(15, 145);
            this.componentNameTB.MaxLength = 25;
            this.componentNameTB.Name = "componentNameTB";
            this.componentNameTB.Size = new System.Drawing.Size(179, 20);
            this.componentNameTB.TabIndex = 11;
            // 
            // componentCostTB
            // 
            this.componentCostTB.Location = new System.Drawing.Point(15, 184);
            this.componentCostTB.MaxLength = 5;
            this.componentCostTB.Name = "componentCostTB";
            this.componentCostTB.Size = new System.Drawing.Size(179, 20);
            this.componentCostTB.TabIndex = 12;
            this.componentCostTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.componentCostTB_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Цена, руб:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(206, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Срок гарантии, мес.:";
            // 
            // warrantyPeriodCB
            // 
            this.warrantyPeriodCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.warrantyPeriodCB.FormattingEnabled = true;
            this.warrantyPeriodCB.Location = new System.Drawing.Point(209, 65);
            this.warrantyPeriodCB.Name = "warrantyPeriodCB";
            this.warrantyPeriodCB.Size = new System.Drawing.Size(100, 21);
            this.warrantyPeriodCB.TabIndex = 14;
            this.warrantyPeriodCB.SelectedIndexChanged += new System.EventHandler(this.warrantyPeriodCB_SelectedIndexChanged);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(158, 475);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(80, 40);
            this.addButton.TabIndex = 15;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // chooseImageButton
            // 
            this.chooseImageButton.Location = new System.Drawing.Point(209, 145);
            this.chooseImageButton.Name = "chooseImageButton";
            this.chooseImageButton.Size = new System.Drawing.Size(166, 40);
            this.chooseImageButton.TabIndex = 16;
            this.chooseImageButton.Text = "Выбрать изображение";
            this.chooseImageButton.UseVisualStyleBackColor = true;
            this.chooseImageButton.Click += new System.EventHandler(this.chooseImageButton_Click);
            // 
            // manufactureCountryNameCB
            // 
            this.manufactureCountryNameCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.manufactureCountryNameCB.FormattingEnabled = true;
            this.manufactureCountryNameCB.Location = new System.Drawing.Point(15, 65);
            this.manufactureCountryNameCB.Name = "manufactureCountryNameCB";
            this.manufactureCountryNameCB.Size = new System.Drawing.Size(179, 21);
            this.manufactureCountryNameCB.TabIndex = 17;
            this.manufactureCountryNameCB.SelectedIndexChanged += new System.EventHandler(this.manufactureCountryNameCB_SelectedIndexChanged);
            // 
            // manufacturerNameCB
            // 
            this.manufacturerNameCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.manufacturerNameCB.FormattingEnabled = true;
            this.manufacturerNameCB.Location = new System.Drawing.Point(15, 105);
            this.manufacturerNameCB.Name = "manufacturerNameCB";
            this.manufacturerNameCB.Size = new System.Drawing.Size(179, 21);
            this.manufacturerNameCB.TabIndex = 18;
            this.manufacturerNameCB.SelectedIndexChanged += new System.EventHandler(this.manufacturerNameCB_SelectedIndexChanged);
            // 
            // componentDescriptionRTB
            // 
            this.componentDescriptionRTB.BackColor = System.Drawing.SystemColors.Control;
            this.componentDescriptionRTB.Location = new System.Drawing.Point(12, 220);
            this.componentDescriptionRTB.Name = "componentDescriptionRTB";
            this.componentDescriptionRTB.Size = new System.Drawing.Size(363, 249);
            this.componentDescriptionRTB.TabIndex = 19;
            this.componentDescriptionRTB.Text = "";
            // 
            // newManufacturerButton
            // 
            this.newManufacturerButton.Location = new System.Drawing.Point(209, 105);
            this.newManufacturerButton.Name = "newManufacturerButton";
            this.newManufacturerButton.Size = new System.Drawing.Size(21, 21);
            this.newManufacturerButton.TabIndex = 20;
            this.newManufacturerButton.Text = "+";
            this.newManufacturerButton.UseVisualStyleBackColor = true;
            this.newManufacturerButton.Click += new System.EventHandler(this.newManufacturerButton_Click);
            // 
            // NewComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 520);
            this.Controls.Add(this.newManufacturerButton);
            this.Controls.Add(this.componentDescriptionRTB);
            this.Controls.Add(this.manufacturerNameCB);
            this.Controls.Add(this.manufactureCountryNameCB);
            this.Controls.Add(this.chooseImageButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.warrantyPeriodCB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.componentCostTB);
            this.Controls.Add(this.componentNameTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.componentCategoryCB);
            this.Controls.Add(this.componentTypeCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NewComponent";
            this.ShowIcon = false;
            this.Text = "Новое комплектующее";
            this.Load += new System.EventHandler(this.NewComponent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox componentTypeCB;
        private System.Windows.Forms.ComboBox componentCategoryCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox componentNameTB;
        private System.Windows.Forms.TextBox componentCostTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox warrantyPeriodCB;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button chooseImageButton;
        private System.Windows.Forms.ComboBox manufactureCountryNameCB;
        private System.Windows.Forms.ComboBox manufacturerNameCB;
        private System.Windows.Forms.RichTextBox componentDescriptionRTB;
        private System.Windows.Forms.Button newManufacturerButton;
    }
}