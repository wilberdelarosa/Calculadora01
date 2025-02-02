using System;
using Microsoft.Maui.Controls;

namespace Calculadora01
{
    public partial class MainPage : ContentPage
    {

       
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;

            carruselprincipal.ItemsSource = Movie.Items;

        }


    }
}