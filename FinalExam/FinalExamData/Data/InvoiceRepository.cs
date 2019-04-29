using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalExamData.Common;

namespace FinalExamData.Data
{
	public class InvoiceRepository
	{
		private static readonly string connString = @"Server=tcp:skeena.database.windows.net,1433; 
                                     Initial Catalog=comp2614;
                                     User ID=student;
                                     Password=93nu5_zZ5b;
                                     Encrypt=True;
                                     TrustServerCertificate=False;
                                     Connection Timeout=30;";

		public static InvoiceCollection GetInvoices()
		{
			InvoiceCollection invoices = new InvoiceCollection();

			using (SqlConnection conn = new SqlConnection(connString))
			{
				string query;

				query = $@"SELECT DetailId, Quantity, Sku, Description, Price, Taxable
                          FROM InvoiceDetail ORDER BY Sku";

				using (SqlCommand cmd = new SqlCommand())
				{
					cmd.CommandType = CommandType.Text;
					cmd.CommandText = query;
					cmd.Connection = conn;
					conn.Open();

					using (SqlDataReader reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							int id, qty;
							string sku, desc;
							decimal price;
							bool taxable;

							// none nullable data
							id = (int)reader["DetailId"];
							qty = (int)reader["Quantity"];
							sku = reader["Sku"] as string;
							price = (decimal)reader["Price"];

							// nullable data
							if (!reader.IsDBNull(3))
							{
								desc = reader["Description"] as string;
							}
							else
							{
								desc = null;
							}

							if (!reader.IsDBNull(5))
							{
								taxable = (bool)reader["Taxable"];
							}
							else
							{
								taxable = false;
							}

							invoices.Add(new Invoice
							{
								DetailId = id,
								Quantity = qty,
								Sku = sku,
								Description = desc,
								Price = price,
								Taxable = taxable
							});
						}
					}
				}
			}
			return invoices;
		}

		public static Dictionary<string, decimal> GetSalesTaxRates()
		{
			Dictionary<string, decimal> rates = new Dictionary<string, decimal>();

			using (SqlConnection conn = new SqlConnection(connString))
			{
				string query;

				query = $@"SELECT TaxId, TaxCode, TaxRate
                          FROM SalesTaxRate ORDER BY TaxId";

				using (SqlCommand cmd = new SqlCommand())
				{
					cmd.CommandType = CommandType.Text;
					cmd.CommandText = query;
					cmd.Connection = conn;
					conn.Open();

					using (SqlDataReader reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							// none nullable data
							rates.Add(reader["TaxCode"] as string, (decimal)reader["TaxRate"]);
						}
					}
				}
			}

			return rates;
		}
	}
}
	
