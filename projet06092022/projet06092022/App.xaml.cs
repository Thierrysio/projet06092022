using projet06092022.Vues;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace projet06092022
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new GestionEtudiantVue();
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
