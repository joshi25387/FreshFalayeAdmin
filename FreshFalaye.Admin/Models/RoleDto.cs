namespace FreshFalaye.Admin.Models
{
    public class RoleDto
    {
        public Guid Id { get; set; }
        public string RoleName { get; set; } = "";
        public string? Description { get; set; }
        public bool IsActive { get; set; }
    }
}
