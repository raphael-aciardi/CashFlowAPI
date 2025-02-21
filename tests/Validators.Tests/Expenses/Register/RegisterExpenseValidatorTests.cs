using CashFlow.Application.UseCases.Expenses.Register;
using CommonTestUtilities.Requests;

namespace Validators.Tests.Expenses.Register;
public class RegisterExpenseValidatorTests
{
    [Fact]
    public void Success()
        //Coments to remember the structure in the next tests
    {
        //Arrange
        var Validator = new RegisterExpenseValidator();
        var request = RequestRegisterExpenseJsonBuilder.Build();
        //Act
        var result = Validator.Validate(request);

        //Assert
        Assert.True(result.IsValid);
    }
}
