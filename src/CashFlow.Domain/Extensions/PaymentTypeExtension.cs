using CashFlow.Domain.Enums;
using CashFlow.Domain.Reports;

namespace CashFlow.Domain.Extensions;

public static class PaymentTypeExtension
{
    public static string PaymentTypeToString(this PaymentType paymentType)
    {
        return paymentType switch
        {
            PaymentType.Cash => ResourceReportGenerationMessages.MONEY,
            PaymentType.CreditCard => ResourceReportGenerationMessages.CREDITCARD,
            PaymentType.DebitCard => ResourceReportGenerationMessages.DEBITCARD,
            PaymentType.EletronicTransfer => ResourceReportGenerationMessages.BANKTRANSFER,
            _ => string.Empty
        };
    }
}
