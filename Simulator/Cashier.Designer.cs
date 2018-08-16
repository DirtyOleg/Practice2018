namespace Simulator
{
    partial class CashierFrm
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
            this.btn_exportXML = new System.Windows.Forms.Button();
            this.cbb_discount = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_totalPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ddv_orderList = new System.Windows.Forms.DataGridView();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_orderid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ddv_orderList)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_exportXML
            // 
            this.btn_exportXML.Location = new System.Drawing.Point(874, 12);
            this.btn_exportXML.Name = "btn_exportXML";
            this.btn_exportXML.Size = new System.Drawing.Size(110, 32);
            this.btn_exportXML.TabIndex = 0;
            this.btn_exportXML.Text = "Export XML";
            this.btn_exportXML.UseVisualStyleBackColor = true;
            this.btn_exportXML.Click += new System.EventHandler(this.btn_exportXML_Click);
            // 
            // cbb_discount
            // 
            this.cbb_discount.FormattingEnabled = true;
            this.cbb_discount.Items.AddRange(new object[] {
            "None",
            "20% off"});
            this.cbb_discount.Location = new System.Drawing.Point(491, 619);
            this.cbb_discount.Name = "cbb_discount";
            this.cbb_discount.Size = new System.Drawing.Size(179, 26);
            this.cbb_discount.TabIndex = 1;
            this.cbb_discount.SelectedIndexChanged += new System.EventHandler(this.cbb_discount_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(358, 619);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Discount:";
            // 
            // lbl_totalPrice
            // 
            this.lbl_totalPrice.AutoSize = true;
            this.lbl_totalPrice.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_totalPrice.Location = new System.Drawing.Point(185, 619);
            this.lbl_totalPrice.Name = "lbl_totalPrice";
            this.lbl_totalPrice.Size = new System.Drawing.Size(88, 24);
            this.lbl_totalPrice.TabIndex = 3;
            this.lbl_totalPrice.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(13, 616);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total Price:";
            // 
            // ddv_orderList
            // 
            this.ddv_orderList.AllowUserToAddRows = false;
            this.ddv_orderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ddv_orderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.ProductPrice,
            this.ProductGuid});
            this.ddv_orderList.Location = new System.Drawing.Point(340, 59);
            this.ddv_orderList.Name = "ddv_orderList";
            this.ddv_orderList.ReadOnly = true;
            this.ddv_orderList.RowTemplate.Height = 30;
            this.ddv_orderList.Size = new System.Drawing.Size(644, 537);
            this.ddv_orderList.TabIndex = 5;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.FillWeight = 200F;
            this.ProductName.HeaderText = "Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // ProductPrice
            // 
            this.ProductPrice.DataPropertyName = "ProductPrice";
            this.ProductPrice.FillWeight = 200F;
            this.ProductPrice.HeaderText = "Price";
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.ReadOnly = true;
            // 
            // ProductGuid
            // 
            this.ProductGuid.DataPropertyName = "ProductGuid";
            this.ProductGuid.FillWeight = 200F;
            this.ProductGuid.HeaderText = "Guid";
            this.ProductGuid.Name = "ProductGuid";
            this.ProductGuid.ReadOnly = true;
            this.ProductGuid.Width = 400;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(405, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Order ID:";
            // 
            // lbl_orderid
            // 
            this.lbl_orderid.AutoSize = true;
            this.lbl_orderid.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_orderid.Location = new System.Drawing.Point(568, 12);
            this.lbl_orderid.Name = "lbl_orderid";
            this.lbl_orderid.Size = new System.Drawing.Size(29, 30);
            this.lbl_orderid.TabIndex = 7;
            this.lbl_orderid.Text = "1";
            // 
            // CashierFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 700);
            this.Controls.Add(this.lbl_orderid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ddv_orderList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_totalPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbb_discount);
            this.Controls.Add(this.btn_exportXML);
            this.Name = "CashierFrm";
            this.Text = "Cashier";
            ((System.ComponentModel.ISupportInitialize)(this.ddv_orderList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exportXML;
        private System.Windows.Forms.ComboBox cbb_discount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_totalPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ddv_orderList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_orderid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductGuid;
    }
}