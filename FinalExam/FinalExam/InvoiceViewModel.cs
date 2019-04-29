using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using FinalExamData.Common;
using FinalExamData.Data;

namespace FinalExam
{
	public class InvoiceViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		private void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		private Invoice invoice;
		public Invoice Invoice
		{
			get
			{
				return invoice;
			}
			set
			{
				invoice = value;
				OnPropertyChanged("Invoice");
			}
		}

		public InvoiceCollection InvoiceList { get; set; }
		public Dictionary<string, decimal> TaxRates { get; set; }

		public InvoiceViewModel()
		{
			InvoiceList = InvoiceRepository.GetInvoices();
			TaxRates = InvoiceRepository.GetSalesTaxRates();
			InvoiceList.SetTaxRates(TaxRates);
		}
	}
}
