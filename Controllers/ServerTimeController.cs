using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DevTaskJulianBenda.Models;

namespace DevTaskJulianBenda.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServerTimeController : ControllerBase
    {
        [HttpGet]
        public ServerTime GetServerTime() {
            return new ServerTime { 
                serverTime = DateTime.UtcNow
            };
        }
    }
}