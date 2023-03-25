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
    public partial class Kalkulator : ContentPage
    {
        public Kalkulator()
        {
            InitializeComponent();
        }
        private void Nazad(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private async void Prvi(object sender, EventArgs e)
        {
            int prva = int.Parse(Maliservis.Text);
            int druga = int.Parse(Maliservis2.Text);
            int x = 10000 - (prva - druga);
            int vrijednost = x;
            if (prva < druga)
            {
                await DisplayAlert("Neispravan unos 'Trenutna kilomtraža manja od prijašnje!'", " ", "Ok");
            }
            else if ((prva - druga) > 10000)
            {
                int c = prva - druga - 10000;
                await DisplayAlert("Trebali ste uraditi mali servis prije " + c + " kilometara! ", " ", "Ok");
            }
            else
            {
                await DisplayAlert("Preostalo vam je: " + vrijednost + " km do malog servisa!", " ", "Ok");
            }

            //await DisplayAlert("Preostalo vam je: " + vrijednost + " km do malog servisa!"," ","Ok");
            //  rez1.Text =vrijednost + " kilometra vam je ostalo do malog servisa!"; 
        }
        // Na drugi način
        private void Drugi(object sender, EventArgs e)
        {
            rez2.IsVisible = true;
            var prva = int.Parse(Velikiservis.Text);
            var druga = int.Parse(Velikiservis2.Text);
            var x = 100000 - (prva - druga);
            var vrijednost = Convert.ToString(x);


            if (prva < druga)
            {
                rez2.Text = "Neispravan unos 'Trenutna kilometraža manja od prijašnje!'";
            }
            else if ((prva - druga) > 100000)
            {
                var c = prva - druga - 100000;
                rez2.Text = "Trebali ste uraditi veliki servis prije " + c + " kilometara!";
            }
            else
            {
                rez2.Text = vrijednost + " kilometara vam je ostalo do velikog servisa!";
            }

        }
    }
}