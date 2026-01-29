namespace FreshFalaye.Admin.Models
{
    public class AccountDto
    {
        public Guid Id { get; set; }

        public string AccountName { get; set; } = null!;
        public string AccountCode { get; set; } = null!;
        public Guid AccountGroupId { get; set; }
        public string AccountGroupName { get; set; }

        public string? Address { get; set; }
        public string? ContactNumber { get; set; }
        public string? MobileNo { get; set; }
        public string? Email { get; set; }
        public string? GstNo { get; set; }

        public decimal OpeningBalance { get; set; }
        public bool IsCredit { get; set; }

        public bool IsApMc { get; set; }
    }

}
