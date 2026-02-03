namespace FreshFalaye.Admin.Models
{
    public class VoucherDto
    {
        public Guid Id { get; set; }
        public DateTime VoucherDate { get; set; }
        public Guid BranchId { get; set; }
        public string VoucherNoString { get; set; }
        public Guid VoucherTypeId { get; set; }
        public string VoucherTypeName { get; set; }
        public Guid? MainAccountId { get; set; }
        public string MainAccountName { get; set; }
        public decimal? VoucherValue { get; set; }
        public decimal? VoucherCreditValue { get; set; }
        public decimal? VoucherDebitValue { get; set; }
        public string? Series { get; set; }
        public string Narration { get; set; }
        public List<VoucherDetailDto> VoucherDetails { get; set; }

    }

    public class VoucherDetailDto
    {        
        public Guid Id { get; set; }
        public Guid VoucherId { get; set; }
        public string DebitCredit { get; set; }
        public Guid? CreditAccountId { get; set; }
        public string DebitAccountName { get; set; }
        public Guid? DebitAccountId { get; set; }
        public string CreditAccountName { get; set; }
        public string AccountName { get; set; }
        public Guid? BankVoucherModeId { get; set; }        
        public decimal? Amount { get; set; }
        public string RefNo { get; set; }
        public string Remarks { get; set; }        
    }

    public class VoucherTypeDto
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public string BasicType { get; set; }
        public string VoucherSeries { get; set; }
    }

    public class BankVoucherModeDto
    {
        public int SerialNumber { get; set; }
        public Guid Id { get; set; }
        public string Mode { get; set; }
    }
}
