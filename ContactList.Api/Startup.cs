using Microsoft.Owin;
using Owin;
using System.Web.Http;
using ContactList.Api.App_Start;

[assembly: OwinStartup(typeof(ContactList.Api.Startup))]

namespace ContactList.Api
{


    public class Startup
    {

        internal static HttpConfiguration HttpConfiguration { get; set; }

        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration = new HttpConfiguration();

            var container = AutofacConfig.Configure(HttpConfiguration);

            WebApiConfig.Register(HttpConfiguration);

            app.UseAutofacMiddleware(container);

            app.UseAutofacWebApi(HttpConfiguration);

            app.UseWebApi(HttpConfiguration);

        }
    }
}
