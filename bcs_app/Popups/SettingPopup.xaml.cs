using Bilateral_Corneal_Symmetry_3D_Analyzer.ViewModels;

namespace Bilateral_Corneal_Symmetry_3D_Analyzer.Popups;
public partial class SettingPopup : Grid
{
    public SettingPopup()
    {
        InitializeComponent();
    }
    protected override void OnBindingContextChanged()
    {
        _vm = BindingContext as SettingPopupViewModel;
        if (!Equals(_vm, null))
        {
        }

        base.OnBindingContextChanged();
    }

    SettingPopupViewModel _vm;
}