namespace FreshFalaye.Admin.Models
{
    public class RepackingIssueListDto
    {
        public Guid Id { get; set; }

        public string VoucherNo { get; set; } = string.Empty;

        public DateTime IssueDate { get; set; }

        public decimal TotalQty { get; set; }

        public int ItemCount { get; set; }

        public string? Remarks { get; set; }
    }
}
