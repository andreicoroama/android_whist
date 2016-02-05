using System;
using Android.Widget;
using Android.Content;

namespace whist
{
	public class ImageAdapter: BaseAdapter
	{
		Context context;

		#region implemented abstract members of BaseAdapter

		public override Java.Lang.Object GetItem (int position)
		{
			throw null;
		}

		public override long GetItemId (int position)
		{
			return thumbIds [position];
		}

		public override Android.Views.View GetView (int position, Android.Views.View convertView, Android.Views.ViewGroup parent)
		{
			ImageView imageView;

			if (convertView == null) {  // if it's not recycled, initialize some attributes
				imageView = new ImageView (context);
				imageView.LayoutParameters = new GridView.LayoutParams (120, 120);
				imageView.SetScaleType (ImageView.ScaleType.CenterCrop);
				imageView.SetPadding (8, 8, 8, 8);
			} else {
				imageView = (ImageView)convertView;
			}

			imageView.SetImageResource (thumbIds [position]);
			return imageView;
		}

		public override int Count {
			get {
				return thumbIds.Length;
			}
		}

		#endregion

		public ImageAdapter (Context c)
		{
			context = c;
		}

		int[] thumbIds = {
			Resource.Drawable.sample_2, Resource.Drawable.sample_3,
			Resource.Drawable.sample_4, Resource.Drawable.sample_5,
			Resource.Drawable.sample_6, Resource.Drawable.sample_7,
			Resource.Drawable.sample_0, Resource.Drawable.sample_1
		};
	}
}

