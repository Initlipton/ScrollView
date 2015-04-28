using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Support.V4.View;
using Android.Views;
using Android.Widget;
using Android.OS;
using Java.Lang;

namespace ScrollView
{
    [Activity(Label = "ScrollView", MainLauncher = true, Icon = "@drawable/icon")]
    public class PagerActivity : Activity
    {
        /// <summary>
        /// The _pager
        /// </summary>
        private ViewPager _pager;


        /// <summary>
        /// The _multiScreen adapter
        /// </summary>
        private MultipleScreen _multiScreen;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            _pager = FindViewById<ViewPager>(Resource.Id.tutorialPager);
            _multiScreen = new MultipleScreen();
            _pager.Adapter = _multiScreen;
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            ActionBar.SetDisplayShowHomeEnabled(true);
            ActionBar.SetDisplayHomeAsUpEnabled(true);
            ActionBar.SetHomeButtonEnabled(true);

            return base.OnCreateOptionsMenu(menu);
        }

        /// <summary>
        /// On Menu Item Click
        /// </summary>
        /// <param name="featureId">The feature Id</param>
        /// <param name="item">The item selected</param>
        /// <returns>boolean</returns>
        public override bool OnMenuItemSelected(int featureId, IMenuItem item)
        {
            const int home = 16908332;
            switch (item.ItemId)
            {
                case (home):
                    { 
                        //Will kill app
                        Finish();
                        break;
                    }
            }
            return base.OnMenuItemSelected(featureId, item);
        }


    }
}

