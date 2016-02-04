using System;
using Android.App;
using Android.OS;
using Android.Widget;
using Android.Content;
using Android.Preferences;

namespace whist
{
	[Activity (Label = "New Player", MainLauncher=true, Icon = "@mipmap/icon")]
	public class NewPlayerActivity: Activity
	{
		public static String Prefs_Name = "MyPrefsFile";

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.NewPlayer);

			ISharedPreferences prefs = PreferenceManager.GetDefaultSharedPreferences(this); 
			ISharedPreferencesEditor editor = prefs.Edit();

			var gridview = FindViewById<GridView> (Resource.Id.gridview);
			gridview.Adapter = new ImageAdapter (this);

			gridview.ItemClick += delegate (object sender, AdapterView.ItemClickEventArgs args) {
				//Toast.MakeText (this, args.Position.ToString (), ToastLength.Short).Show ();

				editor.PutLong("imageId", args.Position);					
				editor.Apply();
			};

			Button button = FindViewById<Button> (Resource.Id.btnNext);
						
			button.Click += delegate {
				
			};
		}
	}
}

