namespace 業績計算
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
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Saleman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUM2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Saleman,
            this.P,
            this.PS,
            this.ER,
            this.RU,
            this.LIC,
            this.SUM});
            this.dataGridView1.Location = new System.Drawing.Point(23, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(934, 175);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.Price,
            this.Quantity,
            this.SUM2});
            this.dataGridView2.Location = new System.Drawing.Point(23, 319);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 31;
            this.dataGridView2.Size = new System.Drawing.Size(545, 270);
            this.dataGridView2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(628, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "最佳業務員";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(628, 462);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "最佳產品";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(788, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "最佳業務員名字";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(788, 462);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "最佳產品的名字";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "業務員業績";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "各產品總銷售額";
            // 
            // Saleman
            // 
            this.Saleman.DataPropertyName = "Saleman";
            this.Saleman.HeaderText = "業務員";
            this.Saleman.Name = "Saleman";
            this.Saleman.ReadOnly = true;
            this.Saleman.Width = 80;
            // 
            // P
            // 
            this.P.DataPropertyName = "P";
            this.P.HeaderText = "原子筆";
            this.P.Name = "P";
            this.P.ReadOnly = true;
            this.P.Width = 80;
            // 
            // PS
            // 
            this.PS.DataPropertyName = "PS";
            this.PS.HeaderText = "鉛筆";
            this.PS.Name = "PS";
            this.PS.ReadOnly = true;
            this.PS.Width = 80;
            // 
            // ER
            // 
            this.ER.DataPropertyName = "ER";
            this.ER.HeaderText = "橡皮擦";
            this.ER.Name = "ER";
            this.ER.ReadOnly = true;
            this.ER.Width = 80;
            // 
            // RU
            // 
            this.RU.DataPropertyName = "RU";
            this.RU.HeaderText = "直尺";
            this.RU.Name = "RU";
            this.RU.ReadOnly = true;
            this.RU.Width = 80;
            // 
            // LIC
            // 
            this.LIC.DataPropertyName = "LIC";
            this.LIC.HeaderText = "立可白";
            this.LIC.Name = "LIC";
            this.LIC.ReadOnly = true;
            this.LIC.Width = 80;
            // 
            // SUM
            // 
            this.SUM.DataPropertyName = "SUM";
            this.SUM.HeaderText = "銷售業績";
            this.SUM.Name = "SUM";
            this.SUM.ReadOnly = true;
            // 
            // Product
            // 
            this.Product.DataPropertyName = "Product";
            this.Product.HeaderText = "商品";
            this.Product.Name = "Product";
            this.Product.Width = 80;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "單價";
            this.Price.Name = "Price";
            this.Price.Width = 80;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "銷售量";
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 80;
            // 
            // SUM2
            // 
            this.SUM2.DataPropertyName = "SUM2";
            this.SUM2.HeaderText = "總銷售額";
            this.SUM2.Name = "SUM2";
            this.SUM2.Width = 80;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 597);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saleman;
        private System.Windows.Forms.DataGridViewTextBoxColumn P;
        private System.Windows.Forms.DataGridViewTextBoxColumn PS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ER;
        private System.Windows.Forms.DataGridViewTextBoxColumn RU;
        private System.Windows.Forms.DataGridViewTextBoxColumn LIC;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUM2;
    }
}

