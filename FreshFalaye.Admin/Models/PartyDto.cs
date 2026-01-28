namespace FreshFalaye.Admin.Models
{
    public class PartyDto
    {
        public int PartyId { get; set; }

        public string PartyName { get; set; } = null!;
        public string PartyCode { get; set; } = null!;
        public string PartyType { get; set; } = "Both";

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
