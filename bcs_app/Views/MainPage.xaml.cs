using Bilateral_Corneal_Symmetry_3D_Analyzer.Json;
using Bilateral_Corneal_Symmetry_3D_Analyzer.ViewModels;
using Newtonsoft.Json;

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
        Loaded +=  OnLoaded;
    }

    private readonly MainPageViewModel _vm;

    #region RightImage code
    private List<Point> _allPoints;
    private IReadOnlyList<List<int>> _differenceMatrix;
    private double _scaleX;
    private double _scaleY;

    private async void OnLoaded(object sender, EventArgs e)
    {
        var size = await ReadJson();
        InitializePointList(size);

        _scaleX = GetScaleFactor(RightImage.Width, size);
        _scaleY = GetScaleFactor(RightImage.Height, size);
    }
    private void InitializePointList(int size)
    {
        _allPoints = new List<Point>();
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                _allPoints.Add(new Point(i, j));
            }
        }
    }


    private double GetScaleFactor(double originalSize, double targetSize)
    {
        return targetSize / originalSize;
    }

    private Point ScalePoint(Point originalPoint, double scaleX, double scaleY)
    {
        return new Point(Math.Floor(originalPoint.X * scaleX), Math.Ceiling((RightImage.Height - 14 - originalPoint.Y) * scaleY));
    }


    private void OnPointerMoved(object sender, PointerEventArgs e)
    {
        var pos = e.GetPosition(RightImage).Value;
        pos = ScalePoint(pos, _scaleX, _scaleY);

        XText.Text = Convert.ToString((int)(pos.X * 0.1));
        YText.Text = Convert.ToString((int)(pos.Y * 0.1));

        var average = 0.0;
        var min = 0.0;
        var max = 0.0;
        double pointValue = 0;
        var surroundingPoints = new List<Point>();

        foreach (Point point in _allPoints)
        {
            var xScaled = point.X * 0.1;
            var yScaled = point.Y * 0.1;

            var distance =
                Math.Sqrt(Math.Pow(xScaled - (pos.X * 0.1), 2) + Math.Pow(yScaled - (pos.Y * 0.1), 2));

            if (distance <= 1)
            {
                surroundingPoints.Add(point);
                average = CalculateMinMaxAndAverage(point, pos.Y, average, ref min, ref max).Average;
            }

            if (point.X == pos.X && point.Y == pos.Y)
            {
                var currentPointResult = CalculateMinMaxAndAverage(point, pos.Y, average, ref min, ref max);
                pointValue = currentPointResult.Value;
            }
        }

        if (surroundingPoints.Any())
        {
            average /= surroundingPoints.Count;
        }

        UpdateTextBoxes(min, max, average, pointValue);
    }

    private void UpdateTextBoxes(double min, double max, double average, double value)
    {
        MaxText.Text = Convert.ToString(max);
        MinText.Text = Convert.ToString(min);
        AverageText.Text = Convert.ToString(Math.Round(average, 2));
        PointText.Text = Convert.ToString(value);
    }

    private (double Average, double Value) CalculateMinMaxAndAverage(Point point, double invertedY, double average, ref double min, ref double max)
    {
        var value = TryGetValue((int)point.X, (int)invertedY);
        if (value != null)
        {
            var resolvedValue = value.GetValueOrDefault();
            average += resolvedValue;

            // Update min_value and max_value
            min = Math.Min(min, resolvedValue);
            max = Math.Max(max, resolvedValue);
        }

        return (average, value.GetValueOrDefault());
    }

    private void OnPointerExited(object sender, PointerEventArgs e)
    {
        XText.Text = string.Empty;
        YText.Text = string.Empty;
        PointText.Text = string.Empty;
        AverageText.Text = string.Empty;
        MaxText.Text = string.Empty;
        MinText.Text = string.Empty;
    }

    private async Task<int> ReadJson()
    {
        var json = await ReadTextFile("Json/data.json");
        var dataPoint = JsonConvert.DeserializeObject<DataPoint>(json);
        _differenceMatrix = dataPoint.Exam3.DifferenceMatrix;
        return _differenceMatrix.Count;
    }

    private double? TryGetValue(int x, int y)
    {
        if (y < _differenceMatrix.Count)
        {
            var value = _differenceMatrix[y];
            if (x < value.Count)
            {
                return value[x];
            }
        }

        return null;
    }

    public async Task<string> ReadTextFile(string filePath)
    {
        await using Stream fileStream = await FileSystem.Current.OpenAppPackageFileAsync(filePath);
        using var reader = new StreamReader(fileStream);

        return await reader.ReadToEndAsync();
    }

    #endregion
}