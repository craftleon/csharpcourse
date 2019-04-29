using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExamData.Common
{
	public class InvoiceCollection : BindingList<Invoice>
	{
		private decimal gst, pst;

		public void SetTaxRates(Dictionary<string, decimal> rates)
		{
			gst = rates["GST"]/100m;
			pst = rates["BCPST"]/100m;
		}

		public decimal SubTotal
		{
			get => this.Sum(inv => inv.Extended);
		}

		public decimal GST {
			get => SubTotal * gst;
		}

		public decimal PST
		{
			// ignore non taxable items
			get => this.Sum(inv => inv.Taxable?inv.Extended:0m) * pst;
		}

		public decimal GrandTotal
		{
			get => SubTotal + GST + PST;
		}

		public decimal AvgPrice
		{
			get => this.Average(inv => inv.Price);
		}

		public decimal MaxPrice
		{
			get => this.Max(inv => inv.Price);
		}

		public decimal MinPrice
		{
			get => this.Min(inv => inv.Price);
		}

		public int TaxCount
		{
			get => this.Count(inv => inv.Taxable == true);
		}
	}
}
