namespace FreshFalaye.Admin.Models
{
    public class DashboardKpiDto
    {
        public decimal TodaySales { get; set; }
        public decimal MonthSales { get; set; }
        public int BillCount { get; set; }
        public decimal AvgBillValue { get; set; }
    }

    public class SalesTrendDto
    {
        public string DateLabel { get; set; }
        public decimal TotalAmount { get; set; }
    }

    public class PaymentBreakdownDto
    {
        public string PaymentMode { get; set; }  // Cash / UPI
        public decimal Amount { get; set; }
    }

    public class TopItemSalesDto
    {
        public string ItemName { get; set; }
        public decimal Quantity { get; set; }
        public string Unit { get; set; }
    }

    public class LowStockDto
    {
        public string ItemName { get; set; }
        public decimal CurrentQty { get; set; }
        public decimal MinQty { get; set; }
        public string Unit { get; set; }
    }


}
