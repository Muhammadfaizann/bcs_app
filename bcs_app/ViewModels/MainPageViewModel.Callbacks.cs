using CommunityToolkit.Maui.Storage;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Bilateral_Corneal_Symmetry_3D_Analyzer.ViewModels;
public partial class MainPageViewModel : ObservableObject
{
    private void ExamsPopupCallback(List<Examination> list)
    {
        CanShowImportPopup = false;
        if (list == null || !list.Any())
            return;

        //TODO: Process files here, both files path exists in the list variable
    }
    private void DisplayOptionSelectedCallback(string optionSelected)
    {
        //TODO:
    }
}