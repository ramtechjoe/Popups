using Popups.Views;

namespace Popups;

public static class PrismStartup
{
    public static void RegisterTypes(IContainerRegistry containerRegistry)
    {
        containerRegistry.RegisterForNavigation<SplashPage>();
        containerRegistry.RegisterForNavigation<MainPage>();
        containerRegistry.RegisterDialog<TestPopupPage>();
    }
    
    public static void OnInitialized(IContainerProvider containerProvider)
    {}
}