namespace FreshFalaye.Admin.Models
{
    public class ExpenseMasterDto
    {
        public int Id { get; set; }

        public string ExpenseType { get; set; } = null!;   // Sale / Purchase
        public string ExpenseName { get; set; } = null!;

        public string RateType { get; set; } = null!;      // # / %
        public decimal Rate { get; set; }

        public string Bearer { get; set; } = null!;        // Self / Customer
        public bool IsTaxable { get; set; }
    }

}
