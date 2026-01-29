namespace FreshFalaye.Admin.Models
{
    public class PurchaseHeaderDto
    {
        public Guid PurchaseId { get; set; }
        public Guid BranchId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public Guid AccountId { get; set; }
        public string PartyInvoiceNo { get; set; } = null!;
        public string InvoiceNo { get; set; } = null!;
        public string? VehicleNo { get; set; }
        public string? ContactPersonName { get; set; }
        public string? ContactPersonNumber { get; set; }
    }

}
