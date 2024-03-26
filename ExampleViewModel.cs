using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ShellFlyoutIconIssue;

public partial class ExampleViewModel : ObservableObject
{
    [RelayCommand]
    public async Task BackButtonAsync()
    {
        await Shell.Current.GoToAsync("//Home/HomePage", true);
    }
}