using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Com.Nightonke.Boommenu;
using System;
using Android.Views;
using Android.Support.Design.Widget;
using Com.Nightonke.Boommenu.Piece;
using Com.Nightonke.Boommenu.BoomButtons;

namespace BoomXamarinAndroid.App
{
    [Activity(Theme = "@style/SplashBase")]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            BoomMenuButton bmb = FindViewById<BoomMenuButton>(Resource.Id.bmb);
            bmb.ButtonEnum = ButtonEnum.SimpleCircle;
            bmb.ButtonPlaceEnum = ButtonPlaceEnum.Sc1;            
            bmb.Click += Bmb_Click;

        }

        private void Bmb_Click(object sender, EventArgs e)
        {
            View view = (View)sender;
            Snackbar.Make(view, "The ButtonBoomMenu works", Snackbar.LengthLong)
                .SetAction("Action", (Android.Views.View.IOnClickListener)null).Show();

        }


        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}