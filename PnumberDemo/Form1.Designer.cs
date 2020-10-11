namespace PnumberDemo
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.udBase_value = new System.Windows.Forms.NumericUpDown();
            this.udAccuracy = new System.Windows.Forms.NumericUpDown();
            this.number1 = new System.Windows.Forms.TextBox();
            this.tbResultNumber = new System.Windows.Forms.TextBox();
            this.number2 = new System.Windows.Forms.TextBox();
            this.cbActions = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.udBase_value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udAccuracy)).BeginInit();
            this.SuspendLayout();
            // 
            // udBase_value
            // 
            this.udBase_value.Location = new System.Drawing.Point(605, 105);
            this.udBase_value.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.udBase_value.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.udBase_value.Name = "udBase_value";
            this.udBase_value.Size = new System.Drawing.Size(120, 26);
            this.udBase_value.TabIndex = 0;
            this.udBase_value.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // udAccuracy
            // 
            this.udAccuracy.Location = new System.Drawing.Point(605, 203);
            this.udAccuracy.Name = "udAccuracy";
            this.udAccuracy.Size = new System.Drawing.Size(120, 26);
            this.udAccuracy.TabIndex = 1;
            // 
            // number1
            // 
            this.number1.Location = new System.Drawing.Point(12, 102);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(160, 26);
            this.number1.TabIndex = 2;
            // 
            // tbResultNumber
            // 
            this.tbResultNumber.Location = new System.Drawing.Point(202, 203);
            this.tbResultNumber.Name = "tbResultNumber";
            this.tbResultNumber.Size = new System.Drawing.Size(100, 26);
            this.tbResultNumber.TabIndex = 3;
            // 
            // number2
            // 
            this.number2.Location = new System.Drawing.Point(214, 102);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(160, 26);
            this.number2.TabIndex = 4;
            // 
            // cbActions
            // 
            this.cbActions.FormattingEnabled = true;
            this.cbActions.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cbActions.Location = new System.Drawing.Point(436, 100);
            this.cbActions.Name = "cbActions";
            this.cbActions.Size = new System.Drawing.Size(72, 28);
            this.cbActions.TabIndex = 5;
            this.cbActions.SelectedIndexChanged += new System.EventHandler(this.cbActions_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Число 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(432, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Действие";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Число 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(601, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Основание с.с.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(601, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Точность";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(210, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Результат";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 278);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbActions);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.tbResultNumber);
            this.Controls.Add(this.number1);
            this.Controls.Add(this.udAccuracy);
            this.Controls.Add(this.udBase_value);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.udBase_value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udAccuracy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown udBase_value;
        private System.Windows.Forms.NumericUpDown udAccuracy;
        private System.Windows.Forms.TextBox number1;
        private System.Windows.Forms.TextBox tbResultNumber;
        private System.Windows.Forms.TextBox number2;
        private System.Windows.Forms.ComboBox cbActions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

