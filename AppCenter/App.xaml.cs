using AppCenter.Services;
using AppCenter.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace AppCenter
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
           DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
            Microsoft.AppCenter.AppCenter.Configure("ios={Your App Secret};macos={Your App Secret};android={99a87e7e-d6bd-4ed9-bb88-c74ad1a618f6};uwp={Your App Secret};windowsdesktop={Your App Secret}");
            if (Microsoft.AppCenter.AppCenter.Configured)
            {
                Microsoft.AppCenter.AppCenter.Start(typeof(Analytics));
                Microsoft.AppCenter.AppCenter.Start(typeof(Crashes));
            }
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

    }
}
