namespace Client
{
    partial class DeliveryAndSale
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
            this.deliveryMethodCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.deliveryCostLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.deliveryCityTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.deliveryStreetTB = new System.Windows.Forms.TextBox();
            this.deliveryHouseTB = new System.Windows.Forms.TextBox();
            this.deliveryFlatTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.deliveryDateDTP = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.clientNameTB = new System.Windows.Forms.TextBox();
            this.clientSurnameTB = new System.Windows.Forms.TextBox();
            this.clientPatronymicTB = new System.Windows.Forms.TextBox();
            this.clientPhoneMTB = new System.Windows.Forms.MaskedTextBox();
            this.clientEmailTB = new System.Windows.Forms.TextBox();
            this.buyButton = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.workerNameCB = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.paymentMethodCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите способ доставки:";
            // 
            // deliveryMethodCB
            // 
            this.deliveryMethodCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deliveryMethodCB.FormattingEnabled = true;
            this.deliveryMethodCB.Location = new System.Drawing.Point(15, 25);
            this.deliveryMethodCB.Name = "deliveryMethodCB";
            this.deliveryMethodCB.Size = new System.Drawing.Size(146, 21);
            this.deliveryMethodCB.TabIndex = 1;
            this.deliveryMethodCB.SelectedIndexChanged += new System.EventHandler(this.deliveryMethodCB_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Стоимость доставки:";
            // 
            // deliveryCostLabel
            // 
            this.deliveryCostLabel.AutoSize = true;
            this.deliveryCostLabel.Location = new System.Drawing.Point(316, 28);
            this.deliveryCostLabel.Name = "deliveryCostLabel";
            this.deliveryCostLabel.Size = new System.Drawing.Size(162, 13);
            this.deliveryCostLabel.TabIndex = 3;
            this.deliveryCostLabel.Text = "Тут будет стоимость доставки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Введите адрес доставки:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Выберите дату доставки:";
            // 
            // deliveryCityTB
            // 
            this.deliveryCityTB.Location = new System.Drawing.Point(15, 108);
            this.deliveryCityTB.MaxLength = 25;
            this.deliveryCityTB.Name = "deliveryCityTB";
            this.deliveryCityTB.Size = new System.Drawing.Size(146, 20);
            this.deliveryCityTB.TabIndex = 6;
            this.deliveryCityTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.deliveryCityTB_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Город:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Улица:";
            // 
            // deliveryStreetTB
            // 
            this.deliveryStreetTB.Location = new System.Drawing.Point(15, 158);
            this.deliveryStreetTB.MaxLength = 25;
            this.deliveryStreetTB.Name = "deliveryStreetTB";
            this.deliveryStreetTB.Size = new System.Drawing.Size(146, 20);
            this.deliveryStreetTB.TabIndex = 9;
            this.deliveryStreetTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.deliveryStreetTB_KeyPress);
            // 
            // deliveryHouseTB
            // 
            this.deliveryHouseTB.Location = new System.Drawing.Point(15, 212);
            this.deliveryHouseTB.MaxLength = 3;
            this.deliveryHouseTB.Name = "deliveryHouseTB";
            this.deliveryHouseTB.Size = new System.Drawing.Size(146, 20);
            this.deliveryHouseTB.TabIndex = 10;
            this.deliveryHouseTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.deliveryHouseTB_KeyPress);
            // 
            // deliveryFlatTB
            // 
            this.deliveryFlatTB.Location = new System.Drawing.Point(15, 264);
            this.deliveryFlatTB.MaxLength = 3;
            this.deliveryFlatTB.Name = "deliveryFlatTB";
            this.deliveryFlatTB.Size = new System.Drawing.Size(146, 20);
            this.deliveryFlatTB.TabIndex = 11;
            this.deliveryFlatTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.deliveryFlatTB_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Дом:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Квартира:";
            // 
            // deliveryDateDTP
            // 
            this.deliveryDateDTP.Location = new System.Drawing.Point(15, 316);
            this.deliveryDateDTP.Name = "deliveryDateDTP";
            this.deliveryDateDTP.Size = new System.Drawing.Size(178, 20);
            this.deliveryDateDTP.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(223, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Введите контактные данные:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(223, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Имя:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(223, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Фамилия:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(223, 196);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Отчество:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(223, 248);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Номер телефона:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(223, 300);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "Электронная почта:";
            // 
            // clientNameTB
            // 
            this.clientNameTB.Location = new System.Drawing.Point(226, 158);
            this.clientNameTB.MaxLength = 20;
            this.clientNameTB.Name = "clientNameTB";
            this.clientNameTB.Size = new System.Drawing.Size(153, 20);
            this.clientNameTB.TabIndex = 21;
            this.clientNameTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.clientNameTB_KeyPress);
            // 
            // clientSurnameTB
            // 
            this.clientSurnameTB.Location = new System.Drawing.Point(226, 108);
            this.clientSurnameTB.MaxLength = 20;
            this.clientSurnameTB.Name = "clientSurnameTB";
            this.clientSurnameTB.Size = new System.Drawing.Size(153, 20);
            this.clientSurnameTB.TabIndex = 22;
            this.clientSurnameTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.clientSurnameTB_KeyPress);
            // 
            // clientPatronymicTB
            // 
            this.clientPatronymicTB.Location = new System.Drawing.Point(226, 212);
            this.clientPatronymicTB.MaxLength = 20;
            this.clientPatronymicTB.Name = "clientPatronymicTB";
            this.clientPatronymicTB.Size = new System.Drawing.Size(153, 20);
            this.clientPatronymicTB.TabIndex = 23;
            this.clientPatronymicTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.clientPatronymicTB_KeyPress);
            // 
            // clientPhoneMTB
            // 
            this.clientPhoneMTB.Location = new System.Drawing.Point(226, 264);
            this.clientPhoneMTB.Mask = "(999) 000-0000";
            this.clientPhoneMTB.Name = "clientPhoneMTB";
            this.clientPhoneMTB.Size = new System.Drawing.Size(153, 20);
            this.clientPhoneMTB.TabIndex = 24;
            // 
            // clientEmailTB
            // 
            this.clientEmailTB.Location = new System.Drawing.Point(226, 316);
            this.clientEmailTB.MaxLength = 25;
            this.clientEmailTB.Name = "clientEmailTB";
            this.clientEmailTB.Size = new System.Drawing.Size(153, 20);
            this.clientEmailTB.TabIndex = 25;
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(235, 402);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(75, 27);
            this.buyButton.TabIndex = 26;
            this.buyButton.Text = "Оплатить";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(437, 92);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(121, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "Выберите сотрдуника:";
            // 
            // workerNameCB
            // 
            this.workerNameCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workerNameCB.FormattingEnabled = true;
            this.workerNameCB.Location = new System.Drawing.Point(437, 108);
            this.workerNameCB.Name = "workerNameCB";
            this.workerNameCB.Size = new System.Drawing.Size(137, 21);
            this.workerNameCB.TabIndex = 28;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(437, 142);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(139, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "Выберите способ оплаты:";
            // 
            // paymentMethodCB
            // 
            this.paymentMethodCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paymentMethodCB.FormattingEnabled = true;
            this.paymentMethodCB.Location = new System.Drawing.Point(437, 158);
            this.paymentMethodCB.Name = "paymentMethodCB";
            this.paymentMethodCB.Size = new System.Drawing.Size(137, 21);
            this.paymentMethodCB.TabIndex = 30;
            // 
            // DeliveryAndSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.paymentMethodCB);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.workerNameCB);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.clientEmailTB);
            this.Controls.Add(this.clientPhoneMTB);
            this.Controls.Add(this.clientPatronymicTB);
            this.Controls.Add(this.clientSurnameTB);
            this.Controls.Add(this.clientNameTB);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.deliveryDateDTP);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.deliveryFlatTB);
            this.Controls.Add(this.deliveryHouseTB);
            this.Controls.Add(this.deliveryStreetTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.deliveryCityTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deliveryCostLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deliveryMethodCB);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "DeliveryAndSale";
            this.ShowIcon = false;
            this.Text = "Delivery";
            this.Load += new System.EventHandler(this.Delivery_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox deliveryMethodCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label deliveryCostLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox deliveryCityTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox deliveryStreetTB;
        private System.Windows.Forms.TextBox deliveryHouseTB;
        private System.Windows.Forms.TextBox deliveryFlatTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker deliveryDateDTP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox clientNameTB;
        private System.Windows.Forms.TextBox clientSurnameTB;
        private System.Windows.Forms.TextBox clientPatronymicTB;
        private System.Windows.Forms.MaskedTextBox clientPhoneMTB;
        private System.Windows.Forms.TextBox clientEmailTB;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox workerNameCB;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox paymentMethodCB;
    }
}