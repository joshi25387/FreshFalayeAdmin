namespace FreshFalaye.Admin.Models
{
    public class SaleGetDto
    {
        public Guid Id { get; set; }
        public Guid SyncId { get; set; }
        public Guid BranchId { get; set; }
        public string BillNo { get; set; } = null!;
        public DateTime SaleDate { get; set; }
        public string? CustomerMobile { get; set; }
        public string? CustomerName { get; set; }
        public decimal SubTotal { get; set; }
        public decimal GstTotal { get; set; }
        public decimal GrandTotal { get; set; }
        public string PaymentMode { get; set; } = null!;
        public List<SaleItemDto> Items { get; set; } = new();
        public List<SaleExpenseDto> Expenses { get; set; } = new();
    }
}
