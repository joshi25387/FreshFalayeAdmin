namespace FreshFalaye.Admin.Models
{
    public class RepackingIssueSaveDto
    {
        public string VoucherNo { get; set; } = string.Empty;

        public Guid BranchId { get; set; }

        public DateTime IssueDate { get; set; }

        public string? Remarks { get; set; }

        public List<RepackingIssueItemDto> Items { get; set; } = new();
    }

    public class RepackingIssueItemDto
    {
        public Guid ProductId { get; set; }

        public string ProductName { get; set; } = string.Empty;
        public string ProductGroupName { get; set; } = string.Empty;
        public string ProductUnitName { get; set; } = string.Empty;

        public Guid LotNo { get; set; }
        
        public decimal BalanceQty { get; set; }

        public decimal Qty { get; set; }

        public decimal Rate { get; set; }
    }
}
