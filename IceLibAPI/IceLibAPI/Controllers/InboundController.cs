using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IceLibAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class InboundController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> TestInbound()
        {
            await Task.Delay(1);
            return Ok("inbound");
        }
    }
}
