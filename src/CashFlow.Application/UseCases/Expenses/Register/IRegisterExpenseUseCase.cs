﻿using CashFlow.Comunication.Requests;
using CashFlow.Comunication.Responses;

namespace CashFlow.Application.UseCases.Expenses.Register;

public interface IRegisterExpenseUseCase
{
    public Task<ResponseRegisteredExpenseJson> Execute(RequestExpenseJson request);

}
