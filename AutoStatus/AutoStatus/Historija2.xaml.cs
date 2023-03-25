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
    public partial class Historija2 : ContentPage
    {
        public Historija2()
        {
            InitializeComponent();

            this.BindingContext = this;

            Piker.Items.Add("10.12.2019");
            Piker.Items.Add("18.05.2022");

            List<Slike> slika = new List<Slike>()
            {
                new Slike(){ Naslov="Slika 1", Slika="golf1"},
                new Slike(){ Naslov="Slika 2", Slika="golf2"},
                new Slike(){ Naslov="Slika 2", Slika="golf3"}

            };
            SlikeCarousel.ItemsSource = slika;
        }

        private void Nazad(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
        public List<Vozilo> Historija { get => Podaci(); }
        private List<Vozilo> Podaci()
        {
            var ServisiList = new List<Vozilo>();
            ServisiList.Add(new Vozilo { Info = "Naziv modela: ", Podatak = "Golf 6" });
            ServisiList.Add(new Vozilo { Info = "Vlasnik: ", Podatak = "Ibrahim Smajlović" });
            ServisiList.Add(new Vozilo { Info = "VIN broj ", Podatak = "WAW2ZZ1JZ1W603956" });
            ServisiList.Add(new Vozilo { Info = "Godina proizvodnje: ", Podatak = "2010" });
            ServisiList.Add(new Vozilo { Info = "Zapremina motora ", Podatak = "1597 cm³" });
            ServisiList.Add(new Vozilo { Info = "Snaga motora ", Podatak = "77kW" });

            return ServisiList;
        }
        private async void Piker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Piker.SelectedItem == "10.12.2019")
            {
                await Navigation.PushAsync(new Historija2a());
            }
            else if (Piker.SelectedItem == "18.05.2022")
            {
                await Navigation.PushAsync(new Historija2b());
            }
            

        }
    }
   

}
