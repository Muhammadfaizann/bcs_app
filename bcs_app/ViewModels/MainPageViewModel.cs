using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Bilateral_Corneal_Symmetry_3D_Analyzer.ViewModels;
public partial class MainPageViewModel : ObservableObject
{
    public MainPageViewModel()
    {
        DisplayItems = new List<string>() { "AE", "PE", "TH" };

        ImportPopupViewModel = new ImportPopupViewModel(() => CanShowImportPopup = false);
        AboutPopupViewModel = new AboutPopupViewModel(() => CanShowAboutPopup = false);

        SettingPopupViewModel = new SettingPopupViewModel(() => CanShowSettingPopup = false);
        JpgPopupViewModel = new JpgPopupViewModel(() => CanShowJpgPopup = false);
    }

    #region Methods
    void HideImportView() => CanShowImportPopup = false;
    void HideAboutView() => CanShowAboutPopup = false;

    void HideJpgView() => CanShowJpgPopup = false;
    void HideSettingView() => CanShowSettingPopup = false;
    #endregion

    #region Properties
    [ObservableProperty]
    List<string> displayItems;

    [ObservableProperty]
    bool canShowImportPopup;

    [ObservableProperty]
    bool canShowAboutPopup;

    [ObservableProperty]
    bool canShowSettingPopup;

    [ObservableProperty]
    bool canShowJpgPopup;

    [ObservableProperty]
    ImportPopupViewModel importPopupViewModel;

    [ObservableProperty]
    SettingPopupViewModel settingPopupViewModel;

    [ObservableProperty]
    JpgPopupViewModel jpgPopupViewModel;

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
    async void Setting() => CanShowSettingPopup = true;

    [RelayCommand]
    void About() => CanShowAboutPopup = true;

    [RelayCommand]
    async void Image() => CanShowJpgPopup = true;

    [RelayCommand]
    async void Print()
    {
        Console.WriteLine("Print command clicked!!!");
    }
    #endregion
}