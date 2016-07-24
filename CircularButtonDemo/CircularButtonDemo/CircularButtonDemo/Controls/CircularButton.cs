using Xamarin.Forms;

namespace CircularButtonDemo.Controls
{
    public class CircularButton : Button
    {
        public static readonly BindableProperty CircularBackgroundColorProperty =
            BindableProperty.Create(nameof(CircularBackgroundColor), typeof(Color), typeof(CircularButton), Color.Transparent);

        public Color CircularBackgroundColor
        {
            get { return (Color)GetValue(CircularBackgroundColorProperty); }
            set { SetValue(CircularBackgroundColorProperty, value); }
        }
    }
}