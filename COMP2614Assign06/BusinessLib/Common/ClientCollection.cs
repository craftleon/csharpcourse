using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLib.Common
{
    public class ClientCollection : BindingList<Client>
    {
        public decimal TotalYTDSales
        {
            // using expression-bodied get function and lamda expression from Sum parameter
            get => this.Sum(client => client.YTDSales);
        }
    }
}
