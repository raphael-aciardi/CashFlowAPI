using CashFlow.Comunication.Requests;
using CashFlow.Comunication.Responses;

namespace CashFlow.Application.UseCases.Users.Login;

public interface IDoLoginUseCase
{
    Task<ResponseRegisteredUserJson> Execute(RequestLoginJson request);
}