using ClosedXML.Excel;
using GymManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagement.Tools
{
    public class ExcelReport
    {
        public static string GetTransactionReport(List<TransactionViewModel> transactions,string path)
        {
            var workbook = new XLWorkbook();
            IXLWorksheet worksheet = workbook.Worksheets.Add("Product");

            var table = worksheet.Range(1, 1, transactions.Count, 5).CreateTable();

            worksheet.Cell(1, 1).Value = "نام فرد";
            worksheet.Cell(1, 2).Value = "مبلغ";
            worksheet.Cell(1, 3).Value = "ادمین ثبت کننده";
            worksheet.Cell(1, 4).Value = "زمان";
            worksheet.Cell(1, 5).Value = "بابت";

            // table customized style
            table.Style.Font.Bold = true;
            table.Style.Font.FontSize = 12;
            table.Style.Fill.BackgroundColor = XLColor.LightGray;
            table.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            table.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
            table.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            table.Style.Border.BottomBorderColor = XLColor.Black;
            table.Style.Border.TopBorder = XLBorderStyleValues.Thin;
            table.Style.Border.TopBorderColor = XLColor.Black;
            table.Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            table.Style.Border.LeftBorderColor = XLColor.Black;
            table.Style.Border.RightBorder = XLBorderStyleValues.Thin;
            table.Style.Border.RightBorderColor = XLColor.Black;

            table.ShowAutoFilter = true;
            table.Worksheet.Columns().AdjustToContents();

            table.Worksheet.Columns("A").Width = 30;
            table.Worksheet.Columns("B").Width = 30;
            table.Worksheet.Columns("C").Width = 30;
            table.Worksheet.Columns("D").Width = 30;
            table.Worksheet.Columns("E").Width = 50;

            for (int index = 1; index <= transactions.Count; index++)
            {
                worksheet.Cell(index + 1, 1).Value = transactions[index - 1].UserName;
                worksheet.Cell(index + 1, 2).Value = transactions[index - 1].Price;
                worksheet.Cell(index + 1, 3).Value = transactions[index - 1].AdminName;
                worksheet.Cell(index + 1, 4).Value = transactions[index - 1].Time;
                worksheet.Cell(index + 1, 5).Value = transactions[index - 1].Description;
            }

            var uniqueId = $" تراکنش های-{DateTime.Now.ToPersianDate()}.xlsx";
            var fileName = $"{path}/{uniqueId}";

            workbook.SaveAs(fileName);

            return $"در مسیر ذخیره شد.{path}/{uniqueId}";
        }
    }
}
