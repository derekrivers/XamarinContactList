using Autofac;
using ContactList.Domain.Repositories;
using ContactList.Persistence.Repositories;

namespace ContactList.Api.AutofacModules
{
    public class PersistenceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ContactRepository>().As<IContactRepository>().InstancePerRequest();

            base.Load(builder);
        }
    }
}