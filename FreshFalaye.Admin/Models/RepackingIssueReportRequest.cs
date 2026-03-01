namespace FreshFalaye.Admin.Models
{
    public class RepackingIssueReportRequest
    {
        public Guid BranchId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        //public Guid? PartyId { get; set; }
        public List<Guid>? ItemGroupIds { get; set; }
        public List<Guid>? ItemIds { get; set; }
    }
    public class RepackingReceiveReportRequest
    {
        public Guid BranchId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        //public Guid? PartyId { get; set; }
        public List<Guid>? ItemGroupIds { get; set; }
        public List<Guid>? ItemIds { get; set; }
        public bool PendingToReceive { get; set; } = false;
    }
}
