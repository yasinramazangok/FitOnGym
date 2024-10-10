using ClosedXML.Excel; // for XLWorkbook
using DataAccessLayer.Contexts;
using FitOnWebSite.Models;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml; // for ExcelPackage

namespace FitOnWebSite.Controllers
{
    public class ReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StaticReport()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ExcelPackage excelPackage = new ExcelPackage();
            var workBook = excelPackage.Workbook.Worksheets.Add("Dosya1");

            workBook.Cells[1, 1].Value = "Ürün Adı";
            workBook.Cells[1, 2].Value = "Ürün Kategorisi";
            workBook.Cells[1, 3].Value = "Ürün Stok";

            workBook.Cells[2, 1].Value = "Mercimek";
            workBook.Cells[2, 2].Value = "Bakliyat";
            workBook.Cells[2, 3].Value = "785 Kg";

            workBook.Cells[3, 1].Value = "Buğday";
            workBook.Cells[3, 2].Value = "Bakliyat";
            workBook.Cells[3, 3].Value = "1.986 Kg";

            workBook.Cells[4, 1].Value = "Havuç";
            workBook.Cells[4, 2].Value = "Sebze";
            workBook.Cells[4, 3].Value = "167 Kg";

            var bytes = excelPackage.GetAsByteArray();
            return File(bytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Bakliyat Raporu.xlsx");
        }

        public List<ContactReportModel> ContactList()
        {
            List<ContactReportModel> contactReportModels = new List<ContactReportModel>();
            using (var context = new Context())
            {
                contactReportModels = context.Contacts.Select(x => new ContactReportModel
                {
                    ID = x.ID,
                    PersonName = x.PersonName,
                    Date = x.Date,
                    Email = x.Email,
                    Message = x.Message
                }).ToList();
            }
            return contactReportModels;
        }

        public IActionResult ContactReport()
        {
            using (var workBook = new XLWorkbook())
            {
                var workSheet = workBook.Worksheets.Add("Mesaj Listesi");
                workSheet.Cell(1, 1).Value = "Mesaj ID";
                workSheet.Cell(1, 2).Value = "Mesaj Gönderen";
                workSheet.Cell(1, 3).Value = "Email Adresi";
                workSheet.Cell(1, 4).Value = "Mesaj İçeriği";
                workSheet.Cell(1, 5).Value = "Mesaj Tarihi";

                int contactRowCount = 2;
                foreach (var item in ContactList())
                {
                    workSheet.Cell(contactRowCount, 1).Value = item.ID;
                    workSheet.Cell(contactRowCount, 2).Value = item.PersonName;
                    workSheet.Cell(contactRowCount, 3).Value = item.Email;
                    workSheet.Cell(contactRowCount, 4).Value = item.Message;
                    workSheet.Cell(contactRowCount, 5).Value = item.Date;
                    contactRowCount++;
                }

                using (var stream = new MemoryStream())
                {
                    workBook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Mesaj Raporu.xlsx");
                }
            }
        }
    }
}

