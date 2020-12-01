using Autofac;
using Solverse.Persistence.Repositories;

namespace Solverse.Persistence
{
    public class PersistenceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.RegisterType<ExamplesRepository>().AsImplementedInterfaces().SingleInstance();
        }
    }
}