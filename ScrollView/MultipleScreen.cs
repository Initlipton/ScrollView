using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.View;
using Android.Views;
using Android.Widget;
using Object = Java.Lang.Object;

namespace ScrollView
{
    public class MultipleScreen : PagerAdapter
    {
        /// <summary>
        /// The resource
        /// </summary>
        private readonly int[] _res =
            {
                Resource.Drawable.Screen1,
                Resource.Drawable.Screen2,
                Resource.Drawable.Screen3,
            };

        public override bool IsViewFromObject(View view, Object obj)
        {
            return view == obj;
        }

        public override int Count
        {
            get { return _res.Length; }
        }

        public override Java.Lang.Object InstantiateItem(ViewGroup container, int position)
        {
            var imageView = new ImageView(Application.Context);
            imageView.SetImageResource(_res[position]);
            imageView.LayoutParameters = new ViewGroup.LayoutParams(ViewGroup.LayoutParams.MatchParent,
            ViewGroup.LayoutParams.MatchParent);

            var layout = new LinearLayout(Application.Context)
            {
                Orientation = Orientation.Horizontal,
                LayoutParameters = new ViewGroup.LayoutParams(ViewGroup.LayoutParams.MatchParent,
                    ViewGroup.LayoutParams.MatchParent)
            };

            layout.AddView(imageView);
            container.AddView(layout);
            return layout;
        }

        public override void DestroyItem(ViewGroup container, int position, Java.Lang.Object obj)
        {
            container.RemoveView((LinearLayout)obj);
        }
    }
}