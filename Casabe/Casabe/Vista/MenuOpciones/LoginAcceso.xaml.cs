using Casabe.VistaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Casabe.Vista.MenuOpciones
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginAcceso : ContentPage
    {
        public LoginAcceso()
        {
            InitializeComponent();
            BindingContext = new VMLogin(Navigation);

        }
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegistrarUsuario());
        }
    }
}