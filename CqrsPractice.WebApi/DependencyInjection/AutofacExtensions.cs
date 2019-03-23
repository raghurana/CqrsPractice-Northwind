using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace CqrsPractice.WebApi.DependencyInjection
{
    public static class AutofacExtensions
    {
        public static AutofacServiceProvider AddAutofacAsDependencyProvider(this IServiceCollection services)
        {
            var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterAssemblyModules(typeof(Startup).Assembly);
            containerBuilder.Populate(services);
            return new AutofacServiceProvider(containerBuilder.Build());
        }
    }
}