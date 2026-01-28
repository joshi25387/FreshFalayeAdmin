namespace FreshFalaye.Admin.Models
{
    public class PurchaseDto
    {
        public int PurchaseId { get; set; }
        public int BranchId { get; set; }
        public string BranchName { get; set; }

        public DateTime PurchaseDate { get; set; }

        public int PartyId { get; set; }
        public string PartyName { get; set; } = null!;

        public string PartyInvoiceNo { get; set; } = null!;
        public string InvoiceNo { get; set; } = null!;

        public string? VehicleNo { get; set; }
        public string? ContactPersonName { get; set; }
        public string? ContactPersonNumber { get; set; }

        public decimal ItemTotal { get; set; }
        public decimal ExpenseTotal { get; set; }
        public decimal NetAmount { get; set; }

        public List<PurchaseItemLineDto> Items { get; set; } = new();
        public List<PurchaseExpenseLineDto> Expenses { get; set; } = new();
    }

    public class PurchaseItemLineDto
    {
        public int PurchaseItemId { get; set; }

        public int ProductGroupId { get; set; }
        public string ProductGroupName { get; set; } = null!;

        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;

        public int UnitId { get; set; }
        public string UnitName { get; set; } = null!;

        public decimal Qty { get; set; }
        public decimal Rate { get; set; }
        public decimal GstPercent { get; set; }
        public decimal Amount { get; set; }

        public string LotNo { get; set; } = null!;
    }
    public class PurchaseExpenseLineDto
    {
        public int PurchaseExpenseId { get; set; }

        public int ExpenseMasterId { get; set; }
        public string ExpenseName { get; set; } = null!;

        public string RateType { get; set; } = null!;
        public decimal Rate { get; set; }
        public decimal Amount { get; set; }

        public string Bearer { get; set; } = null!;
    }


}
