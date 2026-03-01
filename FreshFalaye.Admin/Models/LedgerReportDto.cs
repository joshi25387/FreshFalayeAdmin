namespace FreshFalaye.Admin.Models
{
    public class LedgerReportRequestDto
    {
        public Guid BranchId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public List<Guid>? AccountGroupIds { get; set; }
        public List<Guid>? AccountIds { get; set; }
        public bool OnSeparatePage { get; set; } = false;
    }

    public class LedgerReportDto
    {
        public Guid? LedgerEntryId { get; set; }
        public Guid? VoucherId { get; set; }
        public Guid AccountId { get; set; }
        public string AccountName { get; set; }
        public string VoucherType { get; set; }
        public string VoucherNo { get; set; }

        public DateTime? EntryDate { get; set; }
        public string Particulars { get; set; }

        public decimal Debit { get; set; }
        public decimal Credit { get; set; }

        public decimal RunningBalance { get; set; }
        public bool IsDebit { get; set; }
        public bool IsOpeningRow { get; set; }
        public bool IsAccountHeader { get; set; }
        public bool IsAccountTotalRow { get; set; }
        public bool IsClosingRow { get; set; }
        // Header data
        public string? Address { get; set; }
        public string? Remarks { get; set; }
    }
}
