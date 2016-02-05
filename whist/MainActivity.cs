using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using Android.Preferences;

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

			ISharedPreferences prefs = PreferenceManager.GetDefaultSharedPreferences(this); 

			string name = prefs.GetString ("UserName", "");
			string avatar = prefs.GetString ("UserAvatar", "");

			ImageView imgAvatar = FindViewById<ImageView> (Resource.Id.imgAvatar);
			imgAvatar.SetImageResource (int.Parse(avatar));

			TextView txtName = FindViewById<TextView> (Resource.Id.lblName);
			txtName.Text = name;
		}
	}
}


