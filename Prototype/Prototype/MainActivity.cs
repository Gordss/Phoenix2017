using Android.App;
using Android.Widget;
using Android.OS;
using System;
using BarChart;
using Android.Views;

namespace Prototype
{
	[Activity(Label = "Prototype", MainLauncher = true)]
	public class MainActivity : Activity
	{


		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.Right);

	
			var data = new[] { 10f, 20f, 30f, 40f, 50f, 60f };
			var chart = new BarChartView(this)
			{
				ItemsSource = Array.ConvertAll(data, v => new BarModel { Value = v })
			};

			AddContentView(chart, new ViewGroup.LayoutParams(1000,1000));


		}
	}
}

