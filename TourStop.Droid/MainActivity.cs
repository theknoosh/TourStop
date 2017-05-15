using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace TourStop.Android
{
    [Activity(Label = "Tour Stop", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        // int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button1 = FindViewById<Button>(Resource.Id.callButton1);
            Button button2 = FindViewById<Button>(Resource.Id.callButton2);

            TextView resultText = FindViewById<TextView>(Resource.Id.resultText);

			button1.Click += delegate {
                var duration = new Duration();
                double result = duration.CalculateTourDuration(numberOfStops: 5,
                                                        speedRatio: 1.2);
                resultText.Text = String.Format("{0} minutes", result);
            };

			button2.Click += delegate
			{
                CallNumber(button2.Text);
			};
		}

        private void CallNumber(string phoneNumber)
        {
            var callDialog = new AlertDialog.Builder(this);
            callDialog.SetMessage("What say we call " + phoneNumber + "?");

            callDialog.SetPositiveButton("Call", delegate {
                var callIntent = new Intent(Intent.ActionCall);
                callIntent.SetData(global::Android.Net.Uri.Parse("tel:" + phoneNumber));
                StartActivity(callIntent);

            });
            callDialog.SetNeutralButton("Cancel", delegate { });

            callDialog.Show();

		}
    }
}

