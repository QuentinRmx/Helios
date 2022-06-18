using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Core;
using Helios.Data;
using Helios.Data.Models;
using Helios.Data.Repository;
using CommunityToolkit.Maui.Markup;

namespace Helios;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .UseMauiCommunityToolkitCore()
            .UseMauiCommunityToolkitMarkup()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

        builder.Services.AddMauiBlazorWebView();
#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
#endif


        // Add this code
        string dbPath = FileAccessHelper.GetLocalFilePath("people.db3");
        builder.Services.AddSingleton(s => ActivatorUtilities.CreateInstance<Repository<Todo>>(s, dbPath));

        return builder.Build();
    }
}
