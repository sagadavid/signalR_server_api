using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SignalR.Server.HubConfig;

namespace SignalR.Server.Kontroller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChartController : ControllerBase
    {
        private readonly IHubContext<ChartHub> _hubContext;

        public ChartController(IHubContext<ChartHub> hubContext)
        {
            _hubContext = hubContext;
                
        }
    }
}
