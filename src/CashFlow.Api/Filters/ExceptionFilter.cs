﻿using CashFlow.Comunication.Responses;
using CashFlow.Exception;
using CashFlow.Exception.ExceptionsBase;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CashFlow.Api.Filters;

public class ExceptionFilter : IExceptionFilter
{
    public void OnException(ExceptionContext context)
    {
        if (context.Exception is CashFlowException) 
        {
            HandleProjectException(context);

        } else
        {
            ThrowUnknowError(context);
        }
    }

    private void HandleProjectException(ExceptionContext context)
    {
        if (context.Exception is ErrorOnValidationException exception)
        {
            var errorResponse = new ResponseErrorJson(exception.Errors);
            context.HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
            context.Result = new BadRequestObjectResult(errorResponse);
        }
        else
        {
            var errorResponse = new ResponseErrorJson(context.Exception.Message);
            context.HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
            context.Result = new BadRequestObjectResult(errorResponse);
        }
    }

    private void ThrowUnknowError(ExceptionContext context)
    {
        var errorResponse = new ResponseErrorJson(ResourceErrorMessages.UNKNOWN_ERRO);

        context.HttpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
        context.Result = new ObjectResult(errorResponse);

    }
}
