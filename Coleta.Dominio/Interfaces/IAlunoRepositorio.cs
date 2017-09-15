using Coleta.Dominio.Entidades;
using System.Collections.Generic;

namespace Coleta.Dominio.Interfaces
{
    public interface IAlunoRepositorio
    {
        void InsereAluno(Aluno aluno);
        IEnumerable<Aluno> ExibeDados();
        void ExcluiAlunoIgual(Aluno aluno);
        int VerificaAlunoIgual(Aluno aluno);
        void ExcluiTodos();
    }
}
