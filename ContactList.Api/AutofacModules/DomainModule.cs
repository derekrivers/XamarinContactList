using Autofac;
using ContactList.Domain;
using ContactList.Persistence;

namespace ContactList.Api.AutofacModules
{
    public class DomainModule : Module
    {

        // Add Dependencies

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MyDbUnitOfWork>().As<IUnitOfWork>().InstancePerRequest();

            base.Load(builder);
        }


    }
}