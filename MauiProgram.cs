using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace HelloMaui;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();

        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                // Add fonts here if needed
            });

        return builder.Build();
    }
}