using CashFlow.Communication.Responses;

namespace CashFlow.Communication.Responss;
public class ResponseExpensesJson
{
    public List<ResponseShortExpenseJson> Expenses { get; set; } = [];
}