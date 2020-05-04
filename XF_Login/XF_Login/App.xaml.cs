using System;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF_Login.View;

using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Microsoft.AppCenter.Push;


[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XF_Login
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //set your login page as main page
            // MainPage = new XF_LoginPage();
            MainPage = new NavigationPage(new XF_LoginPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            Console.WriteLine("App start");
            Debug.WriteLine("App starts");

            AppCenter.Start("XF_Login.Android=5b0e0e66-2dd6-48c0-9334-e9576ac3ce2d", typeof(Analytics), typeof(Crashes), typeof(Push));
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
            Console.WriteLine("App sleep");
            Debug.WriteLine("App sleeps");
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
            Console.WriteLine("App resume");
            Debug.WriteLine("App resumes");
        }
    }
}
