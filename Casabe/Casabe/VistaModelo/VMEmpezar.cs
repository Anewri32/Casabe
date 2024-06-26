using Casabe.Vista.MenuOpciones;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Casabe.VistaModelo
{
    public class VMEmpezar : BaseModelo
    {
        #region VARIABLES

        #endregion

        #region CONSTRUCTOR
        public VMEmpezar(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion

        #region OBJETOS

        #endregion

        #region PROCESOS
        private async void NavegarLogin()
        {
            await Navigation.PushAsync(new LoginAcceso());
        }
        #endregion

        #region COMANDOS
        public ICommand NavegarLogincommad => new Command(NavegarLogin);
        #endregion

    }
}
