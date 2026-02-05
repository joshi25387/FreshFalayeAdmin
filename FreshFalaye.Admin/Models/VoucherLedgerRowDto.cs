namespace FreshFalaye.Admin.Models
{
    public class VoucherLedgerRowDto
    {
        // MASTER
        public Guid Id { get; set; }
        public DateTime VoucherDate { get; set; }
        public string VoucherNo { get; set; }
        public string MainAccountName { get; set; }

        // DETAIL
        public string CreditAccountName { get; set; }
        public string DebitAccountName { get; set; }
        public decimal? Amount { get; set; }        
        public string RefNo { get; set; }
        public string Remarks { get; set; }
        public string Narration { get; set; }

    }

}
