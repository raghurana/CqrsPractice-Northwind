using Microsoft.AspNetCore.Mvc;

namespace CqrsPractice.WebApi.Controllers.HealthCheck
{
    [Route(ApiRoutes.HealthCheckV1)]
    public class PingController : BaseController
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Pong";
        }
    }
}
