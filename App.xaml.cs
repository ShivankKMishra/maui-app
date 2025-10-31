using Microsoft.Maui.Controls;

namespace HelloMaui;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        // On .NET 8, this is valid and recommended in non‑Shell apps
        MainPage = new MainPage();
    }
}