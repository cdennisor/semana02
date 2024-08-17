using semana02.View.Producto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace semana02.View.Home
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class VHFooter : ContentView
	{
		public VHFooter ()
		{
			InitializeComponent ();
		}

        private async void btn_inicar_sesion_Clicked(object sender, EventArgs e)
        {
			await Navigation.PushAsync(new VPPrincipal());
        }
    }
}