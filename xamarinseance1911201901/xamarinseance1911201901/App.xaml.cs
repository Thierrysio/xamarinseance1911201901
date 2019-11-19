using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using xamarinseance1911201901.Modeles;
using xamarinseance1911201901.Vues;

namespace xamarinseance1911201901
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //Creation d'instances
            new Projet("Projet 01", new DateTime(2019, 11, 19), new DateTime(2019, 11, 30), 12500);
            //////////////////////
            MainPage = new ProjetPage();
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
