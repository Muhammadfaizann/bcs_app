using System.Collections.ObjectModel;

using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;

namespace SystemCore.ViewModels;

[INotifyPropertyChanged]
public partial class ImportPopupViewModel
{
    public ImportPopupViewModel(Action hideAction)
    {
        _hideAction = hideAction;

        Patients = new ObservableCollection<Patient>()
        {
            new Patient { Name = "Sample1", Condition = "Normal1", Date = DateTime.Now, Code = "1001042" },
            new Patient { Name = "Sample2", Condition = "Normal2", Date = DateTime.Now, Code = "1002050" },
            new Patient { Name = "Sample3", Condition = "KCN 1", Date = DateTime.Now, Code = "1007012" },
            new Patient { Name = "Sample4", Condition = "Direct 1", Date = DateTime.Now, Code = "1008061" },
        };
        Examinations = new ObservableCollection<Examination>()
        {
            new Examination { Date = DateTime.Now, Time = DateTime.Now, Title = "Right" },
            new Examination { Date = DateTime.Now, Time = DateTime.Now, Title = "Left" },

            new Examination { Date = DateTime.Now, Time = DateTime.Now, Title = "Right" },
            new Examination { Date = DateTime.Now, Time = DateTime.Now, Title = "Left" },
        };
    }

    #region Properties
    [ObservableProperty]
    ObservableCollection<Patient> patients;

    [ObservableProperty]
    ObservableCollection<Examination> examinations;

    [ObservableProperty]
    Patient selectedPatient;

    [ObservableProperty]
    Examination selectedExamination;
    #endregion

    #region Commands
    [RelayCommand]
    void Cancel() => _hideAction?.Invoke();

    [RelayCommand]
    async void Import()
    {
        Console.WriteLine("Import command clicked!!!");

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
public class Examination
{
    public string Code { get; set; }
    public string Title { get; set; }
    public DateTime Date { get; set; }
    public DateTime Time { get; set; }
}