using Coleta.Aplicacao.AlunoApp;
using Coleta.Dominio.Interfaces;
using Coleta.Repositorios;
using SimpleInjector;
using System.Reflection;

namespace Coleta.WebAspNet.Simple_Injector
{
    public static class SimpleInjectorContainer
    {
        public static Container RegisterServices()
        { 
            var container = new Container();
            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());

            //registrando as dependências de alunos
            container.Register<IAlunoAplicacao, AlunoAplicacao>();
            container.Register<IAlunoRepositorio, AlunoRepositorioADO>();

            container.Verify();
            return container;
        }
    }
}