using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace SystemCore.ViewModels;

[INotifyPropertyChanged]
public partial class MainPageViewModel
{
    public MainPageViewModel()
    {
        DisplayItems = new List<string>() { "AE", "PE", "TH" };
    }

    [ObservableProperty]
    List<string> displayItems;

    [ObservableProperty]
    string selectedDisplayItem;

    [RelayCommand]
    async void Exam()
    {
        Console.WriteLine("Exam command clicked!!!");
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
    async void Image()
    {
        Console.WriteLine("Image command clicked!!!");
    }

    [RelayCommand]
    async void Print()
    {
        Console.WriteLine("Print command clicked!!!");
    }
}