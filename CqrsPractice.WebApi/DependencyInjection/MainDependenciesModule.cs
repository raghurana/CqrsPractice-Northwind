using Autofac;

namespace CqrsPractice.WebApi.DependencyInjection
{
    public class MainDependenciesModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //builder.RegisterType<CharacterRepository>().As<ICharacterRepository>();
        }
    }
}