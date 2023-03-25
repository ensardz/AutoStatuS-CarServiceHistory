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
    public partial class Provjera : ContentPage
    {
        public Provjera()
        {
            InitializeComponent();
        }
        private void Nazad1(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            string x = Ime.Text;
            string y = Unos.Text;

            if (x == "emir" && y == "emir9999")
            {
                await Navigation.PushAsync(new Historija1());
            }
            else if (x == "ibrahim" && y == "ibrahim996")
            {
                await Navigation.PushAsync(new Historija2());
            }
            else if (x == "elvir" && y == "elvir9999")
            {
                await Navigation.PushAsync(new Historija3());
            }
            else if( x==string.Empty || y==string.Empty )
            {
                await DisplayAlert("Niste unijeli sve podatke!", "Pokušajte ponovo!", "OK");
            }
            else if (x.Any(char.IsDigit))
            {

                 await DisplayAlert("Ime ne smije sadržavati brojeve", "Pokušajte ponovo!", "OK");
            }
            else if (x=="emir" && y!="emir9999")
            {
                await DisplayAlert("Netačan identifikacioni ključ", "Pokušajte ponovo!", "OK");
            }

            else if (x == "ibrahim" && y != "ibrahim996")
            {
                await DisplayAlert("Netačan identifikacioni ključ", "Pokušajte ponovo!", "OK");
            }
            else if (x == "elvir" && y != "elvir9999")
            {
                await DisplayAlert("Netačan identifikacioni ključ", "Pokušajte ponovo!", "OK");
            }

            else 
            {
               await  DisplayAlert("Nemate pristup!", "Pokušajte ponovo!", "OK");
            }
        }
        private void ImageButton_Pressed(object sender, EventArgs e)
        {
            Unos.IsPassword = false;
        }

        private void ImageButton_Released(object sender, EventArgs e)
        {
            Unos.IsPassword = true;
        }
    }
}