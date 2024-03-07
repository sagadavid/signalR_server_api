using SignalR.Server.Models;
namespace SignalR.Server.DataStorage

{
    public class DataManager
    {
        public static List<ChartModel> GetChartData()
        {
            var r = new Random();
            return new List<ChartModel>
            {

            new ChartModel {Data = new List<int> {r.Next(0, 100)}, Label = "Temprature"},
            new ChartModel { Data = new List<int> { r.Next(0, 100) }, Label = "Fugtighet" },
            new ChartModel {Data = new List<int> {r.Next(0, 100)}, Label = "Precipitaion"},
            new ChartModel { Data = new List<int> { r.Next(0, 100) }, Label = "Toxication" }


            };
        }
    }
}
