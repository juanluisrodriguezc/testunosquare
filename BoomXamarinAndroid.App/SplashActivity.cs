using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace BoomXamarinAndroid.App
{
    [Activity(Theme = "@style/SplashTheme", MainLauncher = true, NoHistory = true)]
    public class SplashActivity : AppCompatActivity
    {
        public override void OnCreate(Bundle savedInstanceState, PersistableBundle bundle)
        {
            base.OnCreate(savedInstanceState, bundle);
        }

        public override void OnBackPressed()
        {        
        }

        protected override void OnResume()
        {
            base.OnResume();
            Task task = new Task(() => { StartMainActivity(); });
            task.Start();
        }

        async void StartMainActivity()
        {
            await Task.Run(() =>
            {
                Task.Delay(6000);
                StartActivity(new Intent(Application.Context, typeof(MainActivity)));
            });
        }
    }
}