namespace 運輸票價
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.endComboBox = new System.Windows.Forms.ComboBox();
            this.startComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toNorthRadioButton = new System.Windows.Forms.RadioButton();
            this.toSouthRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 550);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 18);
            this.label4.TabIndex = 30;
            this.label4.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 550);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 29;
            this.label3.Text = "票價為 :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 76);
            this.button1.TabIndex = 28;
            this.button1.Text = "計算";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(93, 340);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(88, 22);
            this.checkBox2.TabIndex = 27;
            this.checkBox2.Text = "優惠票";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(93, 269);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(88, 22);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "來回票";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // endComboBox
            // 
            this.endComboBox.FormattingEnabled = true;
            this.endComboBox.Location = new System.Drawing.Point(455, 183);
            this.endComboBox.Name = "endComboBox";
            this.endComboBox.Size = new System.Drawing.Size(258, 26);
            this.endComboBox.TabIndex = 25;
            // 
            // startComboBox
            // 
            this.startComboBox.FormattingEnabled = true;
            this.startComboBox.Location = new System.Drawing.Point(93, 183);
            this.startComboBox.Name = "startComboBox";
            this.startComboBox.Size = new System.Drawing.Size(258, 26);
            this.startComboBox.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(449, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "訖站";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "起站";
            // 
            // toNorthRadioButton
            // 
            this.toNorthRadioButton.AutoSize = true;
            this.toNorthRadioButton.Location = new System.Drawing.Point(257, 50);
            this.toNorthRadioButton.Name = "toNorthRadioButton";
            this.toNorthRadioButton.Size = new System.Drawing.Size(69, 22);
            this.toNorthRadioButton.TabIndex = 21;
            this.toNorthRadioButton.TabStop = true;
            this.toNorthRadioButton.Text = "北上";
            this.toNorthRadioButton.UseVisualStyleBackColor = true;
            // 
            // toSouthRadioButton
            // 
            this.toSouthRadioButton.AutoSize = true;
            this.toSouthRadioButton.Location = new System.Drawing.Point(98, 50);
            this.toSouthRadioButton.Name = "toSouthRadioButton";
            this.toSouthRadioButton.Size = new System.Drawing.Size(69, 22);
            this.toSouthRadioButton.TabIndex = 20;
            this.toSouthRadioButton.TabStop = true;
            this.toSouthRadioButton.Text = "南下";
            this.toSouthRadioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 619);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.endComboBox);
            this.Controls.Add(this.startComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toNorthRadioButton);
            this.Controls.Add(this.toSouthRadioButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox endComboBox;
        private System.Windows.Forms.ComboBox startComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton toNorthRadioButton;
        private System.Windows.Forms.RadioButton toSouthRadioButton;
    }
}

