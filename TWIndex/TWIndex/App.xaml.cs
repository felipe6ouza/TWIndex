using System;
using TWIndex.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TWIndex
{
    public partial class App : Application
    {
        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MTk4MTQ3QDMxMzcyZTM0MmUzMGF6WDcwUEV5NHhDZTVkZ2prbUV4Uyt2U0l2MDdjV0Y3TmtoMTdqVnUwaVU9");

            InitializeComponent();

            MainPage = new Menu();
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
