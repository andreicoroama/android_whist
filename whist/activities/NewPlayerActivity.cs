using System;
using Android.App;
using Android.OS;
using Android.Widget;
using Android.Content;
using Android.Preferences;
using Newtonsoft.Json;

namespace whist
{
	[Activity (Label = "New Player", MainLauncher=true, Icon = "@mipmap/icon")]
	public class NewPlayerActivity: Activity
	{
		public static String Prefs_Name = "MyPrefsFile";
		protected string _name = string.Empty;
		protected string _avatar = string.Empty;

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.NewPlayer);

			var gridview = FindViewById<GridView> (Resource.Id.gridview);
			gridview.Adapter = new ImageAdapter (this);

			gridview.ItemClick += delegate (object sender, AdapterView.ItemClickEventArgs args) {
				//Toast.MakeText (this, args.Position.ToString (), ToastLength.Short).Show ();
				_avatar = args.Id.ToString();
			};

			EditText name = FindViewById<EditText> (Resource.Id.txtName);

			Button button = FindViewById<Button> (Resource.Id.btnNext);
						
			button.Click += delegate {

				_name = name.Text;

				User user = new User();
				user.AddUser(_name, _avatar);
				SaveToPreferences(user);

				var mainActivity = new Intent(this, typeof(MainActivity));
				StartActivity(mainActivity);
			};
		}

		protected void SaveToPreferences(User user)
		{
			ISharedPreferences prefs = PreferenceManager.GetDefaultSharedPreferences(this); 
			ISharedPreferencesEditor editor = prefs.Edit();


			var player = JsonConvert.SerializeObject (user);

			//to write some code for 

			editor.PutString (user.ID.ToString() , player);

			editor.Apply();
		}
	}
}

