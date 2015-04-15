using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TheDoctors.views;
using Xamarin.Forms;

namespace TheDoctors
{
    public class App : Application
    {
        public App()
        {
            MainPage = new NavigationPage(new DoctorsPage())
            {
                BarBackgroundColor = Color.FromHex("#1976D2"),
                BarTextColor = Color.White
            };
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
