using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Bitki.Vistas;

namespace Bitki
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new UI_inicio());
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
