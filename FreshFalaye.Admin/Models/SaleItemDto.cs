namespace FreshFalaye.Admin.Models
{
    public class SaleItemDto
    {
        public Guid ProductId { get; set; }
        public Guid ProductGroupId { get; set; }
        public Guid UnitId { get; set; }
        public string ProductName { get; set; }
        public string UnitCode { get; set; }
        public List<UnitDto> AvailableUnits { get; set; }
        public decimal Qty { get; set; }
        public decimal Mrp { get; set; }
        public decimal Discount { get; set; }
        public decimal Gst { get; set; }
        public decimal Rate { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal StockQty { get; set; }
        public decimal OriginalQty { get; set; }
    }

}
