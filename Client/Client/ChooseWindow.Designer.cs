namespace Client
{
    partial class ChooseWindow
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
            this.acceptButton = new System.Windows.Forms.Button();
            this.managerRB = new System.Windows.Forms.RadioButton();
            this.storekeeperRB = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите должность:";
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(106, 150);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(80, 40);
            this.acceptButton.TabIndex = 3;
            this.acceptButton.Text = "Принять";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // managerRB
            // 
            this.managerRB.AutoSize = true;
            this.managerRB.Location = new System.Drawing.Point(106, 67);
            this.managerRB.Name = "managerRB";
            this.managerRB.Size = new System.Drawing.Size(78, 17);
            this.managerRB.TabIndex = 4;
            this.managerRB.TabStop = true;
            this.managerRB.Text = "Менеджер";
            this.managerRB.UseVisualStyleBackColor = true;
            // 
            // storekeeperRB
            // 
            this.storekeeperRB.AutoSize = true;
            this.storekeeperRB.Location = new System.Drawing.Point(106, 104);
            this.storekeeperRB.Name = "storekeeperRB";
            this.storekeeperRB.Size = new System.Drawing.Size(83, 17);
            this.storekeeperRB.TabIndex = 5;
            this.storekeeperRB.TabStop = true;
            this.storekeeperRB.Text = "Кладовщик";
            this.storekeeperRB.UseVisualStyleBackColor = true;
            // 
            // ChooseWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 211);
            this.Controls.Add(this.storekeeperRB);
            this.Controls.Add(this.managerRB);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 250);
            this.Name = "ChooseWindow";
            this.ShowIcon = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.RadioButton managerRB;
        private System.Windows.Forms.RadioButton storekeeperRB;
    }
}