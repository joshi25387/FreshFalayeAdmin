namespace FreshFalaye.Admin.Models
{
    public class PurchaseItemDto
    {
        public Guid ProductGroupId { get; set; }
        public Guid ProductId { get; set; }
        public Guid UnitId { get; set; }
        public decimal Qty { get; set; }
        public decimal QIS { get; set; }
        public decimal Rate { get; set; }
        public decimal GstPercent { get; set; }
        public decimal Amount { get; set; }
        public Guid? LotNo { get; set; }   // Auto-generated backend
        public int LineNo { get; set; }
    }

}
