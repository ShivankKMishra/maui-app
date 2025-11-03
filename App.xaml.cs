using Microsoft.Maui.Controls;

namespace HelloMaui;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        try
        {
            MainPage = new MainPage(); // ok on .NET 8
        }
        catch (Exception ex)
        {
            var errorPage = new ContentPage
            {
                Content = new Label
                {
                    Text = $"Error creating MainPage: {ex}",
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.Center
                }
            };
            MainPage = errorPage;
        }
    }
}
