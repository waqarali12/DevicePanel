using DevicePanel.DAL.Interfaces;
using DevicePanel.DAL.Services;
using System.Web.Http;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace DevicePanel.App_Start
{
    public static class UnityConfig
    {
        public static void RegisterComponents(HttpConfiguration config)
        {
            var container = new UnityContainer();
            RegisterServices(container);
            
            config.DependencyResolver = new UnityResolver(container);
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            RegisterApiRoute(config);
        }

        private static void RegisterServices(UnityContainer container)
		{
            container.RegisterType<IDataRepository, DataRepository>();
        }

        private static void RegisterApiRoute(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = UrlParameter.Optional }
            );
        }
    }
}