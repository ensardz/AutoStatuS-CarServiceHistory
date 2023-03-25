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
    public partial class Historija3 : ContentPage
    {
        public Historija3()
        {
            InitializeComponent();

            this.BindingContext = this;

            Piker.Items.Add("10.06.2022");
         

            List<Slike> slika = new List<Slike>()
            {
                new Slike(){ Naslov="Slika 1", Slika="citroen1"},
                new Slike(){ Naslov="Slika 2", Slika="citroen2"},
                new Slike(){ Naslov="Slika 2", Slika="citroen3"}

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
            ServisiList.Add(new Vozilo { Info = "Naziv modela: ", Podatak = "Citroën C4" });
            ServisiList.Add(new Vozilo { Info = "Vlasnik: ", Podatak = "Elvir Litrić" });
            ServisiList.Add(new Vozilo { Info = "VIN broj ", Podatak = "VF3LBBHZ3FS309973" });
            ServisiList.Add(new Vozilo { Info = "Godina proizvodnje: ", Podatak = "2005" });
            ServisiList.Add(new Vozilo { Info = "Zapremina motora ", Podatak = "1598 cm³" });
            ServisiList.Add(new Vozilo { Info = "Snaga motora ", Podatak = "80kW" });

            return ServisiList;
        }
        private async void Piker_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                await Navigation.PushAsync(new Historija3a());
           


        }
    }


}
