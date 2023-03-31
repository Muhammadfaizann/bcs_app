using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;

namespace SystemCore.ViewModels;
[INotifyPropertyChanged]
public partial class MainPageViewModel
{
    public MainPageViewModel()
    {
        DisplayItems = new List<string>() { "AE", "PE", "TH" };
        ImportPopupViewModel= new ImportPopupViewModel(HideImportView);
    }

    #region Methods
    void HideImportView() => CanShowImportPopup = false;
    #endregion

    #region Properties
    [ObservableProperty]
    List<string> displayItems;

    [ObservableProperty]
    string selectedDisplayItem;

    [ObservableProperty]
    bool canShowImportPopup;

    [ObservableProperty]
    ImportPopupViewModel importPopupViewModel;
    #endregion

    #region Commands
    [RelayCommand]
    void Exam() => CanShowImportPopup = true;

    [RelayCommand]
    async void Display()
    {
        Console.WriteLine("Display command clicked!!!");
    }

    [RelayCommand]
    async void Setting()
    {
        Console.WriteLine("Settings command clicked!!!");
    }

    [RelayCommand]
    async void Image()
    {
        Console.WriteLine("Image command clicked!!!");
    }

    [RelayCommand]
    async void Print()
    {
        Console.WriteLine("Print command clicked!!!");
    }
    #endregion
}