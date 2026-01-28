namespace FreshFalaye.Admin.Models
{
    public class PurchaseExpenseRow
    {
        public int ExpenseMasterId { get; set; }
        public string ExpenseName { get; set; } = null!;
        public string RateType { get; set; } = null!;
        public string Bearer { get; set; } = null!;
        public decimal Rate { get; set; }
        public decimal Amount { get; set; }
    }
}
