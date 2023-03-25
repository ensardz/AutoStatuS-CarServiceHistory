using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AutoStatus
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Historija1 : ContentPage
    {
        public Historija1()
        {
            InitializeComponent();
            
            this.BindingContext = this;

            Piker.Items.Add("05.03.2018");
            Piker.Items.Add("18.12.2021");
            Piker.Items.Add("08.06.2022");

            List<Slike> slika = new List<Slike>()
            {
                new Slike(){ Naslov="Slika 1", Slika="audi1"},
                new Slike(){ Naslov="Slika 2", Slika="audi2"},
                new Slike(){ Naslov="Slika 2", Slika="audi3"}

            };
            SlikeCarousel.ItemsSource= slika;
        }
       
        private void Nazad(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
        public List<Vozilo> Historija { get => Podaci(); }
        private List<Vozilo> Podaci()
        {
            var ServisiList = new List<Vozilo>();
            ServisiList.Add(new Vozilo { Info = "Naziv modela: ", Podatak = "Audi A4" });
            ServisiList.Add(new Vozilo { Info = "Vlasnik: ", Podatak = "Emir Ćato" });
            ServisiList.Add(new Vozilo { Info = "VIN broj ", Podatak = "WAUZZZ4H0AN002284" });
            ServisiList.Add(new Vozilo { Info = "Godina proizvodnje: ", Podatak = "2011" });
            ServisiList.Add(new Vozilo { Info = "Zapremina motora ", Podatak = "1998 cm³" });
            ServisiList.Add(new Vozilo { Info = "Snaga motora ", Podatak = "105kW" });
           
            return ServisiList;
        }
        private async void Piker_SelectedIndexChanged(object sender, EventArgs e)
        {
             if (Piker.SelectedItem == "05.03.2018")
            {
                await Navigation.PushAsync(new Historija1a());
            }
            else if (Piker.SelectedItem == "18.12.2021")
            {
                await Navigation.PushAsync(new Historija1b());
            }
            else if (Piker.SelectedItem == "08.06.2022")
            {
                await Navigation.PushAsync(new Historija1c());
            }


        }
    }
    public class Slike
    {
        public string Naslov { get; set; }  
        public string Slika { get; set; }
    }
    public class Vozilo
    {
        public string Info { get; set; }
        public string Podatak { get; set; }

    }

}
