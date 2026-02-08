namespace FreshFalaye.Admin.Models
{
    public class RepackingIssueListDto
    {
        public Guid Id { get; set; }

        public string VoucherNo { get; set; } = string.Empty;

        public DateTime IssueDate { get; set; }
        public string ProductGroup { get; set; }
        public string ProductName { get; set; }
        public string VendorName { get; set; }

        public decimal Qty { get; set; }

        //public int ItemCount { get; set; }

        public string? Remarks { get; set; }
    }
}
