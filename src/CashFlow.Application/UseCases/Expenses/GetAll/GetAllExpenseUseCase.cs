﻿using AutoMapper;
using CashFlow.Domain.Repositories.Expenses;
using CashFlow.Comunication.Responses;

namespace CashFlow.Application.UseCases.Expenses.GetAll;
public class GetAllExpenseUseCase(IExpensesReadOnlyRepository repository, IMapper mapper) : IGetAllExpenseUseCase
{
    private readonly IExpensesReadOnlyRepository _repository = repository;
    private readonly IMapper _mapper = mapper;

    public async Task<ResponseExpensesJson> Execute()
    {
        var result = await _repository.GetAll();

        return new ResponseExpensesJson
        {
            Expenses = _mapper.Map<List<ResponseShortExpenseJson>>(result)
        };
    }
}