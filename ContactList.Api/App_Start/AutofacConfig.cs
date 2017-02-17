using Autofac;
using Autofac.Integration.WebApi;
using ContactList.Api.AutofacModules;
using System.Web.Http;

namespace ContactList.Api.App_Start
{
    public class AutofacConfig
    {
        public static IContainer Configure(HttpConfiguration config)
        {
            var builder = new ContainerBuilder();

            builder.RegisterApiControllers(typeof(Startup).Assembly);

            // OPTIONAL: Register the Autofac filter provider.
            builder.RegisterWebApiFilterProvider(config);

            // Register Autfac Modules. Normall I use Modules. One per Project. In this Instance.
            // I will require to Register Modules for both the Domain Repositories and Application Services.

            builder.RegisterModule<ApplicationModule>();
            builder.RegisterModule<PersistenceModule>();
            builder.RegisterModule<DomainModule>();

            // Set the dependency resolver to be Autofac.
            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);

            return container;

        }
    }
}