using System.Windows.Input;
using Popups.Views;

namespace Popups.ViewModels;

public class MainPageViewModel(IDialogService dialogService) : BindableBase
{

    public ICommand OpenDialogCommand => new DelegateCommand(ExecuteOpenDialog);

    private void ExecuteOpenDialog()
    {
        DialogParameters parameters = new DialogParameters
        {
            { KnownDialogParameters.CloseOnBackgroundTapped, true },
        };
        
        dialogService.ShowDialog(nameof(TestPopupPage), result =>
        {
            Console.WriteLine($"Dialog Result {result.Result}");
        });
    }
}