namespace FreshFalaye.Admin.Models
{
    public class SaleSummaryRequest
    {
        public Guid BranchId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string? PaymentMode { get; set; }
        public List<Guid>? ItemGroupIds { get; set; }
        public List<Guid>? ItemIds { get; set; }
    }
}
