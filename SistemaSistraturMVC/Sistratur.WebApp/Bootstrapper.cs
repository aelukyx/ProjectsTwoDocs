using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc4;

using Sistratur.Interfaces.Servicios;
using Sistratur.Servicios.Servicios;

namespace Sistratur.WebApp
{
  public static class Bootstrapper
  {
    public static IUnityContainer Initialise()
    {
      var container = BuildUnityContainer();

      DependencyResolver.SetResolver(new UnityDependencyResolver(container));

      return container;
    }

    private static IUnityContainer BuildUnityContainer()
    {
      var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IClienteService, ClienteService>();
            container.RegisterType<IProveedorService, ProveedorService>();
            container.RegisterType<IVehiculoService, VehiculoService>();
            container.RegisterType<IAlquilerService, AlquilerService>();

            RegisterTypes(container);

      return container;
    }

    public static void RegisterTypes(IUnityContainer container)
    {
    
    }
  }
}