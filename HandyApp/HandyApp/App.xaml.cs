using HandyApp.Services;
using Xamarin.Forms;

namespace HandyApp
{
    public partial class App : Application
    {
        public static BlueToothService BTService { get; set; }

        public App()
        {
            //Register Syncfusion license
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MTcyNDY0QDMxMzcyZTMzMmUzMGpQaEhtTXRBQnNreTdHZ2dDNmRJQWdpZlY2Y01lK3VDZXp4MHl5NHBZb2s9");

            Device.SetFlags(new[] { 
                "SwipeView_Experimental"
            });

            //Config the Bluetooth Service
            BTService = new BlueToothService();

            InitializeComponent();
            MainPage = new AppShell();
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
