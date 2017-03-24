
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
	[Activity(Label = "Right")]
	public class Right : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			SetContentView(Resource.Layout.Right);
			base.OnCreate(savedInstanceState);

			var data = new[] { 10f, 20f, 30f, 40f, 50f, 60f };
			var chart = new BarChartView(this)
			{
				ItemsSource = Array.ConvertAll(data, v => new BarModel { Value = v })
			};

			AddContentView(chart, new ViewGroup.LayoutParams(1000, 1000));

		}
	}
}
