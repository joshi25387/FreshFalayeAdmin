namespace FreshFalaye.Admin.Models
{
    public class ProductDto
    {
        public Guid BranchId { get; set; }
        public Guid ProductId { get; set; }

        public Guid ProductGroupId { get; set; }
        public string? ProductGroupName { get; set; }

        public Guid UnitId { get; set; }
        public string? UnitName { get; set; }
        public int MinimumStock { get; set; }

        public string ProductName { get; set; } = null!;

        public decimal Mrp { get; set; }
        public decimal Discount { get; set; }
        public decimal SalePrice { get; set; }
        public decimal GstPercent { get; set; }

        public string? ImagePath { get; set; }
        public bool IsActive { get; set; } = true;
        public bool UseWeighingScale { get; set; } = true;
    }

}
