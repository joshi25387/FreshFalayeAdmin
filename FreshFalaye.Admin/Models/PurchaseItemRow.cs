namespace FreshFalaye.Admin.Models
{
    public class PurchaseItemRow
    {
        public Guid ProductGroupId { get; set; }
        public Guid ProductId { get; set; }
        public Guid UnitId { get; set; }
        public string? UnitName { get; set; }
        public decimal Qty { get; set; }
        public decimal Rate { get; set; }
        public decimal GstPercent { get; set; }
        public decimal Amount => Qty * Rate;
        public List<ProductDto> FilteredProducts { get; set; } = new();
    }
}
