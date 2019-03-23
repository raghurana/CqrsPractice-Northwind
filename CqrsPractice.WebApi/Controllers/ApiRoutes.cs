namespace CqrsPractice.WebApi.Controllers
{
    public class ApiRoutes
    {
        private const string VersionOneAlias = "api";

        private const string ControllerPath = "/[controller]";

        public const string HealthCheckV1 = VersionOneAlias + "/health" + ControllerPath;
    }
}