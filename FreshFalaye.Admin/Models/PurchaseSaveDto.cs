namespace FreshFalaye.Admin.Models
{
    public class PurchaseSaveDto
    {
        public PurchaseHeaderDto Header { get; set; } = null!;
        public List<PurchaseItemDto> Items { get; set; } = new();
        public List<PurchaseExpenseDto> Expenses { get; set; } = new();
    }
}
