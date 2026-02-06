namespace FreshFalaye.Admin.Models
{
    public class PurchaseExpenseDto
    {
        public string ExpenseName { get; set; }
        public Guid ExpenseMasterId { get; set; }
        public string Expense { get; set; }
        public string RateType { get; set; } = null!;
        public string Bearer { get; set; } = null!;
        public decimal Rate { get; set; }
        public decimal Amount { get; set; }
        public string AddDeduct { get; set; }
    }

}
