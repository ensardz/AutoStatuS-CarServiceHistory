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
    public partial class Servis : ContentPage
    {
        public Servis()
        {
            InitializeComponent();
        }

        private void Nazad(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private async void Pritisnuto(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Servis1());
        }

        private async void Pritisnuto1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Servis2());
        }

        private async void Pritisnuto2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Servis3());
        }
        private void Dugme_Clicked(object sender, EventArgs e)
        {
                Navigation.PopAsync();
            
        }

        
       
    }
}