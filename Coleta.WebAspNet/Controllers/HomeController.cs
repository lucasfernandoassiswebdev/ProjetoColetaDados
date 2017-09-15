using Coleta.Aplicacao.AlunoApp;
using Coleta.Dominio.Entidades;
using OfficeOpenXml;
using System;
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
            _appAlunos.ExcluiTodos();
            //pegando o arquivo excel e montando os objetos
            string filePath = Server.MapPath(Url.Content("~/BaseDadosExcel/Base de Dados.xlsx"));

            ExcelPackage package = new ExcelPackage(new FileInfo(filePath));
            ExcelWorksheet workSheet = package.Workbook.Worksheets.First();

            package.Save();
            package.Dispose();

            package = new ExcelPackage(new FileInfo(filePath));
            workSheet = package.Workbook.Worksheets.First();

            for (int i = workSheet.Dimension.Start.Row + 1; i <= 51; i++)
            {
                //tratando os dados para pegar as informações das colunas corretas
                var locomocao = workSheet.Cells[i, 10].Value == null ? 11 : 10;
                var trabalha = workSheet.Cells[i, 14].Value.ToString() == "Sozinho" ? 15 : 19;
                var periodoEstudo = trabalha == 15 ? 17 : 22;
                var periodoTrabalho = workSheet.Cells[i, periodoEstudo].ToString() == "Matutino" ? 24 : 23;

                var aluno = new Aluno()
                {
                    RA = workSheet.Cells[i, 4].Value.ToString(),
                    Nome = workSheet.Cells[i, 3].Value.ToString(),
                    Email = workSheet.Cells[i, 2].Value.ToString(),
                    Carimbo = DateTime.FromOADate(Convert.ToDouble(workSheet.Cells[i, 1].Value)),
                    Nascimento = workSheet.Cells[i, 5].Value.ToString(),
                    Deficiencia = workSheet.Cells[i, 6].Value.ToString(),
                    EstadoCivil = workSheet.Cells[i, 7].Value.ToString(),
                    Filhos = workSheet.Cells[i, 8].Value.ToString(),
                    Cidade = workSheet.Cells[i, 9].Value.ToString(),
                    Locomocao = workSheet.Cells[i, locomocao].Value.ToString(),
                    SituacaoDomiciliar = workSheet.Cells[i, 12].Value.ToString(),
                    TempoMoradia = workSheet.Cells[i, 13].Value.ToString(),
                    MoraCom = workSheet.Cells[i, 14].Value.ToString(),
                    MediaRenda = workSheet.Cells[i, 16].Value?.ToString() ?? "0",
                    Linguas = workSheet.Cells[i, 29].Value?.ToString() ?? "nenhuma",
                    Trabalha = workSheet.Cells[i, trabalha].Value.ToString(),
                    PeriodoEstudo = workSheet.Cells[i, periodoEstudo].Value.ToString(),
                    PessoasResidem = workSheet.Cells[i, 18].Value?.ToString() ?? "1",
                    PessoasTrabalham = workSheet.Cells[i, 20].Value?.ToString() ?? "1",
                    SomaRendas = workSheet.Cells[i, 21].Value?.ToString() ?? "0",
                    PeriodoTrabalho = workSheet.Cells[i, periodoTrabalho].Value?.ToString() ?? "não trabalha",
                    VidaEscolar = workSheet.Cells[i, 25].Value.ToString(),
                    ConhecimentoInformatica = workSheet.Cells[i, 26].Value.ToString(),
                    MotivoVestibular = workSheet.Cells[i, 27].Value.ToString(),
                    ConhecimentoLingua = workSheet.Cells[i, 28].Value.ToString(),
                    Meio = workSheet.Cells[i, 30].Value?.ToString() ?? "Web"
                };

                if (aluno.Nome != "Teste")
                {
                    _appAlunos.InsereAluno(aluno);
                }
            }

            package.Dispose();

            return RedirectToAction("Index");
        }

        public ActionResult Graficos()
        {
            return View();
        }
    }
}