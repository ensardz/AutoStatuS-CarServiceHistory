using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AutoStatus
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Servis3 : ContentPage
    {
        public Servis3()
        {
            InitializeComponent();
            this.BindingContext = this;
        }
        public List<Servisinfo> Servisi { get => Podaci(); }
        private List<Servisinfo> Podaci()
        {
            var ServisiList = new List<Servisinfo>();
            ServisiList.Add(new Servisinfo { Polja = "Naziv: ", Vrijednost = "AutoServis Midas" });
            ServisiList.Add(new Servisinfo { Polja = "Odgovorno lice: ", Vrijednost = "Irfan Spahić" });
            ServisiList.Add(new Servisinfo { Polja = "JIB: ", Vrijednost = "4302716530001" });
            ServisiList.Add(new Servisinfo { Polja = "Usluge: ", Vrijednost = "Mehanika, AutoKlime, Elektronika" });
            ServisiList.Add(new Servisinfo { Polja = "Radno vrijeme: ", Vrijednost = "Pon - Sub 9:00 - 17:00" });
            ServisiList.Add(new Servisinfo { Polja = "Broj telefona: ", Vrijednost = "+387 62 294 351" });
            ServisiList.Add(new Servisinfo { Polja = "Adresa: ", Vrijednost = "Vrelo Bosne 2" });

            return ServisiList;
        }
        public List<Cjenovnik> Cijene { get => Podacicijene(); }
        private List<Cjenovnik> Podacicijene()
        {
            var CijeneList = new List<Cjenovnik>();

            CijeneList.Add(new Cjenovnik { RBr = "R. Br.", Opis = "Usluga", Cijena = "Cijena" });
            CijeneList.Add(new Cjenovnik { RBr = "1.", Opis = "Servisiranje autoklime", Cijena = "? KM" });
            CijeneList.Add(new Cjenovnik { RBr = "2.", Opis = "Punjenje klime", Cijena = "30 KM" });
            CijeneList.Add(new Cjenovnik { RBr = "3.", Opis = "Mali servis", Cijena = "20 KM" });
            CijeneList.Add(new Cjenovnik { RBr = "4.", Opis = "Veliki servis", Cijena = "100 KM" });
            CijeneList.Add(new Cjenovnik { RBr = "5.", Opis = "Zamjena diskova", Cijena = "30 KM" });
            CijeneList.Add(new Cjenovnik { RBr = "6.", Opis = "Zamjena disk pločica", Cijena = "20 KM" });
            CijeneList.Add(new Cjenovnik { RBr = "7.", Opis = "Remont mjenjača", Cijena = "200 KM" });
            CijeneList.Add(new Cjenovnik { RBr = "8.", Opis = "Zamjena mikro remena", Cijena = "20 KM" });
            CijeneList.Add(new Cjenovnik { RBr = "9.", Opis = "Zamjena i balans guma 4kom", Cijena = "20 KM" });
            CijeneList.Add(new Cjenovnik { RBr = "10.", Opis = "Elektronika 1h/KM", Cijena = "20 KM" });
            CijeneList.Add(new Cjenovnik { RBr = "11.", Opis = "Mehanika 1h/KM", Cijena = "20 KM" });
            return CijeneList;
        }


        private void Nazad(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
        private void Cjenovnikklik(object sender, EventArgs e)
        {
            Dugme.IsVisible = true;
            Grid2.IsVisible = true;
            Stack1.Margin = new Thickness(0, 0, 0, -300);
            Stack1.TranslationY = -320;

        }
        private void Lokacija(object sender, EventArgs e)
        {
            Map.OpenAsync(43.83077527321528, 18.272853357671345, new MapLaunchOptions
            {
                Name = "midas",
                NavigationMode = NavigationMode.Driving

            });

        }

    }
}