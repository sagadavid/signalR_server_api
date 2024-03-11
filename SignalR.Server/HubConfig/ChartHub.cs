using Microsoft.AspNetCore.SignalR;
namespace SignalR.Server.Models

namespace SignalR.Server.HubConfig
{
    public class ChartHub : Hub
    {
        //when hubcontext is oneway, but not a two-way trip, then there is no need for any mehtod.
        //hub, becomes two way communicable.. recieves from client and broadcasts to clients
        public async Task BroadcastChartData(List<ChartModel>data)=>
            await Clients.All.SendAsync("pustChartData", data);
       
    }
}
