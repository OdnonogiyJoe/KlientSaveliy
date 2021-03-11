using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace KlientSaveliy
{
    public class Model
    {
        ClientList clients = new ClientList();

        public event EventHandler EditClientChanged;

        internal ObservableCollection<ClientInfo> GetClients()
        {
            return new ObservableCollection<ClientInfo>(clients.Clients);
        }

    }
}
