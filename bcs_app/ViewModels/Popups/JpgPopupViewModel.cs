using CommunityToolkit.Maui.Storage;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Diagnostics;

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
        FirstName = App.ApplicationNames.FirstName;
        LastName = App.ApplicationNames.LastName;
        DestinationDirectory = App.ApplicationSettings.DestinationDirectory;
        FileIdentification = DateTime.Now.ToString("ddMMyyyyhhss");
    }
    #endregion
    
    [ObservableProperty]
    string destinationDirectory;

    [ObservableProperty]
    string fileIdentification;

    [ObservableProperty]
    string firstName;
    [ObservableProperty]
    string lastName;

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
            _hideAction?.Invoke(true);
            var screenShot = await Application.Current.MainPage.CaptureAsync();
            var stream = await screenShot.OpenReadAsync();
            using MemoryStream memoryStream = new();
            await stream.CopyToAsync(memoryStream);
            String filepath = String.Format("{0}\\{1}  {2}.jpg", DestinationDirectory, FirstName,LastName);
            File.WriteAllBytes(filepath, memoryStream.ToArray());
            return;
        }
        else
        {
            App.ApplicationNames.FirstName = FileIdentification;
            App.ApplicationNames.LastName = FileIdentification;
            _hideAction?.Invoke(true);
            var screenShot = await Application.Current.MainPage.CaptureAsync();
            var stream = await screenShot.OpenReadAsync();
            using MemoryStream memoryStream = new();
            await stream.CopyToAsync(memoryStream);
            String filepath =  String.Format ("{0}\\{1}.jpg",DestinationDirectory,FileIdentification);
            File.WriteAllBytes(filepath, memoryStream.ToArray());
        }
    } 
    private readonly Action<bool> _hideAction;
    private readonly IFolderPicker folderPicker;

}
