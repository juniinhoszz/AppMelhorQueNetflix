using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppMelhorQueNetflix
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            img_logo.Source = ImageSource.FromResource("AppMelhorQueNetflix.Img.imgnetflix.png");
        }

        private async void btn_aventura_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new AppMelhorQueNetflix.Categorias.Aventura());

            }catch(Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
        }

        private async void btn_comedia_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new AppMelhorQueNetflix.Categorias.Comedia());

            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }

        }


        private async void btn_drama_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new AppMelhorQueNetflix.Categorias.Drama());

            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
        }

        private async void btn_acao_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new AppMelhorQueNetflix.Categorias.Acao());

            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
        }

        private async void btn_suspense_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new AppMelhorQueNetflix.Categorias.Suspense());

            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}
