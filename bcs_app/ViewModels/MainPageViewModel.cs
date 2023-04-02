using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Bilateral_Corneal_Symmetry_3D_Analyzer.ViewModels;
[INotifyPropertyChanged]
public partial class MainPageViewModel
{
    public MainPageViewModel()
    {
        DisplayItems = new List<string>() { "AE", "PE", "TH" };
        ImportPopupViewModel = new ImportPopupViewModel(() => CanShowImportPopup = false);
        AboutPopupViewModel = new AboutPopupViewModel(() => CanShowAboutPopup = false);
    }

    #region Methods
    void HideImportView() => CanShowImportPopup = false;
    void HideAboutView() => CanShowAboutPopup = false;
    #endregion

    #region Properties
    [ObservableProperty]
    List<string> displayItems;

    [ObservableProperty]
    bool canShowImportPopup;

    [ObservableProperty]
    bool canShowAboutPopup;

    [ObservableProperty]
    ImportPopupViewModel importPopupViewModel;

    [ObservableProperty]
    AboutPopupViewModel aboutPopupViewModel;

    private string _selectedDisplayItem;
    public string SelectedDisplayItem
    {
        get => _selectedDisplayItem;
        set
        {
            _selectedDisplayItem = value;
            OnPropertyChanged();

            //Pass selected option to main page, it is part of the requirements otherwise we have the selected option part of this vm anyway
            if (Application.Current.MainPage is AppShell appShell)
            {
                if (appShell.CurrentPage is MainPage mp)
                    mp.DisplaySettingsChanged(value);
            }
        }
    }
    #endregion

    #region Commands
    [RelayCommand]
    void Exam()
    {
        ImportPopupViewModel.init();
        CanShowImportPopup = true;
    }

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
    void About() => CanShowAboutPopup = true;

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