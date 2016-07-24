using System;
using CircularButtonDemo.Controls;
using CircularButtonDemo.iOS.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CircularButton), typeof(CircularButtonRenderer))]
namespace CircularButtonDemo.iOS.Renderers
{
    public class CircularButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            CircularButton formsRoundedButton = e.NewElement as CircularButton;
            if (formsRoundedButton != null)
            {
                // To uniform behavior among platforms
                formsRoundedButton.BackgroundColor = formsRoundedButton.CircularBackgroundColor;
                Control.Layer.CornerRadius = (nfloat)(formsRoundedButton.WidthRequest / 2);
            }
        }
    }
}