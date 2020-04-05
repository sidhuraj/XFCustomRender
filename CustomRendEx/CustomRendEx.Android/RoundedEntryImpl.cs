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
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using CustomRendEx;
using CustomRendEx.Droid;

[assembly:ExportRenderer(typeof(RoundedEntry),typeof(RoundedEntryImpl))]
namespace CustomRendEx.Droid
{
    [Obsolete]
    public class RoundedEntryImpl : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            Control.Background = Android.App.Application.Context.GetDrawable(Resource.Drawable.rounded_entry);

            
        }
    }
}