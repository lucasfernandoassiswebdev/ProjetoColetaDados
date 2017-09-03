using SimpleInjector;
using System.ComponentModel;
using System.Reflection;

namespace Coleta.WebAspNet.Simple_Injector
{
    public static class SimpleInjectorContainer
    {
        public static Container RegisterServices()
        { 
            var container = new Container();

            container.Verify();
            return container;
        }
    }
}