namespace FreshFalaye.Admin.Models
{
    public class AdminUser
    {
        public int UserId { get; set; }
        public string Username { get; set; } = "";
        public string Role { get; set; } = "";
        public int BranchId { get; set; }
        public string BranchName { get; set; } = "";        
        public string Token { get; set; } = "";
    }
}
