using semana02.View.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace semana02.View.Producto
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class VPPrincipal : ContentPage
	{
		public VPPrincipal ()
		{
			InitializeComponent ();
		}

        private async void btnSalir_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync (new VLogin());
        }
    }
}