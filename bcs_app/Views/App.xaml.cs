namespace Bilateral_Corneal_Symmetry_3D_Analyzer;

public partial class App : Application
{
    const int WindowWidth = 400;
    const int WindowHeight = 300;
    public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}

    protected override Window CreateWindow(IActivationState activationState)
    {
        var window = base.CreateWindow(activationState);

        const int newWidth = 1320;
        const int newHeight = 740;

        window.Width = newWidth;
        window.Height = newHeight;

        return window;
    }
}
