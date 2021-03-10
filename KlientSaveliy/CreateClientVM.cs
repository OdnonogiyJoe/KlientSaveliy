using System;
using System.Collections.Generic;
using System.Text;

namespace KlientSaveliy
{
    public class CreateClientVM: Mvvm1125.MvvmNotify
    {
        Model model;

        public List<CreateClientVM> createClientVMs { get; set; }
        public Mvvm1125.MvvmCommand CreateClient { get; set; }
        public Mvvm1125.MvvmCommand EditClient { get; set; }
        public Mvvm1125.MvvmCommand RemoveClient { get; set; }

        public void SetModel(Model model)
        {
            this.model = model;
            CreateClient = new Mvvm1125.MvvmCommand(
                ()=> {model.AddClient)
        }


    }
}
