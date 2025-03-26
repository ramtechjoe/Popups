using Popups.Views;
using Prism.Plugin.Popups;

namespace Popups;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UsePrism(prism =>
                prism.ConfigureMopupDialogs()
                    .UsePrismEssentials()
                    .RegisterTypes(PrismStartup.RegisterTypes)
                    .OnInitialized(PrismStartup.OnInitialized)
                    .CreateWindow(navigationService => navigationService.CreateBuilder()
                        .AddSegment<SplashPage>()
                        .NavigateAsync(HandleNavigationError))
                    
            )
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        return builder.Build();
    }
    
    private static void HandleNavigationError(Exception ex)
    {
        Console.WriteLine(ex);
    }
}