using CashFlow.Application.UseCases.Expenses.Register;
using CashFlow.Comunication.Requests;

namespace Validators.Tests.Expenses.Register;
public class RegisterExpenseValidatorTests
{
    [Fact]
    public void Success()
        //Coments to remember the structure in the next tests
    {
        //Arrange
        var Validator = new RegisterExpenseValidator();
        var request = new RequestRegisterExpenseJson
        {
            Amount = 100,
            Date = DateTime.Now.AddDays(-1),
            Description = "description",
            Title = "title",
            PaymentType = CashFlow.Comunication.Enums.PaymentType.CreditCard,
        };
        //Act
        var result = Validator.Validate(request);

        //Assert
        Assert.True(result.IsValid);
    }
}
