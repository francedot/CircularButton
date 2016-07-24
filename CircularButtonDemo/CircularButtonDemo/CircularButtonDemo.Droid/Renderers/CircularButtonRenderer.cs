using Android.Support.V4.Content;
using CircularButtonDemo.Controls;
using CircularButtonDemo.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using ButtonRenderer = Xamarin.Forms.Platform.Android.AppCompat.ButtonRenderer;

[assembly: ExportRenderer(typeof(CircularButton), typeof(CircularButtonRenderer))]
namespace CircularButtonDemo.Droid.Renderers
{
    public class CircularButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);

            CircularButton formsRoundedButton = e.NewElement as CircularButton;
            if (formsRoundedButton != null)
            {
                // To uniform behavior among platforms
                formsRoundedButton.BackgroundColor = formsRoundedButton.CircularBackgroundColor;
                Control.SetBackground(ContextCompat.GetDrawable(Context, Resource.Drawable.circularShape));
                Control.SetAllCaps(false);
            }
        }
    }
}