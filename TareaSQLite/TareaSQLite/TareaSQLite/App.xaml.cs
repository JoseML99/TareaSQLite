using System;
using TareaSQLite.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TareaSQLite.ViewModel;

namespace TareaSQLite
{
    public partial class App : Application
    {
        public App(String filename)
        {
            InitializeComponent();
            VentasViewModel.Inicializador(filename);
            MainPage = new VentasView();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
