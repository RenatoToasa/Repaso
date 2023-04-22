using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Repaso
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciar_Clicked(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;
            if (usuario == "rtoasa" && contrasena == "12345")
            {
                Navigation.PushAsync(new Principal());

            }
            else
            {
                DisplayAlert("ALERTA", "Usuario/Contraseña Incorrectos", "Cerrar");
                txtUsuario.Text = "";
                txtContrasena.Text = "";
            }
        }

        private void btnRegistrar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Registro());
        }

        private void txtdato_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double numero =Convert.ToDouble(txtdato.Text);
                //1-10
                if (numero < 1 && numero > 10) {
                    DisplayAlert("Mensaje", "El rango permitido es 1 -10", "Cerrar");
                    txtdato.Text = "";
                
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("ERROR", ex.Message, "cerrar");
               
            }
        }
    }
}