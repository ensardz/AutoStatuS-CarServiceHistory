using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Xamarin.Forms;


namespace AutoStatus
{
    public partial class Historija1c : ContentPage
    {
        public Historija1c()
        {
            InitializeComponent();
        }

        private void Nazad(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }


    }

    public class Historija1C
    {
        public ObservableCollection<ServisneInformacije> ServisneInfo { get; set; }
        public Historija1C()
        {
            this.ServisneInfo = new ObservableCollection<ServisneInformacije>();
            Dodaj();
        }
        private void Dodaj()
        {
            ServisneInfo.Add(new ServisneInformacije(1, "Veliki servis", "Midas", "Španer + Vodena pumpa", 384, 4, 100, 484));
            ServisneInfo.Add(new ServisneInformacije(2, "Mali servis", "Midas", "Ulje + Filteri", 138, 1, 20, 158));
            ServisneInfo.Add(new ServisneInformacije(3, "Zamjena ležaja točka (PD)", "Midas", "Ležaj", 80, 2, 40, 120));
            ServisneInfo.Add(new ServisneInformacije(4, "Zamjena račve vode", "Midas", "Račva", 30, 1, 20, 50));
            ServisneInfo.Add(new ServisneInformacije(5, "Zamjena senzora temperature", "Midas", "Senzor", 25, 1, 10, 35));
        }
    }

}
