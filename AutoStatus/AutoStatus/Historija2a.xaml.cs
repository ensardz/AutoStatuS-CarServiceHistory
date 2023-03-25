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
    public partial class Historija2a : ContentPage
    {
        public Historija2a()
        {
            InitializeComponent();
        }

        private void Nazad(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }


    }

    public class Historija2A
    {
        public ObservableCollection<ServisneInformacije> ServisneInfo { get; set; }
        public Historija2A()
        {
            this.ServisneInfo = new ObservableCollection<ServisneInformacije>();
            Dodaj();
        }
        private void Dodaj()
        {
            ServisneInfo.Add(new ServisneInformacije(1, "Veliki servis", "Midas", "Španer + Vodena pumpa", 358, 4, 100, 458));
            ServisneInfo.Add(new ServisneInformacije(2, "Mali servis", "Midas", "Ulje + Filteri", 118, 1, 20, 138));
            ServisneInfo.Add(new ServisneInformacije(3, "Zamjena dizne (1 i 4 cil.)", "Midas", "2x Delphi dizna", 1200, 1, 40, 1240));
            ServisneInfo.Add(new ServisneInformacije(4, "Punjenje autoKlime", "Midas", "0", 0, 1, 30, 30));
            ServisneInfo.Add(new ServisneInformacije(5, "Zamjena guma i balans (2kom)", "Midas", "0", 0, 1, 10, 10));
            ServisneInfo.Add(new ServisneInformacije(6, "Zamjena cilindra kvačila", "Midas", "Cilindar", 60, 1, 30, 90));
            ServisneInfo.Add(new ServisneInformacije(7, "Zamjena disk pločica (Zadnje)", "Midas", "Disk pločice", 40, 1, 20, 60));
            ServisneInfo.Add(new ServisneInformacije(8, "Zamjena spone", "Midas", "Spona", 30, 1, 30, 60));
            
        }
    }



}
