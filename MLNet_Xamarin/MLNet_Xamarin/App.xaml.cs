using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MLNet_Xamarin.Services;
using MLNet_Xamarin.Views;

namespace MLNet_Xamarin
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
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
