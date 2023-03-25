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
    public partial class Servis2 : ContentPage
    {
        public Servis2()
        {
            InitializeComponent();
            this.BindingContext = this;
        }
        public List<Servisinfo> Servisi { get => Podaci(); }
        private List<Servisinfo> Podaci()
        {
            var ServisiList = new List<Servisinfo>();
            ServisiList.Add(new Servisinfo { Polja = "Naziv: ", Vrijednost = "AutoServis Zgodić" });
            ServisiList.Add(new Servisinfo { Polja = "Odgovorno lice: ", Vrijednost = "Zgodić Ermin" });
            ServisiList.Add(new Servisinfo { Polja = "JIB: ", Vrijednost = "4200864110009" });
            ServisiList.Add(new Servisinfo { Polja = "Usluge: ", Vrijednost = "Pregledi, Mehanika, AutoKlime" });
            ServisiList.Add(new Servisinfo { Polja = "Radno vrijeme: ", Vrijednost = "Pon - Sub 10:00 - 18:00" });
            ServisiList.Add(new Servisinfo { Polja = "Broj telefona: ", Vrijednost = "033 744-180" });
            ServisiList.Add(new Servisinfo { Polja = "Adresa: ", Vrijednost = "Franje Vuletića" });

            return ServisiList;
        }
        public List<Cjenovnik> Cijene { get => Podacicijene(); }
        private List<Cjenovnik> Podacicijene()
        {
            var CijeneList = new List<Cjenovnik>();

            CijeneList.Add(new Cjenovnik { RBr = "R. Br.", Opis = "Usluga", Cijena = "Cijena" });
            CijeneList.Add(new Cjenovnik { RBr = "1.", Opis = "Dijagnostika vozila", Cijena = "10 KM" });
            CijeneList.Add(new Cjenovnik { RBr = "2.", Opis = "Punjenje klime", Cijena = "30 KM" });
            CijeneList.Add(new Cjenovnik { RBr = "3.", Opis = "Mali servis", Cijena = "20 KM" });
            CijeneList.Add(new Cjenovnik { RBr = "4.", Opis = "Zamjena disk plocica", Cijena = "30 KM" });
            CijeneList.Add(new Cjenovnik { RBr = "5.", Opis = "Zamjena diskova", Cijena = "30 KM" });
            CijeneList.Add(new Cjenovnik { RBr = "6.", Opis = "Pregled vozila", Cijena = "10 KM" });
            CijeneList.Add(new Cjenovnik { RBr = "7.", Opis = "Veliki servis", Cijena = "100 KM" });
            CijeneList.Add(new Cjenovnik { RBr = "8.", Opis = "Zamjena mikro remena", Cijena = "20 KM" });
            CijeneList.Add(new Cjenovnik { RBr = "9.", Opis = "Zamjena amortizera", Cijena = "30 KM" });
            CijeneList.Add(new Cjenovnik { RBr = "10.", Opis = "Zamjena disk plocica", Cijena = "20 KM" });
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
            Map.OpenAsync(43.84024459240436, 18.30042658356502, new MapLaunchOptions
            {
                Name = "zgodic",
                NavigationMode = NavigationMode.Driving

            });

        }

    }
}