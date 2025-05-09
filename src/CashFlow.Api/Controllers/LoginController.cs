using CashFlow.Application.UseCases.Users.Login;
using CashFlow.Comunication.Requests;
using CashFlow.Comunication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace CashFlow.Api.Controllers
{
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseRegisteredUserJson), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseRegisteredUserJson), StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> Login(
            [FromServices] IDoLoginUseCase useCase,
            [FromBody] RequestLoginJson request)
        {
            var response = await useCase.Execute(request);

            return Ok(response);
        }
    }
}
