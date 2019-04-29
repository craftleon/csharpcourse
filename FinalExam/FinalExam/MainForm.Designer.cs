namespace FinalExam
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.listBoxInvoices = new System.Windows.Forms.ListBox();
			this.labelQty = new System.Windows.Forms.Label();
			this.textBoxQty = new System.Windows.Forms.TextBox();
			this.textBoxSku = new System.Windows.Forms.TextBox();
			this.labelSku = new System.Windows.Forms.Label();
			this.textBoxDesc = new System.Windows.Forms.TextBox();
			this.labelDesc = new System.Windows.Forms.Label();
			this.textBoxPrice = new System.Windows.Forms.TextBox();
			this.labelPrice = new System.Windows.Forms.Label();
			this.textBoxExtend = new System.Windows.Forms.TextBox();
			this.labelExtend = new System.Windows.Forms.Label();
			this.checkBoxTax = new System.Windows.Forms.CheckBox();
			this.buttonSave = new System.Windows.Forms.Button();
			this.labelSub = new System.Windows.Forms.Label();
			this.labelSubValue = new System.Windows.Forms.Label();
			this.labelGstValue = new System.Windows.Forms.Label();
			this.labelGst = new System.Windows.Forms.Label();
			this.labelPstValue = new System.Windows.Forms.Label();
			this.labelPst = new System.Windows.Forms.Label();
			this.labelGrandValue = new System.Windows.Forms.Label();
			this.labelGrand = new System.Windows.Forms.Label();
			this.labelAvgPriceValue = new System.Windows.Forms.Label();
			this.labelAvgPrice = new System.Windows.Forms.Label();
			this.labelMaxPriceValue = new System.Windows.Forms.Label();
			this.labelMaxPrice = new System.Windows.Forms.Label();
			this.labelMinPriceValue = new System.Windows.Forms.Label();
			this.labelMinPrice = new System.Windows.Forms.Label();
			this.labelCountValue = new System.Windows.Forms.Label();
			this.labelCount = new System.Windows.Forms.Label();
			this.labelTaxCountValue = new System.Windows.Forms.Label();
			this.labelTaxCount = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// listBoxInvoices
			// 
			this.listBoxInvoices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.listBoxInvoices.FormattingEnabled = true;
			this.listBoxInvoices.ItemHeight = 15;
			this.listBoxInvoices.Location = new System.Drawing.Point(0, 0);
			this.listBoxInvoices.Name = "listBoxInvoices";
			this.listBoxInvoices.Size = new System.Drawing.Size(186, 244);
			this.listBoxInvoices.TabIndex = 0;
			this.listBoxInvoices.SelectedIndexChanged += new System.EventHandler(this.listBoxInvoices_SelectedIndexChanged);
			// 
			// labelQty
			// 
			this.labelQty.AutoSize = true;
			this.labelQty.Location = new System.Drawing.Point(230, 32);
			this.labelQty.Name = "labelQty";
			this.labelQty.Size = new System.Drawing.Size(54, 15);
			this.labelQty.TabIndex = 1;
			this.labelQty.Text = "&Quantity:";
			// 
			// textBoxQty
			// 
			this.textBoxQty.Location = new System.Drawing.Point(300, 29);
			this.textBoxQty.Name = "textBoxQty";
			this.textBoxQty.Size = new System.Drawing.Size(74, 21);
			this.textBoxQty.TabIndex = 2;
			// 
			// textBoxSku
			// 
			this.textBoxSku.Location = new System.Drawing.Point(300, 59);
			this.textBoxSku.Name = "textBoxSku";
			this.textBoxSku.Size = new System.Drawing.Size(116, 21);
			this.textBoxSku.TabIndex = 4;
			// 
			// labelSku
			// 
			this.labelSku.AutoSize = true;
			this.labelSku.Location = new System.Drawing.Point(230, 62);
			this.labelSku.Name = "labelSku";
			this.labelSku.Size = new System.Drawing.Size(31, 15);
			this.labelSku.TabIndex = 3;
			this.labelSku.Text = "&Sku:";
			// 
			// textBoxDesc
			// 
			this.textBoxDesc.Location = new System.Drawing.Point(300, 89);
			this.textBoxDesc.Name = "textBoxDesc";
			this.textBoxDesc.Size = new System.Drawing.Size(191, 21);
			this.textBoxDesc.TabIndex = 6;
			// 
			// labelDesc
			// 
			this.labelDesc.AutoSize = true;
			this.labelDesc.Location = new System.Drawing.Point(230, 92);
			this.labelDesc.Name = "labelDesc";
			this.labelDesc.Size = new System.Drawing.Size(72, 15);
			this.labelDesc.TabIndex = 5;
			this.labelDesc.Text = "&Description:";
			// 
			// textBoxPrice
			// 
			this.textBoxPrice.Location = new System.Drawing.Point(300, 119);
			this.textBoxPrice.Name = "textBoxPrice";
			this.textBoxPrice.Size = new System.Drawing.Size(116, 21);
			this.textBoxPrice.TabIndex = 8;
			// 
			// labelPrice
			// 
			this.labelPrice.AutoSize = true;
			this.labelPrice.Location = new System.Drawing.Point(230, 122);
			this.labelPrice.Name = "labelPrice";
			this.labelPrice.Size = new System.Drawing.Size(38, 15);
			this.labelPrice.TabIndex = 7;
			this.labelPrice.Text = "&Price:";
			// 
			// textBoxExtend
			// 
			this.textBoxExtend.Location = new System.Drawing.Point(300, 149);
			this.textBoxExtend.Name = "textBoxExtend";
			this.textBoxExtend.Size = new System.Drawing.Size(116, 21);
			this.textBoxExtend.TabIndex = 10;
			// 
			// labelExtend
			// 
			this.labelExtend.AutoSize = true;
			this.labelExtend.Location = new System.Drawing.Point(230, 152);
			this.labelExtend.Name = "labelExtend";
			this.labelExtend.Size = new System.Drawing.Size(62, 15);
			this.labelExtend.TabIndex = 9;
			this.labelExtend.Text = "&Extended:";
			// 
			// checkBoxTax
			// 
			this.checkBoxTax.AutoSize = true;
			this.checkBoxTax.Location = new System.Drawing.Point(300, 189);
			this.checkBoxTax.Name = "checkBoxTax";
			this.checkBoxTax.Size = new System.Drawing.Size(70, 19);
			this.checkBoxTax.TabIndex = 11;
			this.checkBoxTax.Text = "&Taxable";
			this.checkBoxTax.UseVisualStyleBackColor = true;
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(404, 185);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(87, 27);
			this.buttonSave.TabIndex = 12;
			this.buttonSave.Text = "&Save";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// labelSub
			// 
			this.labelSub.AutoSize = true;
			this.labelSub.Location = new System.Drawing.Point(544, 17);
			this.labelSub.Name = "labelSub";
			this.labelSub.Size = new System.Drawing.Size(62, 15);
			this.labelSub.TabIndex = 13;
			this.labelSub.Text = "Sub Total:";
			// 
			// labelSubValue
			// 
			this.labelSubValue.ForeColor = System.Drawing.Color.RoyalBlue;
			this.labelSubValue.Location = new System.Drawing.Point(637, 17);
			this.labelSubValue.Name = "labelSubValue";
			this.labelSubValue.Size = new System.Drawing.Size(80, 15);
			this.labelSubValue.TabIndex = 14;
			this.labelSubValue.Text = "<value>";
			this.labelSubValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// labelGstValue
			// 
			this.labelGstValue.ForeColor = System.Drawing.Color.RoyalBlue;
			this.labelGstValue.Location = new System.Drawing.Point(637, 32);
			this.labelGstValue.Name = "labelGstValue";
			this.labelGstValue.Size = new System.Drawing.Size(80, 15);
			this.labelGstValue.TabIndex = 16;
			this.labelGstValue.Text = "<value>";
			this.labelGstValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// labelGst
			// 
			this.labelGst.AutoSize = true;
			this.labelGst.Location = new System.Drawing.Point(544, 32);
			this.labelGst.Name = "labelGst";
			this.labelGst.Size = new System.Drawing.Size(34, 15);
			this.labelGst.TabIndex = 15;
			this.labelGst.Text = "GST:";
			// 
			// labelPstValue
			// 
			this.labelPstValue.ForeColor = System.Drawing.Color.RoyalBlue;
			this.labelPstValue.Location = new System.Drawing.Point(637, 47);
			this.labelPstValue.Name = "labelPstValue";
			this.labelPstValue.Size = new System.Drawing.Size(80, 15);
			this.labelPstValue.TabIndex = 18;
			this.labelPstValue.Text = "<value>";
			this.labelPstValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// labelPst
			// 
			this.labelPst.AutoSize = true;
			this.labelPst.Location = new System.Drawing.Point(544, 47);
			this.labelPst.Name = "labelPst";
			this.labelPst.Size = new System.Drawing.Size(33, 15);
			this.labelPst.TabIndex = 17;
			this.labelPst.Text = "PST:";
			// 
			// labelGrandValue
			// 
			this.labelGrandValue.ForeColor = System.Drawing.Color.RoyalBlue;
			this.labelGrandValue.Location = new System.Drawing.Point(637, 62);
			this.labelGrandValue.Name = "labelGrandValue";
			this.labelGrandValue.Size = new System.Drawing.Size(80, 15);
			this.labelGrandValue.TabIndex = 20;
			this.labelGrandValue.Text = "<value>";
			this.labelGrandValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// labelGrand
			// 
			this.labelGrand.AutoSize = true;
			this.labelGrand.Location = new System.Drawing.Point(544, 62);
			this.labelGrand.Name = "labelGrand";
			this.labelGrand.Size = new System.Drawing.Size(74, 15);
			this.labelGrand.TabIndex = 19;
			this.labelGrand.Text = "Grand Total:";
			// 
			// labelAvgPriceValue
			// 
			this.labelAvgPriceValue.ForeColor = System.Drawing.Color.RoyalBlue;
			this.labelAvgPriceValue.Location = new System.Drawing.Point(637, 93);
			this.labelAvgPriceValue.Name = "labelAvgPriceValue";
			this.labelAvgPriceValue.Size = new System.Drawing.Size(80, 15);
			this.labelAvgPriceValue.TabIndex = 22;
			this.labelAvgPriceValue.Text = "<value>";
			this.labelAvgPriceValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// labelAvgPrice
			// 
			this.labelAvgPrice.AutoSize = true;
			this.labelAvgPrice.Location = new System.Drawing.Point(544, 93);
			this.labelAvgPrice.Name = "labelAvgPrice";
			this.labelAvgPrice.Size = new System.Drawing.Size(85, 15);
			this.labelAvgPrice.TabIndex = 21;
			this.labelAvgPrice.Text = "Average Price:";
			// 
			// labelMaxPriceValue
			// 
			this.labelMaxPriceValue.ForeColor = System.Drawing.Color.RoyalBlue;
			this.labelMaxPriceValue.Location = new System.Drawing.Point(637, 108);
			this.labelMaxPriceValue.Name = "labelMaxPriceValue";
			this.labelMaxPriceValue.Size = new System.Drawing.Size(80, 15);
			this.labelMaxPriceValue.TabIndex = 24;
			this.labelMaxPriceValue.Text = "<value>";
			this.labelMaxPriceValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// labelMaxPrice
			// 
			this.labelMaxPrice.AutoSize = true;
			this.labelMaxPrice.Location = new System.Drawing.Point(544, 108);
			this.labelMaxPrice.Name = "labelMaxPrice";
			this.labelMaxPrice.Size = new System.Drawing.Size(97, 15);
			this.labelMaxPrice.TabIndex = 23;
			this.labelMaxPrice.Text = "Maximum Price:";
			// 
			// labelMinPriceValue
			// 
			this.labelMinPriceValue.ForeColor = System.Drawing.Color.RoyalBlue;
			this.labelMinPriceValue.Location = new System.Drawing.Point(637, 123);
			this.labelMinPriceValue.Name = "labelMinPriceValue";
			this.labelMinPriceValue.Size = new System.Drawing.Size(80, 15);
			this.labelMinPriceValue.TabIndex = 26;
			this.labelMinPriceValue.Text = "<value>";
			this.labelMinPriceValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// labelMinPrice
			// 
			this.labelMinPrice.AutoSize = true;
			this.labelMinPrice.Location = new System.Drawing.Point(544, 123);
			this.labelMinPrice.Name = "labelMinPrice";
			this.labelMinPrice.Size = new System.Drawing.Size(94, 15);
			this.labelMinPrice.TabIndex = 25;
			this.labelMinPrice.Text = "Minimum Price:";
			// 
			// labelCountValue
			// 
			this.labelCountValue.ForeColor = System.Drawing.Color.RoyalBlue;
			this.labelCountValue.Location = new System.Drawing.Point(637, 152);
			this.labelCountValue.Name = "labelCountValue";
			this.labelCountValue.Size = new System.Drawing.Size(80, 15);
			this.labelCountValue.TabIndex = 28;
			this.labelCountValue.Text = "<value>";
			this.labelCountValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// labelCount
			// 
			this.labelCount.AutoSize = true;
			this.labelCount.Location = new System.Drawing.Point(544, 152);
			this.labelCount.Name = "labelCount";
			this.labelCount.Size = new System.Drawing.Size(69, 15);
			this.labelCount.TabIndex = 27;
			this.labelCount.Text = "Item Count:";
			// 
			// labelTaxCountValue
			// 
			this.labelTaxCountValue.ForeColor = System.Drawing.Color.RoyalBlue;
			this.labelTaxCountValue.Location = new System.Drawing.Point(637, 167);
			this.labelTaxCountValue.Name = "labelTaxCountValue";
			this.labelTaxCountValue.Size = new System.Drawing.Size(80, 15);
			this.labelTaxCountValue.TabIndex = 30;
			this.labelTaxCountValue.Text = "<value>";
			this.labelTaxCountValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// labelTaxCount
			// 
			this.labelTaxCount.AutoSize = true;
			this.labelTaxCount.Location = new System.Drawing.Point(544, 167);
			this.labelTaxCount.Name = "labelTaxCount";
			this.labelTaxCount.Size = new System.Drawing.Size(89, 15);
			this.labelTaxCount.TabIndex = 29;
			this.labelTaxCount.Text = "Taxable Count:";
			// 
			// MainForm
			// 
			this.AcceptButton = this.buttonSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(760, 239);
			this.Controls.Add(this.labelTaxCountValue);
			this.Controls.Add(this.labelTaxCount);
			this.Controls.Add(this.labelCountValue);
			this.Controls.Add(this.labelCount);
			this.Controls.Add(this.labelMinPriceValue);
			this.Controls.Add(this.labelMinPrice);
			this.Controls.Add(this.labelMaxPriceValue);
			this.Controls.Add(this.labelMaxPrice);
			this.Controls.Add(this.labelAvgPriceValue);
			this.Controls.Add(this.labelAvgPrice);
			this.Controls.Add(this.labelGrandValue);
			this.Controls.Add(this.labelGrand);
			this.Controls.Add(this.labelPstValue);
			this.Controls.Add(this.labelPst);
			this.Controls.Add(this.labelGstValue);
			this.Controls.Add(this.labelGst);
			this.Controls.Add(this.labelSubValue);
			this.Controls.Add(this.labelSub);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.checkBoxTax);
			this.Controls.Add(this.textBoxExtend);
			this.Controls.Add(this.labelExtend);
			this.Controls.Add(this.textBoxPrice);
			this.Controls.Add(this.labelPrice);
			this.Controls.Add(this.textBoxDesc);
			this.Controls.Add(this.labelDesc);
			this.Controls.Add(this.textBoxSku);
			this.Controls.Add(this.labelSku);
			this.Controls.Add(this.textBoxQty);
			this.Controls.Add(this.labelQty);
			this.Controls.Add(this.listBoxInvoices);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "COMP2614 Final Exam";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listBoxInvoices;
		private System.Windows.Forms.Label labelQty;
		private System.Windows.Forms.TextBox textBoxQty;
		private System.Windows.Forms.TextBox textBoxSku;
		private System.Windows.Forms.Label labelSku;
		private System.Windows.Forms.TextBox textBoxDesc;
		private System.Windows.Forms.Label labelDesc;
		private System.Windows.Forms.TextBox textBoxPrice;
		private System.Windows.Forms.Label labelPrice;
		private System.Windows.Forms.TextBox textBoxExtend;
		private System.Windows.Forms.Label labelExtend;
		private System.Windows.Forms.CheckBox checkBoxTax;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Label labelSub;
		private System.Windows.Forms.Label labelSubValue;
		private System.Windows.Forms.Label labelGstValue;
		private System.Windows.Forms.Label labelGst;
		private System.Windows.Forms.Label labelPstValue;
		private System.Windows.Forms.Label labelPst;
		private System.Windows.Forms.Label labelGrandValue;
		private System.Windows.Forms.Label labelGrand;
		private System.Windows.Forms.Label labelAvgPriceValue;
		private System.Windows.Forms.Label labelAvgPrice;
		private System.Windows.Forms.Label labelMaxPriceValue;
		private System.Windows.Forms.Label labelMaxPrice;
		private System.Windows.Forms.Label labelMinPriceValue;
		private System.Windows.Forms.Label labelMinPrice;
		private System.Windows.Forms.Label labelCountValue;
		private System.Windows.Forms.Label labelCount;
		private System.Windows.Forms.Label labelTaxCountValue;
		private System.Windows.Forms.Label labelTaxCount;
	}
}

