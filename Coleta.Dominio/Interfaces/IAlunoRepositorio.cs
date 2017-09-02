using Coleta.Dominio.Entidades;
using System.Collections.Generic;

namespace Coleta.Dominio.Interfaces
{
    public interface IAlunoRepositorio
    {
        IEnumerable<Aluno> ListaAlunos();
        IEnumerable<Aluno> ListaFaixasEtarias();
        IEnumerable<Aluno> ListaEstadosCivis();
        IEnumerable<Aluno> ListaFilhos();
        IEnumerable<Aluno> ListaResidencias();
        IEnumerable<Aluno> ListaMeiosLocomocao();
        IEnumerable<Aluno> ListaComQuemMora();
        IEnumerable<Aluno> ListaComposisaoFamiliar();
        IEnumerable<Aluno> ListaAtividadeRemuneradaFamliar();
        IEnumerable<Aluno> ListaRendaFamiliar();
        IEnumerable<Aluno> ListaAreasTrabalho();
        IEnumerable<Aluno> ListaVidaEscolarLocomocao();
        IEnumerable<Aluno> ListaConhecimentoInformatica();
        IEnumerable<Aluno> ListaIdiomas();
        IEnumerable<Aluno> ListaDeficiencias();
    }
}
