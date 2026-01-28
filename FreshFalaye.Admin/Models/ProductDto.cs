namespace FreshFalaye.Admin.Models
{
    public class ProductDto
    {
        public int BranchId { get; set; }
        public int ProductId { get; set; }

        public int ProductGroupId { get; set; }
        public string? ProductGroupName { get; set; }

        public int UnitId { get; set; }
        public string? UnitName { get; set; }
        public int MinimumStock { get; set; }

        public string ProductName { get; set; } = null!;

        public decimal Mrp { get; set; }
        public decimal Discount { get; set; }
        public decimal SalePrice { get; set; }
        public decimal GstPercent { get; set; }

        public string? ImagePath { get; set; }
        public bool IsActive { get; set; } = true;
    }

}
