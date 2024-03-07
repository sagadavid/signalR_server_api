﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SignalR.Server.HubConfig;
using SignalR.Server.TimerFeatures;
using SignalR.Server.DataStorage;

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

        public IActionResult Get()
        {

            var timerManager = new TimerManager(() =>
            //send data to all listener clients
            _hubContext.Clients.All.SendAsync("pustChartData", DataManager.GetChartData())
            );
            return Ok(new { Message = "data pust av Chart'n er ferdig" });
        }
    }
}
