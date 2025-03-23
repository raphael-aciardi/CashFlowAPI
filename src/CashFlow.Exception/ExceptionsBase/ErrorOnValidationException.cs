﻿using System.Net;

namespace CashFlow.Exception.ExceptionsBase;
public class ErrorOnValidationException(List<string> errorMessages) : CashFlowException(string.Empty) 
{
    private readonly List<string> _errors = errorMessages;

    public override int StatusCode => (int)HttpStatusCode.BadRequest;

    public override List<string> GetErros()
    {
        return _errors;
    }
}
