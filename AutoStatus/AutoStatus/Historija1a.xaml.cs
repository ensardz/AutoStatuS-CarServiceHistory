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
    public partial class Historija1a : ContentPage
    {
        public Historija1a()
        {
            InitializeComponent();
        }

        private void Nazad(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }


    }
     public class ServisneInformacije
    {
        private int redniBroj;
        private string opisPosla;
        private string servis;
        private string zamjenskidio;
        private int cijenaDijela;
        private int brRadnihSati;
        private int cijenaUsluge;
        private int ukupno;

        public int RedniBroj
        {
            get { return redniBroj; }
            set
            {
                this.redniBroj = value;
                
            }
        }

        public string OpisPosla
        {
            get { return opisPosla; }
            set
            {
                this.opisPosla = value;    
            }
        }

        public string Servis
        {
            get { return servis; }
            set
            {
                this.servis = value;
            }

        }
        public string Zamjenskidio
        {
            get { return zamjenskidio; }
            set
            {
                this.zamjenskidio = value;
            }
        }
        public int CijenaDijela
        {
            get { return cijenaDijela; }
            set
            {
                this.cijenaDijela = value;
                
            }
        }
        public int BrRadnihSati
        {
            get { return brRadnihSati; }
            set
            {
                this.brRadnihSati = value;

            }
        }
        public int CijenaUsluge
        {
            get { return cijenaUsluge; }
            set
            {
                this.cijenaUsluge = value;

            }
        }
        public int Ukupno
        {
            get { return ukupno; }
            set
            {
                this.ukupno = value;

            }
        }

        public ServisneInformacije(int redniBroj, string opisPosla, string servis, string zamjenskidio, int cijenaDijela, int brRadnihSati
            ,int cijenaUsluge,int ukupno)
        {
            this.redniBroj = redniBroj;
            this.opisPosla = opisPosla;
            this.servis = servis;
            this.zamjenskidio = zamjenskidio;
            this.cijenaDijela = cijenaDijela;
            this.brRadnihSati = brRadnihSati;   
            this.cijenaUsluge =cijenaUsluge;
            this.ukupno=ukupno;

        }

    }

    public class Historija1A
    {
        public ObservableCollection<ServisneInformacije> ServisneInfo { get; set; }
        public Historija1A()
        {
            this.ServisneInfo = new ObservableCollection<ServisneInformacije>();
            Dodaj();
        }
        private void Dodaj()
        {
            ServisneInfo.Add(new ServisneInformacije(1, "Zamjena disk pločica (Prednje)", "Midas", "Disk pločice", 80, 1, 30, 110));
            ServisneInfo.Add(new ServisneInformacije(2, "Zamjena disk pločica (Zadnje)", "Midas", "Disk pločice", 40, 1, 20, 60));
            ServisneInfo.Add(new ServisneInformacije(3, "Zamjena nosača motora (2 kom)", "Midas", "Disk pločice",230, 2, 60, 290));
            ServisneInfo.Add(new ServisneInformacije(4, "Mali servis", "Midas", "Ulje + Filteri", 138, 1, 20, 158));
            ServisneInfo.Add(new ServisneInformacije(5, "Zamjena guma i balans (4kom)", "Midas", "/", 0, 1, 20, 20));
            ServisneInfo.Add(new ServisneInformacije(6, "Zamjena opruge (PL)", "Midas", "Opruga", 60, 1, 30, 90));
            ServisneInfo.Add(new ServisneInformacije(7, "Servisiranje autoKlime", "Midas", "Kvačilo kompresora", 55, 2, 40, 95));
            ServisneInfo.Add(new ServisneInformacije(8, "Punjenje autoKlime", "Midas", "/", 0, 1, 30, 30));
            ServisneInfo.Add(new ServisneInformacije(9, "Remont mjenjača", "Midas", "Ležajevi", 85, 8, 200, 285));

        }
    }


  
}
