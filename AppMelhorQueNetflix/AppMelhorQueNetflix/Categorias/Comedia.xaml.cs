using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppMelhorQueNetflix.Categorias
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Comedia : ContentPage
    {
        public Comedia()
        {
            InitializeComponent();
            img_logo.Source = ImageSource.FromResource("AppMelhorQueNetflix.Img.imgnetflix.png");

            btn_bigbug.Source = ImageSource.FromResource("AppMelhorQueNetflix.Posters.Aventura.bigbug.jpg");
        }

        private async void btn_bigbug_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new AppMelhorQueNetflix.Filmes.bigbug());

            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}