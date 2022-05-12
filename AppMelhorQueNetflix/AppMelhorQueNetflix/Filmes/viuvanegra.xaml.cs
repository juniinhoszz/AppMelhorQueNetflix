using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppMelhorQueNetflix.Filmes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class viuvanegra : ContentPage
    {
        public viuvanegra()
        {
            InitializeComponent();
            img_filme.Source = ImageSource.FromResource("AppMelhorQueNetflix.Posters.Aventura.viuva_negra.png");
            img_logo.Source = ImageSource.FromResource("AppMelhorQueNetflix.Img.imgnetflix.png");

            var htmlSource = new HtmlWebViewSource();
            htmlSource.Html = @"<iframe width='560' height='315' src='https://www.youtube.com/embed/uNAxHLp7wv8' title='YouTube video player' frameborder='0' allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe>";

            visu.Source = htmlSource;
        }
    }
}