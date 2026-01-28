namespace FreshFalaye.Admin.Models
{
    public class PurchaseItemDto
    {
        public int ProductGroupId { get; set; }
        public int ProductId { get; set; }
        public int UnitId { get; set; }
        public decimal Qty { get; set; }
        public decimal Rate { get; set; }
        public decimal GstPercent { get; set; }
        public decimal Amount { get; set; }
        public string LotNo { get; set; } = null!;   // Auto-generated backend
        public int LineNo { get; set; }
    }

}
