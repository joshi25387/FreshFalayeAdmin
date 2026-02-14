namespace FreshFalaye.Admin.Models
{   
    public class SaleSaveDto
    {        
        public Guid SyncId { get; set; }
        public Guid BranchId { get; set; }

        public string BillNo { get; set; }
        public DateTime SaleDate { get; set; }
        public string? CustomerMobile { get; set; }
        public string? CustomerName { get; set; }
        public decimal SubTotal { get; set; }
        public decimal GstTotal { get; set; }
        public decimal GrandTotal { get; set; }

        public string PaymentMode { get; set; } = "";
        public int SyncVersion { get; set; }

        public List<SaleItemDto> Items { get; set; } = new();
        public List<SaleExpenseDto> Expenses { get; set; } = new();
    }
}
