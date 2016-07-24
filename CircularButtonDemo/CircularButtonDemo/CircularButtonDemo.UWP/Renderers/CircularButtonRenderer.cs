using Windows.UI.Xaml.Media;
using CircularButtonDemo.Controls;
using CircularButtonDemo.UWP.Extensions;
using CircularButtonDemo.UWP.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;
using Application = Windows.UI.Xaml.Application;
using Style = Windows.UI.Xaml.Style;

[assembly: ExportRenderer(typeof(CircularButton), typeof(CircularButtonRenderer))]
namespace CircularButtonDemo.UWP.Renderers
{
    public class CircularButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            CircularButton formsRoundedButton = e.NewElement as CircularButton;
            if (formsRoundedButton != null)
            {
                Control.Height = formsRoundedButton.HeightRequest;
                Control.Width = formsRoundedButton.WidthRequest;
                Control.Background = new SolidColorBrush(formsRoundedButton.CircularBackgroundColor.ToUWPColor());
                Control.Style = (Style)Application.Current.Resources["CircularButtonStyle"];
            }
        }
    }
}