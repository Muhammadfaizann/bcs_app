﻿using CommunityToolkit.Maui.Storage;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.ComponentModel;


namespace Bilateral_Corneal_Symmetry_3D_Analyzer.ViewModels;
public partial class MainPageViewModel : ObservableObject
{
   

    public MainPageViewModel(IFolderPicker folderPicker)
    {
        
        DisplayItems = new List<string>() { "AE", "PE", "TH" };

        ImportPopupViewModel = new ImportPopupViewModel(ExamsPopupCallback, folderPicker);
        AboutPopupViewModel = new AboutPopupViewModel(() => CanShowAboutPopup = false);

        SettingPopupViewModel = new SettingPopupViewModel(() => CanShowSettingPopup = false, folderPicker);
        JpgPopupViewModel = new JpgPopupViewModel(JpgPopupCallback, folderPicker);
        FirstName = App.ApplicationNames.FirstName;
        LeftImage = ImageSource.FromFile("MyImages\\ae_left_img.png");
        MiddleImage = ImageSource.FromFile("MyImages\\ae_left_img.png");
        RightImage = ImageSource.FromFile("MyImages\\ae_img_3.png");
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

    [ObservableProperty]
    ImageSource leftImage;

    [ObservableProperty]
    ImageSource middleImage;

    [ObservableProperty]
    ImageSource rightImage;

    [ObservableProperty]
    string firstName;

    [ObservableProperty]
    string lastName;


    private string _selectedDisplayItem;
    public string SelectedDisplayItem
    {
        get => _selectedDisplayItem;
        set
        {
            _selectedDisplayItem = value;
            OnPropertyChanged();

            DisplayOptionSelectedCallback(value);
        }
    }
    #endregion

    #region Commands
    [RelayCommand]
    void Exam()
    {
        ImportPopupViewModel.init(SettingPopupViewModel.ImportDirectory);
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
    async void Image()
    {
        App.ApplicationNames.FirstName = FirstName;
        App.ApplicationNames.LastName = LastName;
        JpgPopupViewModel.init();
        CanShowJpgPopup = true;

    }

    [RelayCommand]
    async void Print() => PrintScreen();
    #endregion

}

public class ApplicationNames
{
    public ApplicationNames()
    {
        FirstName = "";
        LastName = "";
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
}