using Autofac;
using Solverse.Domain.DomainServices;
using System.Collections.Generic;

namespace Solverse.Domain
{

    public class DomainModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.RegisterType<ExampleDomainService>().AsSelf();
        }
    }
}
