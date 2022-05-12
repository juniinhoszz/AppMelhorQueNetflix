using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AppMelhorQueNetflix.Categorias
{
    public class Aventura : ContentPage
    {
        public Aventura()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "teste" }
                }
            };
        }
    }
}