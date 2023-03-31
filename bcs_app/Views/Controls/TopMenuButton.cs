namespace Bilateral_Corneal_Symmetry_3D_Analyzer.Views.Controls;
public class TopMenuButton : Button
{
    public TopMenuButton() => Clicked += async (object sender, EventArgs e) =>
    {
        AnchorX = 0.48;
        AnchorY = 0.48;

        await this.ScaleTo(0.9, 25, Easing.Linear);
        Opacity = 0.9;

        await Task.Delay(50);
        Opacity = 1;
        await this.ScaleTo(1, 25, Easing.Linear);
    };

    public static readonly BindableProperty ImageColorProperty = BindableProperty.Create(nameof(ImageColor), typeof(Color), typeof(TopMenuButton), Colors.Gray);
    public Color ImageColor { get { return (Color)GetValue(ImageColorProperty); } set { SetValue(ImageColorProperty, value); } }
}