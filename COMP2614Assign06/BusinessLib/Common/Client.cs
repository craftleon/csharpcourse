using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLib.Common
{
    public class Client
    {
        public string ClientCode { get; set; }
        public string CompanyName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public decimal YTDSales { get; set; }
        public bool CreditHold { get; set; }
        public string Notes { get; set; }

        public Client()
        {

        }

        public Client(Client other)
        {
            ClientCode = other.ClientCode;
            CompanyName = other.CompanyName;
            Address1 = other.Address1;
            Address2 = other.Address2;
            City = other.City;
            Province = other.Province;
            YTDSales = other.YTDSales;
            CreditHold = other.CreditHold;
            Notes = other.Notes;
        }
    }
}
