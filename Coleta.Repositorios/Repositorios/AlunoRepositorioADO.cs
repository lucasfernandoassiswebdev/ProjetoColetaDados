using Coleta.Dominio.Entidades;
using Coleta.Dominio.Interfaces;
using Coleta.Repositorios.Extensoes;
using System;
using System.Collections.Generic;

namespace Coleta.Repositorios
{
    public class AlunoRepositorioADO : IAlunoRepositorio
    {
        private Contexto.Contexto contexto;

        public IEnumerable<Aluno> ExibeDados()
        {
            using (contexto = new Contexto.Contexto())
            {
                var cmd = contexto.ExecutaComando("ListaAlunos");
                var listadeAlunos = new List<Aluno>();

                using (var r = cmd.ExecuteReader())
                    while (r.Read())
                        listadeAlunos.Add( new Aluno() {
                            RA = r.ReadAsString("RA"),
                            Nome = r.ReadAsString("Nome"),
                            Email = r.ReadAsString("Email"),
                            Carimbo = r.ReadAsDate("Carimbo"),
                            Nascimento = r.ReadAsString("Nascimento"),
                            Deficiencia = r.ReadAsString("Deficiencia"),
                            EstadoCivil = r.ReadAsString("EstadoCivil"),
                            Filhos = r.ReadAsString("Filhos"),
                            Cidade = r.ReadAsString("Cidade"),
                            Locomocao = r.ReadAsString("Locomocao"),
                            SituacaoDomiciliar = r.ReadAsString("SituacaoDomiciliar"),
                            TempoMoradia = r.ReadAsString("TempoMoradia"),
                            MoraCom = r.ReadAsString("MoraCom"),
                            Trabalha = r.ReadAsString("Trabalha"),
                            MediaRenda = r.ReadAsString("MediaRenda"),
                            PeriodoEstudo = r.ReadAsString("PeriodoEstudo"),
                            PessoasResidem = r.ReadAsString("PessoasResidem"),
                            PessoasTrabalham = r.ReadAsString("PessoasTrabalham"),
                            SomaRendas = r.ReadAsString("SomaRendas"),
                            PeriodoTrabalho = r.ReadAsString("PeriodoTrabalho"),
                            VidaEscolar = r.ReadAsString("VidaEscolar"),
                            ConhecimentoInformatica = r.ReadAsString("ConhecimentoInformatica"),
                            MotivoVestibular = r.ReadAsString("MotivoVestibular"),
                            ConhecimentoLingua = r.ReadAsString("ConhecimentoLingua"),
                            Linguas = r.ReadAsString("Linguas"),
                            Meio = r.ReadAsString("Meio")
                        }
                        );
                return listadeAlunos;
            }
        }

        public void InsereAluno(Aluno aluno)
        {
            using (contexto = new Contexto.Contexto())
            {
                var cmd = contexto.ExecutaComando("InsereAlunos");
                cmd.Parameters.AddWithValue("@RA",aluno.RA);
                cmd.Parameters.AddWithValue("@Nome", aluno.Nome);
                cmd.Parameters.AddWithValue("@Email", aluno.Email);
                cmd.Parameters.AddWithValue("@Carimbo", aluno.Carimbo);
                cmd.Parameters.AddWithValue("@Nascimento", aluno.Nascimento);
                cmd.Parameters.AddWithValue("@Deficiencia", aluno.Deficiencia);
                cmd.Parameters.AddWithValue("@EstadoCivil", aluno.EstadoCivil);
                cmd.Parameters.AddWithValue("@Filhos", aluno.Filhos);
                cmd.Parameters.AddWithValue("@Cidade", aluno.Cidade);
                cmd.Parameters.AddWithValue("@Locomocao", aluno.Locomocao);
                cmd.Parameters.AddWithValue("@SituacaoDomiciliar", aluno.SituacaoDomiciliar);
                cmd.Parameters.AddWithValue("@TempoMoradia", aluno.TempoMoradia);
                cmd.Parameters.AddWithValue("@MoraCom", aluno.MoraCom);
                cmd.Parameters.AddWithValue("@Trabalha", aluno.Trabalha);
                cmd.Parameters.AddWithValue("@MediaRenda", aluno.MediaRenda);
                cmd.Parameters.AddWithValue("@PeriodoEstudo", aluno.PeriodoEstudo);
                cmd.Parameters.AddWithValue("@PessoasResidem", aluno.PessoasResidem);
                cmd.Parameters.AddWithValue("@PessoasTrabalham", aluno.PessoasTrabalham);
                cmd.Parameters.AddWithValue("@SomaRendas    ", aluno.SomaRendas);
                cmd.Parameters.AddWithValue("@PeriodoTrabalho", aluno.PeriodoTrabalho);
                cmd.Parameters.AddWithValue("@VidaEscolar", aluno.VidaEscolar);
                cmd.Parameters.AddWithValue("@ConhecimentoInformatica", aluno.ConhecimentoInformatica);
                cmd.Parameters.AddWithValue("@MotivoVestibular", aluno.MotivoVestibular);
                cmd.Parameters.AddWithValue("@ConhecimentoLingua", aluno.ConhecimentoLingua);
                cmd.Parameters.AddWithValue("@Linguas", aluno.Linguas);
                cmd.Parameters.AddWithValue("@Meio", aluno.Meio);

                cmd.ExecuteNonQuery();
            }
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

        public IEnumerable<Aluno> ListaDeficiencias()
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
