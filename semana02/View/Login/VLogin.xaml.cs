using semana02.View.Producto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace semana02.View.Login
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class VLogin : ContentPage
	{
		public VLogin ()
		{
			InitializeComponent ();
		}

        private async void btn_ISesion_Clicked(object sender, EventArgs e)
        {
			string user = "cdennis";
			string password = "senati2024";

			string u_ingresado = txtUser.Text;
			string p_ingresado = txtPass.Text;

			if (user == u_ingresado && password == p_ingresado) { 
				await Navigation.PushModalAsync(new VPPrincipal());
			}
			else
			{
				txtMensaje.Text = "Usuario o contraseña incorrecta...!!!";
			}
        }
    }
}