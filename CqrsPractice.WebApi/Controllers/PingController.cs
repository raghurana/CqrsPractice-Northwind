using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace CqrsPractice.WebApi.Controllers
{
    [ApiController]
    [Route(ApiRoutes.DefaultControllerRoute)]
    public class PingController 
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Pong";
        }
    }
}
