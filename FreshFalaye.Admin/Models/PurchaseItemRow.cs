namespace FreshFalaye.Admin.Models
{
    public class PurchaseItemRow
    {
        public int ProductGroupId { get; set; }
        public int ProductId { get; set; }
        public int UnitId { get; set; }
        public string? UnitName { get; set; }
        public decimal Qty { get; set; }
        public decimal Rate { get; set; }
        public decimal GstPercent { get; set; }
        public decimal Amount => Qty * Rate;
        public List<ProductDto> FilteredProducts { get; set; } = new();
    }
}
