namespace ProductApp
{
    partial class frmMainWindow
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
            this.lblProdName = new System.Windows.Forms.Label();
            this.lblProdID = new System.Windows.Forms.Label();
            this.lblProdPrice = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.tbProdName = new System.Windows.Forms.TextBox();
            this.tbProdID = new System.Windows.Forms.TextBox();
            this.tbProdPrice = new System.Windows.Forms.TextBox();
            this.ProductGrid = new System.Windows.Forms.DataGridView();
            this.lblFindProduct = new System.Windows.Forms.Label();
            this.tbFindProduct = new System.Windows.Forms.TextBox();
            this.tbnfindIDproductid = new System.Windows.Forms.Button();
            this.lbl_displayidnameprice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Manager";
            // 
            // lblProdName
            // 
            this.lblProdName.AutoSize = true;
            this.lblProdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdName.Location = new System.Drawing.Point(8, 103);
            this.lblProdName.Name = "lblProdName";
            this.lblProdName.Size = new System.Drawing.Size(121, 20);
            this.lblProdName.TabIndex = 1;
            this.lblProdName.Text = "Product Name:";
            // 
            // lblProdID
            // 
            this.lblProdID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblProdID.AutoSize = true;
            this.lblProdID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdID.Location = new System.Drawing.Point(8, 65);
            this.lblProdID.Name = "lblProdID";
            this.lblProdID.Size = new System.Drawing.Size(94, 20);
            this.lblProdID.TabIndex = 2;
            this.lblProdID.Text = "Product ID:";
            // 
            // lblProdPrice
            // 
            this.lblProdPrice.AutoSize = true;
            this.lblProdPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdPrice.Location = new System.Drawing.Point(8, 143);
            this.lblProdPrice.Name = "lblProdPrice";
            this.lblProdPrice.Size = new System.Drawing.Size(116, 20);
            this.lblProdPrice.TabIndex = 3;
            this.lblProdPrice.Text = "Product Price:";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(130, 189);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(157, 35);
            this.btnAddProduct.TabIndex = 4;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // tbProdName
            // 
            this.tbProdName.Location = new System.Drawing.Point(130, 103);
            this.tbProdName.Multiline = true;
            this.tbProdName.Name = "tbProdName";
            this.tbProdName.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbProdName.Size = new System.Drawing.Size(264, 24);
            this.tbProdName.TabIndex = 5;
            this.tbProdName.TextChanged += new System.EventHandler(this.tbProdName_TextChanged);
            // 
            // tbProdID
            // 
            this.tbProdID.Location = new System.Drawing.Point(130, 65);
            this.tbProdID.Multiline = true;
            this.tbProdID.Name = "tbProdID";
            this.tbProdID.Size = new System.Drawing.Size(264, 24);
            this.tbProdID.TabIndex = 5;
            this.tbProdID.TextChanged += new System.EventHandler(this.tbProdID_TextChanged);
            // 
            // tbProdPrice
            // 
            this.tbProdPrice.Location = new System.Drawing.Point(130, 143);
            this.tbProdPrice.Multiline = true;
            this.tbProdPrice.Name = "tbProdPrice";
            this.tbProdPrice.Size = new System.Drawing.Size(264, 24);
            this.tbProdPrice.TabIndex = 5;
            this.tbProdPrice.TextChanged += new System.EventHandler(this.tbProdPrice_TextChanged);
            // 
            // ProductGrid
            // 
            this.ProductGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductGrid.Location = new System.Drawing.Point(12, 239);
            this.ProductGrid.Name = "ProductGrid";
            this.ProductGrid.RowHeadersWidth = 51;
            this.ProductGrid.RowTemplate.Height = 24;
            this.ProductGrid.Size = new System.Drawing.Size(382, 150);
            this.ProductGrid.TabIndex = 6;
            this.ProductGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblFindProduct
            // 
            this.lblFindProduct.AutoSize = true;
            this.lblFindProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFindProduct.Location = new System.Drawing.Point(428, 69);
            this.lblFindProduct.Name = "lblFindProduct";
            this.lblFindProduct.Size = new System.Drawing.Size(109, 20);
            this.lblFindProduct.TabIndex = 8;
            this.lblFindProduct.Text = "Find Product:";
            // 
            // tbFindProduct
            // 
            this.tbFindProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFindProduct.Location = new System.Drawing.Point(551, 65);
            this.tbFindProduct.Multiline = true;
            this.tbFindProduct.Name = "tbFindProduct";
            this.tbFindProduct.Size = new System.Drawing.Size(227, 24);
            this.tbFindProduct.TabIndex = 9;
            this.tbFindProduct.TextChanged += new System.EventHandler(this.tbFindProduct_TextChanged);
            // 
            // tbnfindIDproductid
            // 
            this.tbnfindIDproductid.Location = new System.Drawing.Point(551, 103);
            this.tbnfindIDproductid.Name = "tbnfindIDproductid";
            this.tbnfindIDproductid.Size = new System.Drawing.Size(157, 35);
            this.tbnfindIDproductid.TabIndex = 10;
            this.tbnfindIDproductid.Text = "Find Product";
            this.tbnfindIDproductid.UseVisualStyleBackColor = true;
            this.tbnfindIDproductid.Click += new System.EventHandler(this.tbnfindIDproduct_Click);
            // 
            // lbl_displayidnameprice
            // 
            this.lbl_displayidnameprice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_displayidnameprice.AutoSize = true;
            this.lbl_displayidnameprice.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_displayidnameprice.Location = new System.Drawing.Point(475, 239);
            this.lbl_displayidnameprice.Name = "lbl_displayidnameprice";
            this.lbl_displayidnameprice.Size = new System.Drawing.Size(0, 33);
            this.lbl_displayidnameprice.TabIndex = 11;
            this.lbl_displayidnameprice.Click += new System.EventHandler(this.lbl_display_Click);
            // 
            // frmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 435);
            this.Controls.Add(this.lbl_displayidnameprice);
            this.Controls.Add(this.tbnfindIDproductid);
            this.Controls.Add(this.tbFindProduct);
            this.Controls.Add(this.lblFindProduct);
            this.Controls.Add(this.ProductGrid);
            this.Controls.Add(this.tbProdPrice);
            this.Controls.Add(this.tbProdID);
            this.Controls.Add(this.tbProdName);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.lblProdPrice);
            this.Controls.Add(this.lblProdID);
            this.Controls.Add(this.lblProdName);
            this.Controls.Add(this.label1);
            this.Name = "frmMainWindow";
            this.Text = "MainWindow";
            ((System.ComponentModel.ISupportInitialize)(this.ProductGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProdName;
        private System.Windows.Forms.Label lblProdID;
        private System.Windows.Forms.Label lblProdPrice;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.TextBox tbProdID;
        private System.Windows.Forms.TextBox tbProdPrice;
        private System.Windows.Forms.DataGridView ProductGrid;
        public System.Windows.Forms.TextBox tbProdName;
        private System.Windows.Forms.Label lblFindProduct;
        private System.Windows.Forms.TextBox tbFindProduct;
        private System.Windows.Forms.Button tbnfindIDproductid;
        private System.Windows.Forms.Label lbl_displayidnameprice;
    }
}

