using CommunityToolkit.Maui.Storage;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Bilateral_Corneal_Symmetry_3D_Analyzer.ViewModels;
public partial class JpgPopupViewModel : ObservableObject
{
    public JpgPopupViewModel(Action<bool> hideAction, IFolderPicker folderPicker)
    {
        _hideAction = hideAction;
        this.folderPicker = folderPicker;
    }

    #region Methods
    internal void init()
    {
        DestinationDirectory = App.ApplicationSettings.DestinationDirectory;
        FileIdentification = DateTime.Now.ToString("ddMMyyyyhhss");
    }
    #endregion

    [ObservableProperty]
    string destinationDirectory;

    [ObservableProperty]
    string fileIdentification;


    [RelayCommand]
    void Cancel() => _hideAction?.Invoke(false);

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
        if (string.IsNullOrWhiteSpace(FileIdentification))
        {
            await Application.Current.MainPage.DisplayAlert("Error", "Identification is missing?", "Ok");
            return;
        }

        _hideAction?.Invoke(true);
    }

    private readonly Action<bool> _hideAction;
    private readonly IFolderPicker folderPicker;
}
