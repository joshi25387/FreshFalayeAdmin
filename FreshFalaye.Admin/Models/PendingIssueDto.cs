namespace FreshFalaye.Admin.Models
{
    public class PendingIssueDto
    {
        public Guid IssueId { get; set; }
        public Guid IssueItemId { get; set; }

        public string VoucherNo { get; set; }
        public DateTime IssueDate { get; set; }

        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductGroupName { get; set; }
        public string ProductUnitName { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string VendorName { get; set; }

        public Guid LotNo { get; set; }

        public decimal IssuedQty { get; set; }
        public decimal ReceivedQty { get; set; }
        public decimal PendingQty { get; set; }
        public decimal Rate { get; set; }
    }

}
