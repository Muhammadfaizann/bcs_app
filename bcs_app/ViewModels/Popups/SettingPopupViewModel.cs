using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Bilateral_Corneal_Symmetry_3D_Analyzer.ViewModels;
public partial class SettingPopupViewModel : ObservableObject
{
    public SettingPopupViewModel(Action hideAction)
    {
        _hideAction = hideAction;
     
        ZoneItems = new List<string>() { "3", "4", "5", "6", "7", "8" };
        SymmetryItems = new List<string>() { "direct", "mirror" };
        DisplayItems = new List<string>() { "AE", "PE", "TH" };

        ImportDirectory = @"C:\bcs\importFolder";
        ExportDirectory = @"C:\bcs\exportFolder";
        DestinationDirectory = @"C:\bcs\destinationFolder";
        DefaultIcon = @"C:\bcs\icon.jpg";

        SelectedDisplayItem = DisplayItems.First();
        SelectedSymmetryItem = SymmetryItems.First();
        SelectedZoneItem = ZoneItems[3];
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
    async void Save()
    {
        //TODO: Save
        _hideAction?.Invoke();
    }

    private readonly Action _hideAction;
}