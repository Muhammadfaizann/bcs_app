using Bilateral_Corneal_Symmetry_3D_Analyzer.ViewModels;

namespace Bilateral_Corneal_Symmetry_3D_Analyzer.Popups;
public partial class JpgPopup : Grid
{
    public JpgPopup()
    {
        InitializeComponent();
    }
    protected override void OnBindingContextChanged()
    {
        _vm = BindingContext as JpgPopupViewModel;
        if (!Equals(_vm, null))
        {
        }

        base.OnBindingContextChanged();
    }

    JpgPopupViewModel _vm;
}