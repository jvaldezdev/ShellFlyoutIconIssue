using ShellFlyoutIconIssue.Helpers;

namespace ShellFlyoutIconIssue;

public partial class ExamplePage : ContentPage
{

    public ExamplePage()
    {
        InitializeComponent();
        BindingContext = new ExampleViewModel();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        if (Shell.Current.FlyoutIcon == null)
        {
            Shell.Current.FlyoutIcon = Icons.ModalFlyout;
        }
    }
}