﻿namespace CashFlow.Comunication.Responses;
public class ResponseErrorJson
{
    public List<string> ErrorMessages { get; set; }
    public ResponseErrorJson(string errorMessage)
    {
        ErrorMessages = [errorMessage];
    }

    public ResponseErrorJson(List<string> errorMesage)
    {
        ErrorMessages = errorMesage;
    }
}
