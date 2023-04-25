using CommunityToolkit.Maui.Storage;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Bilateral_Corneal_Symmetry_3D_Analyzer.ViewModels;
public partial class SettingPopupViewModel : ObservableObject
{
    public SettingPopupViewModel(Action hideAction, IFolderPicker folderPicker)
    {
        _hideAction = hideAction;
        this.folderPicker = folderPicker;

        ZoneItems = new List<string>() { "3", "4", "5", "6", "7", "8" };
        SymmetryItems = new List<string>() { "direct", "mirror" };
        DisplayItems = new List<string>() { "AE", "PE", "TH" };

        ImportDirectory = App.ApplicationSettings.ImportDirectory;
        ExportDirectory = App.ApplicationSettings.ExportDirectory;
        DestinationDirectory = App.ApplicationSettings.DestinationDirectory;
        DefaultIcon = App.ApplicationSettings.DefaultIcon;

        SelectedDisplayItem = App.ApplicationSettings.SelectedDisplayItem;
        SelectedSymmetryItem = App.ApplicationSettings.SelectedSymmetryItem;
        SelectedZoneItem = App.ApplicationSettings.SelectedZoneItem;
    }

    [ObservableProperty]
    string importDirectory;

    [ObservableProperty]
    string exportDirectory;

    [ObservableProperty]
    string destinationDirectory;

    [ObservableProperty]
    string defaultIcon;

    [ObservableProperty]
    List<string> displayItems;

    [ObservableProperty]
    List<string> symmetryItems;

    [ObservableProperty]
    List<string> zoneItems;

    [ObservableProperty]
    string selectedDisplayItem;

    [ObservableProperty]
    string selectedSymmetryItem;

    [ObservableProperty]
    string selectedZoneItem;

    [RelayCommand]
    void Cancel() => _hideAction?.Invoke();

    [RelayCommand]
    void Save()
    {
        App.ApplicationSettings.ImportDirectory = ImportDirectory;
        App.ApplicationSettings.ExportDirectory = ExportDirectory;
        App.ApplicationSettings.DestinationDirectory = DestinationDirectory;
        App.ApplicationSettings.DefaultIcon = DefaultIcon;

        App.ApplicationSettings.SelectedDisplayItem = SelectedDisplayItem;
        App.ApplicationSettings.SelectedSymmetryItem = SelectedSymmetryItem;
        App.ApplicationSettings.SelectedZoneItem = SelectedZoneItem;
        _hideAction?.Invoke();
    }

    

    [RelayCommand]
    async Task BrowseExportDirectory(CancellationToken cancellationToken)
    {
        var result = await folderPicker.PickAsync(cancellationToken);
        if (!result.IsSuccessful)
            return;

        ExportDirectory = result.Folder.Path;
    }
    [RelayCommand]
    async Task BrowseDestinationDirectory(CancellationToken cancellationToken)
    {
        var result = await folderPicker.PickAsync(cancellationToken);
        if (!result.IsSuccessful)
            return;

        DestinationDirectory = result.Folder.Path;
    }
    [RelayCommand]
    async Task BrowseImportDirectory(CancellationToken cancellationToken)
    {
        var result = await folderPicker.PickAsync(cancellationToken);
        if (!result.IsSuccessful)
            return;

        ImportDirectory = result.Folder.Path;
    }
    [RelayCommand]
    async Task BrowseDefaultIcon(CancellationToken cancellationToken)
    {
        var result = await folderPicker.PickAsync(cancellationToken);
        if (!result.IsSuccessful)
            return;

        DefaultIcon = result.Folder.Path;
    }

    private readonly Action _hideAction;
    private readonly IFolderPicker folderPicker;
}

public class ApplicationSettings
{
    public ApplicationSettings()
    {
        ImportDirectory = @"C:\bcs\importFolder";
        ExportDirectory = @"C:\bcs\exportFolder";
        DestinationDirectory = @"C:\bcs\destinationFolder";
        DefaultIcon = @"C:\bcs\icon.jpg";

        SelectedDisplayItem = "AE";
        SelectedSymmetryItem = "direct";
        SelectedZoneItem = "6";

    }
    public string ImportDirectory { get; set; }
    public string ExportDirectory { get; set; }
    public string DestinationDirectory { get; set; }
    public string DefaultIcon { get; set; }
    public string SelectedDisplayItem { get; set; }
    public string SelectedSymmetryItem { get; set; }
    public string SelectedZoneItem { get; set; }
}