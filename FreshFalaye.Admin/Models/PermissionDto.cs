namespace FreshFalaye.Admin.Models
{
    public class PermissionDto
    {
        public Guid? Id { get; set; }
        public string Module { get; set; } = "";     
        public string Action { get; set; } = "";
    }
}
