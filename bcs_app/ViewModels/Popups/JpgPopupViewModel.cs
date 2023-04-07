using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Bilateral_Corneal_Symmetry_3D_Analyzer.ViewModels;
public partial class JpgPopupViewModel : ObservableObject
{
    public JpgPopupViewModel(Action hideAction)
    {
        _hideAction = hideAction;

        DestinationDirectory = @"C:\bcs\outputFolder";
    }

    [ObservableProperty]
    string destinationDirectory;

    [ObservableProperty]
    string fileIdentification;

    [RelayCommand]
    void Cancel() => _hideAction?.Invoke();

    [RelayCommand]
    async void Save()
    {
        //TODO: Save
        _hideAction?.Invoke();
    }

    private readonly Action _hideAction;
}
