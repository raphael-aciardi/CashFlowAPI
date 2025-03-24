using CashFlow.Domain.Entities;

namespace CashFlow.Domain.Repositories.Expenses;

public  interface IExpensesWriteOnlyRepository
{
    Task Add(Expense expense);
    /// <summary>
    /// This function returns True if the deletion was successful otherwise return False
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<bool> Delete(long id);
}
