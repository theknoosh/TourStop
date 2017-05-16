using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using TourLib;

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

            var stops = TourSource.GetTourStops(6);
            var table = FindViewById<TableLayout>(Resource.Id.tableLayout1);
            foreach(var currentStop in stops)
            {
				var tableRow = new TableRow(this);

				table.AddView(tableRow);

				var textView = new TextView(this);
				textView.Text = currentStop.Name;

				textView.Gravity = GravityFlags.Left;
				tableRow.AddView(textView);



				var mapButton = new Button(this);
				mapButton.Text = "Map";

				// map button click handler goes here...

				mapButton.Gravity = GravityFlags.Right;

				tableRow.AddView(mapButton);

				var button = new Button(this);
				button.Text = currentStop.Phone;

				button.Gravity = GravityFlags.Right;

				// call button click handler goes here...


				tableRow.AddView(button);

			}

            Button calcButton = FindViewById<Button>(Resource.Id.calculateDuration);

            TextView resultText = FindViewById<TextView>(Resource.Id.resultText);

            calcButton.Click += delegate {
                var duration = new Duration();
                double result = duration.CalculateTourDuration(numberOfStops: stops.Count,
                                                        speedRatio: 1.2);
                resultText.Text = String.Format("{0} minutes", result);
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

