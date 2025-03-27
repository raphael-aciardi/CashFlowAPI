namespace CashFlow.Application.UseCases.Expenses.Reports.Excel;

public interface IGenerateExpensesReportExcelUseCase
{
    public async Task<byte[]> Execute(DateOnly month);
}
