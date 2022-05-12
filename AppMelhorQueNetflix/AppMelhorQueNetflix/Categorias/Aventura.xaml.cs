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
    public partial class Aventura : ContentPage
    {
        public Aventura()
        {
            InitializeComponent();
            img_logo.Source = ImageSource.FromResource("AppMelhorQueNetflix.Img.imgnetflix.png");

            btn_spiderman.Source = ImageSource.FromResource("AppMelhorQueNetflix.Posters.Aventura.miranha.jpg");
            btn_uncharted.Source = ImageSource.FromResource("AppMelhorQueNetflix.Posters.Aventura.uncharted.png");
            btn_esquadrao_suic.Source = ImageSource.FromResource("AppMelhorQueNetflix.Posters.Aventura.esquadrao_suicida.png");
            btn_viuvanegra.Source = ImageSource.FromResource("AppMelhorQueNetflix.Posters.Aventura.viuva_negra.png");
            btn_godzillavskong.Source = ImageSource.FromResource("AppMelhorQueNetflix.Posters.Aventura.godzillavskong.jpg");
            btn_moonfall.Source = ImageSource.FromResource("AppMelhorQueNetflix.Posters.Aventura.moonfall.jpg");

        }

        private async void btn_spiderman_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new AppMelhorQueNetflix.Filmes.spidermannwh());

            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
        }

        private async void btn_uncharted_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new AppMelhorQueNetflix.Filmes.uncharted());

            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
        }

        private async void btn_esquadrao_suic_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new AppMelhorQueNetflix.Filmes.esquadrao_suic());

            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
        }

        private async void btn_viuvanegra_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new AppMelhorQueNetflix.Filmes.viuvanegra());

            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
        }

        private async void btn_godzillavskong_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new AppMelhorQueNetflix.Filmes.godzillavskong());

            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
        }

        private async void btn_moonfall_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new AppMelhorQueNetflix.Filmes.moonfall());

            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}