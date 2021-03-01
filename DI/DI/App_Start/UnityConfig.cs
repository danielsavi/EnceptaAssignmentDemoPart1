using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using DAL;
using Services;

namespace DI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            container.RegisterType<IShoeRepository, ShoeRepository>();
            container.RegisterType<IShoeService, ShoeService>();
        }
    }
}