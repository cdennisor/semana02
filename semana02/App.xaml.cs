using semana02.View.Home;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace semana02
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new VHPrincipal();
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
