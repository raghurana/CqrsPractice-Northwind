using Microsoft.AspNetCore.Mvc;

namespace CqrsPractice.WebApi.Controllers.HealthCheck
{
    [ApiController]
    [Route(ApiRoutes.HealthCheckV1)]
    public class PingController 
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Pong";
        }
    }
}
