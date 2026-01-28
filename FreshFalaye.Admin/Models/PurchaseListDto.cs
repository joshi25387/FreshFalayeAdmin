namespace FreshFalaye.Admin.Models
{
   
    public class PurchaseListDto
    {
        public int PurchaseId { get; set; }

        public DateTime PurchaseDate { get; set; }

        public int BranchId { get; set; }
        public string BranchName { get; set; } = null!;

        public int PartyId { get; set; }
        public string PartyName { get; set; } = null!;

        public string PartyInvoiceNo { get; set; } = null!;
        public string InvoiceNo { get; set; } = null!;

        public decimal ItemTotal { get; set; }
        public decimal ExpenseTotal { get; set; }
        public decimal NetAmount { get; set; }
    }


}
