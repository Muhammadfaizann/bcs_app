using CommunityToolkit.Mvvm.ComponentModel;
using System.Reflection;

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

    private async void JpgPopupCallback(bool result)
    {
        CanShowJpgPopup = false;
        if (!result)
            return;

        string codeBase = Assembly.GetExecutingAssembly().CodeBase;
        UriBuilder uri = new UriBuilder(codeBase);
        string path = Uri.UnescapeDataString(uri.Path);
        var d = Path.GetDirectoryName(path);

        FileImageSource leftImageSource = (FileImageSource)LeftImage;
        FileImageSource middleImageSource = (FileImageSource)MiddleImage;
        FileImageSource rightImageSource = (FileImageSource)RightImage;

        SaveImage(Path.Combine(d, leftImageSource.File));
        SaveImage(Path.Combine(d, middleImageSource.File));
        SaveImage(Path.Combine(d, rightImageSource.File));
    }
    private void SaveImage(string file)
    {
        try
        {
            using (Stream stream = File.OpenRead(file))
            {
                // store bytes
                byte[] bytes = new byte[stream.Length];
                stream.Read(bytes, 0, bytes.Length);

                //TODO: See if this will work
                FileStream copyFileStream = File.Create(Path.Combine(file));
                {
                    stream.CopyTo(copyFileStream);
                    copyFileStream.Close();
                }
            }
        }
        catch (Exception ex)
        {
        }
    }

    private void PrintScreen()
    {
        try
        {
        }
        catch (Exception ex)
        {
        }
    }
}