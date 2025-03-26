using Popups.Views;
using Prism.AppModel;

namespace Popups.ViewModels;

public class SplashPageViewModel(INavigationService navigationService) : BindableBase, IPageLifecycleAware
{
    public async void OnAppearing()
    {
        await navigationService.CreateBuilder()
            .AddNavigationPage()
            .AddSegment<MainPage>()
            .NavigateAsync(OnNavigationSuccess, OnNavigationError);
    }

    private void OnNavigationError(Exception obj)
    {
        Console.WriteLine(obj.ToString());
    }

    private void OnNavigationSuccess()
    {
        Console.WriteLine("OnNavigationSuccess");
    }

    public void OnDisappearing()
    {
        
    }
}