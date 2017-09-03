using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Coleta.WebAspNet.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MexeExcel()
        {
            // Caminho do meu arquivo (coloquei na pasta Content da minha aplicação MVC)
            string filePath = Server.MapPath(Url.Content("~/BaseDadosExcel/Base de Dados.xlsx"));

            // Abrindo, modificando meu arquivo e salvando
            ExcelPackage package = new ExcelPackage(new FileInfo(filePath));
            ExcelWorksheet workSheet = package.Workbook.Worksheets.First();
            
            package.Save();
            package.Dispose();

            // Abrindo meu arquivo para varrer o conteudo da primeira planilha e exibir na minha página
            package = new ExcelPackage(new FileInfo(filePath));
            workSheet = package.Workbook.Worksheets.First();
            StringBuilder conteudo = new StringBuilder();
            for (int i = workSheet.Dimension.Start.Row; i <= workSheet.Dimension.End.Row;i++)
            {
                for (int j = workSheet.Dimension.Start.Column; j <= workSheet.Dimension.End.Column; j++)
                {
                    conteudo.Append( "["+ workSheet.Cells[i, j].Value + "]" );
                }
            conteudo.Append("<br/>");
            }

            package.Dispose();
            return View((object) conteudo.ToString());
        }
    }
}