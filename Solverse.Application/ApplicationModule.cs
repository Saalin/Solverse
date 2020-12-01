using Autofac;
using Solverse.Application.CommandHandlers;
using Solverse.Application.QueryHandlers;

namespace Solverse.Application
{
    public class ApplicationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.RegisterType<CreateExampleCommandHandler>().AsImplementedInterfaces();
            builder.RegisterType<ExamplesListQueryHandler>().AsImplementedInterfaces();
        }
    }
}
