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
    public partial class Historija2b : ContentPage
    {
        public Historija2b()
        {
            InitializeComponent();
        }

        private void Nazad(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }


    }

    public class Historija2B
    {
        public ObservableCollection<ServisneInformacije> ServisneInfo { get; set; }
        public Historija2B()
        {
            this.ServisneInfo = new ObservableCollection<ServisneInformacije>();
            Dodaj();
        }
        private void Dodaj()
        {
            ServisneInfo.Add(new ServisneInformacije(1, "Zamjena seta kvačila", "Zgodić", "Set kvačila + zamajac", 984, 4, 100, 1084));
            ServisneInfo.Add(new ServisneInformacije(2, "Zamjena stabilizatora (PD)", "Zgodić", "Stabilizator", 28, 1, 10, 38));
            ServisneInfo.Add(new ServisneInformacije(3, "Zamjena ležaja točka (ZL)", "Zgodić", "Ležaj", 80, 2, 40, 120));
            ServisneInfo.Add(new ServisneInformacije(4, "Zamjena spone (D)", "Zgodić", "Spona", 30, 1, 20, 50));
            ServisneInfo.Add(new ServisneInformacije(5, "Zamjena kugle(L)", "Zgodić", "Kugla", 30, 1, 20, 50));
            ServisneInfo.Add(new ServisneInformacije(6, "Zamjena sajli ručne", "Zgodić", "Sajle", 67, 1, 30, 60));
            ServisneInfo.Add(new ServisneInformacije(7, "Zamjena uljne pumpe", "Zgodić", "Uljna pumpa", 125, 1, 30, 155));
            ServisneInfo.Add(new ServisneInformacije(8, "Čišćenje EGR ventila", "Zgodić", "/", 0, 1, 30, 60));

        }
    }

}
