
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using BarChart;

namespace Prototype
{
	[Activity(Label = "Saved")]
	public class Saved : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			SetContentView(Resource.Layout.Left);
			base.OnCreate(savedInstanceState);

			double steps = 10000;
			double km = steps / 1320;
			double gasoline_price_litre = 0.85;
			double litre_per_km = 0.089;
			//double kg_co2_per_gallon = 8.887;
			//391 kg CO2 emisii za kola za mesec
			double CO2_per_km = 0.13;

			var savedText = FindViewById<TextView>(Resource.Id.savedText);
			var CO2Text = FindViewById<TextView>(Resource.Id.CO2Text);
			savedText.Text = Math.Round(km * litre_per_km * gasoline_price_litre, 2) + " $ Saved";
			CO2Text.Text = Math.Round(km * CO2_per_km, 2) + "KG CO2 Footprint";

			//bar chart
			var data = new[] { 390f, 380f, 375f, 370f, 350f };
			var chart = new BarChartView(this)
			{
				ItemsSource = Array.ConvertAll(data, v => new BarModel { Value = v })
			};

			AddContentView(chart, new ViewGroup.LayoutParams(
				ViewGroup.LayoutParams.MatchParent,
				ViewGroup.LayoutParams.MatchParent));

		}
	}
}
