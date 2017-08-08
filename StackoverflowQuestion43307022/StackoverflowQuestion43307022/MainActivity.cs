using Android.App;
using Android.Widget;
using Android.OS;

namespace StackoverflowQuestion43307022
{
    [Activity(Label = "StackoverflowQuestion43307022", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            // Setting Searchview text colour
            SearchView sv = FindViewById<SearchView>(Resource.Id.sv);
            int id = sv.Context.Resources.GetIdentifier("android:id/search_src_text", null, null);
            TextView tv = (TextView)sv.FindViewById(id);
            tv.SetTextColor(Android.Graphics.Color.Black);

            // To dismiss search programatically
            Button dismissSearch = FindViewById<Button>(Resource.Id.button1);
            dismissSearch.Click += delegate 
            {
                sv.ClearFocus();
            };
        }
    }
}

