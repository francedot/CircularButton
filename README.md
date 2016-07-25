# CircularButton

A simple custom circular buttom for Xamarin.Forms (UWP, iOS, Android).

*Authors: Francesco Bonacci*

![UWP](/Images/UWP.png)
![iOS](/Images/iOS.png)
![Android](/Images/Android.png)

## Usage Example

```xaml
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage x:Class="CircularButtonDemo.Views.MainPage"
             xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:controls="clr-namespace:CircularButtonDemo.Controls;assembly=CircularButtonDemo">

  <Grid Padding="4, 16">
    <Grid.RowDefinitions>
      <RowDefinition Height="Auto" />
      <RowDefinition Height="*" />
    </Grid.RowDefinitions>

    <Label Style="{DynamicResource TitleStyle}"
           FontSize="28"
           Text="Circular Button"
           VerticalTextAlignment="Center"
           HorizontalTextAlignment="Center" />

    <controls:CircularButton Grid.Row="1"
                             HeightRequest="100"
                             WidthRequest="100"
                             VerticalOptions="Center"
                             TextColor="White"
                             CircularBackgroundColor="Purple"
                             HorizontalOptions="Center"
                             Text="Renderer" />
  </Grid>

</ContentPage>
```
