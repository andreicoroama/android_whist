using Android.App;
using Android.Widget;
using Android.OS;

namespace whist
{
	[Activity (Label = "whist", Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
//			Button button = FindViewById<Button> (Resource.Id.btnNext);
//			
//			button.Click += delegate {
//				button.Text = string.Format ("{0} clicks!", count++);
//			};

//			var gridview = FindViewById<GridView> (Resource.Id.gridview);
//			gridview.Adapter = new ImageAdapter (this);
//
//			gridview.ItemClick += delegate (object sender, AdapterView.ItemClickEventArgs args) {
//				Toast.MakeText (this, args.Position.ToString (), ToastLength.Short).Show ();
//			};
		}
	}
}


