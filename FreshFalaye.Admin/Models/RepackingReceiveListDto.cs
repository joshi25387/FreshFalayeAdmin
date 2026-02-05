namespace FreshFalaye.Admin.Models
{
    public class RepackingReceiveListDto
    {
        public Guid Id { get; set; }
        public string VoucherNo { get; set; }
        public DateTime ReceiveDate { get; set; }
        public decimal TotalUsedQty { get; set; }
        public decimal TotalOutputQty { get; set; }
        public int ItemCount { get; set; }
        public string? Remarks { get; set; }
    }
}
