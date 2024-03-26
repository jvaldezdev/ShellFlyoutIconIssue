using ShellFlyoutIconIssue.Helpers;

namespace ShellFlyoutIconIssue;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        if (Shell.Current.FlyoutIcon == Icons.ModalFlyout)
        {
            Shell.Current.FlyoutIcon = null;
        }
    }

    private async void OnCounterClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//ExamplePage", true);
    }
}