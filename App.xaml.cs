using Microsoft.Maui.Controls;

namespace HelloMaui;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        MainPage = new MainPage();
    }
}
