using CommunityToolkit.Maui.Storage;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Bilateral_Corneal_Symmetry_3D_Analyzer.ViewModels;
public partial class JpgPopupViewModel : ObservableObject
{
    public JpgPopupViewModel(Action hideAction, IFolderPicker folderPicker)
    {
        _hideAction = hideAction;

        DestinationDirectory = @"C:\bcs\outputFolder";
        this.folderPicker = folderPicker;
    }

    [ObservableProperty]
    string destinationDirectory;

    [ObservableProperty]
    string fileIdentification;


    [RelayCommand]
    void Cancel() => _hideAction?.Invoke();

    [RelayCommand]
    async Task Browse(CancellationToken cancellationToken)
    {
        var result = await folderPicker.PickAsync(cancellationToken);
        if (!result.IsSuccessful)
            return;

        DestinationDirectory = result.Folder.Path;
    }
    [RelayCommand]
    async void Save()
    {
        //TODO: Save
        _hideAction?.Invoke();
    }

    private readonly Action _hideAction;
    private readonly IFolderPicker folderPicker;
}
