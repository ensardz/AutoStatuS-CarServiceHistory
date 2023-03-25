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
    public partial class Servis1 : ContentPage
    {
        public Servis1()
        {
            InitializeComponent();
            this.BindingContext = this;
        }
        public List<Servisinfo> Servisi { get => Podaci(); }
        private List<Servisinfo> Podaci()
        {
            var ServisiList = new List<Servisinfo>();
            ServisiList.Add(new Servisinfo { Polja = "Naziv: ", Vrijednost = "Auto Simanić" });
            ServisiList.Add(new Servisinfo { Polja = "Odgovorno lice: ", Vrijednost = "Simanić Sreten"}); 
            ServisiList.Add(new Servisinfo { Polja = "JIB: ", Vrijednost = "4201667200008" });
            ServisiList.Add(new Servisinfo { Polja = "Usluge: ", Vrijednost = "Pregledi, Mehanika, Elektronika" });
            ServisiList.Add(new Servisinfo { Polja = "Radno vrijeme: ", Vrijednost = "Pon - Sub 09:00 - 17:00" });
            ServisiList.Add(new Servisinfo { Polja = "Broj telefona: ", Vrijednost = "+387 61 270 696" });
            ServisiList.Add(new Servisinfo { Polja = "Adresa: ", Vrijednost = "Adema Buće 234" });
           
            return ServisiList;
        }
        public List<Cjenovnik> Cijene { get => Podacicijene(); }
        private List<Cjenovnik> Podacicijene()
        {
            var CijeneList = new List<Cjenovnik>();
            
            CijeneList.Add (new Cjenovnik { RBr = "R. Br.", Opis = "Usluga", Cijena = "Cijena" });
            CijeneList.Add(new Cjenovnik {  RBr = "1.", Opis = "Pregled vozila", Cijena = "10 KM" });
            CijeneList.Add(new Cjenovnik { RBr = "2.", Opis = "Zamjena ulja", Cijena = "10 KM" });
            CijeneList.Add(new Cjenovnik { RBr = "3.", Opis = "Mali servis", Cijena = "20 KM" });
            CijeneList.Add(new Cjenovnik { RBr = "4.", Opis = "Zamjena disk plocica", Cijena = "30 KM" });
            CijeneList.Add(new Cjenovnik { RBr = "5.", Opis = "Zamjena diskova", Cijena = "30 KM" });
            CijeneList.Add(new Cjenovnik { RBr = "6.", Opis = "Dijagnostika vozila", Cijena = "10 KM" });
            CijeneList.Add(new Cjenovnik { RBr = "7.", Opis = "Veliki servis", Cijena = "100 KM" });
            CijeneList.Add(new Cjenovnik { RBr = "8.", Opis = "Zamjena mikro remena", Cijena = "20 KM" });
            CijeneList.Add(new Cjenovnik { RBr = "9.", Opis = "Zamjena amortizera", Cijena = "30 KM" });
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
              Stack1.Margin = new Thickness(0,0,0,-300);
            Stack1.TranslationY = -320;
                
        }
        private void Lokacija(object sender, EventArgs e)
        {
            Map.OpenAsync(43.86273015775319, 18.358952542164147, new MapLaunchOptions
            {
                Name = "simanic",
                NavigationMode = NavigationMode.Driving

            });

        }

    }
    public class Servisinfo
    {
        public string Polja { get; set; }
        public string Vrijednost { get; set; }
       
    }
        public class Cjenovnik
    {
        public string RBr { get; set; }
        public string Opis { get; set; }
        public string Cijena { get; set; }

    }
}
 