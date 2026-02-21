namespace FreshFalaye.Admin.Models
{
    public class UserDto
    {
        public Guid Id { get; set; }
        public string Username { get; set; } = "";
        public string Password { get; set; } = "";
        public string ConfirmPassword { get; set; } = "";
        public Guid RoleId { get; set; }
        public Guid BranchId { get; set; }
        public string RoleName { get; set; } = "";
        public string BranchName { get; set; } = "";
        public bool IsActive { get; set; }
    }

}
