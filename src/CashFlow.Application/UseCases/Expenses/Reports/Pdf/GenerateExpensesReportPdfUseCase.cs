using CashFlow.Domain.Repositories.Expenses;

namespace CashFlow.Application.UseCases.Expenses.Reports.Pdf;

class GenerateExpensesReportPdfUseCase : IGenerateExpensesReportPdfUseCase
{
    private const string CURRENCY_SYMBOL = "€";
    private readonly IExpensesReadOnlyRepository _reposotory;

    public GenerateExpensesReportPdfUseCase(IExpensesReadOnlyRepository reposotory)
    {
        _reposotory = reposotory;
    }

    public async Task<byte[]> Execute(DateOnly month)
    {
        var expense = await _reposotory.FilterByMonth(month);
        if (expense.Count == 0)
        {
            return [];
        }


        return [];
    }


}
