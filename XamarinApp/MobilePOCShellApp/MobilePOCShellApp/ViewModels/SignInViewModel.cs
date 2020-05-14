using MobilePOCAPI;
using MobilePOCShellApp.Models;
using System.Windows.Input;
using Xamarin.Forms;

namespace MobilePOCShellApp.ViewModels
{
    public class SignInViewModel : BaseViewModel
    {
        public Usuario SignInUser { get; set; }
        public SignInViewModel() { }
        public SignInViewModel(Usuario usuario = null)
        {
            Title = "Sign In...";
            SignInUser = usuario;

            //AuthenticateUserCommand = new Command(async () =>  //await UserDataStore.Authenticate<Usuario>());
            //OnForgotPasswordTap = new Command(async () => await Navigation.PushModalAsync());
        }

        public ICommand AuthenticateUserCommand { get; }

        public ICommand OnForgotPasswordTap { get; }
    }
}
