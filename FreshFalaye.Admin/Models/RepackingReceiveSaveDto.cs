namespace FreshFalaye.Admin.Models
{
    public class RepackingReceiveSaveDto
    {
        public Guid BranchId { get; set; }
        public string VoucherNo { get; set; } = string.Empty;
        public DateTime ReceiveDate { get; set; }
        public DateTime PurchaseDate { get; set; }

        // ⭐ link back to issue row
        public Guid IssueId { get; set; }

        public Guid IssueItemId { get; set; }

        // ⭐ how much raw material consumed
        public decimal UsedQty { get; set; }

        public string? Remarks { get; set; }

        public List<RepackingReceiveItemDto> Items { get; set; } = new();
    }

    public class RepackingReceiveItemDto
    {
        public Guid ProductId { get; set; }

        public Guid LotNo { get; set; }      
        public Guid IssueItemId { get; set; }

        public decimal Qty { get; set; }

        public decimal Rate { get; set; }
        public string ProductName { get; set; }
        public string ProductGroupName { get; set; }
        public string ProductUnitName { get; set; }
    }


}
