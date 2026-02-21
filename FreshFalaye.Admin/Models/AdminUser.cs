namespace FreshFalaye.Admin.Models
{
    public class AdminUser
    {
        public Guid UserId { get; set; }
        public string Username { get; set; } = "";

        public Guid RoleId { get; set; }
        public string RoleName { get; set; } = "";

        public Guid BranchId { get; set; }
        public string BranchName { get; set; } = "";

        public List<string> Permissions { get; set; } = new();

        public string Token { get; set; } = "";
    }
}
