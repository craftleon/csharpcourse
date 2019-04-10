using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using BusinessLib.Common;
using BusinessLib.Business;
using System.Data.SqlClient;

namespace COMP2614Assign06
{
    public class ClientViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // viewmodel properties
        public ClientCollection Clients { get; set; }
        public List<string> ProvinceList { get; set; }
        public int ClientCount
        {
            get
            {
                return Clients.Count;
            }
        }

        public decimal TotalYTDSales
        {
            get
            {
                return Clients.TotalYTDSales;
            }
        }

        public ClientViewModel()
        {
            try
            {
                Clients = ClientValidation.GetClients();
                ProvinceList = ClientValidation.GetProvinceList();
            }
            // This is optional. Catch exception in case db access or other error happens. Make a minimal list with error indications.
            catch (SqlException ex)
            {
                Clients = new ClientCollection();
                Clients.Add(new Client { ClientCode = "DB Error", CompanyName = ex.Message });
            }
            catch (Exception ex)
            {
                Clients = new ClientCollection();
                Clients.Add(new Client { ClientCode = "Error", CompanyName = ex.Message });
            }
        }

        public Client GetClientByIndex(int index)
        {
            return Clients[index];
        }

        public void SetClientByIndex(int index, Client client)
        {
            Clients[index] = client;
            OnPropertyChanged("Clients");
        }

        public void AddClient(Client client)
        {
            Clients.Add(client);
            OnPropertyChanged("Clients");
        }

        public void RemoveClient(Client client)
        {
            Clients.Remove(client);
            OnPropertyChanged("Clients");
        }
    }
}
