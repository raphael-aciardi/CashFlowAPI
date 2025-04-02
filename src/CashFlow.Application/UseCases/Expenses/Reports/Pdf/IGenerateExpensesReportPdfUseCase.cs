namespace CashFlow.Application.UseCases.Expenses.Reports.Pdf;

interface IGenerateExpensesReportPdfUseCase
{
    Task<byte[]> Execute(DateOnly month);
}
