using Coleta.Aplicacao.AlunoApp;
using SimpleInjector;
using System.Reflection;

namespace Coleta.Web.Simple_Injector
{
    public class SimpleInjectorContainer
    {
        public static Container RegisterServices()
        {
            var container = new Container();

            //registrando as dependências de alunos
            container.Register<IAlunoAplicacao, AlunoAplicacao>();

            container.Verify();
            return container;
        }
    }
}