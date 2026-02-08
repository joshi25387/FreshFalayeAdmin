namespace FreshFalaye.Admin.Models
{
    public class StockSummaryDto
    {
        public Guid ProductId { get; set; }

        public string ProductName { get; set; } = "";

        public decimal QtyIn { get; set; }

        public decimal QtyOut { get; set; }

        public decimal Balance { get; set; }

        public decimal AvgRate { get; set; }

        public decimal Value { get; set; }
    }

    public class StockSummaryRequest
    {
        public Guid BranchId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public List<Guid>? ItemGroupIds { get; set; }
        public List<Guid>? ItemIds { get; set; }
        public bool WithZeroStock { get; set; }
    }

}
