using Newtonsoft.Json;

namespace Bilateral_Corneal_Symmetry_3D_Analyzer.Json
{
    public class Exam1
    {
        [JsonConstructor]
        public Exam1(
            [JsonProperty("Astig")] double astig,
            [JsonProperty("Axis")] double axis,
            [JsonProperty("Data of birth")] string dataOfBirth,
            [JsonProperty("Exam date")] string examDate,
            [JsonProperty("Eye")] string eye,
            [JsonProperty("First Name")] string firstName,
            [JsonProperty("ID")] string id,
            [JsonProperty("KKS")] string kKS,
            [JsonProperty("Last Name")] string lastName,
            [JsonProperty("Max dia")] double maxDia,
            [JsonProperty("Pachy apex")] double pachyApex,
            [JsonProperty("Pachy min")] double pachyMin,
            [JsonProperty("Pachy min X")] double pachyMinX,
            [JsonProperty("Pachy min Y")] double pachyMinY,
            [JsonProperty("QS status")] string qSStatus,
            [JsonProperty("Rh")] double rh,
            [JsonProperty("Rv")] double rv,
            [JsonProperty("Time")] string time
        )
        {
            this.Astig = astig;
            this.Axis = axis;
            this.DataOfBirth = dataOfBirth;
            this.ExamDate = examDate;
            this.Eye = eye;
            this.FirstName = firstName;
            this.ID = id;
            this.KKS = kKS;
            this.LastName = lastName;
            this.MaxDia = maxDia;
            this.PachyApex = pachyApex;
            this.PachyMin = pachyMin;
            this.PachyMinX = pachyMinX;
            this.PachyMinY = pachyMinY;
            this.QSStatus = qSStatus;
            this.Rh = rh;
            this.Rv = rv;
            this.Time = time;
        }

        [JsonProperty("Astig")]
        public double Astig { get; }

        [JsonProperty("Axis")]
        public double Axis { get; }

        [JsonProperty("Data of birth")]
        public string DataOfBirth { get; }

        [JsonProperty("Exam date")]
        public string ExamDate { get; }

        [JsonProperty("Eye")]
        public string Eye { get; }

        [JsonProperty("First Name")]
        public string FirstName { get; }

        [JsonProperty("ID")]
        public string ID { get; }

        [JsonProperty("KKS")]
        public string KKS { get; }

        [JsonProperty("Last Name")]
        public string LastName { get; }

        [JsonProperty("Max dia")]
        public double MaxDia { get; }

        [JsonProperty("Pachy apex")]
        public double PachyApex { get; }

        [JsonProperty("Pachy min")]
        public double PachyMin { get; }

        [JsonProperty("Pachy min X")]
        public double PachyMinX { get; }

        [JsonProperty("Pachy min Y")]
        public double PachyMinY { get; }

        [JsonProperty("QS status")]
        public string QSStatus { get; }

        [JsonProperty("Rh")]
        public double Rh { get; }

        [JsonProperty("Rv")]
        public double Rv { get; }

        [JsonProperty("Time")]
        public string Time { get; }
    }

    public class Exam2
    {
        [JsonConstructor]
        public Exam2(
            [JsonProperty("Astig")] double astig,
            [JsonProperty("Axis")] double axis,
            [JsonProperty("Data of birth")] string dataOfBirth,
            [JsonProperty("Exam date")] string examDate,
            [JsonProperty("Eye")] string eye,
            [JsonProperty("First Name")] string firstName,
            [JsonProperty("ID")] string id,
            [JsonProperty("KKS")] string kKS,
            [JsonProperty("Last Name")] string lastName,
            [JsonProperty("Max dia")] double maxDia,
            [JsonProperty("Pachy apex")] double pachyApex,
            [JsonProperty("Pachy min")] double pachyMin,
            [JsonProperty("Pachy min X")] double pachyMinX,
            [JsonProperty("Pachy min Y")] double pachyMinY,
            [JsonProperty("QS status")] string qSStatus,
            [JsonProperty("Rh")] double rh,
            [JsonProperty("Rv")] double rv,
            [JsonProperty("Time")] string time
        )
        {
            this.Astig = astig;
            this.Axis = axis;
            this.DataOfBirth = dataOfBirth;
            this.ExamDate = examDate;
            this.Eye = eye;
            this.FirstName = firstName;
            this.ID = id;
            this.KKS = kKS;
            this.LastName = lastName;
            this.MaxDia = maxDia;
            this.PachyApex = pachyApex;
            this.PachyMin = pachyMin;
            this.PachyMinX = pachyMinX;
            this.PachyMinY = pachyMinY;
            this.QSStatus = qSStatus;
            this.Rh = rh;
            this.Rv = rv;
            this.Time = time;
        }

        [JsonProperty("Astig")]
        public double Astig { get; }

        [JsonProperty("Axis")]
        public double Axis { get; }

        [JsonProperty("Data of birth")]
        public string DataOfBirth { get; }

        [JsonProperty("Exam date")]
        public string ExamDate { get; }

        [JsonProperty("Eye")]
        public string Eye { get; }

        [JsonProperty("First Name")]
        public string FirstName { get; }

        [JsonProperty("ID")]
        public string ID { get; }

        [JsonProperty("KKS")]
        public string KKS { get; }

        [JsonProperty("Last Name")]
        public string LastName { get; }

        [JsonProperty("Max dia")]
        public double MaxDia { get; }

        [JsonProperty("Pachy apex")]
        public double PachyApex { get; }

        [JsonProperty("Pachy min")]
        public double PachyMin { get; }

        [JsonProperty("Pachy min X")]
        public double PachyMinX { get; }

        [JsonProperty("Pachy min Y")]
        public double PachyMinY { get; }

        [JsonProperty("QS status")]
        public string QSStatus { get; }

        [JsonProperty("Rh")]
        public double Rh { get; }

        [JsonProperty("Rv")]
        public double Rv { get; }

        [JsonProperty("Time")]
        public string Time { get; }
    }

    public class Exam3
    {
        [JsonConstructor]
        public Exam3(
            [JsonProperty("Astig")] double astig,
            [JsonProperty("Axis")] double axis,
            [JsonProperty("Difference matrix")] List<List<int>> differenceMatrix,
            [JsonProperty("Max dia")] double maxDia,
            [JsonProperty("Pachy apex")] double pachyApex,
            [JsonProperty("Pachy min")] double pachyMin,
            [JsonProperty("Pachy min dist")] double pachyMinDist,
            [JsonProperty("Pachy min X")] double pachyMinX,
            [JsonProperty("Pachy min Y")] double pachyMinY,
            [JsonProperty("Rh")] double rh,
            [JsonProperty("Rv")] double rv
        )
        {
            this.Astig = astig;
            this.Axis = axis;
            this.DifferenceMatrix = differenceMatrix;
            this.MaxDia = maxDia;
            this.PachyApex = pachyApex;
            this.PachyMin = pachyMin;
            this.PachyMinDist = pachyMinDist;
            this.PachyMinX = pachyMinX;
            this.PachyMinY = pachyMinY;
            this.Rh = rh;
            this.Rv = rv;
        }

        [JsonProperty("Astig")]
        public double Astig { get; }

        [JsonProperty("Axis")]
        public double Axis { get; }

        [JsonProperty("Difference matrix")]
        public IReadOnlyList<List<int>> DifferenceMatrix { get; }

        [JsonProperty("Max dia")]
        public double MaxDia { get; }

        [JsonProperty("Pachy apex")]
        public double PachyApex { get; }

        [JsonProperty("Pachy min")]
        public double PachyMin { get; }

        [JsonProperty("Pachy min dist")]
        public double PachyMinDist { get; }

        [JsonProperty("Pachy min X")]
        public double PachyMinX { get; }

        [JsonProperty("Pachy min Y")]
        public double PachyMinY { get; }

        [JsonProperty("Rh")]
        public double Rh { get; }

        [JsonProperty("Rv")]
        public double Rv { get; }
    }

    public class Exam4
    {
        [JsonConstructor]
        public Exam4(
            [JsonProperty("Ring Summaries")] RingSummaries ringSummaries,
            [JsonProperty("Zone Summaries")] ZoneSummaries zoneSummaries
        )
        {
            this.RingSummaries = ringSummaries;
            this.ZoneSummaries = zoneSummaries;
        }

        [JsonProperty("Ring Summaries")]
        public RingSummaries RingSummaries { get; }

        [JsonProperty("Zone Summaries")]
        public ZoneSummaries ZoneSummaries { get; }
    }

    public class RingSummaries
    {
        [JsonConstructor]
        public RingSummaries(
            [JsonProperty("2-3_mm_Avg")] double __23MmAvg,
            [JsonProperty("2-3_mm_Max")] double __23MmMax,
            [JsonProperty("2-3_mm_Min")] double __23MmMin,
            [JsonProperty("3-4_mm_Avg")] double __34MmAvg,
            [JsonProperty("3-4_mm_Max")] double __34MmMax,
            [JsonProperty("3-4_mm_Min")] double __34MmMin,
            [JsonProperty("4-5_mm_Avg")] double __45MmAvg,
            [JsonProperty("4-5_mm_Max")] double __45MmMax,
            [JsonProperty("4-5_mm_Min")] double __45MmMin,
            [JsonProperty("5-6_mm_Avg")] double __56MmAvg,
            [JsonProperty("5-6_mm_Max")] double __56MmMax,
            [JsonProperty("5-6_mm_Min")] double __56MmMin,
            [JsonProperty("6-7_mm_Avg")] double __67MmAvg,
            [JsonProperty("6-7_mm_Max")] double __67MmMax,
            [JsonProperty("6-7_mm_Min")] double __67MmMin,
            [JsonProperty("7-8_mm_Avg")] double __78MmAvg,
            [JsonProperty("7-8_mm_Max")] double __78MmMax,
            [JsonProperty("7-8_mm_Min")] double __78MmMin
        )
        {
            this._23MmAvg = __23MmAvg;
            this._23MmMax = __23MmMax;
            this._23MmMin = __23MmMin;
            this._34MmAvg = __34MmAvg;
            this._34MmMax = __34MmMax;
            this._34MmMin = __34MmMin;
            this._45MmAvg = __45MmAvg;
            this._45MmMax = __45MmMax;
            this._45MmMin = __45MmMin;
            this._56MmAvg = __56MmAvg;
            this._56MmMax = __56MmMax;
            this._56MmMin = __56MmMin;
            this._67MmAvg = __67MmAvg;
            this._67MmMax = __67MmMax;
            this._67MmMin = __67MmMin;
            this._78MmAvg = __78MmAvg;
            this._78MmMax = __78MmMax;
            this._78MmMin = __78MmMin;
        }

        [JsonProperty("2-3_mm_Avg")]
        public double _23MmAvg { get; }

        [JsonProperty("2-3_mm_Max")]
        public double _23MmMax { get; }

        [JsonProperty("2-3_mm_Min")]
        public double _23MmMin { get; }

        [JsonProperty("3-4_mm_Avg")]
        public double _34MmAvg { get; }

        [JsonProperty("3-4_mm_Max")]
        public double _34MmMax { get; }

        [JsonProperty("3-4_mm_Min")]
        public double _34MmMin { get; }

        [JsonProperty("4-5_mm_Avg")]
        public double _45MmAvg { get; }

        [JsonProperty("4-5_mm_Max")]
        public double _45MmMax { get; }

        [JsonProperty("4-5_mm_Min")]
        public double _45MmMin { get; }

        [JsonProperty("5-6_mm_Avg")]
        public double _56MmAvg { get; }

        [JsonProperty("5-6_mm_Max")]
        public double _56MmMax { get; }

        [JsonProperty("5-6_mm_Min")]
        public double _56MmMin { get; }

        [JsonProperty("6-7_mm_Avg")]
        public double _67MmAvg { get; }

        [JsonProperty("6-7_mm_Max")]
        public double _67MmMax { get; }

        [JsonProperty("6-7_mm_Min")]
        public double _67MmMin { get; }

        [JsonProperty("7-8_mm_Avg")]
        public double _78MmAvg { get; }

        [JsonProperty("7-8_mm_Max")]
        public double _78MmMax { get; }

        [JsonProperty("7-8_mm_Min")]
        public double _78MmMin { get; }
    }

    public class DataPoint
    {
        [JsonConstructor]
        public DataPoint(
            [JsonProperty("Exam 1")] Exam1 exam1,
            [JsonProperty("Exam 2")] Exam2 exam2,
            [JsonProperty("Exam 3")] Exam3 exam3,
            [JsonProperty("Exam 4")] Exam4 exam4
        )
        {
            this.Exam1 = exam1;
            this.Exam2 = exam2;
            this.Exam3 = exam3;
            this.Exam4 = exam4;
        }

        [JsonProperty("Exam 1")]
        public Exam1 Exam1 { get; }

        [JsonProperty("Exam 2")]
        public Exam2 Exam2 { get; }

        [JsonProperty("Exam 3")]
        public Exam3 Exam3 { get; }

        [JsonProperty("Exam 4")]
        public Exam4 Exam4 { get; }
    }

    public class ZoneSummaries
    {
        [JsonConstructor]
        public ZoneSummaries(
            [JsonProperty("3_mm_zone_Avg")] double __3MmZoneAvg,
            [JsonProperty("3_mm_zone_Max")] double __3MmZoneMax,
            [JsonProperty("3_mm_zone_Min")] double __3MmZoneMin,
            [JsonProperty("6_mm_zone_Avg")] double __6MmZoneAvg,
            [JsonProperty("6_mm_zone_Max")] double __6MmZoneMax,
            [JsonProperty("6_mm_zone_Max_X")] double __6MmZoneMaxX,
            [JsonProperty("6_mm_zone_Max_Y")] double __6MmZoneMaxY,
            [JsonProperty("6_mm_zone_Min")] double __6MmZoneMin,
            [JsonProperty("6_mm_zone_Min_X")] double __6MmZoneMinX,
            [JsonProperty("6_mm_zone_Min_Y")] double __6MmZoneMinY
        )
        {
            this._3MmZoneAvg = __3MmZoneAvg;
            this._3MmZoneMax = __3MmZoneMax;
            this._3MmZoneMin = __3MmZoneMin;
            this._6MmZoneAvg = __6MmZoneAvg;
            this._6MmZoneMax = __6MmZoneMax;
            this._6MmZoneMaxX = __6MmZoneMaxX;
            this._6MmZoneMaxY = __6MmZoneMaxY;
            this._6MmZoneMin = __6MmZoneMin;
            this._6MmZoneMinX = __6MmZoneMinX;
            this._6MmZoneMinY = __6MmZoneMinY;
        }

        [JsonProperty("3_mm_zone_Avg")]
        public double _3MmZoneAvg { get; }

        [JsonProperty("3_mm_zone_Max")]
        public double _3MmZoneMax { get; }

        [JsonProperty("3_mm_zone_Min")]
        public double _3MmZoneMin { get; }

        [JsonProperty("6_mm_zone_Avg")]
        public double _6MmZoneAvg { get; }

        [JsonProperty("6_mm_zone_Max")]
        public double _6MmZoneMax { get; }

        [JsonProperty("6_mm_zone_Max_X")]
        public double _6MmZoneMaxX { get; }

        [JsonProperty("6_mm_zone_Max_Y")]
        public double _6MmZoneMaxY { get; }

        [JsonProperty("6_mm_zone_Min")]
        public double _6MmZoneMin { get; }

        [JsonProperty("6_mm_zone_Min_X")]
        public double _6MmZoneMinX { get; }

        [JsonProperty("6_mm_zone_Min_Y")]
        public double _6MmZoneMinY { get; }
    }


}
