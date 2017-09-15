using System;
using System.Collections.Generic;
using Coleta.Dominio.Entidades;
using Coleta.Dominio.Interfaces;

namespace Coleta.Aplicacao.AlunoApp
{
    public class AlunoAplicacao : IAlunoAplicacao
    {
        private readonly IAlunoRepositorio _appAlunos;

        public AlunoAplicacao(IAlunoRepositorio alunos)
        {
            _appAlunos = alunos;
        }

        public void ExcluiAlunoIgual(Aluno aluno)
        {
            _appAlunos.ExcluiAlunoIgual(aluno);
        }

        public void ExcluiTodos()
        {
            _appAlunos.ExcluiTodos();
        }

        public IEnumerable<Aluno> ExibeDados()
        {
            return _appAlunos.ExibeDados();
        }

        public void InsereAluno(Aluno aluno)
        {
            _appAlunos.InsereAluno(aluno);
        }

        public int VerificaAlunoIgual(Aluno aluno)
        {
            return _appAlunos.VerificaAlunoIgual(aluno);
        }
    }
}
