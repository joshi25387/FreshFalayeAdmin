namespace FreshFalaye.Admin.Models
{
    public class SaleHeaderDto
    {
        public Guid SaleId { get; set; }
        public Guid SyncId { get; set; }
        public Guid BranchId { get; set; }
        public DateTime SaleDate { get; set; }
        public string BillNo { get; set; }
        public string? CustomerMobile { get; set; }
        public string? CustomerName { get; set; }
        public string PaymentMode { get; set; } = null!;        
    }
}
