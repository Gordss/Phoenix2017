using Android.App;
using Android.Widget;
using Android.OS;
using Android.Locations;
using Android.Content;

namespace Hackaton2017
{
    [Activity(Label = "Hackaton2017", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            LocationManager locMgr;

            locMgr = GetSystemService(Context.LocationService) as LocationManager;
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.test);
        }
    }
}

