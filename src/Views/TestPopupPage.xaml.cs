using Prism.Plugin.Popups.Xaml;

namespace Popups.Views;

public partial class TestPopupPage : ContentView
{
    public TestPopupPage()
    {
        InitializeComponent();
        //Compile error
        PopupDialogLayout.SetIsAnimationEnabled(this, true);
    }
}