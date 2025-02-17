using CashFlow.Comunication.Enums;
using CashFlow.Comunication.Requests;
using CashFlow.Comunication.Responses;
using CashFlow.Exception.ExceptionsBase;
using CashFlow.Exception.ExeptionsBase;

namespace CashFlow.Application.UseCases.Expenses.Register;
public class RegisterExpenseUseCase
{
    public ResponseRegisterExpenseJson Execute(RequestRegisterExpenseJson request)
    {
        Validate(request);
        return new ResponseRegisterExpenseJson();

    }
    private void Validate(RequestRegisterExpenseJson request)
    {
        var validator = new RegisterExpenseValidator();
        var result = validator.Validate(request);
        if (result.IsValid == false)
        {
            var errorMensages = result.Errors.Select(f => f.ErrorMessage).ToList();
            throw new ErrorOnValidationException(errorMensages);
        }
    }
}