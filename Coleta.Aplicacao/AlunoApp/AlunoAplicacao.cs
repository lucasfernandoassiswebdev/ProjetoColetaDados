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

        public IEnumerable<Aluno> ExibeDados()
        {
            return _appAlunos.ExibeDados();
        }

        public void InsereAluno(Aluno aluno)
        {
            _appAlunos.InsereAluno(aluno);
        }

        public IEnumerable<Aluno> ListaAlunos()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Aluno> ListaAreasTrabalho()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Aluno> ListaAtividadeRemuneradaFamliar()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Aluno> ListaComposisaoFamiliar()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Aluno> ListaComQuemMora()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Aluno> ListaConhecimentoInformatica()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Aluno> ListaEstadosCivis()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Aluno> ListaFaixasEtarias()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Aluno> ListaFilhos()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Aluno> ListaIdiomas()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Aluno> ListaMeiosLocomocao()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Aluno> ListaRendaFamiliar()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Aluno> ListaResidencias()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Aluno> ListaVidaEscolarLocomocao()
        {
            throw new NotImplementedException();
        }
    }
}
