namespace FreshFalaye.Admin.Models
{
    public class AdminUser
    {
        public Guid UserId { get; set; }
        public string Username { get; set; } = "";
        public string Role { get; set; } = "";
        public Guid BranchId { get; set; }
        public string BranchName { get; set; } = "";        
        public string Token { get; set; } = "";
    }
}
