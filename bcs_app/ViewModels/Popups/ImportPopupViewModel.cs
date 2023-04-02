﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using IronPython.Runtime.Operations;
using System.Collections.ObjectModel;

namespace Bilateral_Corneal_Symmetry_3D_Analyzer.ViewModels;

[INotifyPropertyChanged]
public partial class ImportPopupViewModel
{
    public ImportPopupViewModel(Action hideAction)
    {
        _hideAction = hideAction;

        DataFolderPath = @"C:\data";

        Patients = new ObservableCollection<Patient>();
        Examinations = new ObservableCollection<Examination>();
    }

    #region Methods
    internal void init()
    {
        Patients = new System.Collections.ObjectModel.ObservableCollection<Patient>();
        Examinations = new System.Collections.ObjectModel.ObservableCollection<Examination>();
    }
    #endregion

    #region Properties
    [ObservableProperty]
    ObservableCollection<Patient> patients;

    [ObservableProperty]
    ObservableCollection<Examination> examinations;

    private Patient _selectedPatient;
    public Patient SelectedPatient
    {
        get => _selectedPatient;
        set
        {
            _selectedPatient = value;
            OnPropertyChanged();
            Load(_selectedPatient);
        }
    }

    public ObservableCollection<Examination> SelectedExaminations { get; set; }

    [ObservableProperty]
    string dataFolderPath;
    #endregion

    #region Commands
    [RelayCommand]
    void Load()
    {
        var dataFiles = Directory.EnumerateFiles(DataFolderPath);

        var listOfPatients = new List<Patient>();
        foreach (var dataFile in dataFiles)
        {
            var file = Path.GetFileNameWithoutExtension(dataFile);
            var attributes = file.Split('_');

            if (listOfPatients.Any(i => i.Name == attributes[0]))
                continue;

            var item = new Patient { Name = attributes[0], Date = DateTime.Now, Code = attributes[2] };
            listOfPatients.Add(item);
        }

        Patients = new ObservableCollection<Patient>(listOfPatients);
    }
    void Load(Patient selectedPatient)
    {
        var dataFiles = Directory.EnumerateFiles(DataFolderPath).Where(i => i.Contains(selectedPatient.Name));

        var listOfExams = new List<Examination>();
        foreach (var dataFile in dataFiles)
        {
            var file = Path.GetFileNameWithoutExtension(dataFile);

            var dotSplit = file.Split('.');

            var title = dotSplit[0];
            var item = new Examination { Title = title, FilePath = dataFile };
            listOfExams.Add(item);
        }

        Examinations = new ObservableCollection<Examination>(listOfExams);
    }

    [RelayCommand]
    void Cancel() => _hideAction?.Invoke();

    [RelayCommand]
    async void Import()
    {
        if (Equals(SelectedExaminations, null) || (SelectedExaminations?.Any() == false))
        {
            await Application.Current.MainPage.DisplayAlert("Error", "Please select exams!", "Ok");
            return;
        }

        if (SelectedExaminations.Count != 2)
        {
            await Application.Current.MainPage.DisplayAlert("Error", "Please select two exams!", "Ok");
            return;
        }

        var isOdFileSelected = SelectedExaminations.Any(i => i.FilePath.Contains("_OD"));
        var isOsFileSelected = SelectedExaminations.Any(i => i.FilePath.Contains("_OS"));

        var firstFileTitle = SelectedExaminations[0].Title.replace("_OS", "").replace("_OD", "");
        var secondFileTitle = SelectedExaminations[1].Title.replace("_OS", "").replace("_OD", "");
        bool shouldContinueWithoutWarning = (firstFileTitle == secondFileTitle) && isOdFileSelected && isOsFileSelected;

        if (!shouldContinueWithoutWarning)
        {
            bool answer = await Application.Current.MainPage.DisplayAlert("Warning",
                "The selected files are not compatible; click yes if you want to continue?", "Continue", "Cancel");
            if (!answer)
                return;
        }

        //TODO: Pass the selected object back
        _hideAction?.Invoke();
    }
    #endregion

    private readonly Action _hideAction;
}
public class Patient
{
    public string Name { get; set; }
    public string Condition { get; set; }
    public DateTime Date { get; set; }
    public string Code { get; set; }
}
public class Examination : ObservableObject
{
    public string Code { get; set; }
    public string Title { get; set; }
    public DateTime Date { get; set; }
    public DateTime Time { get; set; }
    public string FilePath { get; set; }
}