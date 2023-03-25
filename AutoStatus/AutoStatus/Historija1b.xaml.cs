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
    public partial class Historija1b : ContentPage
    {
        public Historija1b()
        {
            InitializeComponent();
        }

        private void Nazad(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
        

    }

    public class Historija1B
    {
        public ObservableCollection<ServisneInformacije> ServisneInfo { get; set; }
        public Historija1B()
        {
            this.ServisneInfo = new ObservableCollection<ServisneInformacije>();
            Dodaj();
        }
        private void Dodaj()
        {
            ServisneInfo.Add(new ServisneInformacije(1, "Zamjena ulja u mjenjaču", "Simanić", "Ulje SAE 75W", 120, 1, 30, 150));
            ServisneInfo.Add(new ServisneInformacije(2, "Mali servis", "Simanić", "Ulje + Filteri", 148, 1, 20, 168));
            ServisneInfo.Add(new ServisneInformacije(3, "Zamjena kočionih kliješta (P)", "Simanić", "Kliješta", 125, 2, 40, 165));
            ServisneInfo.Add(new ServisneInformacije(4, "Zamjena hladnjaka", "Simanić", "Hladnjak", 230, 2, 60, 290));
            ServisneInfo.Add(new ServisneInformacije(5, "Zamjena stabilizatora (2 kom)", "Simanić", "Stabilizatori", 98, 1, 30, 128));
            ServisneInfo.Add(new ServisneInformacije(6, "Zamjena akumulatora", "Simanić", "Akumulator", 140, 1, 10, 150));
            ServisneInfo.Add(new ServisneInformacije(7, "Zamjena termostata", "Simanić", "Termostat", 30, 2, 50, 80));
            ServisneInfo.Add(new ServisneInformacije(8, "Zamjena brisača (P)", "Simanić", "Brisači", 40, 1, 10, 50));
        }
    }



}
