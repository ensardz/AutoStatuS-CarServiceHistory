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
    public partial class Historija3a : ContentPage
    {
        public Historija3a()
        {
            InitializeComponent();
        }

        private void Nazad(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }


    }

    public class Historija3A
    {
        public ObservableCollection<ServisneInformacije> ServisneInfo { get; set; }
        public Historija3A()
        {
            this.ServisneInfo = new ObservableCollection<ServisneInformacije>();
            Dodaj();
        }
        private void Dodaj()
        {
            ServisneInfo.Add(new ServisneInformacije(1, "Zamjena grijača (4kom)", "Simanić", "Grijači", 40, 1, 20, 60));
            ServisneInfo.Add(new ServisneInformacije(2, "Mali servis", "Simanić", "Ulje + Filteri", 98, 1, 20, 118));
            ServisneInfo.Add(new ServisneInformacije(3, "Zamjena krajnice", "Simanić", "Krajnica", 18, 1, 20, 38));
            ServisneInfo.Add(new ServisneInformacije(4, "El. probl. brave vrata (PD)", "Simanić", "/", 0, 2, 40, 40));
            ServisneInfo.Add(new ServisneInformacije(5, "Zamjena stabilizatora (2 kom)", "Simanić", "Stabilizatori", 38, 1, 20, 58));
            ServisneInfo.Add(new ServisneInformacije(6, "Zamjena donjeg nosača motora", "Simanić", "Nosač motora ", 47, 1, 20, 67));
        }
    }



}
