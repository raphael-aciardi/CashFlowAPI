using ClosedXML.Excel;

namespace CashFlow.Application.UseCases.Expenses.Reports.Excel;

class GenerateExpensesReportExcelUseCase: IGenerateExpensesReportExcelUseCase
{
    public async Task<byte[]> Execute(DateOnly month) {
        var workbook = new XLWorkbook();

        //Archive
        workbook.Author = "Raphael";
        workbook.Style.Font.FontSize = 12;
        workbook.Style.Font.FontName = "Times New Roman";

        // DateTime.Now.ToString("Y")

        //Page
        var worksheet = workbook.Worksheets.Add(month.ToString("Y"));
    }
}
