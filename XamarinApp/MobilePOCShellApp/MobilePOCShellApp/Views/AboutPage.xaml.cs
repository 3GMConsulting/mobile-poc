using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MobilePOCAPI;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MobilePOCShellApp.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            //CallApi();
        }

        //public async void CallApi() 
        //{
        //    //var listaUsuarios = ApiConsumer.API.GetListFromJson<List<Models.Usuario>>();
        //
        //    //string response = await ApiConsumer.API.GetAllASync();
        //    //responseObject.Text = response;
        //}
    }
}