using System.Windows.Input;

namespace Popups.ViewModels;

public class TestPopupPageViewModel : IDialogAware
{
    public bool CanCloseDialog()
    {
        return true;
    }

    public void OnDialogClosed()
    {
        
    }

    public void OnDialogOpened(IDialogParameters parameters)
    {
        
    }

    #region ClosePopupCommand

    public ICommand ClosePopupCommand => new DelegateCommand<object>(ExecuteClosePopup);

    protected virtual void ExecuteClosePopup(object obj)
    {
        RequestClose.Invoke();
    }

    #endregion
    
    public DialogCloseListener RequestClose { get; }
}