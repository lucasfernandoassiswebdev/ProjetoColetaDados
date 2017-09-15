using Coleta.Dominio.Entidades;
using System.Collections.Generic;

namespace Coleta.Aplicacao.AlunoApp
{
    public interface IAlunoAplicacao
    {
        void InsereAluno(Aluno aluno);
        IEnumerable<Aluno> ExibeDados();
        void ExcluiAlunoIgual(Aluno aluno);
        int VerificaAlunoIgual(Aluno aluno);
        void ExcluiTodos();
    }
}
