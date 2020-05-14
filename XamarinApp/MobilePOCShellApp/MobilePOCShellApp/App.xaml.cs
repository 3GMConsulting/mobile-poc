using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MobilePOCShellApp.Services;
using MobilePOCShellApp.Views;

namespace MobilePOCShellApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            //Inicio Modificación - FernandoAMartinez - 15/04/2020
            DependencyService.Register<UsuarioDataStore>();
            //MainPage = new AppShell();
            MainPage = new SignInPage();
            //Fin Modificación - FernandoAMartinez - 15/04/2020
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
