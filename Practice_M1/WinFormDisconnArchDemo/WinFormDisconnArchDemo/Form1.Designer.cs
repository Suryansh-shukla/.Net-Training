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
            this.txtProdID = new System.Windows.Forms.TextBox();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.lblProdName = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnShowAllProduct = new System.Windows.Forms.Button();
            this.btnSearchById = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProdId
            // 
            this.lblProdId.AutoSize = true;
            this.lblProdId.Location = new System.Drawing.Point(157, 92);
            this.lblProdId.Name = "lblProdId";
            this.lblProdId.Size = new System.Drawing.Size(85, 20);
            this.lblProdId.TabIndex = 0;
            this.lblProdId.Text = "Product ID";
            // 
            // txtProdID
            // 
            this.txtProdID.Location = new System.Drawing.Point(359, 92);
            this.txtProdID.Name = "txtProdID";
            this.txtProdID.Size = new System.Drawing.Size(100, 26);
            this.txtProdID.TabIndex = 1;
            // 
            // txtProdName
            // 
            this.txtProdName.Location = new System.Drawing.Point(359, 134);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(100, 26);
            this.txtProdName.TabIndex = 3;
            // 
            // lblProdName
            // 
            this.lblProdName.AutoSize = true;
            this.lblProdName.Location = new System.Drawing.Point(157, 134);
            this.lblProdName.Name = "lblProdName";
            this.lblProdName.Size = new System.Drawing.Size(110, 20);
            this.lblProdName.TabIndex = 2;
            this.lblProdName.Text = "Product Name";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(359, 174);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 26);
            this.txtPrice.TabIndex = 5;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(157, 174);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 20);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(359, 216);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(137, 63);
            this.txtDesc.TabIndex = 7;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(157, 216);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(89, 20);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Description";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(115, 310);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(120, 39);
            this.btnAddProduct.TabIndex = 8;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Location = new System.Drawing.Point(241, 310);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(136, 39);
            this.btnUpdateProduct.TabIndex = 9;
            this.btnUpdateProduct.Text = "Update Product";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(383, 310);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(135, 39);
            this.btnDeleteProduct.TabIndex = 10;
            this.btnDeleteProduct.Text = "Delete Product";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnShowAllProduct
            // 
            this.btnShowAllProduct.Location = new System.Drawing.Point(155, 350);
            this.btnShowAllProduct.Name = "btnShowAllProduct";
            this.btnShowAllProduct.Size = new System.Drawing.Size(148, 37);
            this.btnShowAllProduct.TabIndex = 11;
            this.btnShowAllProduct.Text = "Show All Product";
            this.btnShowAllProduct.UseVisualStyleBackColor = true;
            this.btnShowAllProduct.Click += new System.EventHandler(this.btnShowAllProduct_Click);
            // 
            // btnSearchById
            // 
            this.btnSearchById.Location = new System.Drawing.Point(326, 350);
            this.btnSearchById.Name = "btnSearchById";
            this.btnSearchById.Size = new System.Drawing.Size(133, 37);
            this.btnSearchById.TabIndex = 12;
            this.btnSearchById.Text = "Search By ID";
            this.btnSearchById.UseVisualStyleBackColor = true;
            this.btnSearchById.Click += new System.EventHandler(this.btnSearchById_Click);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(564, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(667, 429);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(767, 429);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(862, 429);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 477);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSearchById);
            this.Controls.Add(this.btnShowAllProduct);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnUpdateProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtProdName);
            this.Controls.Add(this.lblProdName);
            this.Controls.Add(this.txtProdID);
            this.Controls.Add(this.lblProdId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProdId;
        private System.Windows.Forms.TextBox txtProdID;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.Label lblProdName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnShowAllProduct;
        private System.Windows.Forms.Button btnSearchById;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

