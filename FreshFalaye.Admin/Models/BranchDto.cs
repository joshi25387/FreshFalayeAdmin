namespace FreshFalaye.Admin.Models
{
    public class BranchDto
    {
        public Guid BranchId { get; set; }
        public string BranchCode { get; set; } = null!;
        public string BranchName { get; set; } = null!;
        public string? Address { get; set; }
        public string? City { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }

    public class BranchBatchStockDto
    {
        public Guid ProductId { get; set; }

        public string ProductName { get; set; } = string.Empty;
        public string ProductGroupName { get; set; } = string.Empty;
        public string UnitName { get; set; } = string.Empty;
        public string VendorName { get; set; } = string.Empty;
        public Guid LotNo { get; set; }

        public decimal BalanceQty { get; set; }

        public decimal Rate { get; set; }

        public DateTime PurchaseDate { get; set; }
    }
}
