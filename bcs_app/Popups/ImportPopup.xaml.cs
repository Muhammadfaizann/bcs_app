using SystemCore.ViewModels;

namespace Bilateral_Corneal_Symmetry_3D_Analyzer.Popups;
public partial class ImportPopup : Grid
{
	public ImportPopup()
	{
		InitializeComponent();
	}

    protected override void OnBindingContextChanged()
    {
        _vm = BindingContext as ImportPopupViewModel;
        if (!Equals(_vm, null))
        {
        }

        base.OnBindingContextChanged();
    }

    ImportPopupViewModel _vm;
}