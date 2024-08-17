using semana02.View.Home;
using semana02.View.Login;
using semana02.View.Producto;
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

            //MainPage = new NavigationPage(new VHPrincipal());
            MainPage = new VLogin();
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
