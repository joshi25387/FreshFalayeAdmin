namespace FreshFalaye.Admin.Models
{
    public class PurchaseHeaderDto
    {
        public int PurchaseId { get; set; }
        public int BranchId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int PartyId { get; set; }
        public string PartyInvoiceNo { get; set; } = null!;
        public string InvoiceNo { get; set; } = null!;
        public string? VehicleNo { get; set; }
        public string? ContactPersonName { get; set; }
        public string? ContactPersonNumber { get; set; }
    }

}
