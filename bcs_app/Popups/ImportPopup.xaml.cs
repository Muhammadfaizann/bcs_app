using Bilateral_Corneal_Symmetry_3D_Analyzer.ViewModels;

namespace Bilateral_Corneal_Symmetry_3D_Analyzer.Popups;
public partial class ImportPopup : Grid
{
    public ImportPopup()
    {
        InitializeComponent();
    }

    private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (Equals(_vm, null))
            return;

        var list = e.CurrentSelection?.Select(i => i as Examination)?.ToList();
        _vm.SelectedExaminations = list.Any() == true ?
            new System.Collections.ObjectModel.ObservableCollection<Examination>(list)
            : new System.Collections.ObjectModel.ObservableCollection<Examination>();
    }

    protected override void OnBindingContextChanged()
    {
        _vm = BindingContext as ImportPopupViewModel;
        if (!Equals(_vm, null))
        {
            _vm.Patients = new System.Collections.ObjectModel.ObservableCollection<Patient>();
            _vm.Examinations = new System.Collections.ObjectModel.ObservableCollection<Examination>();
        }

        base.OnBindingContextChanged();
    }

    ImportPopupViewModel _vm;
}