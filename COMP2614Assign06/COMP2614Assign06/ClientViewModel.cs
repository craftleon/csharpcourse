using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using COMP2614Assign06.Common;
using COMP2614Assign06.Business;

namespace COMP2614Assign06
{
    public class ClientViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ClientCollection Clients { get; set; }

        public ClientViewModel()
        {
            Clients = ClientValidation.GetClients();
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
    }
}
