using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign06
{
    public class ClientCollection : List<Client>
    {
        public decimal TotalYTDSales
        {
            // using expression-bodied function and lamda expression
            get => this.Sum(c => c.YTDSales);
        }

        public ClientCollection()
        {

        }

        public ClientCollection(int capacity) : base(capacity)
        {

        }
    }
}
