using FoodDrinkUIAppPractice.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodDrinkUIAppPractice
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MenuDetailPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
