namespace Bilateral_Corneal_Symmetry_3D_Analyzer;

using IronPython.Hosting;




public partial class MainPage : ContentPage
{
    public int label_font_size = 10;

	int count = 0;

	public MainPage()
	{
		InitializeComponent();

    }


    //private async void PrintImageCommand(object sender, EventArgs e)
    //{
    //    // Your code to print the image here
    //    await DisplayAlert("Print Image", "Image printed", "OK");
    //}


    //private void OnCounterClicked(object sender, EventArgs e)
    //{
    //    count++;
    //    var py = Python.CreateEngine();
    //    try
    //    {
    //        py.ExecuteFile("Test.py");
            
    //    }
    //    catch (Exception ex)
    //    {
    //        Console.WriteLine(ex.Message.ToString());
    //    }

    //    if (count == 1)
    //        CounterBtn.Text = $"Clicked {count} time {py.Execute("print('hello from python')")}";
    //    else
    //        CounterBtn.Text = $"Clicked {count} times {py.Execute("print('hello from python')")}";

    //    SemanticScreenReader.Announce(CounterBtn.Text);
    //}


}

