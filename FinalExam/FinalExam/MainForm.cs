//                                               Possible  Actual
// Final Exam Criteria                               Mark    Mark
// --------------------------------------------------------------
// GUI design  - Follows design principles taught      12      10
// in the course. Mimics the  sample program
// Duplicate mnemonic "S"
// Extended should be readonly
//
// Data Layer - separate DLL Project                   10      10 
// Yes
//
//
// Databinding - done correctly                         6       6
// Yes
//
// 
// Program operation - correct values in display        8       7
// Rounding error: displayed total and calculated
//   total are out by 0.01
//
// Coding style: follows coding standards for course;   4       4
//  commented; easy to read
// Yes
//
//
// --------------------------------------------------------------
// Total:                                              40      37
//
//
// Final Course Mark: 90%
//
// (Unofficial: offical mark will be posted on MyBCIT)
//
//


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalExamData.Common;

namespace FinalExam
{
	public partial class MainForm : Form
	{
		public InvoiceViewModel InvoiceVM { get; set; }

		private Invoice tempInv;

		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			// clear label values
			labelSubValue.Text = "";
			labelGstValue.Text = "";
			labelPstValue.Text = "";
			labelGrandValue.Text = "";
			labelAvgPriceValue.Text = "";
			labelMaxPriceValue.Text = "";
			labelMinPriceValue.Text = "";
			labelCountValue.Text = "";
			labelTaxCountValue.Text = "";

			// populate invoices to listbox
			InvoiceVM = new InvoiceViewModel();
			listBoxInvoices.DataSource = InvoiceVM.InvoiceList;
			listBoxInvoices.DisplayMember = "Sku";

			// add databindings
			setupDataBindings();
		}

		private void setupDataBindings()
		{
			textBoxQty.DataBindings.Add("Text", InvoiceVM, "Invoice.Quantity");
			textBoxSku.DataBindings.Add("Text", InvoiceVM, "Invoice.Sku");
			textBoxDesc.DataBindings.Add("Text", InvoiceVM, "Invoice.Description");
			textBoxPrice.DataBindings.Add("Text", InvoiceVM, "Invoice.Price", true, DataSourceUpdateMode.OnValidation, "0.00", "#,##0.00;-#,##0.00;0.00");
			textBoxExtend.DataBindings.Add("Text", InvoiceVM, "Invoice.Extended", true, DataSourceUpdateMode.OnValidation, "0.00", "#,##0.00;-#,##0.00;0.00");
			checkBoxTax.DataBindings.Add("Checked", InvoiceVM, "Invoice.Taxable");

			//labelSubValue.DataBindings.Add("Text", InvoiceVM, "InvoiceList.SubTotal", true, DataSourceUpdateMode.OnValidation, "0.00", "#,##0.00;-#,##0.00;0.00");
			//labelGstValue.DataBindings.Add("Text", InvoiceVM, "InvoiceList.GST", true, DataSourceUpdateMode.OnValidation, "0.00", "#,##0.00;-#,##0.00;0.00");
			//labelPstValue.DataBindings.Add("Text", InvoiceVM, "InvoiceList.PST", true, DataSourceUpdateMode.OnValidation, "0.00", "#,##0.00;-#,##0.00;0.00");
			//labelGrandValue.DataBindings.Add("Text", InvoiceVM, "InvoiceList.GrandTotal", true, DataSourceUpdateMode.OnValidation, "0.00", "#,##0.00;-#,##0.00;0.00");
			//labelAvgPriceValue.DataBindings.Add("Text", InvoiceVM, "InvoiceList.AvgPrice", true, DataSourceUpdateMode.OnValidation, "0.00", "#,##0.00;-#,##0.00;0.00");
			//labelMaxPriceValue.DataBindings.Add("Text", InvoiceVM, "InvoiceList.SubTotal", true, DataSourceUpdateMode.OnValidation, "0.00", "#,##0.00;-#,##0.00;0.00");
			//labelMinPriceValue.DataBindings.Add("Text", InvoiceVM, "InvoiceList.SubTotal", true, DataSourceUpdateMode.OnValidation, "0.00", "#,##0.00;-#,##0.00;0.00");
			//labelCountValue.DataBindings.Add("Text", InvoiceVM, "InvoiceList.Count");
			//labelTaxCountValue.DataBindings.Add("Text", InvoiceVM, "InvoiceList.TaxCount");
		}

		private void listBoxInvoices_SelectedIndexChanged(object sender, EventArgs e)
		{
			int selectedIndex = Math.Max(0, listBoxInvoices.SelectedIndex);
			// create a new invoice instance for modification
			tempInv = new Invoice(InvoiceVM.InvoiceList[selectedIndex]);
			InvoiceVM.Invoice = tempInv;
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			// write the modified invoice back into list
			int selectedIndex = Math.Max(0, listBoxInvoices.SelectedIndex);
			InvoiceVM.InvoiceList[selectedIndex] = tempInv;

			// update labels with new values
			updateValues();
		}

		private void updateValues()
		{
			labelSubValue.Text = string.Format("{0:N2}", InvoiceVM.InvoiceList.SubTotal);
			labelGstValue.Text = string.Format("{0:N2}", InvoiceVM.InvoiceList.GST);
			labelPstValue.Text = string.Format("{0:N2}", InvoiceVM.InvoiceList.PST);
			labelGrandValue.Text = string.Format("{0:N2}", InvoiceVM.InvoiceList.GrandTotal);
			labelAvgPriceValue.Text = string.Format("{0:N2}", InvoiceVM.InvoiceList.AvgPrice);
			labelMaxPriceValue.Text = string.Format("{0:N2}", InvoiceVM.InvoiceList.MaxPrice);
			labelMinPriceValue.Text = string.Format("{0:N2}", InvoiceVM.InvoiceList.MinPrice);
			labelCountValue.Text = string.Format("{0}", InvoiceVM.InvoiceList.Count);
			labelTaxCountValue.Text = string.Format("{0}", InvoiceVM.InvoiceList.TaxCount);
		}
	}
}
