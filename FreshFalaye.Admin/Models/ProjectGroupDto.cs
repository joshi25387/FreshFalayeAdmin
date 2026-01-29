namespace FreshFalaye.Admin.Models
{
    public class ProductGroupDto
    {
        public Guid ProductGroupId { get; set; }
        public Guid BranchId { get; set; }
        public string GroupName { get; set; } = null!;
        public Guid? ParentGroupId { get; set; }
    }
}
