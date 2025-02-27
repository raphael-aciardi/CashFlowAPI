using CashFlow.Domain.Enums;

namespace CashFlow.Domain.Entities;
public class Expense
{
    public long Id { get; set; }
    public string Tilte { get; set; } = string.Empty;
    public string? Desciption {  get; set; } 
    public DateTime Date { get; set; }
    public decimal Amount { get; set; }
    public PaymentType PaymentType {  get; set; }
}
