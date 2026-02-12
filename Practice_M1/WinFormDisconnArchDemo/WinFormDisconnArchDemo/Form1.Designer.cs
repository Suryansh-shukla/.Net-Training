namespace WinFormDisconnArchDemo
{
    partial class Form1
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
            this.lblProdId = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblProdName = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProdId
            // 
            this.lblProdId.AutoSize = true;
            this.lblProdId.Location = new System.Drawing.Point(169, 117);
            this.lblProdId.Name = "lblProdId";
            this.lblProdId.Size = new System.Drawing.Size(85, 20);
            this.lblProdId.TabIndex = 0;
            this.lblProdId.Text = "Product ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(371, 117);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(371, 159);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 3;
            // 
            // lblProdName
            // 
            this.lblProdName.AutoSize = true;
            this.lblProdName.Location = new System.Drawing.Point(169, 159);
            this.lblProdName.Name = "lblProdName";
            this.lblProdName.Size = new System.Drawing.Size(110, 20);
            this.lblProdName.TabIndex = 2;
            this.lblProdName.Text = "Product Name";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(371, 199);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 26);
            this.textBox3.TabIndex = 5;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(169, 199);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 20);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(371, 241);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 26);
            this.textBox4.TabIndex = 7;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(169, 241);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(89, 20);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Description";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(273, 310);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 28);
            this.button2.TabIndex = 9;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(386, 310);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 28);
            this.button3.TabIndex = 10;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(220, 344);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 28);
            this.button4.TabIndex = 11;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(331, 344);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 28);
            this.button5.TabIndex = 12;
            this.button5.Text = "Add";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(524, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(524, 340);
            this.dataGridView1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 477);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblProdName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblProdId);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProdId;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblProdName;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

