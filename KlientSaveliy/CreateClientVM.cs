using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace KlientSaveliy
{
    public class CreateClientVM: Mvvm1125.MvvmNotify, INotifyPropertyChanged
    {
        Model model;
        public ObservableCollection<ClientInfo> ClientInfos { get; set; }
        public Mvvm1125.MvvmCommand EditClient { get; set; }
        public Mvvm1125.MvvmCommand RemoveClient { get; set; }
        public Mvvm1125.MvvmCommand CreateClient { get; set; }

        public void SetModel(Model model)
        {
            this.model = model;
            ClientInfos = model.GetClients();
            CreateClient = new Mvvm1125.MvvmCommand(
                () =>
                {
                    ClientInfo clientInfos = new ClientInfo();
                    ClientInfos.Insert(0, clientInfos);
                    CreateClient = clientInfos;
                },
                () => true);
        }
        private void EditClientChanged(object sender, EventArgs e)
        {
            ClientInfos = model.GetClients();
            NotifyPropertyChanged("Clients");
        }
    }
}
