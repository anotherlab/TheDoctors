using System;
using System.Globalization;
using System.Threading;
using Android.App;
using Android.Content.PM;
using Android.Graphics.Drawables;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace TheDoctors.Droid
{
    [Activity(Label = "@string/ApplicationTitle", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            RemoveTheIcon();

            global::Xamarin.Forms.Forms.Init(this, bundle);

            //Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-FR");
            //Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;

            LoadApplication(new App());
        }

        private void RemoveTheIcon()
        {
            ActionBar.SetIcon(
              new ColorDrawable(Resources.GetColor(Android.Resource.Color.Transparent)));
        }
    }
}

