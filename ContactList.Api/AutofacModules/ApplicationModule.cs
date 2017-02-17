using Autofac;
using ContactList.Application;

namespace ContactList.Api.AutofacModules
{
    public class ApplicationModule : Module
    {

        // Add Dependencies

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ContactService>().As<IContactService>().InstancePerRequest();

            base.Load(builder);
        }
   

    }
}