using SystemCore.ViewModels;

namespace Bilateral_Corneal_Symmetry_3D_Analyzer;
public partial class MainPage : ContentPage
{
    public int label_font_size = 10;

    public MainPage(MainPageViewModel vm)
    {
        _vm = vm;
        BindingContext = _vm;

        InitializeComponent();
        Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
    }

    private readonly MainPageViewModel _vm;
}