using Coleta.Aplicacao.AlunoApp;
using Coleta.Dominio.Entidades;
using OfficeOpenXml;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Mvc;

namespace Coleta.WebAspNet.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAlunoAplicacao _appAlunos;

        public HomeController(IAlunoAplicacao aluno)
        {
            _appAlunos = aluno;
        }

        public ActionResult Index()
        {
            var alunos = _appAlunos.ExibeDados();
            return View(alunos);
        }

        public ActionResult TransfereBaseSegura()
        {
            List<Aluno> alunos = new List<Aluno>();

            //variáveis que serão usadas no tratamento de dados
            int locomocao;
            int trabalha;
            int periodoEstudo;
            int periodoTrabalho;
            
            //pegando o arquivo excel e montando os objetos
            string filePath = Server.MapPath(Url.Content("~/BaseDadosExcel/Base de Dados.xlsx"));

            ExcelPackage package = new ExcelPackage(new FileInfo(filePath));
            ExcelWorksheet workSheet = package.Workbook.Worksheets.First();

            package.Save();
            package.Dispose();

            package = new ExcelPackage(new FileInfo(filePath));
            workSheet = package.Workbook.Worksheets.First();
            
            for (int i = workSheet.Dimension.Start.Row + 1; i <= workSheet.Dimension.End.Row; i++)
            {
                //tratando os dados para pegar as informações das colunas corretas
                locomocao = workSheet.Cells[i, 10].ToString() == string.Empty ?  11 :  10;
                trabalha = workSheet.Cells[i, 14].ToString() == "Sozinho" ? 15 : 19;
                periodoEstudo = trabalha == 15 ? 17 : 22;
                periodoTrabalho = workSheet.Cells[i, periodoEstudo].ToString() == "Matutino" ? 23 : 24;

                alunos.Add( new Aluno()
                {
                    RA = workSheet.Cells[i, 4].Value.ToString(),
                    Nome = workSheet.Cells[i, 3].Value.ToString(),
                    Email = workSheet.Cells[i, 2].Value.ToString(),
                    Carimbo = workSheet.Cells[i, 1].Value.ToString(),
                    Nascimento = workSheet.Cells[i, 5].Value.ToString(),
                    Deficiencia = workSheet.Cells[i, 5].Value.ToString(),
                    EstadoCivil = workSheet.Cells[i, 7].Value.ToString(),
                    //Filhos = Convert.ToInt32(workSheet.Cells[i, 8].Value.ToString()),
                    Cidade = workSheet.Cells[i, 9].Value.ToString(),
                    Locomocao = workSheet.Cells[i, locomocao].Value.ToString(),
                    SituacaoDomiciliar = workSheet.Cells[i, 12].Value.ToString(),
                    //TempoMoradia = Convert.ToInt32(workSheet.Cells[i, 13].Value.ToString()),
                    MoraCom = workSheet.Cells[i, 14].Value.ToString(),
                    //Trabalha = workSheet.Cells[i, trabalha].Value.ToString(),
                    //MediaRenda = Convert.ToInt32(workSheet.Cells[i, 16].Value.ToString()),
                    PeriodoEstudo = workSheet.Cells[i, periodoEstudo].Value.ToString(),
                    //PessoasResidem = Convert.ToInt32(workSheet.Cells[i, 18].Value.ToString()),
                    //PessoasTrabalham = Convert.ToInt32(workSheet.Cells[i, 20].Value.ToString()),
                    //SomaRendas = Convert.ToInt32(workSheet.Cells[i, 21].Value.ToString()),
                    PeriodoTrabalho = workSheet.Cells[i, periodoTrabalho].Value.ToString(),
                    VidaEscolar = workSheet.Cells[i, 25].Value.ToString(),
                    ConhecimentoInformatica = workSheet.Cells[i, 26].Value.ToString(),
                    MotivoVestibular = workSheet.Cells[i, 27].Value.ToString(),
                    ConhecimentoLingua = workSheet.Cells[i, 28].Value.ToString(),
                    Linguas = workSheet.Cells[i, 29].Value.ToString(),
                    Meio = workSheet.Cells[i, 30].Value.ToString()
                });
            }

            //inserindo os alunos da planilha na base de dados do SQL server
            foreach(var alunoA in alunos)
            {
                _appAlunos.InsereAluno(alunoA);
            }

            package.Dispose();
            return RedirectToAction("Index");
        }
    }
}