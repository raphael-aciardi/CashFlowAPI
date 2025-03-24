﻿using CashFlow.Domain.Repositories;
using CashFlow.Domain.Repositories.Expenses;
using CashFlow.Exception;

namespace CashFlow.Application.UseCases.Expenses.Delete;

class DeleteExpenseUseCase : IDeleteExpenseUseCase
{
    private readonly IExpensesWriteOnlyRepository _repository;
    private readonly IUnitOfWork _unitOfWork;

    public DeleteExpenseUseCase(IExpensesWriteOnlyRepository repository, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }

    public async Task Execute(long id)
    {
        var result = await _repository.Delete(id);

        if (result is false)
        {
            throw new DirectoryNotFoundException(ResourceErrorMessages.EXPENSE_NOT_FOUND);
        }

        await _unitOfWork.Commit();
    }

}
