namespace FreshFalaye.Admin.Models
{
    public class AccountGroupDto
    {
        public string GroupName { get; set; }
        public Guid Id { get; set; }
        public Guid? ParentGroupId { get; set; }
        public bool? IsPredefined { get; set; } = false;
    }
}
