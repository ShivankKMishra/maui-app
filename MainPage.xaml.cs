using Microsoft.Maui.Controls;

namespace HelloMaui;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        try
        {
            InitializeComponent();
        }
        catch (Exception ex)
        {
            Content = new Label
            {
                Text = $"Error initializing MainPage: {ex}",
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center
            };
        }
    }
}