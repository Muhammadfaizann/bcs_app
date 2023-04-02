using Bilateral_Corneal_Symmetry_3D_Analyzer.ViewModels;

namespace Bilateral_Corneal_Symmetry_3D_Analyzer.Popups;
public partial class AboutPopup : Grid
{
    public AboutPopup()
    {
        InitializeComponent();
    }
    protected override void OnBindingContextChanged()
    {
        _vm = BindingContext as AboutPopupViewModel;
        if (!Equals(_vm, null))
        {
        }

        base.OnBindingContextChanged();
    }

    AboutPopupViewModel _vm;
}