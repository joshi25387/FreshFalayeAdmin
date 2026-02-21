namespace FreshFalaye.Admin.Models
{
    public class LedgerReportDto
    {
        public Guid BranchId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public List<Guid>? AccountGroupIds { get; set; }
        public List<Guid>? AccountIds { get; set; }
        public bool OnSeparatePage { get; set; } = false;
    }
}
