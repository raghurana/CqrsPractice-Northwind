using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace CqrsPractice.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PingController 
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Pong";
        }
    }
}
