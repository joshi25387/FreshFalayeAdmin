namespace FreshFalaye.Admin.Models
{
    public class BranchDto
    {
        public Guid BranchId { get; set; }
        public string BranchCode { get; set; } = null!;
        public string BranchName { get; set; } = null!;
        public string? Address { get; set; }
        public string? City { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
