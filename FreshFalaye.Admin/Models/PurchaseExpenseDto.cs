namespace FreshFalaye.Admin.Models
{
    public class PurchaseExpenseDto
    {
        public int ExpenseMasterId { get; set; }
        public string Expense { get; set; }
        public string RateType { get; set; } = null!;
        public string Bearer { get; set; } = null!;
        public decimal Rate { get; set; }
    }

}
