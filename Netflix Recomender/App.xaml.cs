using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Netflix_Recomender.Services;
using Netflix_Recomender.Views;
using MovieApp;

namespace Netflix_Recomender
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new NavigationPage(new MoviesPage());
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
