using System.ComponentModel;
using Android.Content;
using Android.Views;
using Report_Asapp.Droid;
using ReportAsapp.View.Custom;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace Report_Asapp.Droid
{
    public class CustomEntryRenderer : EntryRenderer
    {
        public CustomEntryRenderer(Context context) : base(context) { }



        private BorderRenderer _renderer;
        private const GravityFlags DefaultGravity = GravityFlags.CenterVertical;



        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Entry> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement != null || this.Element == null)
                return;
            Control.Gravity = DefaultGravity;
            var entryEx = Element as CustomEntry;
            UpdateBackground(entryEx);
            UpdatePadding(entryEx);
            UpdateTextAlighnment(entryEx);
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            if (Element == null)
                return;
            var customEntry = Element as CustomEntry;
            if (e.PropertyName == CustomEntry.BorderWidthProperty.PropertyName ||
                e.PropertyName == CustomEntry.BorderColorProperty.PropertyName ||
                e.PropertyName == CustomEntry.BorderRadiusProperty.PropertyName ||
                e.PropertyName == CustomEntry.BackgroundColorProperty.PropertyName)
            {
                UpdateBackground(customEntry);
            }
            else if (e.PropertyName == CustomEntry.LeftPaddingProperty.PropertyName ||
                e.PropertyName == CustomEntry.RightPaddingProperty.PropertyName)
            {
                UpdatePadding(customEntry);
            }
            else if (e.PropertyName == Entry.HorizontalTextAlignmentProperty.PropertyName)
            {
                UpdateTextAlighnment(customEntry);
            }
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            if (disposing)
            {
                if (_renderer != null)
                {
                    _renderer.Dispose();
                    _renderer = null;
                }
            }
        }



        private void UpdateBackground(CustomEntry customEntry)
        {
            if (_renderer != null)
            {
                _renderer.Dispose();
                _renderer = null;
            }
            var oldBg = customEntry.BackgroundColor;
            customEntry.BackgroundColor = Xamarin.Forms.Color.Transparent;
            _renderer = new BorderRenderer();
            Control.SetBackground(_renderer.GetBorderBackground(customEntry.BorderColor, oldBg, customEntry.BorderWidth, customEntry.BorderRadius));

        }

        private void UpdatePadding(CustomEntry entryEx)
        {
            Control.SetPadding((int)Forms.Context.ToPixels(entryEx.LeftPadding), 0,
                (int)Forms.Context.ToPixels(entryEx.RightPadding), 0);
        }

        private void UpdateTextAlighnment(CustomEntry entryEx)
        {
            var gravity = DefaultGravity;
            switch (entryEx.HorizontalTextAlignment)
            {
                case Xamarin.Forms.TextAlignment.Start:
                    gravity |= GravityFlags.Start;
                    break;
                case Xamarin.Forms.TextAlignment.Center:
                    gravity |= GravityFlags.CenterHorizontal;
                    break;
                case Xamarin.Forms.TextAlignment.End:
                    gravity |= GravityFlags.End;
                    break;
            }
            Control.Gravity = gravity;
        }

    }
}